using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbKeyseq1.Text = VernamCipher.GenerateKeyseq(tbOpenText.Text.Length);
            tbEncryptedText1.Text = VernamCipher.Encrypt(tbOpenText.Text, tbKeyseq1.Text);

            tbKeyseq2.Text = tbKeyseq1.Text;
            tbEncryptedText2.Text = tbEncryptedText1.Text;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbDecryptedText.Text = VernamCipher.Decrypt(tbEncryptedText2.Text, tbKeyseq2.Text);
        }
    }
}
