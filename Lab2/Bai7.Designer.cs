﻿namespace Lab2
{
    partial class Bai7
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
            this.components = new System.ComponentModel.Container();
            this.TreeDirectory = new System.Windows.Forms.TreeView();
            this.FilePictureContent = new System.Windows.Forms.PictureBox();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeDirectory
            // 
            this.TreeDirectory.Location = new System.Drawing.Point(13, 12);
            this.TreeDirectory.Name = "TreeDirectory";
            this.TreeDirectory.Size = new System.Drawing.Size(764, 891);
            this.TreeDirectory.TabIndex = 0;
            this.TreeDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDirectory_NodeMouseClick);
            this.TreeDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDirectory_NodeMouseDoubleClick);
            // 
            // FilePictureContent
            // 
            this.FilePictureContent.Location = new System.Drawing.Point(783, 12);
            this.FilePictureContent.Name = "FilePictureContent";
            this.FilePictureContent.Size = new System.Drawing.Size(806, 891);
            this.FilePictureContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilePictureContent.TabIndex = 3;
            this.FilePictureContent.TabStop = false;
            this.FilePictureContent.Visible = false;
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(783, 12);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.Size = new System.Drawing.Size(806, 891);
            this.txtFileContent.TabIndex = 4;
            this.txtFileContent.Text = "";
            this.txtFileContent.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1601, 915);
            this.Controls.Add(this.FilePictureContent);
            this.Controls.Add(this.TreeDirectory);
            this.Controls.Add(this.txtFileContent);
            this.Name = "Bai06";
            this.Text = "Bai6";
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeDirectory;
        private System.Windows.Forms.PictureBox FilePictureContent;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}