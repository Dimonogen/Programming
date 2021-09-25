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
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(13, 13);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(431, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(450, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxInto
            // 
            this.textBoxInto.Location = new System.Drawing.Point(13, 40);
            this.textBoxInto.Name = "textBoxInto";
            this.textBoxInto.Size = new System.Drawing.Size(267, 20);
            this.textBoxInto.TabIndex = 2;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(13, 96);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(512, 154);
            this.textBoxOut.TabIndex = 3;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(287, 66);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(205, 66);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBoxWindow
            // 
            this.textBoxWindow.Location = new System.Drawing.Point(287, 40);
            this.textBoxWindow.Name = "textBoxWindow";
            this.textBoxWindow.Size = new System.Drawing.Size(118, 20);
            this.textBoxWindow.TabIndex = 6;
            // 
            // textBoxOutPutSize
            // 
            this.textBoxOutPutSize.Location = new System.Drawing.Point(411, 40);
            this.textBoxOutPutSize.Name = "textBoxOutPutSize";
            this.textBoxOutPutSize.Size = new System.Drawing.Size(114, 20);
            this.textBoxOutPutSize.TabIndex = 7;
            // 
            // radioButtonChar
            // 
            this.radioButtonChar.AutoSize = true;
            this.radioButtonChar.Checked = true;
            this.radioButtonChar.Location = new System.Drawing.Point(13, 69);
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
            this.radioButtonWords.Location = new System.Drawing.Point(71, 69);
            this.radioButtonWords.Name = "radioButtonWords";
            this.radioButtonWords.Size = new System.Drawing.Size(56, 17);
            this.radioButtonWords.TabIndex = 9;
            this.radioButtonWords.Text = "Words";
            this.radioButtonWords.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
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
            this.Text = "Form1";
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
    }
}

