using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDatabase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            var exitapplication = MessageBox.Show("Are you sure you want to quit?",
                "Are you sure?", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if(exitapplication == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
