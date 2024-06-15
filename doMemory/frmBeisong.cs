using doMemory.cls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doMemory
{
    public partial class frmBeisong : Form
    {
        public frmLogin frmLogin = null;
        public clsKnowladgeDb db = new clsKnowladgeDb();
        public clsSpeech speech = new clsSpeech();
        public clsQuestion quest = new clsQuestion(null, null);
        public int CurrentQuestIndex = 0;
        public frmBeisong()
        {
            InitializeComponent();
        }

        private void listBoxdb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //载入数据字典
            List<string> tls = new List<string>();
            tls.Clear();
            string[] strls = textBoxDb.Text.Split('\n');
            foreach (string str in strls) { 
                tls.Add(str.Trim());
            }
            db.loadDic(tls);
            string info = "";
            info += DateTime.Now.ToString()+"\n";
            info += string.Format("字典名称：{0} \n 字典类型：{1} \n 字典数据条数：{2} \n ",db.name,db.type,db.cells.Count.ToString());
            labelInfo.Text = info;

            //测试发音设备
            speech.initspeech();
            speech.speechtext("zh-CN","我爱我的祖国");
            
            speech.speechtext("en-US", "good morning lucy");
            
            labelQuestInfo.Text = "考试类型:"+textBoxQuestType.Text;
            
            quest = new clsQuestion(db, textBoxQuestType.Text);
            quest.type = textBoxQuestType.Text;
            quest.GetQuestion();
        }

        private void buttonFrist_Click(object sender, EventArgs e)
        {
            loadQuest(0);
        }

        public void loadQuest(int index)
        {
            CurrentQuestIndex = index;
            labelQuestionInfo.Text = string.Format("试题信息： 当前第{0}题，总共{1}题。", (index+1).ToString(), (quest.QuestionDic.Count()).ToString());
            QuestionCell qc = quest.QuestionDic[index.ToString()];
            labelQuestInfo.Text = qc.quest;
            textBoxUserAnswer.Text = "";
            string answerstr = string.Join(" ", qc.RightAnswer);
            textBoxRightAnswer.Text = answerstr;
            textBoxIsUserAnswerRight.Text = "错误";
            textBoxQuestUserScore.Text = "0";
            speech.initspeech();
            speech.speechtext("zh-CN", labelQuestInfo.Text);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            loadQuest( quest.QuestionDic.Count()-1);
        }

        private void buttonPervi_Click(object sender, EventArgs e)
        {
            CurrentQuestIndex--;
            if (CurrentQuestIndex < 0)
            {
                CurrentQuestIndex = quest.QuestionDic.Count()-1 ;
            }
            loadQuest(CurrentQuestIndex);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CurrentQuestIndex++;
            if (CurrentQuestIndex > quest.QuestionDic.Count()-1)
            {
                CurrentQuestIndex = 0;
            }
            loadQuest(CurrentQuestIndex);
        }

        private void radioButtonTest_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTest.Checked)
            { 
                textBoxQuestType.Text = radioButtonTest.Text;
            }
        }

        private void radioButtonExam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExam.Checked)
            {
                textBoxQuestType.Text = radioButtonExam.Text;
            }
        }

        private void radioButtonAllTest_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAllTest.Checked)
            {
                textBoxQuestType.Text = radioButtonAllTest.Text;
            }
        }
    }
}
