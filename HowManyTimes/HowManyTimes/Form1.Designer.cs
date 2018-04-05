namespace HowManyTimes
{
    partial class HowManyTimesUI
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
            this.paragraphTextBox = new System.Windows.Forms.TextBox();
            this.wordToBeSearchTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paragraphTextBox
            // 
            this.paragraphTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.paragraphTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.paragraphTextBox.Location = new System.Drawing.Point(30, 12);
            this.paragraphTextBox.Multiline = true;
            this.paragraphTextBox.Name = "paragraphTextBox";
            this.paragraphTextBox.Size = new System.Drawing.Size(547, 147);
            this.paragraphTextBox.TabIndex = 0;
            // 
            // wordToBeSearchTextBox
            // 
            this.wordToBeSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.wordToBeSearchTextBox.Location = new System.Drawing.Point(124, 189);
            this.wordToBeSearchTextBox.Name = "wordToBeSearchTextBox";
            this.wordToBeSearchTextBox.Size = new System.Drawing.Size(453, 30);
            this.wordToBeSearchTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 192);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Word to Search :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(124, 274);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resultTextBox.Location = new System.Drawing.Point(318, 283);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(271, 30);
            this.resultTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Time Appeared :";
            // 
            // HowManyTimesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.wordToBeSearchTextBox);
            this.Controls.Add(this.paragraphTextBox);
            this.Name = "HowManyTimesUI";
            this.Text = "How Many Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paragraphTextBox;
        private System.Windows.Forms.TextBox wordToBeSearchTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
    }
}

