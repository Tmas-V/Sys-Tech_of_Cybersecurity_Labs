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
    public partial class EditUserWindow : Form
    {
        private MainMenuAdmin calleeMainMenuAdmin;
        private _UserData userData;

        private static string passFieldsFiller = "********";
        private int chosen_regex_num;
        public EditUserWindow()
        {
            InitializeComponent();
            calleeMainMenuAdmin = null;
            userData = null;
        }
        public EditUserWindow(MainMenuAdmin caller, _UserData editedUserData)
        {
            InitializeComponent();
            calleeMainMenuAdmin = caller;
            userData = editedUserData;
            assignUserFields();
        }
        private void assignUserFields()
        {
            this.login_textbox.Text = userData._login;
            this.id_textbox.Text = userData._ID;
            this.new_pass_textbox.Text = passFieldsFiller;
            this.confirm_pass_textbox.Text = passFieldsFiller;
            this.block_checkbox.Checked = userData._blocked;
            this.pass_restrict_check.Checked = userData._allowPassRestrict;
            this.min_pass_len_numbox.Value = userData._passRestrict._minLength;
            chosen_regex_num = userData._passRestrict._passRegexIndex;
            this.regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(chosen_regex_num);
            if ((this.pass_restrict_check.Checked))
            {
                this.pass_rules_panel.Enabled = true;
                this.min_pass_len_numbox.Enabled = true;
                this.change_regex_button.Enabled = true;
                this.pass_rules_panel.Show();

            }
            else
            {
                this.pass_rules_panel.Enabled = false;
                this.min_pass_len_numbox.Enabled = false;
                this.change_regex_button.Enabled = false;
                this.pass_rules_panel.Hide();
            }
        }

        private _UserData returnEditedUserData()
        {
            if (this.login_textbox.Text.Equals(""))
            {
                this.empty_login_label.Show();
                return null;
            }
            if (this.new_pass_textbox.Text.Equals(""))
            {
                this.wrong_pass_label.Show();
                return null;
            }
            if (!this.new_pass_textbox.Text.Equals(this.confirm_pass_textbox.Text))//SAME
            {
                this.wrong_confirm_pass_label.Show();
                return null;
            }
            if (this.pass_restrict_check.Checked)
            {
                string actualregex = _passwordRestriction.premadeRegex[chosen_regex_num];
                if (!new Regex(actualregex).IsMatch(this.new_pass_textbox.Text) || (this.new_pass_textbox.Text.Length < (int)this.min_pass_len_numbox.Value))
                {
                    this.not_match_regex_label.Show();
                    return null;
                }
            }
            string passhash = _UserData.getHash(this.new_pass_textbox.Text);
            if (this.pass_restrict_check.Checked)
                return new _UserData(this.login_textbox.Text, this.id_textbox.Text, passhash, this.block_checkbox.Checked, this.pass_restrict_check.Checked, (int)this.min_pass_len_numbox.Value, chosen_regex_num);
            else
                return new _UserData(this.login_textbox.Text, this.id_textbox.Text, passhash, this.block_checkbox.Checked, this.pass_restrict_check.Checked);
        }

        private void hideAllEditErrors()
        {
            this.wrong_pass_label.Hide();
            this.wrong_confirm_pass_label.Hide();
            this.not_match_regex_label.Hide();
            this.empty_login_label.Hide();
        }
        private void quit()
        {
            calleeMainMenuAdmin.Enabled = true;
            calleeMainMenuAdmin.updateUserList();
            this.Close();
        }

        private void edit_settings_button_Click(object sender, EventArgs e)
        {
            hideAllEditErrors();
            _UserData editedUserData = returnEditedUserData();
            if (editedUserData == null)
            {
                return;
            }
            _UserAccountsManager userAccManager = _UserAccountsManager.getInstance();
            userAccManager.saveUserData(editedUserData);
            quit();
        }

        private void remove_user_button_Click(object sender, EventArgs e)
        {
            _UserAccountsManager.getInstance().removeUserData(userData);
            quit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            quit();
        }

        private void pass_restrict_check_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.pass_restrict_check.Checked))
            {
                this.pass_rules_panel.Enabled = true;
                this.min_pass_len_numbox.Enabled = true;
                this.change_regex_button.Enabled = true;
                this.pass_rules_panel.Show();
                
            }
            else
            {
                this.pass_rules_panel.Enabled = false;
                this.min_pass_len_numbox.Enabled = false;
                this.change_regex_button.Enabled = false;
                this.pass_rules_panel.Hide();
            }
        }

        private void change_regex_button_Click(object sender, EventArgs e)
        {
            chosen_regex_num = (chosen_regex_num + 1) % _passwordRestriction.premadeRegexArrLen;
            this.regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(chosen_regex_num);
        }
    }
}
