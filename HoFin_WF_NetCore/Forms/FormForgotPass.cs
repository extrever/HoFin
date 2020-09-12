using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoFin_WF_NetCore.Forms
{
    public partial class FormForgotPass : Form
    {
        public FormForgotPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonForgotPassCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
