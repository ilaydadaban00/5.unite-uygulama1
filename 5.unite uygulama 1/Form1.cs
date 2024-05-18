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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter tuşu çalışıyor");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESC tuşu çalışıyor");
        }

        private void btnControlbox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)

                this.ControlBox = false;

            else

                this.ControlBox = true;
            
        }

        private void btnCenterToScreen_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormB formB= new FormB();
            formB.Show();

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }
    }
}
