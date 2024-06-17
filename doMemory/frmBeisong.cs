using doMemory.cls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //textBoxUserAnswer.LostFocus += new EventHandler(textBoxUserAnswer_Leave);
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
            loadQuest(0);
        }

        private void buttonFrist_Click(object sender, EventArgs e)
        {
            loadQuest(0);
        }

        public void loadQuest(int index)
        {
            CurrentQuestIndex = index;
            labelQuestIndexInfo.Text = string.Format("试题信息： 当前第{0}题，总共{1}题。", (index+1).ToString(), (quest.QuestionDic.Count()).ToString());
            QuestionCell qc = quest.QuestionDic[index.ToString()];
            labelQuestInfo.Text = qc.quest;
            textBoxUserAnswer.Text = qc.answer[0];
            string RightAnswerstr = string.Join(" ", qc.RightAnswer);
            textBoxRightAnswer.Text = RightAnswerstr;
            textBoxQuestIndex.Text = index.ToString();
            string userisright = "";
            if (qc.isright)
                userisright = "正确";
            else
                userisright = "错误";
            textBoxIsUserAnswerRight.Text = userisright;
            textBoxQuestUserScore.Text = qc.socre_get.ToString();
            textBoxScore_right.Text = qc.score_right.ToString();
            qc.userViewed = true;
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

        private void timerLoadDb_Tick(object sender, EventArgs e)
        {           
        }

        private void timerRefreshQuestInfo_Tick(object sender, EventArgs e)
        {
            DateTime currentdatetime = DateTime.Now;
            TimeSpan timeused = currentdatetime - quest.startdatetime;
            quest.timeusedSenond = Convert.ToInt32( timeused.TotalSeconds);
            quest.timeleftSecond = quest.questtimelengthSecond - quest.timeusedSenond;

            string questinfo = string.Format("考试信息：" +"考试类型{0} " +
                "\n开始时间：{1}，总时长{2}分钟，" +
                "\n当前时间：{3}，已过去{4}分钟，" +"还剩{5}分钟交卷。" ,
                textBoxQuestType.Text,quest.startdatetime.ToString("yyyy-MM-dd HH:mm:ss"),(quest.questtimelengthSecond/60).ToString(), currentdatetime.ToString("yyyy-MM-dd HH:mm:ss"), (quest.timeusedSenond/60).ToString(),(quest.timeleftSecond/60).ToString()

                );
            labelQuestionInfo.Text = questinfo;
            quest.allrightScore = 0;
            quest.allgetscore = 0;
            quest.QuestRightNum = 0;
            quest.QuestWrongNum = 0;
            foreach (QuestionCell tqc in quest.QuestionDic.Values)
            {
                quest.allrightScore += tqc.score_right;
                if (tqc.userViewed)
                {
                    if (tqc.isright)
                    {
                        quest.allgetscore += tqc.score_right;
                        quest.QuestRightNum += 1;
                    }
                    else
                    {
                        quest.allgetscore += 0;
                        quest.QuestWrongNum += 1;
                    }
                }
            }
            textBoxQuestAllRightScore.Text = quest.allrightScore.ToString();
            textBoxUserAallGetScore.Text = quest.allgetscore.ToString();
            textBoxUserRightNum.Text = quest.QuestRightNum.ToString();
            textBoxUserWrongNum.Text = quest.QuestWrongNum.ToString();
        }

        private void frmBeisong_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStartQuest_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
            timerRefreshQuestInfo.Enabled = true;
            buttonStartQuest.Enabled = false;
            buttonSubmitQuest.Enabled = true;
            quest.startdatetime = DateTime.Now;
        }

        private void buttonSubmitQuest_Click(object sender, EventArgs e)
        {
            buttonStartQuest.Enabled = true;
            buttonSubmitQuest.Enabled = false;
            timerRefreshQuestInfo.Enabled = false;
            quest.enddatetime = DateTime.Now;
        }

        private void textBoxUserAnswer_Leave(object sender, EventArgs e)
        {
            QuestionCell qc = quest.QuestionDic[CurrentQuestIndex.ToString()];
            qc.answer[0] = textBoxUserAnswer.Text;
            if (textBoxUserAnswer.Text.Trim()==textBoxRightAnswer.Text.Trim())
            {
                textBoxIsUserAnswerRight.Text = "正确";
                qc.isright = true;
                qc.socre_get = qc.score_right;
                textBoxQuestUserScore.Text = qc.socre_get.ToString();

            }
            else
            {
                textBoxIsUserAnswerRight.Text = "错误";
                qc.isright = false;
                qc.socre_get = 0;
            }



        }

        private void frmBeisong_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.frmMain.Show();
        }
    }
}
