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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeisong));
            this.spcMainForm = new System.Windows.Forms.SplitContainer();
            this.btnLoadDb = new System.Windows.Forms.Button();
            this.spcLeftPanel = new System.Windows.Forms.SplitContainer();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.splitContainerDbArea = new System.Windows.Forms.SplitContainer();
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
            this.labelQuestionInfo = new System.Windows.Forms.Label();
            this.tabPageDb = new System.Windows.Forms.TabPage();
            this.textBoxDb = new System.Windows.Forms.TextBox();
            this.textBoxQuestType = new System.Windows.Forms.TextBox();
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
            this.spcMainForm.Panel1.Controls.Add(this.btnLoadDb);
            // 
            // spcMainForm.Panel2
            // 
            this.spcMainForm.Panel2.Controls.Add(this.spcLeftPanel);
            this.spcMainForm.Size = new System.Drawing.Size(919, 553);
            this.spcMainForm.SplitterDistance = 41;
            this.spcMainForm.TabIndex = 0;
            // 
            // btnLoadDb
            // 
            this.btnLoadDb.Location = new System.Drawing.Point(3, 10);
            this.btnLoadDb.Name = "btnLoadDb";
            this.btnLoadDb.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDb.TabIndex = 0;
            this.btnLoadDb.Text = "载入数据库";
            this.btnLoadDb.UseVisualStyleBackColor = true;
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
            // 
            // spcLeftPanel.Panel2
            // 
            this.spcLeftPanel.Panel2.Controls.Add(this.splitContainerDbArea);
            this.spcLeftPanel.Size = new System.Drawing.Size(919, 508);
            this.spcLeftPanel.SplitterDistance = 153;
            this.spcLeftPanel.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(3, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(100, 461);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "信息";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.splitContainerDbArea.Size = new System.Drawing.Size(762, 508);
            this.splitContainerDbArea.SplitterDistance = 90;
            this.splitContainerDbArea.TabIndex = 1;
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
            this.tabCMain.Size = new System.Drawing.Size(758, 410);
            this.tabCMain.TabIndex = 0;
            // 
            // tabPageLianxi
            // 
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
            this.tabPageLianxi.Controls.Add(this.labelQuestionInfo);
            this.tabPageLianxi.Location = new System.Drawing.Point(4, 22);
            this.tabPageLianxi.Name = "tabPageLianxi";
            this.tabPageLianxi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLianxi.Size = new System.Drawing.Size(750, 384);
            this.tabPageLianxi.TabIndex = 0;
            this.tabPageLianxi.Text = "试题";
            this.tabPageLianxi.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(264, 221);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 13;
            this.buttonLast.Text = "最后一题";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFrist
            // 
            this.buttonFrist.Location = new System.Drawing.Point(18, 221);
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
            this.label7.Location = new System.Drawing.Point(222, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "本题得分";
            // 
            // textBoxQuestUserScore
            // 
            this.textBoxQuestUserScore.Location = new System.Drawing.Point(281, 194);
            this.textBoxQuestUserScore.Name = "textBoxQuestUserScore";
            this.textBoxQuestUserScore.Size = new System.Drawing.Size(82, 21);
            this.textBoxQuestUserScore.TabIndex = 10;
            this.textBoxQuestUserScore.Text = "本题得分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "是否正确";
            // 
            // textBoxIsUserAnswerRight
            // 
            this.textBoxIsUserAnswerRight.Location = new System.Drawing.Point(89, 194);
            this.textBoxIsUserAnswerRight.Name = "textBoxIsUserAnswerRight";
            this.textBoxIsUserAnswerRight.Size = new System.Drawing.Size(123, 21);
            this.textBoxIsUserAnswerRight.TabIndex = 8;
            this.textBoxIsUserAnswerRight.Text = "用户答案是否正确";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "正确回答";
            // 
            // textBoxRightAnswer
            // 
            this.textBoxRightAnswer.Location = new System.Drawing.Point(87, 164);
            this.textBoxRightAnswer.Name = "textBoxRightAnswer";
            this.textBoxRightAnswer.Size = new System.Drawing.Size(276, 21);
            this.textBoxRightAnswer.TabIndex = 6;
            this.textBoxRightAnswer.Text = "正确回答";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "用户回答";
            // 
            // buttonPervi
            // 
            this.buttonPervi.Location = new System.Drawing.Point(102, 221);
            this.buttonPervi.Name = "buttonPervi";
            this.buttonPervi.Size = new System.Drawing.Size(75, 23);
            this.buttonPervi.TabIndex = 4;
            this.buttonPervi.Text = "上一题";
            this.buttonPervi.UseVisualStyleBackColor = true;
            this.buttonPervi.Click += new System.EventHandler(this.buttonPervi_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(183, 221);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "下一题";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(87, 137);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(276, 21);
            this.textBoxUserAnswer.TabIndex = 2;
            this.textBoxUserAnswer.Text = "用户回答";
            // 
            // labelQuestInfo
            // 
            this.labelQuestInfo.AutoSize = true;
            this.labelQuestInfo.Location = new System.Drawing.Point(4, 45);
            this.labelQuestInfo.Name = "labelQuestInfo";
            this.labelQuestInfo.Size = new System.Drawing.Size(89, 12);
            this.labelQuestInfo.TabIndex = 1;
            this.labelQuestInfo.Text = "labelQuestInfo";
            // 
            // labelQuestionInfo
            // 
            this.labelQuestionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestionInfo.Location = new System.Drawing.Point(3, 3);
            this.labelQuestionInfo.Name = "labelQuestionInfo";
            this.labelQuestionInfo.Size = new System.Drawing.Size(744, 23);
            this.labelQuestionInfo.TabIndex = 0;
            this.labelQuestionInfo.Text = "试题信息";
            // 
            // tabPageDb
            // 
            this.tabPageDb.Controls.Add(this.textBoxDb);
            this.tabPageDb.Location = new System.Drawing.Point(4, 22);
            this.tabPageDb.Name = "tabPageDb";
            this.tabPageDb.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDb.Size = new System.Drawing.Size(750, 384);
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
            this.textBoxDb.Size = new System.Drawing.Size(744, 378);
            this.textBoxDb.TabIndex = 0;
            this.textBoxDb.Text = resources.GetString("textBoxDb.Text");
            // 
            // textBoxQuestType
            // 
            this.textBoxQuestType.Location = new System.Drawing.Point(674, 21);
            this.textBoxQuestType.Name = "textBoxQuestType";
            this.textBoxQuestType.Size = new System.Drawing.Size(74, 21);
            this.textBoxQuestType.TabIndex = 6;
            this.textBoxQuestType.Text = "全部练习";
            // 
            // frmBeisong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 553);
            this.Controls.Add(this.spcMainForm);
            this.Name = "frmBeisong";
            this.Text = "背诵";
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
    }
}

