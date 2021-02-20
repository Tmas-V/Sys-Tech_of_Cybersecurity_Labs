
namespace CyberSysTech_Lab1
{
    partial class EditUserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings_panel = new System.Windows.Forms.Panel();
            this.empty_login_label = new System.Windows.Forms.Label();
            this.not_match_regex_label = new System.Windows.Forms.Label();
            this.new_pass_panel = new System.Windows.Forms.Panel();
            this.confirm_pass_label = new System.Windows.Forms.Label();
            this.confirm_pass_textbox = new System.Windows.Forms.TextBox();
            this.new_pass_label = new System.Windows.Forms.Label();
            this.new_pass_textbox = new System.Windows.Forms.TextBox();
            this.pass_rules_panel = new System.Windows.Forms.Panel();
            this.change_regex_button = new System.Windows.Forms.Button();
            this.regex_textbox = new System.Windows.Forms.TextBox();
            this.pass_regex_label = new System.Windows.Forms.Label();
            this.min_pass_len_label = new System.Windows.Forms.Label();
            this.min_pass_len_numbox = new System.Windows.Forms.NumericUpDown();
            this.edit_settings_button = new System.Windows.Forms.Button();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_restrict_check = new System.Windows.Forms.CheckBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.block_checkbox = new System.Windows.Forms.CheckBox();
            this.pass_restrict_label = new System.Windows.Forms.Label();
            this.block_label = new System.Windows.Forms.Label();
            this.sid_label = new System.Windows.Forms.Label();
            this.wrong_confirm_pass_label = new System.Windows.Forms.Label();
            this.wrong_pass_label = new System.Windows.Forms.Label();
            this.remove_user_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.settings_panel.SuspendLayout();
            this.new_pass_panel.SuspendLayout();
            this.pass_rules_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pass_len_numbox)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.settings_panel.Controls.Add(this.remove_user_button);
            this.settings_panel.Controls.Add(this.empty_login_label);
            this.settings_panel.Controls.Add(this.not_match_regex_label);
            this.settings_panel.Controls.Add(this.new_pass_panel);
            this.settings_panel.Controls.Add(this.pass_rules_panel);
            this.settings_panel.Controls.Add(this.edit_settings_button);
            this.settings_panel.Controls.Add(this.login_textbox);
            this.settings_panel.Controls.Add(this.login_label);
            this.settings_panel.Controls.Add(this.pass_restrict_check);
            this.settings_panel.Controls.Add(this.id_textbox);
            this.settings_panel.Controls.Add(this.block_checkbox);
            this.settings_panel.Controls.Add(this.pass_restrict_label);
            this.settings_panel.Controls.Add(this.block_label);
            this.settings_panel.Controls.Add(this.sid_label);
            this.settings_panel.Controls.Add(this.wrong_confirm_pass_label);
            this.settings_panel.Controls.Add(this.wrong_pass_label);
            this.settings_panel.Location = new System.Drawing.Point(51, 21);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(698, 345);
            this.settings_panel.TabIndex = 1;
            // 
            // empty_login_label
            // 
            this.empty_login_label.AutoSize = true;
            this.empty_login_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empty_login_label.ForeColor = System.Drawing.Color.Red;
            this.empty_login_label.Location = new System.Drawing.Point(311, 25);
            this.empty_login_label.Name = "empty_login_label";
            this.empty_login_label.Size = new System.Drawing.Size(187, 13);
            this.empty_login_label.TabIndex = 23;
            this.empty_login_label.Text = "Error:empty logins are not allowed!";
            this.empty_login_label.Visible = false;
            // 
            // not_match_regex_label
            // 
            this.not_match_regex_label.AutoSize = true;
            this.not_match_regex_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.not_match_regex_label.ForeColor = System.Drawing.Color.Red;
            this.not_match_regex_label.Location = new System.Drawing.Point(311, 24);
            this.not_match_regex_label.Name = "not_match_regex_label";
            this.not_match_regex_label.Size = new System.Drawing.Size(251, 13);
            this.not_match_regex_label.TabIndex = 19;
            this.not_match_regex_label.Text = "Error: new pasword doesn`t match to restriction!";
            this.not_match_regex_label.Visible = false;
            // 
            // new_pass_panel
            // 
            this.new_pass_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.new_pass_panel.Controls.Add(this.confirm_pass_label);
            this.new_pass_panel.Controls.Add(this.confirm_pass_textbox);
            this.new_pass_panel.Controls.Add(this.new_pass_label);
            this.new_pass_panel.Controls.Add(this.new_pass_textbox);
            this.new_pass_panel.Location = new System.Drawing.Point(45, 103);
            this.new_pass_panel.Name = "new_pass_panel";
            this.new_pass_panel.Size = new System.Drawing.Size(601, 43);
            this.new_pass_panel.TabIndex = 16;
            // 
            // confirm_pass_label
            // 
            this.confirm_pass_label.AutoSize = true;
            this.confirm_pass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_pass_label.Location = new System.Drawing.Point(306, 11);
            this.confirm_pass_label.Name = "confirm_pass_label";
            this.confirm_pass_label.Size = new System.Drawing.Size(126, 19);
            this.confirm_pass_label.TabIndex = 14;
            this.confirm_pass_label.Text = "Confirm password:";
            // 
            // confirm_pass_textbox
            // 
            this.confirm_pass_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_pass_textbox.Location = new System.Drawing.Point(438, 8);
            this.confirm_pass_textbox.Name = "confirm_pass_textbox";
            this.confirm_pass_textbox.Size = new System.Drawing.Size(143, 25);
            this.confirm_pass_textbox.TabIndex = 15;
            this.confirm_pass_textbox.Text = "********";
            this.confirm_pass_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_pass_label
            // 
            this.new_pass_label.AutoSize = true;
            this.new_pass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_pass_label.Location = new System.Drawing.Point(13, 11);
            this.new_pass_label.Name = "new_pass_label";
            this.new_pass_label.Size = new System.Drawing.Size(104, 19);
            this.new_pass_label.TabIndex = 12;
            this.new_pass_label.Text = "New password:";
            // 
            // new_pass_textbox
            // 
            this.new_pass_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_pass_textbox.Location = new System.Drawing.Point(145, 8);
            this.new_pass_textbox.Name = "new_pass_textbox";
            this.new_pass_textbox.Size = new System.Drawing.Size(143, 25);
            this.new_pass_textbox.TabIndex = 13;
            this.new_pass_textbox.Text = "********";
            this.new_pass_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_rules_panel
            // 
            this.pass_rules_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pass_rules_panel.Controls.Add(this.change_regex_button);
            this.pass_rules_panel.Controls.Add(this.regex_textbox);
            this.pass_rules_panel.Controls.Add(this.pass_regex_label);
            this.pass_rules_panel.Controls.Add(this.min_pass_len_label);
            this.pass_rules_panel.Controls.Add(this.min_pass_len_numbox);
            this.pass_rules_panel.Enabled = false;
            this.pass_rules_panel.Location = new System.Drawing.Point(45, 213);
            this.pass_rules_panel.Name = "pass_rules_panel";
            this.pass_rules_panel.Size = new System.Drawing.Size(641, 119);
            this.pass_rules_panel.TabIndex = 11;
            this.pass_rules_panel.Visible = false;
            // 
            // change_regex_button
            // 
            this.change_regex_button.Enabled = false;
            this.change_regex_button.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_regex_button.Location = new System.Drawing.Point(396, 44);
            this.change_regex_button.Name = "change_regex_button";
            this.change_regex_button.Size = new System.Drawing.Size(48, 26);
            this.change_regex_button.TabIndex = 19;
            this.change_regex_button.Text = "< >";
            this.change_regex_button.UseVisualStyleBackColor = true;
            this.change_regex_button.Click += new System.EventHandler(this.change_regex_button_Click);
            // 
            // regex_textbox
            // 
            this.regex_textbox.Enabled = false;
            this.regex_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regex_textbox.Location = new System.Drawing.Point(174, 44);
            this.regex_textbox.Name = "regex_textbox";
            this.regex_textbox.Size = new System.Drawing.Size(216, 25);
            this.regex_textbox.TabIndex = 19;
            this.regex_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_regex_label
            // 
            this.pass_regex_label.AutoSize = true;
            this.pass_regex_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_regex_label.Location = new System.Drawing.Point(16, 47);
            this.pass_regex_label.Name = "pass_regex_label";
            this.pass_regex_label.Size = new System.Drawing.Size(109, 19);
            this.pass_regex_label.TabIndex = 14;
            this.pass_regex_label.Text = "Password regex:";
            // 
            // min_pass_len_label
            // 
            this.min_pass_len_label.AutoSize = true;
            this.min_pass_len_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min_pass_len_label.Location = new System.Drawing.Point(16, 14);
            this.min_pass_len_label.Name = "min_pass_len_label";
            this.min_pass_len_label.Size = new System.Drawing.Size(108, 19);
            this.min_pass_len_label.TabIndex = 12;
            this.min_pass_len_label.Text = "Minimal length:";
            // 
            // min_pass_len_numbox
            // 
            this.min_pass_len_numbox.Enabled = false;
            this.min_pass_len_numbox.Location = new System.Drawing.Point(175, 15);
            this.min_pass_len_numbox.Name = "min_pass_len_numbox";
            this.min_pass_len_numbox.Size = new System.Drawing.Size(120, 20);
            this.min_pass_len_numbox.TabIndex = 0;
            // 
            // edit_settings_button
            // 
            this.edit_settings_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_settings_button.Location = new System.Drawing.Point(611, 12);
            this.edit_settings_button.Name = "edit_settings_button";
            this.edit_settings_button.Size = new System.Drawing.Size(75, 32);
            this.edit_settings_button.TabIndex = 10;
            this.edit_settings_button.Text = "Save";
            this.edit_settings_button.UseVisualStyleBackColor = true;
            this.edit_settings_button.Click += new System.EventHandler(this.edit_settings_button_Click);
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(104, 22);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(100, 25);
            this.login_textbox.TabIndex = 9;
            this.login_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(41, 25);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(47, 19);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "Login:";
            // 
            // pass_restrict_check
            // 
            this.pass_restrict_check.AutoSize = true;
            this.pass_restrict_check.Location = new System.Drawing.Point(190, 191);
            this.pass_restrict_check.Name = "pass_restrict_check";
            this.pass_restrict_check.Size = new System.Drawing.Size(15, 14);
            this.pass_restrict_check.TabIndex = 7;
            this.pass_restrict_check.UseVisualStyleBackColor = true;
            this.pass_restrict_check.CheckedChanged += new System.EventHandler(this.pass_restrict_check_CheckedChanged);
            // 
            // id_textbox
            // 
            this.id_textbox.Enabled = false;
            this.id_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_textbox.Location = new System.Drawing.Point(86, 65);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(100, 25);
            this.id_textbox.TabIndex = 5;
            this.id_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // block_checkbox
            // 
            this.block_checkbox.AutoSize = true;
            this.block_checkbox.Location = new System.Drawing.Point(95, 162);
            this.block_checkbox.Name = "block_checkbox";
            this.block_checkbox.Size = new System.Drawing.Size(15, 14);
            this.block_checkbox.TabIndex = 4;
            this.block_checkbox.UseVisualStyleBackColor = true;
            // 
            // pass_restrict_label
            // 
            this.pass_restrict_label.AutoSize = true;
            this.pass_restrict_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_restrict_label.Location = new System.Drawing.Point(41, 188);
            this.pass_restrict_label.Name = "pass_restrict_label";
            this.pass_restrict_label.Size = new System.Drawing.Size(143, 19);
            this.pass_restrict_label.TabIndex = 3;
            this.pass_restrict_label.Text = "Password Restriction:";
            // 
            // block_label
            // 
            this.block_label.AutoSize = true;
            this.block_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.block_label.Location = new System.Drawing.Point(42, 157);
            this.block_label.Name = "block_label";
            this.block_label.Size = new System.Drawing.Size(47, 19);
            this.block_label.TabIndex = 2;
            this.block_label.Text = "Block:";
            // 
            // sid_label
            // 
            this.sid_label.AutoSize = true;
            this.sid_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sid_label.Location = new System.Drawing.Point(41, 68);
            this.sid_label.Name = "sid_label";
            this.sid_label.Size = new System.Drawing.Size(34, 19);
            this.sid_label.TabIndex = 0;
            this.sid_label.Text = "SID:";
            // 
            // wrong_confirm_pass_label
            // 
            this.wrong_confirm_pass_label.AutoSize = true;
            this.wrong_confirm_pass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong_confirm_pass_label.ForeColor = System.Drawing.Color.Red;
            this.wrong_confirm_pass_label.Location = new System.Drawing.Point(311, 22);
            this.wrong_confirm_pass_label.Name = "wrong_confirm_pass_label";
            this.wrong_confirm_pass_label.Size = new System.Drawing.Size(167, 13);
            this.wrong_confirm_pass_label.TabIndex = 18;
            this.wrong_confirm_pass_label.Text = "Error: wrong confirm password!";
            this.wrong_confirm_pass_label.Visible = false;
            // 
            // wrong_pass_label
            // 
            this.wrong_pass_label.AutoSize = true;
            this.wrong_pass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong_pass_label.ForeColor = System.Drawing.Color.Red;
            this.wrong_pass_label.Location = new System.Drawing.Point(311, 21);
            this.wrong_pass_label.Name = "wrong_pass_label";
            this.wrong_pass_label.Size = new System.Drawing.Size(125, 13);
            this.wrong_pass_label.TabIndex = 17;
            this.wrong_pass_label.Text = "Error: wrong password!";
            this.wrong_pass_label.Visible = false;
            // 
            // remove_user_button
            // 
            this.remove_user_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove_user_button.Location = new System.Drawing.Point(611, 55);
            this.remove_user_button.Name = "remove_user_button";
            this.remove_user_button.Size = new System.Drawing.Size(75, 32);
            this.remove_user_button.TabIndex = 24;
            this.remove_user_button.Text = "Remove";
            this.remove_user_button.UseVisualStyleBackColor = true;
            this.remove_user_button.Click += new System.EventHandler(this.remove_user_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(333, 386);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 44);
            this.back_button.TabIndex = 25;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // EditUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.settings_panel);
            this.Name = "EditUserWindow";
            this.Text = "EditUserWindow";
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.new_pass_panel.ResumeLayout(false);
            this.new_pass_panel.PerformLayout();
            this.pass_rules_panel.ResumeLayout(false);
            this.pass_rules_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pass_len_numbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Label empty_login_label;
        private System.Windows.Forms.Label not_match_regex_label;
        private System.Windows.Forms.Panel new_pass_panel;
        private System.Windows.Forms.Label confirm_pass_label;
        private System.Windows.Forms.TextBox confirm_pass_textbox;
        private System.Windows.Forms.Label new_pass_label;
        private System.Windows.Forms.TextBox new_pass_textbox;
        private System.Windows.Forms.Panel pass_rules_panel;
        public System.Windows.Forms.Button change_regex_button;
        private System.Windows.Forms.TextBox regex_textbox;
        private System.Windows.Forms.Label pass_regex_label;
        private System.Windows.Forms.Label min_pass_len_label;
        private System.Windows.Forms.NumericUpDown min_pass_len_numbox;
        public System.Windows.Forms.Button edit_settings_button;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.CheckBox pass_restrict_check;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.CheckBox block_checkbox;
        private System.Windows.Forms.Label pass_restrict_label;
        private System.Windows.Forms.Label block_label;
        private System.Windows.Forms.Label sid_label;
        private System.Windows.Forms.Label wrong_confirm_pass_label;
        private System.Windows.Forms.Label wrong_pass_label;
        public System.Windows.Forms.Button remove_user_button;
        public System.Windows.Forms.Button back_button;
    }
}