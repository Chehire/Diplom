namespace Compo
{
    partial class ChangePasswordForm
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
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblRepNewPassword = new System.Windows.Forms.Label();
            this.tbRepNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(8, 21);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewPassword.MaxLength = 16;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(240, 20);
            this.tbNewPassword.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(8, 6);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(123, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Введите новый пароль";
            // 
            // lblRepNewPassword
            // 
            this.lblRepNewPassword.AutoSize = true;
            this.lblRepNewPassword.Location = new System.Drawing.Point(11, 43);
            this.lblRepNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepNewPassword.Name = "lblRepNewPassword";
            this.lblRepNewPassword.Size = new System.Drawing.Size(135, 13);
            this.lblRepNewPassword.TabIndex = 2;
            this.lblRepNewPassword.Text = "Повторите новый пароль";
            // 
            // tbRepNewPassword
            // 
            this.tbRepNewPassword.Location = new System.Drawing.Point(9, 58);
            this.tbRepNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRepNewPassword.MaxLength = 16;
            this.tbRepNewPassword.Name = "tbRepNewPassword";
            this.tbRepNewPassword.Size = new System.Drawing.Size(240, 20);
            this.tbRepNewPassword.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(9, 85);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(239, 32);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Сменить пароль";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 128);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbRepNewPassword);
            this.Controls.Add(this.lblRepNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePasswordForm";
            this.Text = "Сменить парроль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblRepNewPassword;
        private System.Windows.Forms.TextBox tbRepNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
    }
}