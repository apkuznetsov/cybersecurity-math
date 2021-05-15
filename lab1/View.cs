using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            tbKeyseq1.Text = VernamCipher.GenerateKeyseq(tbOpenText.Text.Length);
            tbEncodedText1.Text = VernamCipher.Encode(tbOpenText.Text, tbKeyseq1.Text);
            
            tbKeyseq2.Text = tbKeyseq1.Text;
            tbEncodedText2.Text = tbEncodedText1.Text;
        }
    }
}
