
namespace CyberSysTech_Lab1
{
    partial class TypeInPasswordDialog
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
            this.pass_dialog_textbox = new System.Windows.Forms.TextBox();
            this.pass_dialog_label = new System.Windows.Forms.Label();
            this.wrong_pass_dialog_label = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.Button();
            this.pass_dialog_submit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass_dialog_textbox
            // 
            this.pass_dialog_textbox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_dialog_textbox.Location = new System.Drawing.Point(12, 60);
            this.pass_dialog_textbox.Name = "pass_dialog_textbox";
            this.pass_dialog_textbox.Size = new System.Drawing.Size(165, 25);
            this.pass_dialog_textbox.TabIndex = 8;
            this.pass_dialog_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_dialog_label
            // 
            this.pass_dialog_label.AutoSize = true;
            this.pass_dialog_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_dialog_label.Location = new System.Drawing.Point(61, 25);
            this.pass_dialog_label.Name = "pass_dialog_label";
            this.pass_dialog_label.Size = new System.Drawing.Size(136, 19);
            this.pass_dialog_label.TabIndex = 7;
            this.pass_dialog_label.Text = "Type your password.";
            // 
            // wrong_pass_dialog_label
            // 
            this.wrong_pass_dialog_label.AutoSize = true;
            this.wrong_pass_dialog_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrong_pass_dialog_label.ForeColor = System.Drawing.Color.Red;
            this.wrong_pass_dialog_label.Location = new System.Drawing.Point(80, 88);
            this.wrong_pass_dialog_label.Name = "wrong_pass_dialog_label";
            this.wrong_pass_dialog_label.Size = new System.Drawing.Size(97, 13);
            this.wrong_pass_dialog_label.TabIndex = 9;
            this.wrong_pass_dialog_label.Text = "Wrong password!";
            this.wrong_pass_dialog_label.Visible = false;
            // 
            // quit_button
            // 
            this.quit_button.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quit_button.Location = new System.Drawing.Point(83, 115);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(87, 21);
            this.quit_button.TabIndex = 12;
            this.quit_button.Text = "Back";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // pass_dialog_submit_button
            // 
            this.pass_dialog_submit_button.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_dialog_submit_button.Location = new System.Drawing.Point(183, 62);
            this.pass_dialog_submit_button.Name = "pass_dialog_submit_button";
            this.pass_dialog_submit_button.Size = new System.Drawing.Size(65, 21);
            this.pass_dialog_submit_button.TabIndex = 13;
            this.pass_dialog_submit_button.Text = "Submit";
            this.pass_dialog_submit_button.UseVisualStyleBackColor = true;
            this.pass_dialog_submit_button.Click += new System.EventHandler(this.pass_dialog_submit_button_Click);
            // 
            // TypeInPasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 148);
            this.Controls.Add(this.pass_dialog_submit_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.wrong_pass_dialog_label);
            this.Controls.Add(this.pass_dialog_textbox);
            this.Controls.Add(this.pass_dialog_label);
            this.Name = "TypeInPasswordDialog";
            this.Text = "TypeInPasswordDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass_dialog_textbox;
        private System.Windows.Forms.Label pass_dialog_label;
        private System.Windows.Forms.Label wrong_pass_dialog_label;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button pass_dialog_submit_button;
    }
}