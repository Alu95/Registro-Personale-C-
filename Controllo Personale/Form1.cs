using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controllo_Personale
{
    public partial class home_form : Form
    {
        public home_form()
        {
            InitializeComponent();
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close()
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
