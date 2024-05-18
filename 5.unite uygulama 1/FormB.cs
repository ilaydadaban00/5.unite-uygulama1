using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama_1
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("formB yükleniyor");
        }

        private void FormB_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("formB kapanıyor");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
