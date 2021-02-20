
namespace CyberSysTech_Lab1
{
    partial class LoginForm
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
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.about_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(304, 285);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(162, 42);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Log-In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(304, 359);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(162, 43);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(133, 123);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(51, 21);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(133, 198);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 21);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(268, 123);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(237, 25);
            this.login_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textbox.Location = new System.Drawing.Point(268, 198);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(237, 25);
            this.password_textbox.TabIndex = 5;
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.Location = new System.Drawing.Point(728, 12);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(60, 27);
            this.about_button.TabIndex = 6;
            this.about_button.Text = "About";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button about_button;
    }
}

