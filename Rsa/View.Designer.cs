namespace Rsa
{
    partial class View
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbP = new System.Windows.Forms.Label();
            this.lbQ = new System.Windows.Forms.Label();
            this.lbPrimes = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.nudQ = new System.Windows.Forms.NumericUpDown();
            this.nudD = new System.Windows.Forms.NumericUpDown();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(13, 120);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(139, 29);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(13, 261);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(139, 31);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP.Location = new System.Drawing.Point(13, 49);
            this.lbP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(31, 20);
            this.lbP.TabIndex = 3;
            this.lbP.Text = "p =";
            // 
            // lbQ
            // 
            this.lbQ.AutoSize = true;
            this.lbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQ.Location = new System.Drawing.Point(13, 82);
            this.lbQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(31, 20);
            this.lbQ.TabIndex = 5;
            this.lbQ.Text = "q =";
            // 
            // lbPrimes
            // 
            this.lbPrimes.AutoSize = true;
            this.lbPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrimes.Location = new System.Drawing.Point(13, 9);
            this.lbPrimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrimes.Name = "lbPrimes";
            this.lbPrimes.Size = new System.Drawing.Size(125, 20);
            this.lbPrimes.TabIndex = 7;
            this.lbPrimes.Text = "Простые числа";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbD.Location = new System.Drawing.Point(13, 203);
            this.lbD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(31, 20);
            this.lbD.TabIndex = 8;
            this.lbD.Text = "d =";
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbN.Location = new System.Drawing.Point(13, 232);
            this.lbN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(31, 20);
            this.lbN.TabIndex = 9;
            this.lbN.Text = "n =";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKey.Location = new System.Drawing.Point(13, 169);
            this.lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(136, 20);
            this.lbKey.TabIndex = 10;
            this.lbKey.Text = "Секретный ключ";
            // 
            // nudP
            // 
            this.nudP.Location = new System.Drawing.Point(51, 49);
            this.nudP.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(72, 23);
            this.nudP.TabIndex = 13;
            this.nudP.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // nudQ
            // 
            this.nudQ.Location = new System.Drawing.Point(51, 82);
            this.nudQ.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudQ.Name = "nudQ";
            this.nudQ.Size = new System.Drawing.Size(72, 23);
            this.nudQ.TabIndex = 14;
            this.nudQ.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            // 
            // nudD
            // 
            this.nudD.Location = new System.Drawing.Point(51, 203);
            this.nudD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudD.Name = "nudD";
            this.nudD.Size = new System.Drawing.Size(72, 23);
            this.nudD.TabIndex = 15;
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(51, 232);
            this.nudN.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(72, 23);
            this.nudN.TabIndex = 16;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(165, 306);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.nudD);
            this.Controls.Add(this.nudQ);
            this.Controls.Add(this.nudP);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbPrimes);
            this.Controls.Add(this.lbQ);
            this.Controls.Add(this.lbP);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.Text = "RSA";
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbQ;
        private System.Windows.Forms.Label lbPrimes;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.NumericUpDown nudD;
        private System.Windows.Forms.NumericUpDown nudN;
    }
}

