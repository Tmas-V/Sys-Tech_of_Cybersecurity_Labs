
namespace CyberSysTech_Lab1
{
    partial class AboutWindow
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
            this.close_button = new System.Windows.Forms.Button();
            this.about_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.Location = new System.Drawing.Point(108, 100);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(69, 27);
            this.close_button.TabIndex = 12;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // about_label
            // 
            this.about_label.AllowDrop = true;
            this.about_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_label.Location = new System.Drawing.Point(12, 9);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(281, 31);
            this.about_label.TabIndex = 13;
            this.about_label.Text = "Systems and technologies of cybersecurity. Practical work #1 FB-83, variant#5";
            this.about_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Variant-specific restriction for passwords: Only letters,numbers and punctual sig" +
    "ns are allowed.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.about_label);
            this.Controls.Add(this.close_button);
            this.Name = "AboutWindow";
            this.Text = "AboutWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Label label1;
    }
}