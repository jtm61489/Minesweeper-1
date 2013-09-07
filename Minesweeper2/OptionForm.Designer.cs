namespace Minesweeper2
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colNumBox = new System.Windows.Forms.TextBox();
            this.mineNumBox = new System.Windows.Forms.TextBox();
            this.rowNumBox = new System.Windows.Forms.TextBox();
            this.customRdBtn = new System.Windows.Forms.RadioButton();
            this.hardRdBtn = new System.Windows.Forms.RadioButton();
            this.medRdBtn = new System.Windows.Forms.RadioButton();
            this.easyRdBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colNumBox);
            this.groupBox1.Controls.Add(this.mineNumBox);
            this.groupBox1.Controls.Add(this.rowNumBox);
            this.groupBox1.Controls.Add(this.customRdBtn);
            this.groupBox1.Controls.Add(this.hardRdBtn);
            this.groupBox1.Controls.Add(this.medRdBtn);
            this.groupBox1.Controls.Add(this.easyRdBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mines (10 - 600):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Columns (9 - 30):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rows (9 - 24):";
            // 
            // colNumBox
            // 
            this.colNumBox.Enabled = false;
            this.colNumBox.Location = new System.Drawing.Point(173, 153);
            this.colNumBox.Name = "colNumBox";
            this.colNumBox.Size = new System.Drawing.Size(63, 20);
            this.colNumBox.TabIndex = 6;
            this.colNumBox.Text = "9";
            // 
            // mineNumBox
            // 
            this.mineNumBox.Enabled = false;
            this.mineNumBox.Location = new System.Drawing.Point(173, 179);
            this.mineNumBox.Name = "mineNumBox";
            this.mineNumBox.Size = new System.Drawing.Size(63, 20);
            this.mineNumBox.TabIndex = 5;
            this.mineNumBox.Text = "10";
            // 
            // rowNumBox
            // 
            this.rowNumBox.Enabled = false;
            this.rowNumBox.Location = new System.Drawing.Point(173, 125);
            this.rowNumBox.Name = "rowNumBox";
            this.rowNumBox.Size = new System.Drawing.Size(63, 20);
            this.rowNumBox.TabIndex = 4;
            this.rowNumBox.Text = "9";
            // 
            // customRdBtn
            // 
            this.customRdBtn.AutoSize = true;
            this.customRdBtn.Location = new System.Drawing.Point(26, 126);
            this.customRdBtn.Name = "customRdBtn";
            this.customRdBtn.Size = new System.Drawing.Size(63, 17);
            this.customRdBtn.TabIndex = 3;
            this.customRdBtn.TabStop = true;
            this.customRdBtn.Text = "Custom:";
            this.customRdBtn.UseVisualStyleBackColor = true;
            this.customRdBtn.CheckedChanged += new System.EventHandler(this.customRdBtn_CheckedChanged);
            // 
            // hardRdBtn
            // 
            this.hardRdBtn.AutoSize = true;
            this.hardRdBtn.Location = new System.Drawing.Point(26, 93);
            this.hardRdBtn.Name = "hardRdBtn";
            this.hardRdBtn.Size = new System.Drawing.Size(157, 17);
            this.hardRdBtn.TabIndex = 2;
            this.hardRdBtn.TabStop = true;
            this.hardRdBtn.Text = "Hard: 99 mines; 16 x 30 grid";
            this.hardRdBtn.UseVisualStyleBackColor = true;
            // 
            // medRdBtn
            // 
            this.medRdBtn.AutoSize = true;
            this.medRdBtn.Location = new System.Drawing.Point(26, 60);
            this.medRdBtn.Name = "medRdBtn";
            this.medRdBtn.Size = new System.Drawing.Size(171, 17);
            this.medRdBtn.TabIndex = 1;
            this.medRdBtn.TabStop = true;
            this.medRdBtn.Text = "Medium: 40 mines; 16 x 16 grid";
            this.medRdBtn.UseVisualStyleBackColor = true;
            // 
            // easyRdBtn
            // 
            this.easyRdBtn.AutoSize = true;
            this.easyRdBtn.Location = new System.Drawing.Point(26, 28);
            this.easyRdBtn.Name = "easyRdBtn";
            this.easyRdBtn.Size = new System.Drawing.Size(145, 17);
            this.easyRdBtn.TabIndex = 0;
            this.easyRdBtn.TabStop = true;
            this.easyRdBtn.Text = "Easy: 10 mines; 9 x 9 grid";
            this.easyRdBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(27, 250);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(174, 250);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(291, 295);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox colNumBox;
        private System.Windows.Forms.TextBox mineNumBox;
        private System.Windows.Forms.TextBox rowNumBox;
        private System.Windows.Forms.RadioButton customRdBtn;
        private System.Windows.Forms.RadioButton hardRdBtn;
        private System.Windows.Forms.RadioButton medRdBtn;
        private System.Windows.Forms.RadioButton easyRdBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}