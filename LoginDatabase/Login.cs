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
            const string exitMessage = "Are you sure you want to quit?";
            const string exitCapation = "Exit Application";

            var exitapplication = MessageBox.Show(exitMessage, exitCapation, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if(exitapplication == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }


        public static bool CloseCancel()
        {
            const string message = "Are you sure you want to exit the application?";
            const string caption = "Exit application";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
