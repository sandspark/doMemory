﻿namespace doMemory
{
    partial class frmMaintainDb
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
            this.buttonResetToFactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonResetToFactory
            // 
            this.buttonResetToFactory.Location = new System.Drawing.Point(12, 12);
            this.buttonResetToFactory.Name = "buttonResetToFactory";
            this.buttonResetToFactory.Size = new System.Drawing.Size(91, 27);
            this.buttonResetToFactory.TabIndex = 0;
            this.buttonResetToFactory.Text = "重置程序";
            this.buttonResetToFactory.UseVisualStyleBackColor = true;
            this.buttonResetToFactory.Click += new System.EventHandler(this.buttonResetToFactory_Click);
            // 
            // frmMaintainDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResetToFactory);
            this.Name = "frmMaintainDb";
            this.Text = "维护数据库";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMaintainDb_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResetToFactory;
    }
}