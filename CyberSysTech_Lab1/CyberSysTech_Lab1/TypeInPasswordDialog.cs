using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSysTech_Lab1
{
    public partial class TypeInPasswordDialog : Form
    {
        private MainMenu callerMenuForm;
        private MainMenuAdmin callerAdminMenuFrom;
        private int buttonIndexToClick;
        public TypeInPasswordDialog()
        {
            InitializeComponent();
            callerMenuForm = null;
            callerAdminMenuFrom = null;
            buttonIndexToClick = -1;
        }
        public TypeInPasswordDialog(MainMenu mainMenu, int buttonIndex)
        {
            InitializeComponent();
            callerMenuForm = mainMenu;
            callerAdminMenuFrom = null;
            buttonIndexToClick = buttonIndex;
        }
        public TypeInPasswordDialog(MainMenuAdmin mainMenu, int buttonIndex)
        {
            InitializeComponent();
            callerAdminMenuFrom = mainMenu;
            callerMenuForm = null;
            buttonIndexToClick = buttonIndex;
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            if (callerMenuForm != null)
            {
                callerMenuForm.assignPassDialogReturn(true, false);
                callerMenuForm.Enabled = true;
                callerMenuForm.passwordProtectedButtons[buttonIndexToClick].PerformClick();
                this.Close();
            }
            else if (callerAdminMenuFrom != null)
            {
                callerAdminMenuFrom.assignPassDialogReturn(true, false);
                callerAdminMenuFrom.Enabled = true;
                callerAdminMenuFrom.passwordProtectedButtons[buttonIndexToClick].PerformClick();
                this.Close();
            }

        }

        private void pass_dialog_submit_button_Click(object sender, EventArgs e)
        {
            if (callerMenuForm != null)
            {
                string password = this.pass_dialog_textbox.Text;
                bool check = callerMenuForm.checkTypedPasswordDialog(_UserData.getHash(password));
                if (!check)
                {
                    this.wrong_pass_dialog_label.Show();
                    return;
                }
                else
                {
                    callerMenuForm.assignPassDialogReturn(true, true);
                    this.wrong_pass_dialog_label.Hide();
                    callerMenuForm.Enabled = true;
                    callerMenuForm.passwordProtectedButtons[buttonIndexToClick].PerformClick();
                    this.Close();
                }
            }
            else if (callerAdminMenuFrom != null)
            {
                string password = this.pass_dialog_textbox.Text;
                bool check = callerAdminMenuFrom.checkTypedPasswordDialog(_UserData.getHash(password));
                if (!check)
                {
                    this.wrong_pass_dialog_label.Show();
                    return;
                }
                else
                {
                    callerAdminMenuFrom.assignPassDialogReturn(true, true);
                    this.wrong_pass_dialog_label.Hide();
                    callerAdminMenuFrom.Enabled = true;
                    callerAdminMenuFrom.passwordProtectedButtons[buttonIndexToClick].PerformClick();
                    this.Close();
                }
            }
        }
    }
}
