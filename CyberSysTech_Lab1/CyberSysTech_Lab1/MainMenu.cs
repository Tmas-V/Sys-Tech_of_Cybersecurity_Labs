using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CyberSysTech_Lab1
{
    public partial class MainMenu : Form
    {
        public Button[] passwordProtectedButtons;
        private bool isInEditMode;
        private _UserData actualUserData;
        private static string passFieldsFiller = "********";
        private bool passDialogFinished = false;
        private bool passDialogReturn = false;
        private int chosen_regex_num;
        private TypeInPasswordDialog openedTypeInPassDialog;
        public MainMenu()
        {
            InitializeComponent();
            passwordProtectedButtons = new Button[1];
            passwordProtectedButtons[0] = this.edit_settings_button;
            isInEditMode = false;
            actualUserData = new _UserData();
            this.password_textbox.Text = passFieldsFiller;
            this.new_pass_textbox.Text = passFieldsFiller;
            this.confirm_pass_textbox.Text = passFieldsFiller;
            openedTypeInPassDialog = null;
        }
        public MainMenu(_UserData userData)
        {
            InitializeComponent();
            chosen_regex_num = userData._passRestrict._passRegexIndex;
            assignUserSettingsToFields(userData);
            this.block_checkbox.Enabled = false;
            this.pass_restrict_check.Enabled = false;
            this.pass_rules_panel.Enabled = false;
            passwordProtectedButtons = new Button[1];
            passwordProtectedButtons[0] = this.edit_settings_button;
            isInEditMode = false;
            if (userData._allowPassRestrict)
            {
                this.pass_rules_panel.Show();
                this.pass_rules_panel.Enabled = false;
            }
            actualUserData = new _UserData(ref userData);
            openedTypeInPassDialog = null;
        }
        private void assignUserSettingsToFields(_UserData userData)
        {
            this.login_welcome_textbox.Text = userData._login;
            this.login_textbox.Text = userData._login;
            this.id_textbox.Text = userData._ID;
            this.block_checkbox.Checked = userData._blocked;
            this.pass_restrict_check.Checked = userData._allowPassRestrict;
            this.min_pass_len_numbox.Minimum = userData._passRestrict._minLength;
            this.regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(userData._passRestrict._passRegexIndex);
            this.password_textbox.Text = passFieldsFiller;
            this.new_pass_textbox.Text = passFieldsFiller;
            this.confirm_pass_textbox.Text = passFieldsFiller;
        }
        private _UserData returnEditedUserSettings()
        {
            if(!isInEditMode)
            {
                return null;
            }
            bool hasPasswordChanged = false;
            if (this.login_textbox.Equals(""))
            {
                this.empty_login_label.Show();
                return null;
            }
            if (!this.password_textbox.Text.Equals(passFieldsFiller))
            {
                if (!_UserData.getHash(this.password_textbox.Text).Equals(actualUserData._passhash))//Make regex checking on editModeOut
                {
                    this.wrong_pass_label.Show();
                    return null;
                }
                if (!this.new_pass_textbox.Text.Equals(this.confirm_pass_textbox.Text))
                {
                    this.wrong_confirm_pass_label.Show();
                    return null;
                }
                if (!this.new_pass_textbox.Text.Equals(passFieldsFiller))
                {
                    hasPasswordChanged = true;
                    if (this.pass_restrict_check.Checked)
                    {
                        string actualregex = _passwordRestriction.premadeRegex[chosen_regex_num];
                        if (!new Regex(actualregex).IsMatch(this.new_pass_textbox.Text) || (this.new_pass_textbox.Text.Length < (int)this.min_pass_len_numbox.Value))
                        {
                            this.not_match_regex_label.Show();
                            return null;
                        }
                    }
                }
            }
            string passhash = "";
            if (hasPasswordChanged)
            {
                passhash = _UserData.getHash(this.new_pass_textbox.Text);
            }
            else
            {
                passhash = actualUserData._passhash;
            }
            if (this.pass_restrict_check.Checked)
                return new _UserData(this.login_textbox.Text, actualUserData._ID, passhash, this.block_checkbox.Checked, this.pass_restrict_check.Checked, (int)this.min_pass_len_numbox.Value, chosen_regex_num);
            else
                return new _UserData(this.login_textbox.Text, actualUserData._ID, passhash, this.block_checkbox.Checked, this.pass_restrict_check.Checked);
        }
        private void hideAllEditErrors()
        {
            this.wrong_pass_label.Hide();
            this.wrong_confirm_pass_label.Hide();
            this.not_match_regex_label.Hide();
            this.empty_login_label.Hide();
        }

        private void userData_page_button_Click(object sender, EventArgs e)
        {
        }

        private void edit_settings_button_Click(object sender, EventArgs e)
        {
            if (!isInEditMode)
            {
                if (!passDialogFinished)
                {
                    openedTypeInPassDialog = new TypeInPasswordDialog(this, 0);
                    openedTypeInPassDialog.Show();
                    this.Enabled = false;
                    return;
                }
                
                if (!passDialogReturn)
                {
                    passDialogFinished = false;
                    passDialogReturn = false;
                    openedTypeInPassDialog = null;
                    return;
                }
                passDialogFinished = false;
                passDialogReturn = false;

                this.login_textbox.Enabled = true;
                this.password_textbox.Enabled = true;

                this.new_pass_panel.Show();
                this.new_pass_panel.Enabled = true;
                this.new_pass_textbox.Enabled = true;
                this.confirm_pass_textbox.Enabled = true;
                isInEditMode = true;
                this.edit_settings_button.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
            }
            else
            {
                hideAllEditErrors();
                _UserData editedUserData = returnEditedUserSettings();
                if (editedUserData == null)
                {
                    return;
                }
                _UserAccountsManager userAccManager = _UserAccountsManager.getInstance();
                userAccManager.saveUserData(editedUserData);
                actualUserData = new _UserData(ref editedUserData);
                this.password_textbox.Text = passFieldsFiller;
                this.new_pass_textbox.Text = passFieldsFiller;
                this.confirm_pass_textbox.Text = passFieldsFiller;
                this.login_textbox.Enabled = false;
                this.password_textbox.Enabled = false;

                this.new_pass_panel.Hide();
                this.new_pass_panel.Enabled = false;
                this.new_pass_textbox.Enabled = false;
                this.confirm_pass_textbox.Enabled = false;
                isInEditMode = false;
                this.edit_settings_button.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
            }

        }


        private void pass_restrict_check_CheckedChanged(object sender, EventArgs e)
        {
        }


        private void quit_button_Click(object sender, EventArgs e)
        {
            _UserAccountsManager uAM = _UserAccountsManager.getInstance();
            uAM.endSession();
            Application.Exit();
        }

        public bool checkTypedPasswordDialog(string passhash)
        {
            return actualUserData._passhash.Equals(passhash);
        }
        public void assignPassDialogReturn(bool passDialogStatus, bool passDialogResult)
        {
            passDialogFinished = passDialogStatus;
            passDialogReturn = passDialogResult;
        }

        private void all_users_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void change_regex_button_Click(object sender, EventArgs e)
        {
        }
    }
}
