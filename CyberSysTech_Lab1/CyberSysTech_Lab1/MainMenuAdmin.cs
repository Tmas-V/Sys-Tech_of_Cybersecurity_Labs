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
    public partial class MainMenuAdmin : Form
    {
        private struct userDataBoxes
        {
            public Panel userFieldsPanel;
            public TextBox login_textbox;
            public TextBox id_textbox;
            public CheckBox block_checkbox;
            public Button edit_button;
            public _UserData userData;
        };
        private Panel[] panels;
        public Button[] passwordProtectedButtons;
        private int currentPanelIndex;
        private bool isInEditMode;
        private _UserData actualUserData;
        private static string passFieldsFiller = "********";
        private bool passDialogFinished = false;
        private bool passDialogReturn = false;
        private int chosen_regex_num;
        private int create_user_chosen_regex_num;
        private TypeInPasswordDialog openedTypeInPassDialog;
        private userDataBoxes[] userListRows;
        public MainMenuAdmin()
        {
            InitializeComponent();
            panels = new Panel[3];
            panels[0] = this.settings_panel;
            panels[1] = this.all_users_panel;
            panels[2] = this.create_new_user_panel;
            panels[1].Hide();
            panels[2].Hide();
            passwordProtectedButtons = new Button[2];
            passwordProtectedButtons[0] = this.edit_settings_button;
            passwordProtectedButtons[1] = this.create_new_user_button;
            currentPanelIndex = 0;
            isInEditMode = false;
            actualUserData = new _UserData();
            this.password_textbox.Text = passFieldsFiller;
            this.new_pass_textbox.Text = passFieldsFiller;
            this.confirm_pass_textbox.Text = passFieldsFiller;
            openedTypeInPassDialog = null;
            userListRows = null;
        }
        public MainMenuAdmin(_UserData userData)
        {
            InitializeComponent();
            chosen_regex_num = userData._passRestrict._passRegexIndex;
            create_user_chosen_regex_num = _passwordRestriction.def_pass_regex_Index;
            create_user_pass_regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(_passwordRestriction.def_pass_regex_Index);
            assignUserSettingsToFields(userData);
            panels = new Panel[3];
            panels[0] = this.settings_panel;
            panels[1] = this.all_users_panel;
            panels[2] = this.create_new_user_panel;
            panels[1].Hide();
            panels[2].Hide();
            passwordProtectedButtons = new Button[2];
            passwordProtectedButtons[0] = this.edit_settings_button;
            passwordProtectedButtons[1] = this.create_new_user_button;
            currentPanelIndex = 0;
            isInEditMode = false;
            if (userData._allowPassRestrict)
            {
                this.pass_rules_panel.Show();
                this.pass_rules_panel.Enabled = false;
            }
            actualUserData = new _UserData(ref userData);
            create_user_id_textbox.Text = _UserAccountsManager.getInstance().getNextUserID();
            create_user_min_len_numbox.Value = _passwordRestriction.def_min_len;
            openedTypeInPassDialog = null;
            assignUsersList();
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
        private void assignUsersList()
        {
            _UserAccountsManager userAccManager = _UserAccountsManager.getInstance();
            userListRows = new userDataBoxes[6];
            userListRows[0].userFieldsPanel = this.user_panel1; userListRows[0].login_textbox = this.user_login_textbox1; userListRows[0].id_textbox = this.user_id_textbox1; userListRows[0].block_checkbox = this.user_block_check1; userListRows[0].edit_button = this.user_edit_button1;
            userListRows[1].userFieldsPanel = this.user_panel2; userListRows[1].login_textbox = this.user_login_textbox2; userListRows[1].id_textbox = this.user_id_textbox2; userListRows[1].block_checkbox = this.user_block_check2; userListRows[1].edit_button = this.user_edit_button2;
            userListRows[2].userFieldsPanel = this.user_panel3; userListRows[2].login_textbox = this.user_login_textbox3; userListRows[2].id_textbox = this.user_id_textbox3; userListRows[2].block_checkbox = this.user_block_check3; userListRows[2].edit_button = this.user_edit_button3;
            userListRows[3].userFieldsPanel = this.user_panel4; userListRows[3].login_textbox = this.user_login_textbox4; userListRows[3].id_textbox = this.user_id_textbox4; userListRows[3].block_checkbox = this.user_block_check4; userListRows[3].edit_button = this.user_edit_button4;
            userListRows[4].userFieldsPanel = this.user_panel5; userListRows[4].login_textbox = this.user_login_textbox5; userListRows[4].id_textbox = this.user_id_textbox5; userListRows[4].block_checkbox = this.user_block_check5; userListRows[4].edit_button = this.user_edit_button5;
            userListRows[5].userFieldsPanel = this.user_panel6; userListRows[5].login_textbox = this.user_login_textbox6; userListRows[5].id_textbox = this.user_id_textbox6; userListRows[5].block_checkbox = this.user_block_check6; userListRows[5].edit_button = this.user_edit_button6;
        }
        public void updateUserList()
        {
            _UserAccountsManager userAccManager = _UserAccountsManager.getInstance();
            for (int i = 0; i < userListRows.Length; i++)
            {
                userListRows[i].userFieldsPanel.Hide();
            }
            for (int i = 0; i < userAccManager.getListLen() - 1; i++)
            {
                _UserData userDataFromList = userAccManager.getFromList(i + 1);
                userListRows[i].userData = new _UserData(ref userDataFromList);
                userListRows[i].login_textbox.Text = userDataFromList._login;
                userListRows[i].id_textbox.Text = userDataFromList._ID;
                userListRows[i].block_checkbox.Checked = userDataFromList._blocked;
                userListRows[i].edit_button.Enabled = true;
                userListRows[i].userFieldsPanel.Show();
            }
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
                if (!_UserData.getHash(this.password_textbox.Text).Equals(actualUserData._passhash))
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
        private _UserData returnNewUserData()
        {
            if (this.create_user_login_textbox.Text.Equals(""))
            {
                this.create_user_empty_login_label.Show();
                return null;
            }
            if (this.create_user_password_textbox.Text.Equals(""))
            {
                this.create_user_wrong_pass_label.Show();
                return null;
            }
            if (!this.create_user_password_textbox.Text.Equals(this.create_user_confirm_password_textbox.Text))//SAME
            {
                this.create_user_wrong_confirm_pass_label.Show();
                return null;
            }
            if (this.create_user_restrict_checked.Checked)
            {
                string actualregex = _passwordRestriction.premadeRegex[create_user_chosen_regex_num];
                if (!new Regex(actualregex).IsMatch(this.create_user_password_textbox.Text) || (this.create_user_password_textbox.Text.Length < (int)this.create_user_min_len_numbox.Value))
                {
                    this.create_user_not_match_regex_label.Show();
                    return null;
                }
            }
            string passhash = _UserData.getHash(this.create_user_password_textbox.Text);
            if (this.create_user_restrict_checked.Checked)
                return new _UserData(this.create_user_login_textbox.Text, this.create_user_id_textbox.Text, passhash, this.create_user_block_checked.Checked, this.create_user_restrict_checked.Checked, (int)this.create_user_min_len_numbox.Value, create_user_chosen_regex_num);
            else
                return new _UserData(this.create_user_login_textbox.Text, this.create_user_id_textbox.Text, passhash, this.create_user_block_checked.Checked, this.create_user_restrict_checked.Checked);
        }
        private void hideAllEditErrors()
        {
            this.wrong_pass_label.Hide();
            this.wrong_confirm_pass_label.Hide();
            this.not_match_regex_label.Hide();
            this.empty_login_label.Hide();
        }
        private void hideAllCreateErrors()
        {
            this.create_user_wrong_pass_label.Hide();
            this.create_user_wrong_confirm_pass_label.Hide();
            this.create_user_not_match_regex_label.Hide();
            this.create_user_empty_login_label.Hide();
            this.create_user_many_users_label.Hide();
        }

        private void userData_page_button_Click(object sender, EventArgs e)
        {
            if(currentPanelIndex == 0)
            {
                return;
            }
            panels[currentPanelIndex].Hide();
            currentPanelIndex = 0;
            panels[currentPanelIndex].Show();
        }
        private void all_users_button_Click(object sender, EventArgs e)
        {
            if (currentPanelIndex == 1)
            {
                return;
            }
            panels[currentPanelIndex].Hide();
            currentPanelIndex = 1;
            panels[currentPanelIndex].Show();
            updateUserList();
        }
        private void create_new_user_button_Click(object sender, EventArgs e)
        {
            if (currentPanelIndex == 2)
            {
                return;
            }
            if (!passDialogFinished)
            {
                openedTypeInPassDialog = new TypeInPasswordDialog(this, 1);
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
            panels[currentPanelIndex].Hide();
            currentPanelIndex = 2;
            panels[currentPanelIndex].Show();
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
                this.block_checkbox.Enabled = true;
                this.pass_restrict_check.Enabled = true;
                if ((this.pass_restrict_check.Checked))
                {
                    this.pass_rules_panel.Show();
                    this.pass_rules_panel.Enabled = true;
                    this.min_pass_len_numbox.Enabled = true;
                    change_regex_button.Enabled = true;
                }

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
                this.block_checkbox.Enabled = false;
                this.pass_restrict_check.Enabled = false;
                if ((this.pass_restrict_check.Checked))
                {
                    this.pass_rules_panel.Show();
                    this.pass_rules_panel.Enabled = false;
                    this.min_pass_len_numbox.Enabled = false;
                    change_regex_button.Enabled = false;
                }

                this.new_pass_panel.Hide();
                this.new_pass_panel.Enabled = false;
                this.new_pass_textbox.Enabled = false;
                this.confirm_pass_textbox.Enabled = false;
                isInEditMode = false;
                this.edit_settings_button.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
            }

        }

        private void submit_new_user_button_Click(object sender, EventArgs e)
        {
            hideAllCreateErrors();
            int currentListLen = _UserAccountsManager.getInstance().getListLen();
            int numOfUsers = _UserAccountsManager.maxUserCount;
            if (currentListLen >= numOfUsers)
            {
                this.create_user_many_users_label.Show();
                return;
            }
            _UserData newUserData = returnNewUserData();
            if (newUserData == null)
            {
                return;
            }
            _UserAccountsManager userAccManager = _UserAccountsManager.getInstance();
            userAccManager.appendNewUserData(newUserData);
            this.create_user_login_textbox.Text = "";
            this.create_user_password_textbox.Text = "";
            this.create_user_confirm_password_textbox.Text = "";
            this.create_user_block_checked.Checked = false;
            this.create_user_restrict_checked.Checked = false;
            this.create_user_id_textbox.Text = _UserAccountsManager.getInstance().getNextUserID();
            this.create_user_min_len_numbox.Value = _passwordRestriction.def_min_len;
            create_user_chosen_regex_num = _passwordRestriction.def_pass_regex_Index;
            this.create_user_pass_regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(_passwordRestriction.def_pass_regex_Index);
        }


        private void pass_restrict_check_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.pass_restrict_check.Checked))
            {
                this.pass_rules_panel.Show();
            }
            else
            {
                this.pass_rules_panel.Hide();
            }
            if (isInEditMode)
            {
                this.pass_rules_panel.Enabled = true;
                this.change_regex_button.Enabled = true;
                this.min_pass_len_numbox.Enabled = true;
            }
            else
            {
                this.pass_rules_panel.Enabled = false;
                this.change_regex_button.Enabled = false;
                this.min_pass_len_numbox.Enabled = false;
            }
        }

        private void create_user_restrict_checked_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.create_user_restrict_checked.Checked))
            {
                this.create_user_restrict_panel.Enabled = true;
                this.create_user_change_regex_button.Enabled = true;
                this.create_user_restrict_panel.Show();
            }
            else
            {
                this.create_user_restrict_panel.Enabled = false;
                this.create_user_change_regex_button.Enabled = false;
                this.create_user_restrict_panel.Hide();
            }
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
            if (isInEditMode)
            {
                chosen_regex_num = (chosen_regex_num + 1) % _passwordRestriction.premadeRegexArrLen;
                this.regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(chosen_regex_num);
            }
        }

        private void create_user_change_regex_button_Click(object sender, EventArgs e)
        {
            create_user_chosen_regex_num = (create_user_chosen_regex_num + 1) % _passwordRestriction.premadeRegexArrLen;
            this.create_user_pass_regex_textbox.Text = _passwordRestriction.getRegexFriendlyName(create_user_chosen_regex_num);
        }

        private void editUserButtonClick(int num)
        {
            if ((num < 0) || (num > userListRows.Length))
                return;
            EditUserWindow editUserWindow = new EditUserWindow(this, userListRows[num].userData);
            this.Enabled = false;
            editUserWindow.Show();
        }
        private void user_edit_button1_Click(object sender, EventArgs e)
        {
            editUserButtonClick(0);
        }

        private void user_edit_button2_Click(object sender, EventArgs e)
        {
            editUserButtonClick(1);
        }

        private void user_edit_button3_Click(object sender, EventArgs e)
        {
            editUserButtonClick(2);
        }

        private void user_edit_button4_Click(object sender, EventArgs e)
        {
            editUserButtonClick(3);
        }

        private void user_edit_button5_Click(object sender, EventArgs e)
        {
            editUserButtonClick(4);
        }

        private void user_edit_button6_Click(object sender, EventArgs e)
        {
            editUserButtonClick(5);
        }
    }
}
