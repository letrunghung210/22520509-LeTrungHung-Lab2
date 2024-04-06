using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    partial class Bai5
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtWriteCourse2 = new System.Windows.Forms.TextBox();
            this.txtWriteCourse1 = new System.Windows.Forms.TextBox();
            this.txtWritePhone = new System.Windows.Forms.TextBox();
            this.txtWriteID = new System.Windows.Forms.TextBox();
            this.txtWriteName = new System.Windows.Forms.TextBox();
            this.lbWriteCourse2 = new System.Windows.Forms.Label();
            this.lbWriteCourse1 = new System.Windows.Forms.Label();
            this.lbWritePhone = new System.Windows.Forms.Label();
            this.lbWriteName = new System.Windows.Forms.Label();
            this.lbWriteID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "READ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtWriteCourse2
            // 
            this.txtWriteCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCourse2.Location = new System.Drawing.Point(289, 387);
            this.txtWriteCourse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteCourse2.Name = "txtWriteCourse2";
            this.txtWriteCourse2.Size = new System.Drawing.Size(197, 38);
            this.txtWriteCourse2.TabIndex = 30;
            this.txtWriteCourse2.TextChanged += new System.EventHandler(this.txtWriteCourse2_TextChanged);
            // 
            // txtWriteCourse1
            // 
            this.txtWriteCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteCourse1.Location = new System.Drawing.Point(289, 299);
            this.txtWriteCourse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteCourse1.Name = "txtWriteCourse1";
            this.txtWriteCourse1.Size = new System.Drawing.Size(197, 38);
            this.txtWriteCourse1.TabIndex = 29;
            this.txtWriteCourse1.TextChanged += new System.EventHandler(this.txtWriteCourse1_TextChanged);
            // 
            // txtWritePhone
            // 
            this.txtWritePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWritePhone.Location = new System.Drawing.Point(289, 207);
            this.txtWritePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWritePhone.Name = "txtWritePhone";
            this.txtWritePhone.Size = new System.Drawing.Size(197, 38);
            this.txtWritePhone.TabIndex = 28;
            this.txtWritePhone.TextChanged += new System.EventHandler(this.txtWritePhone_TextChanged);
            // 
            // txtWriteID
            // 
            this.txtWriteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteID.Location = new System.Drawing.Point(289, 131);
            this.txtWriteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteID.Name = "txtWriteID";
            this.txtWriteID.Size = new System.Drawing.Size(197, 38);
            this.txtWriteID.TabIndex = 27;
            this.txtWriteID.TextChanged += new System.EventHandler(this.txtWriteID_TextChanged);
            // 
            // txtWriteName
            // 
            this.txtWriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteName.Location = new System.Drawing.Point(289, 58);
            this.txtWriteName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteName.Name = "txtWriteName";
            this.txtWriteName.Size = new System.Drawing.Size(197, 38);
            this.txtWriteName.TabIndex = 25;
            this.txtWriteName.TextChanged += new System.EventHandler(this.txtWriteName_TextChanged);
            // 
            // lbWriteCourse2
            // 
            this.lbWriteCourse2.AutoSize = true;
            this.lbWriteCourse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteCourse2.Location = new System.Drawing.Point(22, 394);
            this.lbWriteCourse2.Name = "lbWriteCourse2";
            this.lbWriteCourse2.Size = new System.Drawing.Size(129, 31);
            this.lbWriteCourse2.TabIndex = 23;
            this.lbWriteCourse2.Text = "Xếp hạng";
            this.lbWriteCourse2.Click += new System.EventHandler(this.lbWriteCourse2_Click);
            // 
            // lbWriteCourse1
            // 
            this.lbWriteCourse1.AutoSize = true;
            this.lbWriteCourse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteCourse1.Location = new System.Drawing.Point(22, 306);
            this.lbWriteCourse1.Name = "lbWriteCourse1";
            this.lbWriteCourse1.Size = new System.Drawing.Size(139, 31);
            this.lbWriteCourse1.TabIndex = 22;
            this.lbWriteCourse1.Text = "Doanh thu";
            this.lbWriteCourse1.Click += new System.EventHandler(this.lbWriteCourse1_Click);
            // 
            // lbWritePhone
            // 
            this.lbWritePhone.AutoSize = true;
            this.lbWritePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWritePhone.Location = new System.Drawing.Point(15, 214);
            this.lbWritePhone.Name = "lbWritePhone";
            this.lbWritePhone.Size = new System.Drawing.Size(191, 31);
            this.lbWritePhone.TabIndex = 21;
            this.lbWritePhone.Text = "Tỉ lệ vé bán ra ";
            this.lbWritePhone.Click += new System.EventHandler(this.lbWritePhone_Click);
            // 
            // lbWriteName
            // 
            this.lbWriteName.AutoSize = true;
            this.lbWriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteName.Location = new System.Drawing.Point(15, 58);
            this.lbWriteName.Name = "lbWriteName";
            this.lbWriteName.Size = new System.Drawing.Size(239, 31);
            this.lbWriteName.TabIndex = 19;
            this.lbWriteName.Text = "Số lượng vé bán ra";
            this.lbWriteName.Click += new System.EventHandler(this.lbWriteName_Click);
            // 
            // lbWriteID
            // 
            this.lbWriteID.AutoSize = true;
            this.lbWriteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteID.Location = new System.Drawing.Point(22, 134);
            this.lbWriteID.Name = "lbWriteID";
            this.lbWriteID.Size = new System.Drawing.Size(92, 31);
            this.lbWriteID.TabIndex = 20;
            this.lbWriteID.Text = "Vé tồn";
            this.lbWriteID.Click += new System.EventHandler(this.lbWriteID_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(742, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 31;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtWriteCourse2);
            this.Controls.Add(this.txtWriteCourse1);
            this.Controls.Add(this.txtWritePhone);
            this.Controls.Add(this.txtWriteID);
            this.Controls.Add(this.txtWriteName);
            this.Controls.Add(this.lbWriteCourse2);
            this.Controls.Add(this.lbWriteCourse1);
            this.Controls.Add(this.lbWritePhone);
            this.Controls.Add(this.lbWriteID);
            this.Controls.Add(this.lbWriteName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TextBox txtWriteCourse2;
        private TextBox txtWriteCourse1;
        private TextBox txtWritePhone;
        private TextBox txtWriteID;
        private TextBox txtWriteName;
        private Label lbWriteCourse2;
        private Label lbWriteCourse1;
        private Label lbWritePhone;
        private Label lbWriteName;
        private Label lbWriteID;
        private Button button2;
    }
}