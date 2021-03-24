
namespace CyberSysTech_Lab1
{
    partial class PassphraseEncryptForm
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
            this.passphrase_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.description_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passphrase_label
            // 
            this.passphrase_label.AutoSize = true;
            this.passphrase_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passphrase_label.Location = new System.Drawing.Point(67, 203);
            this.passphrase_label.Name = "passphrase_label";
            this.passphrase_label.Size = new System.Drawing.Size(90, 21);
            this.passphrase_label.TabIndex = 3;
            this.passphrase_label.Text = "Passphrase";
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(177, 203);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(396, 25);
            this.login_textbox.TabIndex = 5;
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.Location = new System.Drawing.Point(280, 287);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(162, 42);
            this.enter_button.TabIndex = 6;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(280, 353);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(162, 43);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_label.Location = new System.Drawing.Point(144, 103);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(261, 21);
            this.description_label.TabIndex = 8;
            this.description_label.Text = "Enter your passphrase for this session.";
            // 
            // PassphraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.passphrase_label);
            this.Name = "PassphraseForm";
            this.Text = "PassphraseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passphrase_label;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label description_label;
    }
}