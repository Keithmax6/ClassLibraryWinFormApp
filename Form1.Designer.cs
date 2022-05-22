namespace WindowsFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.textBoxFormattedString = new System.Windows.Forms.TextBox();
            this.textBoxVowels = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formatted String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vowels in the String";
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(330, 64);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(251, 22);
            this.textBoxUserInput.TabIndex = 3;
            // 
            // textBoxFormattedString
            // 
            this.textBoxFormattedString.Enabled = false;
            this.textBoxFormattedString.Location = new System.Drawing.Point(330, 157);
            this.textBoxFormattedString.Name = "textBoxFormattedString";
            this.textBoxFormattedString.Size = new System.Drawing.Size(251, 22);
            this.textBoxFormattedString.TabIndex = 4;
            // 
            // textBoxVowels
            // 
            this.textBoxVowels.Enabled = false;
            this.textBoxVowels.Location = new System.Drawing.Point(330, 249);
            this.textBoxVowels.Name = "textBoxVowels";
            this.textBoxVowels.Size = new System.Drawing.Size(251, 22);
            this.textBoxVowels.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxVowels);
            this.Controls.Add(this.textBoxFormattedString);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.TextBox textBoxFormattedString;
        private System.Windows.Forms.TextBox textBoxVowels;
        private System.Windows.Forms.Button button1;
    }
}

