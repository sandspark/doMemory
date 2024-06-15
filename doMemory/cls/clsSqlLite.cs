using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace doMemory.cls
{
        public class DBHelperSQLite
        {
            public static string dbname = "domemory.db";
            public static string dataBaseFileName = AppDomain.CurrentDomain.BaseDirectory + "//db//"+dbname;
            public static string connectionString = @"Data Source=" + dataBaseFileName + "; Pooling=true;FailIfMissing=false;";

            public DBHelperSQLite()
            {

            }

            public static void ExistsDataBase()
            {
                if (!File.Exists(dataBaseFileName))
                {
                    SQLiteConnection.CreateFile(dataBaseFileName);
                }

                if (!ExixtsTable("user"))
                {
                    ExecuteSql(@"CREATE TABLE user(
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    username TEXT ,
                    password TEXT ,
                    lastlogindatetime text
                    )");
                }

                if (!ExixtsTable("knowladgedb"))
                {
                    ExecuteSql(@"CREATE TABLE knowladgedb(
                      Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                      name TEXT ,
                      type TEXT ,
                      dataformat TEXT 
                    )");

                }
            }

            #region 公用方法

            public static bool ExixtsTable(string tableName)
            {
                string sqlStr = $"SELECT count(*) from sqlite_master where type='table' and name='{tableName}'";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, connection))
                    {
                        try
                        {
                            connection.Open();
                            return !(Convert.ToInt32(cmd.ExecuteScalar()) == 0);//不存在此表，返回false
                        }
                        catch (SQLiteException E)
                        {
                            connection.Close();
                            throw new Exception(E.Message);
                        }
                    }
                }
            }

            public static int GetMaxID(string FieldName, string TableName)
            {
                string strsql = "select max(" + FieldName + ")+1 from " + TableName;
                object obj = GetSingle(strsql);
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    return int.Parse(obj.ToString());
                }
            }
            public static bool Exists(string strSql)
            {
                object obj = GetSingle(strSql);
                int cmdresult;
                if (Equals(obj, null) || Equals(obj, DBNull.Value))
                {
                    cmdresult = 0;
                }
                else
                {
                    cmdresult = int.Parse(obj.ToString());
                }
                if (cmdresult == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public static bool Exists(string strSql, params SQLiteParameter[] cmdParms)
            {
                object obj = GetSingle(strSql, cmdParms);
                int cmdresult;
                if (Equals(obj, null) || Equals(obj, DBNull.Value))
                {
                    cmdresult = 0;
                }
                else
                {
                    cmdresult = int.Parse(obj.ToString());
                }
                if (cmdresult == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            #endregion

            #region  执行简单SQL语句

            /// <summary> 
            /// 对SQLite数据库执行增删改操作，返回受影响的行数。 
            /// </summary> 
            /// <param name="sql">要执行的增删改的SQL语句</param> 
            /// <param name="parameters">执行增删改语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
            /// <returns></returns> 
            public static int ExecuteNonQuery(string sql, SQLiteParameter[] parameters)
            {
                int affectedRows = 0;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (DbTransaction transaction = connection.BeginTransaction())
                    {
                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            command.CommandText = sql;
                            if (parameters != null)
                            {
                                command.Parameters.AddRange(parameters);
                            }
                            affectedRows = command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
                return affectedRows;
            }

            /// <summary>
            /// 执行SQL语句，返回影响的记录数
            /// </summary>
            /// <param name="SQLString">SQL语句</param>
            /// <returns>影响的记录数</returns>
            public static int ExecuteSql(string SQLString)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            return rows;
                        }
                        catch (SQLiteException E)
                        {
                            connection.Close();
                            throw new Exception(E.Message);
                        }
                    }
                }
            }

            /// <summary>
            /// 执行多条SQL语句，实现数据库事务。
            /// </summary>
            /// <param name="SQLStringList">多条SQL语句</param>    
            public static void ExecuteSqlTran(ArrayList SQLStringList)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = conn;
                    SQLiteTransaction tx = conn.BeginTransaction();
                    cmd.Transaction = tx;
                    try
                    {
                        for (int n = 0; n < SQLStringList.Count; n++)
                        {
                            string strsql = SQLStringList[n].ToString();
                            if (strsql.Trim().Length > 1)
                            {
                                cmd.CommandText = strsql;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        tx.Commit();
                    }
                    catch (SQLiteException E)
                    {
                        tx.Rollback();
                        throw new Exception(E.Message);
                    }
                }
            }
            /// <summary>
            /// 执行带一个存储过程参数的的SQL语句。
            /// </summary>
            /// <param name="SQLString">SQL语句</param>
            /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
            /// <returns>影响的记录数</returns>
            public static int ExecuteSql(string SQLString, string content)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand(SQLString, connection);
                    SQLiteParameter myParameter = new SQLiteParameter("@content", DbType.String);
                    myParameter.Value = content;
                    cmd.Parameters.Add(myParameter);
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SQLiteException E)
                    {
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        connection.Close();
                    }
                }
            }
            /// <summary>
            /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
            /// </summary>
            /// <param name="strSQL">SQL语句</param>
            /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
            /// <returns>影响的记录数</returns>
            public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand(strSQL, connection);
                    SQLiteParameter myParameter = new SQLiteParameter("@fs", DbType.Binary);
                    myParameter.Value = fs;
                    cmd.Parameters.Add(myParameter);
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SQLiteException E)
                    {
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        connection.Close();
                    }
                }
            }

            /// <summary>
            /// 执行一条计算查询结果语句，返回查询结果（object）。
            /// </summary>
            /// <param name="SQLString">计算查询结果语句</param>
            /// <returns>查询结果（object）</returns>
            public static object GetSingle(string SQLString)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            object obj = cmd.ExecuteScalar();
                            if (Equals(obj, null) || Equals(obj, DBNull.Value))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (SQLiteException e)
                        {
                            connection.Close();
                            throw new Exception(e.Message);
                        }
                    }
                }
            }
            /// <summary>
            /// 执行查询语句，返回SQLiteDataReader
            /// </summary>
            /// <param name="strSQL">查询语句</param>
            /// <returns>SQLiteDataReader</returns>
            public static SQLiteDataReader ExecuteReader(string strSQL)
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand cmd = new SQLiteCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    SQLiteDataReader myReader = cmd.ExecuteReader();
                    return myReader;
                }
                catch (SQLiteException e)
                {
                    throw new Exception(e.Message);
                }

            }
            /// <summary>
            /// 执行查询语句，返回DataSet
            /// </summary>
            /// <param name="SQLString">查询语句</param>
            /// <returns>DataSet</returns>
            public static DataSet Query(string SQLString)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        connection.Open();
                        SQLiteDataAdapter command = new SQLiteDataAdapter(SQLString, connection);
                        command.Fill(ds, "ds");
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                        //throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }


            #endregion

            #region 执行带参数的SQL语句

            /// <summary>
            /// 执行SQL语句，返回影响的记录数
            /// </summary>
            /// <param name="SQLString">SQL语句</param>
            /// <returns>影响的记录数</returns>
            public static int ExecuteSql(string SQLString, params SQLiteParameter[] cmdParms)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        try
                        {
                            PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                            int rows = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            return rows;
                        }
                        catch (SQLiteException E)
                        {
                            throw new Exception(E.Message);
                        }
                    }
                }
            }


            /// <summary>
            /// 执行多条SQL语句，实现数据库事务。
            /// </summary>
            /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SQLiteParameter[]）</param>
            public static void ExecuteSqlTran(Hashtable SQLStringList)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteTransaction trans = conn.BeginTransaction())
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        try
                        {
                            //循环
                            foreach (DictionaryEntry myDE in SQLStringList)
                            {
                                string cmdText = myDE.Key.ToString();
                                SQLiteParameter[] cmdParms = (SQLiteParameter[])myDE.Value;
                                PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                                int val = cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();

                                trans.Commit();
                            }
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }


            /// <summary>
            /// 执行一条计算查询结果语句，返回查询结果（object）。
            /// </summary>
            /// <param name="SQLString">计算查询结果语句</param>
            /// <returns>查询结果（object）</returns>
            public static object GetSingle(string SQLString, params SQLiteParameter[] cmdParms)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        try
                        {
                            PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                            object obj = cmd.ExecuteScalar();
                            cmd.Parameters.Clear();
                            if (Equals(obj, null) || Equals(obj, DBNull.Value))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (SQLiteException e)
                        {
                            throw new Exception(e.Message);
                        }
                    }
                }
            }

            /// <summary>
            /// 执行查询语句，返回SQLiteDataReader
            /// </summary>
            /// <param name="strSQL">查询语句</param>
            /// <returns>SQLiteDataReader</returns>
            public static SQLiteDataReader ExecuteReader(string SQLString, params SQLiteParameter[] cmdParms)
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand cmd = new SQLiteCommand();
                try
                {
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    SQLiteDataReader myReader = cmd.ExecuteReader();
                    cmd.Parameters.Clear();
                    return myReader;
                }
                catch (SQLiteException e)
                {
                    throw new Exception(e.Message);
                }

            }

            /// <summary>
            /// 执行查询语句，返回DataSet
            /// </summary>
            /// <param name="SQLString">查询语句</param>
            /// <returns>DataSet</returns>
            public static DataSet Query(string SQLString, params SQLiteParameter[] cmdParms)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            da.Fill(ds, "ds");
                            cmd.Parameters.Clear();
                        }
                        catch (SQLiteException ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        return ds;
                    }
                }
            }


            private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, SQLiteParameter[] cmdParms)
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                if (trans != null)
                    cmd.Transaction = trans;
                cmd.CommandType = CommandType.Text;//cmdType;
                if (cmdParms != null)
                {
                    foreach (SQLiteParameter parm in cmdParms)
                        cmd.Parameters.Add(parm);
                }
            }

            /// <summary>
            /// 同步datagridview表中的数据至数据库，要求单表，有主键；
            /// </summary>
            /// <param name="ds  "></param>
            /// <param name="strTblName"> 要更新的表名 </param>
            /// <returns></returns>
            public static int UpdateDataTable(DataTable dt, string strTblName)
            {
                int num2 = -1;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.CommandText = "SELECT * FROM " + strTblName + " where 1=2 ";
                        try
                        {
                            SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(cmd);
                            myAdapter.SelectCommand.Connection = connection;
                            //自动生成单表命令，用于将对DataSet所做的更改与数据库更改相对应
                            SQLiteCommandBuilder myCommandBuilder = new SQLiteCommandBuilder(myAdapter);

                            myAdapter.Update(dt);
                        }
                        catch (SQLiteException e)
                        {
                            throw new Exception(e.Message);
                        }
                        finally
                        {

                        }

                    }
                }
                return 0;

            }

            #endregion

        }
    
}


/*
 https://www.cnblogs.com/lrzy/p/18096299
1、在nuget 工具中安装 “System.Data.SQLite”插件；

2、将数据库文件放在DEBUG目录下（表文件可以通过navicate 建立也）；

3、创建DbHelperSQLite.cs文件，指定数据库路径等信息；

复制代码
using System;
using System.Collections;
using System.Data.Common;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WordWrite
{
    public class DBHelperSQLite
    {
        public static string dataBaseFileName = AppDomain.CurrentDomain.BaseDirectory + "goods.db";
        public static string connectionString = @"Data Source=" + dataBaseFileName + "; Pooling=true;FailIfMissing=false;";

        public DBHelperSQLite()
        {

        }

        public static void ExistsDataBase()
        {
            if (!File.Exists(dataBaseFileName))
            {
                SQLiteConnection.CreateFile(dataBaseFileName);
            }

            if (!ExixtsTable("PointManage"))
            {
                ExecuteSql(@"CREATE TABLE PointManage(
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    PointAddress TEXT NOT NULL,
                    PointDes TEXT NOT NULL
                    )");
            }

            if (!ExixtsTable("PointValue"))
            {
                ExecuteSql(@"CREATE TABLE PointValue(
                      Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                      PointAddress TEXT NOT NULL,
                      Time TEXT NOT NULL,
                      Value NUMERIC NOT NULL
                    )");

                ExecuteSql("CREATE INDEX PointAddress ON PointValue(PointAddress COLLATE BINARY ASC)");
                ExecuteSql("CREATE INDEX Time ON PointValue(Time COLLATE BINARY ASC)");
            }
        }

        #region 公用方法

        public static bool ExixtsTable(string tableName)
        {
            string sqlStr = $"SELECT count(*) from sqlite_master where type='table' and name='{tableName}'";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlStr, connection))
                {
                    try
                    {
                        connection.Open();
                        return !(Convert.ToInt32(cmd.ExecuteScalar()) == 0);//不存在此表，返回false
                    }
                    catch (SQLiteException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        public static int GetMaxID(string FieldName, string TableName)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            object obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }
        public static bool Exists(string strSql)
        {
            object obj = GetSingle(strSql);
            int cmdresult;
            if (Equals(obj, null) || Equals(obj, DBNull.Value))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Exists(string strSql, params SQLiteParameter[] cmdParms)
        {
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if (Equals(obj, null) || Equals(obj, DBNull.Value))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region  执行简单SQL语句

        /// <summary> 
        /// 对SQLite数据库执行增删改操作，返回受影响的行数。 
        /// </summary> 
        /// <param name="sql">要执行的增删改的SQL语句</param> 
        /// <param name="parameters">执行增删改语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param> 
        /// <returns></returns> 
        public static int ExecuteNonQuery(string sql, SQLiteParameter[] parameters)
        {
            int affectedRows = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (DbTransaction transaction = connection.BeginTransaction())
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = sql;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        affectedRows = command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            return affectedRows;
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (SQLiteException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>    
        public static void ExecuteSqlTran(ArrayList SQLStringList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;
                SQLiteTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n].ToString();
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                }
                catch (SQLiteException E)
                {
                    tx.Rollback();
                    throw new Exception(E.Message);
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, string content)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(SQLString, connection);
                SQLiteParameter myParameter = new SQLiteParameter("@content", DbType.String);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (SQLiteException E)
                {
                    throw new Exception(E.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(strSQL, connection);
                SQLiteParameter myParameter = new SQLiteParameter("@fs", DbType.Binary);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (SQLiteException E)
                {
                    throw new Exception(E.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if (Equals(obj, null) || Equals(obj, DBNull.Value))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (SQLiteException e)
                    {
                        connection.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回SQLiteDataReader
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SQLiteDataReader</returns>
        public static SQLiteDataReader ExecuteReader(string strSQL)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand cmd = new SQLiteCommand(strSQL, connection);
            try
            {
                connection.Open();
                SQLiteDataReader myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }

        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SQLiteDataAdapter command = new SQLiteDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                    //throw new Exception(ex.Message);
                }
                return ds;
            }
        }


        #endregion

        #region 执行带参数的SQL语句

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, params SQLiteParameter[] cmdParms)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (SQLiteException E)
                    {
                        throw new Exception(E.Message);
                    }
                }
            }
        }


        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SQLiteParameter[]）</param>
        public static void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteTransaction trans = conn.BeginTransaction())
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    try
                    {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SQLiteParameter[] cmdParms = (SQLiteParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            trans.Commit();
                        }
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }


        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString, params SQLiteParameter[] cmdParms)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if (Equals(obj, null) || Equals(obj, DBNull.Value))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (SQLiteException e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SQLiteDataReader
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SQLiteDataReader</returns>
        public static SQLiteDataReader ExecuteReader(string SQLString, params SQLiteParameter[] cmdParms)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand cmd = new SQLiteCommand();
            try
            {
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                SQLiteDataReader myReader = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                return myReader;
            }
            catch (SQLiteException e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString, params SQLiteParameter[] cmdParms)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (SQLiteException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }


        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, string cmdText, SQLiteParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (SQLiteParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// 同步datagridview表中的数据至数据库，要求单表，有主键；
        /// </summary>
        /// <param name="ds  "></param>
        /// <param name="strTblName"> 要更新的表名 </param>
        /// <returns></returns>
        public static int UpdateDataTable(DataTable dt, string strTblName)
        {
            int num2 = -1;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = "SELECT * FROM " + strTblName + " where 1=2 ";
                    try
                    {
                        SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(cmd);
                        myAdapter.SelectCommand.Connection = connection;
                        //自动生成单表命令，用于将对DataSet所做的更改与数据库更改相对应
                        SQLiteCommandBuilder myCommandBuilder = new SQLiteCommandBuilder(myAdapter);

                        myAdapter.Update(dt);
                    }
                    catch (SQLiteException e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {

                    }

                }
            }
            return 0;

        }

        #endregion

    }
}
 */
