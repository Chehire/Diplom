namespace Compo
{
    partial class Vip_no_RabotForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblZayavka = new System.Windows.Forms.Label();
            this.lblTip_Rabot = new System.Windows.Forms.Label();
            this.cbTip_Rabot = new System.Windows.Forms.ComboBox();
            this.cbZayavka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUddate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblZayavka
            // 
            this.lblZayavka.AutoSize = true;
            this.lblZayavka.Location = new System.Drawing.Point(12, 9);
            this.lblZayavka.Name = "lblZayavka";
            this.lblZayavka.Size = new System.Drawing.Size(261, 20);
            this.lblZayavka.TabIndex = 4;
            this.lblZayavka.Text = "Выберите заявку торговой точки";
            // 
            // lblTip_Rabot
            // 
            this.lblTip_Rabot.AutoSize = true;
            this.lblTip_Rabot.Location = new System.Drawing.Point(16, 68);
            this.lblTip_Rabot.Name = "lblTip_Rabot";
            this.lblTip_Rabot.Size = new System.Drawing.Size(275, 20);
            this.lblTip_Rabot.TabIndex = 5;
            this.lblTip_Rabot.Text = "Выберите выполненный вид работ";
            // 
            // cbTip_Rabot
            // 
            this.cbTip_Rabot.FormattingEnabled = true;
            this.cbTip_Rabot.Location = new System.Drawing.Point(12, 95);
            this.cbTip_Rabot.Name = "cbTip_Rabot";
            this.cbTip_Rabot.Size = new System.Drawing.Size(320, 28);
            this.cbTip_Rabot.TabIndex = 6;
            this.cbTip_Rabot.SelectedIndexChanged += new System.EventHandler(this.cbTip_Rabot_SelectedIndexChanged);
            // 
            // cbZayavka
            // 
            this.cbZayavka.FormattingEnabled = true;
            this.cbZayavka.Location = new System.Drawing.Point(12, 37);
            this.cbZayavka.Name = "cbZayavka";
            this.cbZayavka.Size = new System.Drawing.Size(320, 28);
            this.cbZayavka.TabIndex = 7;
            this.cbZayavka.SelectedIndexChanged += new System.EventHandler(this.cbZayavka_SelectedIndexChanged);
            // 
            // Vip_no_RabotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 198);
            this.Controls.Add(this.cbZayavka);
            this.Controls.Add(this.cbTip_Rabot);
            this.Controls.Add(this.lblTip_Rabot);
            this.Controls.Add(this.lblZayavka);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Vip_no_RabotForm";
            this.Text = "Выполненные работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblZayavka;
        private System.Windows.Forms.Label lblTip_Rabot;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox cbTip_Rabot;
        public System.Windows.Forms.ComboBox cbZayavka;
    }
}