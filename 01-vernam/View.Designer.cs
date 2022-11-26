
namespace Vernam
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOpenText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbKeyseq1 = new System.Windows.Forms.TextBox();
            this.lbOpenText = new System.Windows.Forms.Label();
            this.lbKeyseq1 = new System.Windows.Forms.Label();
            this.lbEncryptedText1 = new System.Windows.Forms.Label();
            this.tbEncryptedText1 = new System.Windows.Forms.TextBox();
            this.lbKeyseq2 = new System.Windows.Forms.Label();
            this.tbKeyseq2 = new System.Windows.Forms.TextBox();
            this.lbEncryptedText2 = new System.Windows.Forms.Label();
            this.tbEncryptedText2 = new System.Windows.Forms.TextBox();
            this.lbDecryptedText = new System.Windows.Forms.Label();
            this.tbDecryptedText = new System.Windows.Forms.TextBox();
            this.btnDeсrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOpenText
            // 
            this.tbOpenText.Location = new System.Drawing.Point(12, 27);
            this.tbOpenText.Name = "tbOpenText";
            this.tbOpenText.Size = new System.Drawing.Size(491, 23);
            this.tbOpenText.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(13, 174);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(491, 36);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbKeyseq1
            // 
            this.tbKeyseq1.Location = new System.Drawing.Point(12, 80);
            this.tbKeyseq1.Name = "tbKeyseq1";
            this.tbKeyseq1.ReadOnly = true;
            this.tbKeyseq1.Size = new System.Drawing.Size(491, 23);
            this.tbKeyseq1.TabIndex = 2;
            // 
            // lbOpenText
            // 
            this.lbOpenText.AutoSize = true;
            this.lbOpenText.Location = new System.Drawing.Point(12, 9);
            this.lbOpenText.Name = "lbOpenText";
            this.lbOpenText.Size = new System.Drawing.Size(179, 15);
            this.lbOpenText.TabIndex = 3;
            this.lbOpenText.Text = "Введите текст для шифрования";
            // 
            // lbKeyseq1
            // 
            this.lbKeyseq1.AutoSize = true;
            this.lbKeyseq1.Location = new System.Drawing.Point(13, 62);
            this.lbKeyseq1.Name = "lbKeyseq1";
            this.lbKeyseq1.Size = new System.Drawing.Size(178, 15);
            this.lbKeyseq1.TabIndex = 4;
            this.lbKeyseq1.Text = "Ключевая последовательность";
            // 
            // lbEncryptedText1
            // 
            this.lbEncryptedText1.AutoSize = true;
            this.lbEncryptedText1.Location = new System.Drawing.Point(12, 115);
            this.lbEncryptedText1.Name = "lbEncryptedText1";
            this.lbEncryptedText1.Size = new System.Drawing.Size(134, 15);
            this.lbEncryptedText1.TabIndex = 5;
            this.lbEncryptedText1.Text = "Зашифрованный текст";
            // 
            // tbEncryptedText1
            // 
            this.tbEncryptedText1.Location = new System.Drawing.Point(12, 133);
            this.tbEncryptedText1.Name = "tbEncryptedText1";
            this.tbEncryptedText1.ReadOnly = true;
            this.tbEncryptedText1.Size = new System.Drawing.Size(491, 23);
            this.tbEncryptedText1.TabIndex = 6;
            // 
            // lbKeyseq2
            // 
            this.lbKeyseq2.AutoSize = true;
            this.lbKeyseq2.Location = new System.Drawing.Point(12, 235);
            this.lbKeyseq2.Name = "lbKeyseq2";
            this.lbKeyseq2.Size = new System.Drawing.Size(178, 15);
            this.lbKeyseq2.TabIndex = 7;
            this.lbKeyseq2.Text = "Ключевая последовательность";
            // 
            // tbKeyseq2
            // 
            this.tbKeyseq2.Location = new System.Drawing.Point(12, 253);
            this.tbKeyseq2.Name = "tbKeyseq2";
            this.tbKeyseq2.ReadOnly = true;
            this.tbKeyseq2.Size = new System.Drawing.Size(491, 23);
            this.tbKeyseq2.TabIndex = 8;
            // 
            // lbEncryptedText2
            // 
            this.lbEncryptedText2.AutoSize = true;
            this.lbEncryptedText2.Location = new System.Drawing.Point(12, 288);
            this.lbEncryptedText2.Name = "lbEncryptedText2";
            this.lbEncryptedText2.Size = new System.Drawing.Size(134, 15);
            this.lbEncryptedText2.TabIndex = 9;
            this.lbEncryptedText2.Text = "Зашифрованный текст";
            // 
            // tbEncryptedText2
            // 
            this.tbEncryptedText2.Location = new System.Drawing.Point(12, 306);
            this.tbEncryptedText2.Name = "tbEncryptedText2";
            this.tbEncryptedText2.ReadOnly = true;
            this.tbEncryptedText2.Size = new System.Drawing.Size(491, 23);
            this.tbEncryptedText2.TabIndex = 10;
            // 
            // lbDecryptedText
            // 
            this.lbDecryptedText.AutoSize = true;
            this.lbDecryptedText.Location = new System.Drawing.Point(12, 343);
            this.lbDecryptedText.Name = "lbDecryptedText";
            this.lbDecryptedText.Size = new System.Drawing.Size(140, 15);
            this.lbDecryptedText.TabIndex = 11;
            this.lbDecryptedText.Text = "Расшифрованный текст";
            // 
            // tbDecryptedText
            // 
            this.tbDecryptedText.Location = new System.Drawing.Point(12, 361);
            this.tbDecryptedText.Name = "tbDecryptedText";
            this.tbDecryptedText.ReadOnly = true;
            this.tbDecryptedText.Size = new System.Drawing.Size(491, 23);
            this.tbDecryptedText.TabIndex = 12;
            // 
            // btnDeсrypt
            // 
            this.btnDeсrypt.Location = new System.Drawing.Point(12, 402);
            this.btnDeсrypt.Name = "btnDeсrypt";
            this.btnDeсrypt.Size = new System.Drawing.Size(491, 36);
            this.btnDeсrypt.TabIndex = 13;
            this.btnDeсrypt.Text = "Расшифровать";
            this.btnDeсrypt.UseVisualStyleBackColor = true;
            this.btnDeсrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnDeсrypt);
            this.Controls.Add(this.tbDecryptedText);
            this.Controls.Add(this.lbDecryptedText);
            this.Controls.Add(this.tbEncryptedText2);
            this.Controls.Add(this.lbEncryptedText2);
            this.Controls.Add(this.tbKeyseq2);
            this.Controls.Add(this.lbKeyseq2);
            this.Controls.Add(this.tbEncryptedText1);
            this.Controls.Add(this.lbEncryptedText1);
            this.Controls.Add(this.lbKeyseq1);
            this.Controls.Add(this.lbOpenText);
            this.Controls.Add(this.tbKeyseq1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbOpenText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.Text = "Шифр Вернама. Реализация: Кузнецов, группа 6138 (2021)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOpenText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbKeyseq1;
        private System.Windows.Forms.Label lbOpenText;
        private System.Windows.Forms.Label lbKeyseq1;
        private System.Windows.Forms.Label lbEncryptedText1;
        private System.Windows.Forms.TextBox tbEncryptedText1;
        private System.Windows.Forms.Label lbKeyseq2;
        private System.Windows.Forms.TextBox tbKeyseq2;
        private System.Windows.Forms.Label lbEncryptedText2;
        private System.Windows.Forms.TextBox tbEncryptedText2;
        private System.Windows.Forms.Label lbDecryptedText;
        private System.Windows.Forms.TextBox tbDecryptedText;
        private System.Windows.Forms.Button btnDeсrypt;
    }
}

