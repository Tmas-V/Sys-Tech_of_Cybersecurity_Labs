
namespace CyberSysTech_Lab1
{
    partial class LoginErrorDialog
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
            this.back_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(118, 93);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(91, 34);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.Location = new System.Drawing.Point(27, 54);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(18, 19);
            this.error_label.TabIndex = 1;
            this.error_label.Text = "...";
            // 
            // LoginErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 169);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.back_button);
            this.Name = "LoginErrorDialog";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label error_label;
    }
}