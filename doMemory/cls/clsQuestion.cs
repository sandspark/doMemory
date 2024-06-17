using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doMemory.cls
{
    /// <summary>
    /// 问题模板
    /// </summary>
    public class QuestionCell {
        /// <summary>
        /// 字典数据库的索引key
        /// </summary>
        public string key;

        /// <summary>
        /// 问题种类 ： 
        ///     0 根据val提示 默写key，
        ///     1 根据key 默写val，
        ///     
        ///     2 根据key 填空val，
        ///     3 根据val 填空key，
        ///     
        ///     4 根据val 选择key，
        ///     5 根据key 选择val，
        /// </summary>
        public string type; 

        /// <summary>
        /// 提出问题的文本
        /// </summary>
        public string quest;  

        /// <summary>
        /// 用户的回答
        /// </summary>
        public string[] answer = new string[20];


        /// <summary>
        /// 正确答案 包含答案即可
        /// </summary>
        public string[] RightAnswer = new string[20];

        /// <summary>
        /// 回答是否可以乱序
        /// </summary>
        public bool RightAnswerCanRandomOrder = false;

        /// <summary>
        /// 回答成功 得分值
        /// </summary>
        public int score_right = 1;

        /// <summary>
        /// 用户获得的分数
        /// </summary>
        public int socre_get = 0;

        public bool isright = false;

        public bool userViewed = false;
    }
    public class clsQuestion
    {

        public string type = "全部练习";
        public clsKnowladgeDb db = null;
        public Dictionary<string, QuestionCell> QuestionDic = new Dictionary<string, QuestionCell>();
        public int RandomBlankMaxNum = 3;
        public DateTime startdatetime = DateTime.Now;
        public DateTime enddatetime = DateTime.Now;
        public int questtimelengthSecond = 600;
        public int timeusedSenond = 0;
        public int timeleftSecond = 0;
        public string username = "";
        
        public int allrightScore = 0, allgetscore = 0, QuestRightNum = 0, QuestWrongNum = 0;
        
        public clsQuestion(clsKnowladgeDb tdb, string ttype) {
            db = tdb;
            type = ttype;

        }
        Dictionary<string, string> usedQuestionkey = new Dictionary<string, string>();

        public void GetQuestion()
        {
            if (db != null)
            {
                int cellnum = db.cells.Count;
                int questnum = 0;

                //确定试题数量
                Random rd = new Random();
                switch (type)
                {
                    case "练习":
                        if (cellnum < 10)
                            questnum = cellnum;
                        else
                            questnum = rd.Next(10,cellnum);
                        break;

                    case "考试":
                        if (cellnum < 10)
                            questnum = cellnum;
                        else
                            questnum = rd.Next(10, cellnum);
                        break;


                    case "全部练习":
                            questnum = cellnum;
                        break;


                    default:
                            questnum = 10;
                        break;
                }
                questnum = 10;
                questtimelengthSecond = questnum * 20;
                //随机生成试题
                QuestionDic.Clear();
                usedQuestionkey.Clear();
                Dictionary<object,object> dic = new Dictionary<object,object>();
                dic = getRandDsSet(db.cells.Keys.ToList(), questnum,true);


                for (int questNum = 0; questNum < questnum; questNum++)
                {
                    //找到一个未使用的cell key，用于考试知识点。
                    object index = dic.Keys.ToArray()[questNum];
                    
                    string questKey = db.cells.Keys.ToArray()[Convert.ToInt32(index)].ToString().Trim();
                    string questVal = db.cells[questKey].ToString().Trim();

                    //确定出题类型
                    string questType = rd.Next(2).ToString();
                    QuestionCell qc = new QuestionCell();
                    qc.key = questKey;
                    qc.type = questType;
                    qc.score_right = 10;

                    /// 问题种类 ： 
                    ///     0 根据val提示 默写key，
                    ///     1 根据key 默写val，
                    ///     
                    ///     2 根据key val 填空 key val，
                    ///     3 根据val 填空key，
                    ///     
                    ///     4 根据val 选择key，
                    ///     5 根据key 选择val，
                    switch (questType)
                    {
                        ///     0 根据val提示 默写key，
                        case "0":
                            qc.quest = string.Format("请默写 {0} 为 {1} 的 {2} ：___", db.dataformat[1], questVal, db.dataformat[0]);
                            qc.RightAnswer = new string[1];
                            qc.RightAnswer[0] = questKey;

                            qc.socre_get = 0;
                            qc.isright = false;

                            break;

                         /// 1 根据key 默写val， 
                        case "1":
                            qc.quest = string.Format("请默写 {0} 为 {1} 的 {2} ：___", db.dataformat[0], questKey, db.dataformat[1]);
                            qc.RightAnswer = new string[1];
                            qc.RightAnswer[0] = questVal;
                            qc.socre_get = 0;
                            qc.isright = false;
                            break;

                         //2 根据key val 填空 key val，
                        case "2":
                            //为0随机填空key 为1随机填空val

                            int blankKind = rd.Next(0,1);
                            int blankNum = rd.Next(0,3);
                            List<int> blankPosList = new List<int>();

                            if (blankKind == 0)
                            {
                                string tmpQuestKey = questKey, tmpQuestVal = questVal;
                                //为0随机填空key
                                if (questKey.Length < 3) blankNum = 1;
                                qc.RightAnswer = new string[blankNum];
                                qc.socre_get = 0;
                                qc.isright = false;
                                for (int i = 0; i < blankNum; i++)
                                { 
                                    int randompos = rd.Next(0, questKey.Length);
                                    blankPosList.Add(randompos);
                                    tmpQuestKey = tmpQuestKey.Substring(0,randompos)+"_"+ tmpQuestKey.Substring(randompos+1);
                                    qc.RightAnswer[i] = tmpQuestKey.Substring(randompos,1);
                                }
                                qc.quest = string.Format("填空题： {0} 为 {1}  {2} 为 {3}", db.dataformat[0], tmpQuestKey,tmpQuestKey, db.dataformat[0], tmpQuestVal);
                            }
                            else
                            {
                                string tmpQuestKey = questKey, tmpQuestVal = questVal;
                                //为0随机填空key
                                if (tmpQuestVal.Length < 3) blankNum = 1;
                                qc.RightAnswer = new string[blankNum];
                                qc.socre_get = 0;
                                qc.isright = false;
                                for (int i = 0; i < blankNum; i++)
                                {
                                    int randompos = rd.Next(0, tmpQuestVal.Length);
                                    blankPosList.Add(randompos);
                                    tmpQuestVal = tmpQuestVal.Substring(0, randompos) + "_" + tmpQuestVal.Substring(randompos + 1);
                                    qc.RightAnswer[i] = tmpQuestVal.Substring(randompos, 1);
                                }
                                qc.quest = string.Format("填空题： {0} 为 {1}  {2} 为 {3}", db.dataformat[0], tmpQuestKey, tmpQuestKey, db.dataformat[0], tmpQuestVal);
                            }

                            break;

                        case "3":
                            questnum = cellnum;
                            break;

                        case "4":
                            questnum = cellnum;
                            break;

                        case "5":
                            questnum = cellnum;
                            break;

                        //默认为根据val 默写key
                        default:
                            qc.quest = string.Format("请默写 {0} 为 {1} 的 {2} ：___", db.dataformat[1], qc.key, db.dataformat[0]);
                            qc.RightAnswer = new string[1];
                            qc.RightAnswer[0] = questVal;

                            qc.socre_get = 0;
                            qc.isright = false;
                            break;
                    }
                    QuestionDic[questNum.ToString()] = qc;
                }
            }
        }

        public Dictionary<object,object> getRandDsSet(List<string> tds, int num, bool isResultSortedbyKey)
        {

            Dictionary<object, object> result = new Dictionary<object, object>();
            List<int> usedIndex = new List<int>();
            usedIndex.Clear();
            result.Clear();
            Random rd = new Random();
            int tindex = rd.Next(0, tds.Count);
            for (int i = 0; i < num; i++)
            {
                tindex = rd.Next(0, tds.Count);
                while (usedIndex.Contains(tindex))
                {
                    tindex = rd.Next(0, tds.Count);
                }
                result[tindex]=tds[tindex];
                usedIndex.Add(tindex);
            }
            if(isResultSortedbyKey)
            {
                
            }
            return result;
        }

 
    }
}
