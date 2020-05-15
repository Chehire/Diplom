namespace Compo
{
    partial class TipRabotForm
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
            this.lblTipRabot = new System.Windows.Forms.Label();
            this.tbTipRabot = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipRabot
            // 
            this.lblTipRabot.AutoSize = true;
            this.lblTipRabot.Location = new System.Drawing.Point(13, 9);
            this.lblTipRabot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipRabot.Name = "lblTipRabot";
            this.lblTipRabot.Size = new System.Drawing.Size(85, 20);
            this.lblTipRabot.TabIndex = 0;
            this.lblTipRabot.Text = "Тип работ";
            // 
            // tbTipRabot
            // 
            this.tbTipRabot.Location = new System.Drawing.Point(13, 34);
            this.tbTipRabot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTipRabot.MaxLength = 25;
            this.tbTipRabot.Name = "tbTipRabot";
            this.tbTipRabot.Size = new System.Drawing.Size(316, 26);
            this.tbTipRabot.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 70);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 70);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(229, 70);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TipRabotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 126);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTipRabot);
            this.Controls.Add(this.lblTipRabot);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TipRabotForm";
            this.Text = "Тип работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipRabot;
        public System.Windows.Forms.TextBox tbTipRabot;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
    }
}