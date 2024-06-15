namespace doMemory
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMatainDB = new System.Windows.Forms.Button();
            this.buttonStartText = new System.Windows.Forms.Button();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMatainDB
            // 
            this.buttonMatainDB.Location = new System.Drawing.Point(12, 88);
            this.buttonMatainDB.Name = "buttonMatainDB";
            this.buttonMatainDB.Size = new System.Drawing.Size(165, 45);
            this.buttonMatainDB.TabIndex = 0;
            this.buttonMatainDB.Text = "维护数据库";
            this.buttonMatainDB.UseVisualStyleBackColor = true;
            this.buttonMatainDB.Click += new System.EventHandler(this.buttonMatainDB_Click);
            // 
            // buttonStartText
            // 
            this.buttonStartText.Location = new System.Drawing.Point(12, 33);
            this.buttonStartText.Name = "buttonStartText";
            this.buttonStartText.Size = new System.Drawing.Size(165, 40);
            this.buttonStartText.TabIndex = 1;
            this.buttonStartText.Text = "开始练习或考试";
            this.buttonStartText.UseVisualStyleBackColor = true;
            this.buttonStartText.Click += new System.EventHandler(this.buttonStartText_Click);
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.Location = new System.Drawing.Point(12, 154);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(165, 40);
            this.buttonExitApp.TabIndex = 2;
            this.buttonExitApp.Text = "退出";
            this.buttonExitApp.UseVisualStyleBackColor = true;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.buttonStartText);
            this.Controls.Add(this.buttonMatainDB);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMatainDB;
        private System.Windows.Forms.Button buttonStartText;
        private System.Windows.Forms.Button buttonExitApp;
    }
}