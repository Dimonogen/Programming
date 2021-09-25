namespace Markov_cep
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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxInto = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxWindow = new System.Windows.Forms.TextBox();
            this.textBoxOutPutSize = new System.Windows.Forms.TextBox();
            this.radioButtonChar = new System.Windows.Forms.RadioButton();
            this.radioButtonWords = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(12, 25);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(431, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(449, 25);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxInto
            // 
            this.textBoxInto.Location = new System.Drawing.Point(12, 68);
            this.textBoxInto.Name = "textBoxInto";
            this.textBoxInto.Size = new System.Drawing.Size(267, 20);
            this.textBoxInto.TabIndex = 2;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(13, 156);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(512, 210);
            this.textBoxOut.TabIndex = 3;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(279, 116);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(198, 116);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxWindow
            // 
            this.textBoxWindow.Location = new System.Drawing.Point(287, 68);
            this.textBoxWindow.Name = "textBoxWindow";
            this.textBoxWindow.Size = new System.Drawing.Size(118, 20);
            this.textBoxWindow.TabIndex = 6;
            // 
            // textBoxOutPutSize
            // 
            this.textBoxOutPutSize.Location = new System.Drawing.Point(410, 68);
            this.textBoxOutPutSize.Name = "textBoxOutPutSize";
            this.textBoxOutPutSize.Size = new System.Drawing.Size(114, 20);
            this.textBoxOutPutSize.TabIndex = 7;
            // 
            // radioButtonChar
            // 
            this.radioButtonChar.AutoSize = true;
            this.radioButtonChar.Checked = true;
            this.radioButtonChar.Location = new System.Drawing.Point(12, 116);
            this.radioButtonChar.Name = "radioButtonChar";
            this.radioButtonChar.Size = new System.Drawing.Size(52, 17);
            this.radioButtonChar.TabIndex = 8;
            this.radioButtonChar.TabStop = true;
            this.radioButtonChar.Text = "Chars";
            this.radioButtonChar.UseVisualStyleBackColor = true;
            // 
            // radioButtonWords
            // 
            this.radioButtonWords.AutoSize = true;
            this.radioButtonWords.Location = new System.Drawing.Point(70, 116);
            this.radioButtonWords.Name = "radioButtonWords";
            this.radioButtonWords.Size = new System.Drawing.Size(56, 17);
            this.radioButtonWords.TabIndex = 9;
            this.radioButtonWords.Text = "Words";
            this.radioButtonWords.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File with Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "String from Input Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Window size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prepear data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Print result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 378);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonWords);
            this.Controls.Add(this.radioButtonChar);
            this.Controls.Add(this.textBoxOutPutSize);
            this.Controls.Add(this.textBoxWindow);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxInto);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileName);
            this.Name = "Form1";
            this.Text = "Markov chain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxInto;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxWindow;
        private System.Windows.Forms.TextBox textBoxOutPutSize;
        private System.Windows.Forms.RadioButton radioButtonChar;
        private System.Windows.Forms.RadioButton radioButtonWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

