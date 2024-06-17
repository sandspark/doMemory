namespace doMemory
{
    partial class frmBeisong
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeisong));
            this.spcMainForm = new System.Windows.Forms.SplitContainer();
            this.buttonSubmitQuest = new System.Windows.Forms.Button();
            this.buttonStartQuest = new System.Windows.Forms.Button();
            this.labelQuestionInfo = new System.Windows.Forms.Label();
            this.spcLeftPanel = new System.Windows.Forms.SplitContainer();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadDb = new System.Windows.Forms.Button();
            this.splitContainerDbArea = new System.Windows.Forms.SplitContainer();
            this.textBoxQuestType = new System.Windows.Forms.TextBox();
            this.labelQuestType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllTest = new System.Windows.Forms.RadioButton();
            this.radioButtonExam = new System.Windows.Forms.RadioButton();
            this.radioButtonTest = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDBType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.tabCMain = new System.Windows.Forms.TabControl();
            this.tabPageLianxi = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxScore_right = new System.Windows.Forms.TextBox();
            this.labelQuestIndexInfo = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFrist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQuestUserScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIsUserAnswerRight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRightAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPervi = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.labelQuestInfo = new System.Windows.Forms.Label();
            this.tabPageDb = new System.Windows.Forms.TabPage();
            this.textBoxDb = new System.Windows.Forms.TextBox();
            this.timerLoadDb = new System.Windows.Forms.Timer(this.components);
            this.timerRefreshQuestInfo = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQuestIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUserRightNum = new System.Windows.Forms.TextBox();
            this.textBoxUserWrongNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxUserAallGetScore = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxQuestAllRightScore = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForm)).BeginInit();
            this.spcMainForm.Panel1.SuspendLayout();
            this.spcMainForm.Panel2.SuspendLayout();
            this.spcMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLeftPanel)).BeginInit();
            this.spcLeftPanel.Panel1.SuspendLayout();
            this.spcLeftPanel.Panel2.SuspendLayout();
            this.spcLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDbArea)).BeginInit();
            this.splitContainerDbArea.Panel1.SuspendLayout();
            this.splitContainerDbArea.Panel2.SuspendLayout();
            this.splitContainerDbArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCMain.SuspendLayout();
            this.tabPageLianxi.SuspendLayout();
            this.tabPageDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMainForm
            // 
            this.spcMainForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMainForm.Location = new System.Drawing.Point(0, 0);
            this.spcMainForm.Name = "spcMainForm";
            this.spcMainForm.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMainForm.Panel1
            // 
            this.spcMainForm.Panel1.Controls.Add(this.buttonSubmitQuest);
            this.spcMainForm.Panel1.Controls.Add(this.buttonStartQuest);
            this.spcMainForm.Panel1.Controls.Add(this.labelQuestionInfo);
            // 
            // spcMainForm.Panel2
            // 
            this.spcMainForm.Panel2.Controls.Add(this.spcLeftPanel);
            this.spcMainForm.Size = new System.Drawing.Size(919, 553);
            this.spcMainForm.SplitterDistance = 65;
            this.spcMainForm.TabIndex = 0;
            // 
            // buttonSubmitQuest
            // 
            this.buttonSubmitQuest.Location = new System.Drawing.Point(91, 10);
            this.buttonSubmitQuest.Name = "buttonSubmitQuest";
            this.buttonSubmitQuest.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitQuest.TabIndex = 2;
            this.buttonSubmitQuest.Text = "提交";
            this.buttonSubmitQuest.UseVisualStyleBackColor = true;
            this.buttonSubmitQuest.Click += new System.EventHandler(this.buttonSubmitQuest_Click);
            // 
            // buttonStartQuest
            // 
            this.buttonStartQuest.Location = new System.Drawing.Point(10, 10);
            this.buttonStartQuest.Name = "buttonStartQuest";
            this.buttonStartQuest.Size = new System.Drawing.Size(75, 23);
            this.buttonStartQuest.TabIndex = 1;
            this.buttonStartQuest.Text = "开始考试";
            this.buttonStartQuest.UseVisualStyleBackColor = true;
            this.buttonStartQuest.Click += new System.EventHandler(this.buttonStartQuest_Click);
            // 
            // labelQuestionInfo
            // 
            this.labelQuestionInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelQuestionInfo.Location = new System.Drawing.Point(171, 0);
            this.labelQuestionInfo.Name = "labelQuestionInfo";
            this.labelQuestionInfo.Size = new System.Drawing.Size(744, 61);
            this.labelQuestionInfo.TabIndex = 0;
            this.labelQuestionInfo.Text = "考试信息";
            // 
            // spcLeftPanel
            // 
            this.spcLeftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.spcLeftPanel.Name = "spcLeftPanel";
            // 
            // spcLeftPanel.Panel1
            // 
            this.spcLeftPanel.Panel1.Controls.Add(this.labelInfo);
            this.spcLeftPanel.Panel1.Controls.Add(this.btnStart);
            this.spcLeftPanel.Panel1.Controls.Add(this.btnLoadDb);
            // 
            // spcLeftPanel.Panel2
            // 
            this.spcLeftPanel.Panel2.Controls.Add(this.splitContainerDbArea);
            this.spcLeftPanel.Size = new System.Drawing.Size(919, 484);
            this.spcLeftPanel.SplitterDistance = 153;
            this.spcLeftPanel.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.Location = new System.Drawing.Point(0, 89);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(149, 391);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "信息";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(2, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始读取数据库到内存";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoadDb
            // 
            this.btnLoadDb.Location = new System.Drawing.Point(3, 21);
            this.btnLoadDb.Name = "btnLoadDb";
            this.btnLoadDb.Size = new System.Drawing.Size(143, 23);
            this.btnLoadDb.TabIndex = 0;
            this.btnLoadDb.Text = "载入数据库";
            this.btnLoadDb.UseVisualStyleBackColor = true;
            // 
            // splitContainerDbArea
            // 
            this.splitContainerDbArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerDbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDbArea.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDbArea.Name = "splitContainerDbArea";
            this.splitContainerDbArea.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDbArea.Panel1
            // 
            this.splitContainerDbArea.Panel1.Controls.Add(this.textBoxQuestType);
            this.splitContainerDbArea.Panel1.Controls.Add(this.labelQuestType);
            this.splitContainerDbArea.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerDbArea.Panel1.Controls.Add(this.label2);
            this.splitContainerDbArea.Panel1.Controls.Add(this.textBoxDBType);
            this.splitContainerDbArea.Panel1.Controls.Add(this.label1);
            this.splitContainerDbArea.Panel1.Controls.Add(this.textBoxDbName);
            // 
            // splitContainerDbArea.Panel2
            // 
            this.splitContainerDbArea.Panel2.Controls.Add(this.tabCMain);
            this.splitContainerDbArea.Size = new System.Drawing.Size(762, 484);
            this.splitContainerDbArea.SplitterDistance = 46;
            this.splitContainerDbArea.TabIndex = 1;
            // 
            // textBoxQuestType
            // 
            this.textBoxQuestType.Location = new System.Drawing.Point(674, 21);
            this.textBoxQuestType.Name = "textBoxQuestType";
            this.textBoxQuestType.Size = new System.Drawing.Size(74, 21);
            this.textBoxQuestType.TabIndex = 6;
            this.textBoxQuestType.Text = "全部练习";
            // 
            // labelQuestType
            // 
            this.labelQuestType.AutoSize = true;
            this.labelQuestType.Location = new System.Drawing.Point(605, 24);
            this.labelQuestType.Name = "labelQuestType";
            this.labelQuestType.Size = new System.Drawing.Size(65, 12);
            this.labelQuestType.TabIndex = 5;
            this.labelQuestType.Text = "考试类型：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAllTest);
            this.groupBox1.Controls.Add(this.radioButtonExam);
            this.groupBox1.Controls.Add(this.radioButtonTest);
            this.groupBox1.Location = new System.Drawing.Point(379, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模式选择";
            // 
            // radioButtonAllTest
            // 
            this.radioButtonAllTest.AutoSize = true;
            this.radioButtonAllTest.Checked = true;
            this.radioButtonAllTest.Location = new System.Drawing.Point(112, 18);
            this.radioButtonAllTest.Name = "radioButtonAllTest";
            this.radioButtonAllTest.Size = new System.Drawing.Size(71, 16);
            this.radioButtonAllTest.TabIndex = 2;
            this.radioButtonAllTest.TabStop = true;
            this.radioButtonAllTest.Text = "全部练习";
            this.radioButtonAllTest.UseVisualStyleBackColor = true;
            this.radioButtonAllTest.CheckedChanged += new System.EventHandler(this.radioButtonAllTest_CheckedChanged);
            // 
            // radioButtonExam
            // 
            this.radioButtonExam.AutoSize = true;
            this.radioButtonExam.Location = new System.Drawing.Point(59, 18);
            this.radioButtonExam.Name = "radioButtonExam";
            this.radioButtonExam.Size = new System.Drawing.Size(47, 16);
            this.radioButtonExam.TabIndex = 1;
            this.radioButtonExam.Text = "考试";
            this.radioButtonExam.UseVisualStyleBackColor = true;
            this.radioButtonExam.CheckedChanged += new System.EventHandler(this.radioButtonExam_CheckedChanged);
            // 
            // radioButtonTest
            // 
            this.radioButtonTest.AutoSize = true;
            this.radioButtonTest.Location = new System.Drawing.Point(6, 18);
            this.radioButtonTest.Name = "radioButtonTest";
            this.radioButtonTest.Size = new System.Drawing.Size(47, 16);
            this.radioButtonTest.TabIndex = 0;
            this.radioButtonTest.Text = "练习";
            this.radioButtonTest.UseVisualStyleBackColor = true;
            this.radioButtonTest.CheckedChanged += new System.EventHandler(this.radioButtonTest_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型";
            // 
            // textBoxDBType
            // 
            this.textBoxDBType.Location = new System.Drawing.Point(201, 21);
            this.textBoxDBType.Name = "textBoxDBType";
            this.textBoxDBType.Size = new System.Drawing.Size(153, 21);
            this.textBoxDBType.TabIndex = 2;
            this.textBoxDBType.Text = "字典 区划代码 全国";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(60, 21);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(100, 21);
            this.textBoxDbName.TabIndex = 0;
            this.textBoxDbName.Text = "行政区划代码表";
            // 
            // tabCMain
            // 
            this.tabCMain.Controls.Add(this.tabPageLianxi);
            this.tabCMain.Controls.Add(this.tabPageDb);
            this.tabCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCMain.Location = new System.Drawing.Point(0, 0);
            this.tabCMain.Name = "tabCMain";
            this.tabCMain.SelectedIndex = 0;
            this.tabCMain.Size = new System.Drawing.Size(758, 430);
            this.tabCMain.TabIndex = 0;
            // 
            // tabPageLianxi
            // 
            this.tabPageLianxi.Controls.Add(this.textBoxQuestAllRightScore);
            this.tabPageLianxi.Controls.Add(this.label12);
            this.tabPageLianxi.Controls.Add(this.textBoxUserAallGetScore);
            this.tabPageLianxi.Controls.Add(this.label11);
            this.tabPageLianxi.Controls.Add(this.textBoxUserWrongNum);
            this.tabPageLianxi.Controls.Add(this.label10);
            this.tabPageLianxi.Controls.Add(this.textBoxUserRightNum);
            this.tabPageLianxi.Controls.Add(this.label9);
            this.tabPageLianxi.Controls.Add(this.textBoxQuestIndex);
            this.tabPageLianxi.Controls.Add(this.label8);
            this.tabPageLianxi.Controls.Add(this.label3);
            this.tabPageLianxi.Controls.Add(this.textBoxScore_right);
            this.tabPageLianxi.Controls.Add(this.labelQuestIndexInfo);
            this.tabPageLianxi.Controls.Add(this.buttonLast);
            this.tabPageLianxi.Controls.Add(this.buttonFrist);
            this.tabPageLianxi.Controls.Add(this.label7);
            this.tabPageLianxi.Controls.Add(this.textBoxQuestUserScore);
            this.tabPageLianxi.Controls.Add(this.label6);
            this.tabPageLianxi.Controls.Add(this.textBoxIsUserAnswerRight);
            this.tabPageLianxi.Controls.Add(this.label5);
            this.tabPageLianxi.Controls.Add(this.textBoxRightAnswer);
            this.tabPageLianxi.Controls.Add(this.label4);
            this.tabPageLianxi.Controls.Add(this.buttonPervi);
            this.tabPageLianxi.Controls.Add(this.buttonNext);
            this.tabPageLianxi.Controls.Add(this.textBoxUserAnswer);
            this.tabPageLianxi.Controls.Add(this.labelQuestInfo);
            this.tabPageLianxi.Location = new System.Drawing.Point(4, 22);
            this.tabPageLianxi.Name = "tabPageLianxi";
            this.tabPageLianxi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLianxi.Size = new System.Drawing.Size(750, 404);
            this.tabPageLianxi.TabIndex = 0;
            this.tabPageLianxi.Text = "试题";
            this.tabPageLianxi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "本题分值";
            // 
            // textBoxScore_right
            // 
            this.textBoxScore_right.Location = new System.Drawing.Point(258, 69);
            this.textBoxScore_right.Name = "textBoxScore_right";
            this.textBoxScore_right.Size = new System.Drawing.Size(123, 21);
            this.textBoxScore_right.TabIndex = 15;
            this.textBoxScore_right.Text = "本题分值";
            // 
            // labelQuestIndexInfo
            // 
            this.labelQuestIndexInfo.AutoSize = true;
            this.labelQuestIndexInfo.Location = new System.Drawing.Point(12, 20);
            this.labelQuestIndexInfo.Name = "labelQuestIndexInfo";
            this.labelQuestIndexInfo.Size = new System.Drawing.Size(77, 12);
            this.labelQuestIndexInfo.TabIndex = 14;
            this.labelQuestIndexInfo.Text = "试题索引信息";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(306, 280);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 13;
            this.buttonLast.Text = "最后一题";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFrist
            // 
            this.buttonFrist.Location = new System.Drawing.Point(18, 280);
            this.buttonFrist.Name = "buttonFrist";
            this.buttonFrist.Size = new System.Drawing.Size(75, 23);
            this.buttonFrist.TabIndex = 12;
            this.buttonFrist.Text = "第一题";
            this.buttonFrist.UseVisualStyleBackColor = true;
            this.buttonFrist.Click += new System.EventHandler(this.buttonFrist_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "本题得分";
            // 
            // textBoxQuestUserScore
            // 
            this.textBoxQuestUserScore.Location = new System.Drawing.Point(284, 213);
            this.textBoxQuestUserScore.Name = "textBoxQuestUserScore";
            this.textBoxQuestUserScore.Size = new System.Drawing.Size(97, 21);
            this.textBoxQuestUserScore.TabIndex = 10;
            this.textBoxQuestUserScore.Text = "本题得分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "是否正确";
            // 
            // textBoxIsUserAnswerRight
            // 
            this.textBoxIsUserAnswerRight.Location = new System.Drawing.Point(96, 216);
            this.textBoxIsUserAnswerRight.Name = "textBoxIsUserAnswerRight";
            this.textBoxIsUserAnswerRight.Size = new System.Drawing.Size(123, 21);
            this.textBoxIsUserAnswerRight.TabIndex = 8;
            this.textBoxIsUserAnswerRight.Text = "用户答案是否正确";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "正确回答";
            // 
            // textBoxRightAnswer
            // 
            this.textBoxRightAnswer.Location = new System.Drawing.Point(97, 190);
            this.textBoxRightAnswer.Name = "textBoxRightAnswer";
            this.textBoxRightAnswer.Size = new System.Drawing.Size(284, 21);
            this.textBoxRightAnswer.TabIndex = 6;
            this.textBoxRightAnswer.Text = "正确回答";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "用户回答";
            // 
            // buttonPervi
            // 
            this.buttonPervi.Location = new System.Drawing.Point(111, 280);
            this.buttonPervi.Name = "buttonPervi";
            this.buttonPervi.Size = new System.Drawing.Size(75, 23);
            this.buttonPervi.TabIndex = 4;
            this.buttonPervi.Text = "上一题";
            this.buttonPervi.UseVisualStyleBackColor = true;
            this.buttonPervi.Click += new System.EventHandler(this.buttonPervi_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(203, 280);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "下一题";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(97, 163);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(284, 21);
            this.textBoxUserAnswer.TabIndex = 2;
            this.textBoxUserAnswer.Text = "用户回答";
            this.textBoxUserAnswer.Leave += new System.EventHandler(this.textBoxUserAnswer_Leave);
            // 
            // labelQuestInfo
            // 
            this.labelQuestInfo.AutoSize = true;
            this.labelQuestInfo.Location = new System.Drawing.Point(16, 95);
            this.labelQuestInfo.Name = "labelQuestInfo";
            this.labelQuestInfo.Size = new System.Drawing.Size(89, 12);
            this.labelQuestInfo.TabIndex = 1;
            this.labelQuestInfo.Text = "labelQuestInfo";
            // 
            // tabPageDb
            // 
            this.tabPageDb.Controls.Add(this.textBoxDb);
            this.tabPageDb.Location = new System.Drawing.Point(4, 22);
            this.tabPageDb.Name = "tabPageDb";
            this.tabPageDb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDb.Size = new System.Drawing.Size(750, 404);
            this.tabPageDb.TabIndex = 2;
            this.tabPageDb.Text = "数据库";
            this.tabPageDb.UseVisualStyleBackColor = true;
            // 
            // textBoxDb
            // 
            this.textBoxDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDb.Location = new System.Drawing.Point(3, 3);
            this.textBoxDb.Multiline = true;
            this.textBoxDb.Name = "textBoxDb";
            this.textBoxDb.ReadOnly = true;
            this.textBoxDb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDb.Size = new System.Drawing.Size(744, 398);
            this.textBoxDb.TabIndex = 0;
            this.textBoxDb.Text = resources.GetString("textBoxDb.Text");
            // 
            // timerLoadDb
            // 
            this.timerLoadDb.Interval = 1000;
            this.timerLoadDb.Tick += new System.EventHandler(this.timerLoadDb_Tick);
            // 
            // timerRefreshQuestInfo
            // 
            this.timerRefreshQuestInfo.Interval = 1000;
            this.timerRefreshQuestInfo.Tick += new System.EventHandler(this.timerRefreshQuestInfo_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "本题序号";
            // 
            // textBoxQuestIndex
            // 
            this.textBoxQuestIndex.Location = new System.Drawing.Point(96, 69);
            this.textBoxQuestIndex.Name = "textBoxQuestIndex";
            this.textBoxQuestIndex.Size = new System.Drawing.Size(60, 21);
            this.textBoxQuestIndex.TabIndex = 18;
            this.textBoxQuestIndex.Text = "本题序号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "正确题数";
            // 
            // textBoxUserRightNum
            // 
            this.textBoxUserRightNum.Location = new System.Drawing.Point(74, 42);
            this.textBoxUserRightNum.Name = "textBoxUserRightNum";
            this.textBoxUserRightNum.Size = new System.Drawing.Size(49, 21);
            this.textBoxUserRightNum.TabIndex = 20;
            this.textBoxUserRightNum.Text = "试题正确数";
            // 
            // textBoxUserWrongNum
            // 
            this.textBoxUserWrongNum.Location = new System.Drawing.Point(185, 42);
            this.textBoxUserWrongNum.Name = "textBoxUserWrongNum";
            this.textBoxUserWrongNum.Size = new System.Drawing.Size(67, 21);
            this.textBoxUserWrongNum.TabIndex = 22;
            this.textBoxUserWrongNum.Text = "错误题数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "错误题数";
            // 
            // textBoxUserAallGetScore
            // 
            this.textBoxUserAallGetScore.Location = new System.Drawing.Point(306, 42);
            this.textBoxUserAallGetScore.Name = "textBoxUserAallGetScore";
            this.textBoxUserAallGetScore.Size = new System.Drawing.Size(75, 21);
            this.textBoxUserAallGetScore.TabIndex = 24;
            this.textBoxUserAallGetScore.Text = "用户得分";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 23;
            this.label11.Tag = "wode";
            this.label11.Text = "最后得分";
            // 
            // textBoxQuestAllRightScore
            // 
            this.textBoxQuestAllRightScore.Location = new System.Drawing.Point(306, 14);
            this.textBoxQuestAllRightScore.Name = "textBoxQuestAllRightScore";
            this.textBoxQuestAllRightScore.Size = new System.Drawing.Size(75, 21);
            this.textBoxQuestAllRightScore.TabIndex = 26;
            this.textBoxQuestAllRightScore.Text = "试卷总分数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 25;
            this.label12.Tag = "wode";
            this.label12.Text = "试卷总分数";
            // 
            // frmBeisong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 553);
            this.Controls.Add(this.spcMainForm);
            this.Name = "frmBeisong";
            this.Text = "背诵";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBeisong_FormClosed);
            this.Load += new System.EventHandler(this.frmBeisong_Load);
            this.spcMainForm.Panel1.ResumeLayout(false);
            this.spcMainForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMainForm)).EndInit();
            this.spcMainForm.ResumeLayout(false);
            this.spcLeftPanel.Panel1.ResumeLayout(false);
            this.spcLeftPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLeftPanel)).EndInit();
            this.spcLeftPanel.ResumeLayout(false);
            this.splitContainerDbArea.Panel1.ResumeLayout(false);
            this.splitContainerDbArea.Panel1.PerformLayout();
            this.splitContainerDbArea.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDbArea)).EndInit();
            this.splitContainerDbArea.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCMain.ResumeLayout(false);
            this.tabPageLianxi.ResumeLayout(false);
            this.tabPageLianxi.PerformLayout();
            this.tabPageDb.ResumeLayout(false);
            this.tabPageDb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMainForm;
        private System.Windows.Forms.TabControl tabCMain;
        private System.Windows.Forms.TabPage tabPageLianxi;
        private System.Windows.Forms.SplitContainer spcLeftPanel;
        private System.Windows.Forms.SplitContainer splitContainerDbArea;
        private System.Windows.Forms.TabPage tabPageDb;
        private System.Windows.Forms.Button btnLoadDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAllTest;
        private System.Windows.Forms.RadioButton radioButtonExam;
        private System.Windows.Forms.RadioButton radioButtonTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDBType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.TextBox textBoxDb;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelQuestionInfo;
        private System.Windows.Forms.Label labelQuestType;
        private System.Windows.Forms.Button buttonPervi;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Label labelQuestInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQuestUserScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIsUserAnswerRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRightAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFrist;
        private System.Windows.Forms.TextBox textBoxQuestType;
        private System.Windows.Forms.Timer timerLoadDb;
        private System.Windows.Forms.Timer timerRefreshQuestInfo;
        private System.Windows.Forms.Button buttonSubmitQuest;
        private System.Windows.Forms.Button buttonStartQuest;
        private System.Windows.Forms.Label labelQuestIndexInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScore_right;
        private System.Windows.Forms.TextBox textBoxQuestIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUserWrongNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUserRightNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUserAallGetScore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxQuestAllRightScore;
        private System.Windows.Forms.Label label12;
    }
}

