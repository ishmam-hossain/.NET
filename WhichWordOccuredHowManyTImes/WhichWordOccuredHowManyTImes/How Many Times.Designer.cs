namespace WhichWordOccuredHowManyTImes
{
    partial class howManyTimesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.insertTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCharacterLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.Labeltotal = new System.Windows.Forms.Label();
            this.lalbelTotalWords = new System.Windows.Forms.Label();
            this.lalbelAnswer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 53);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SlateGray;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Location = new System.Drawing.Point(666, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "x";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count Total Words";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insertTextBox
            // 
            this.insertTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.insertTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insertTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.insertTextBox.Location = new System.Drawing.Point(13, 99);
            this.insertTextBox.Multiline = true;
            this.insertTextBox.Name = "insertTextBox";
            this.insertTextBox.Size = new System.Drawing.Size(668, 132);
            this.insertTextBox.TabIndex = 1;
            this.insertTextBox.TextChanged += new System.EventHandler(this.insertTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert the paragraph: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(468, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Characters : ";
            // 
            // totalCharacterLabel
            // 
            this.totalCharacterLabel.AutoSize = true;
            this.totalCharacterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalCharacterLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.totalCharacterLabel.Location = new System.Drawing.Point(614, 75);
            this.totalCharacterLabel.Name = "totalCharacterLabel";
            this.totalCharacterLabel.Size = new System.Drawing.Size(0, 21);
            this.totalCharacterLabel.TabIndex = 3;
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.countButton.FlatAppearance.BorderSize = 0;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.countButton.Location = new System.Drawing.Point(253, 250);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(182, 36);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // Labeltotal
            // 
            this.Labeltotal.AutoSize = true;
            this.Labeltotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Labeltotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.Labeltotal.Location = new System.Drawing.Point(249, 320);
            this.Labeltotal.Name = "Labeltotal";
            this.Labeltotal.Size = new System.Drawing.Size(113, 21);
            this.Labeltotal.TabIndex = 5;
            this.Labeltotal.Text = "Total Words : ";
            this.Labeltotal.Visible = false;
            // 
            // lalbelTotalWords
            // 
            this.lalbelTotalWords.AutoSize = true;
            this.lalbelTotalWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lalbelTotalWords.ForeColor = System.Drawing.Color.Gainsboro;
            this.lalbelTotalWords.Location = new System.Drawing.Point(368, 320);
            this.lalbelTotalWords.Name = "lalbelTotalWords";
            this.lalbelTotalWords.Size = new System.Drawing.Size(0, 21);
            this.lalbelTotalWords.TabIndex = 6;
            // 
            // lalbelAnswer
            // 
            this.lalbelAnswer.AutoSize = true;
            this.lalbelAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lalbelAnswer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lalbelAnswer.Location = new System.Drawing.Point(368, 320);
            this.lalbelAnswer.Name = "lalbelAnswer";
            this.lalbelAnswer.Size = new System.Drawing.Size(113, 21);
            this.lalbelAnswer.TabIndex = 7;
            this.lalbelAnswer.Text = "Total Words : ";
            this.lalbelAnswer.Visible = false;
            // 
            // howManyTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(72)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(694, 388);
            this.Controls.Add(this.lalbelAnswer);
            this.Controls.Add(this.lalbelTotalWords);
            this.Controls.Add(this.Labeltotal);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.totalCharacterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertTextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "howManyTimesForm";
            this.Text = "How Many Times ?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCharacterLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label Labeltotal;
        private System.Windows.Forms.Label lalbelTotalWords;
        private System.Windows.Forms.Label lalbelAnswer;
    }
}

