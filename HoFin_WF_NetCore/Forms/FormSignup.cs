using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoFin_WF_NetCore.Forms
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO: add validations for all fields
    }
}
