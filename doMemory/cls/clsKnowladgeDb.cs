using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doMemory.cls
{

    
    public class clsKnowladgeDb
    {
        public string name = "db"+DateTime.Now.ToString("yyy-MM-dd-HH-mm")+".txt";
        public string type = "字典";
        public string[] dataformat = {"",""};
        public Dictionary<string,object> cells = new  Dictionary<string, object>();

        public void loadDic(List<string> strls)
        { 
            name = strls[0].Split('=')[1];
            type = strls[1].Split('=')[1];
            dataformat = strls[2].Split('=')[1].Split(':');
            List<string> datals = strls.GetRange(3, strls.Count - 3);
            cells.Clear();
            foreach (string data in datals)
            {
                if (data.Trim().Length > 0 && data.IndexOf(':')>0 ) {
                    string[] datakv = data.Split(':');
                    string key = datakv[0];
                    string val = datakv[1];
                    if(cells.ContainsKey(key)) {
                        key = key +"-" +DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss");
                    }
                    cells[key] = val;
                }
            }
        }

    }
}
