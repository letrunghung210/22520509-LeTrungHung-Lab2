﻿namespace Lab2
{
    partial class Bai2
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
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.lbCharCount = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.lbLineCount = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lbFileName = new System.Windows.Forms.Label();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.lbWordsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileContent
            // 
            this.txtFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.Location = new System.Drawing.Point(822, 10);
            this.txtFileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.Size = new System.Drawing.Size(544, 422);
            this.txtFileContent.TabIndex = 0;
            this.txtFileContent.Text = "";
            // 
            // lbCharCount
            // 
            this.lbCharCount.AutoSize = true;
            this.lbCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharCount.Location = new System.Drawing.Point(11, 350);
            this.lbCharCount.Name = "lbCharCount";
            this.lbCharCount.Size = new System.Drawing.Size(208, 31);
            this.lbCharCount.TabIndex = 1;
            this.lbCharCount.Text = "Character count";
            // 
            // btnRead
            // 
            this.btnRead.AutoSize = true;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(11, 10);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(806, 41);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read from file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtCharCount
            // 
            this.txtCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharCount.Location = new System.Drawing.Point(235, 347);
            this.txtCharCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.ReadOnly = true;
            this.txtCharCount.Size = new System.Drawing.Size(583, 38);
            this.txtCharCount.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(11, 394);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(806, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(235, 176);
            this.txtURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(583, 38);
            this.txtURL.TabIndex = 6;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbURL.Location = new System.Drawing.Point(11, 178);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(69, 31);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL";
            // 
            // txtLineCount
            // 
            this.txtLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineCount.Location = new System.Drawing.Point(235, 234);
            this.txtLineCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.ReadOnly = true;
            this.txtLineCount.Size = new System.Drawing.Size(583, 38);
            this.txtLineCount.TabIndex = 8;
            // 
            // lbLineCount
            // 
            this.lbLineCount.AutoSize = true;
            this.lbLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineCount.Location = new System.Drawing.Point(11, 236);
            this.lbLineCount.Name = "lbLineCount";
            this.lbLineCount.Size = new System.Drawing.Size(139, 31);
            this.lbLineCount.TabIndex = 7;
            this.lbLineCount.Text = "Line count";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(235, 114);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(583, 38);
            this.txtSize.TabIndex = 10;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(11, 116);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(67, 31);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "Size";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(235, 57);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(583, 38);
            this.txtFileName.TabIndex = 12;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(11, 59);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(137, 31);
            this.lbFileName.TabIndex = 11;
            this.lbFileName.Text = "File Name";
            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsCount.Location = new System.Drawing.Point(235, 290);
            this.txtWordsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.ReadOnly = true;
            this.txtWordsCount.Size = new System.Drawing.Size(583, 38);
            this.txtWordsCount.TabIndex = 14;
            // 
            // lbWordsCount
            // 
            this.lbWordsCount.AutoSize = true;
            this.lbWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordsCount.Location = new System.Drawing.Point(11, 293);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(166, 31);
            this.lbWordsCount.TabIndex = 13;
            this.lbWordsCount.Text = "Words count";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 441);
            this.Controls.Add(this.txtWordsCount);
            this.Controls.Add(this.lbWordsCount);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.lbLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lbCharCount);
            this.Controls.Add(this.txtFileContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.Label lbCharCount;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.Label lbLineCount;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox txtWordsCount;
        private System.Windows.Forms.Label lbWordsCount;
    }
}