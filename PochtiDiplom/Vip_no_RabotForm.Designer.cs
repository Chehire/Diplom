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
            this.btnUddate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbZayavka = new System.Windows.Forms.ComboBox();
            this.lblZayavka = new System.Windows.Forms.Label();
            this.lblTip_Rabot = new System.Windows.Forms.Label();
            this.cbTip_Rabot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUddate
            // 
            this.btnUddate.Location = new System.Drawing.Point(169, 153);
            this.btnUddate.Name = "btnUddate";
            this.btnUddate.Size = new System.Drawing.Size(104, 29);
            this.btnUddate.TabIndex = 1;
            this.btnUddate.Text = "Изменить";
            this.btnUddate.UseVisualStyleBackColor = true;
            this.btnUddate.Click += new System.EventHandler(this.btnUddate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbZayavka
            // 
            this.cbZayavka.FormattingEnabled = true;
            this.cbZayavka.Location = new System.Drawing.Point(12, 32);
            this.cbZayavka.Name = "cbZayavka";
            this.cbZayavka.Size = new System.Drawing.Size(418, 28);
            this.cbZayavka.TabIndex = 3;
            this.cbZayavka.SelectedIndexChanged += new System.EventHandler(this.cbZayavka_SelectedIndexChanged);
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
            this.lblTip_Rabot.Location = new System.Drawing.Point(12, 63);
            this.lblTip_Rabot.Name = "lblTip_Rabot";
            this.lblTip_Rabot.Size = new System.Drawing.Size(275, 20);
            this.lblTip_Rabot.TabIndex = 5;
            this.lblTip_Rabot.Text = "Выберите выполненный вид работ";
            // 
            // cbTip_Rabot
            // 
            this.cbTip_Rabot.FormattingEnabled = true;
            this.cbTip_Rabot.Location = new System.Drawing.Point(12, 86);
            this.cbTip_Rabot.Name = "cbTip_Rabot";
            this.cbTip_Rabot.Size = new System.Drawing.Size(418, 28);
            this.cbTip_Rabot.TabIndex = 6;
            this.cbTip_Rabot.SelectedIndexChanged += new System.EventHandler(this.cbTip_Rabot_SelectedIndexChanged);
            // 
            // Vip_no_RabotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 194);
            this.Controls.Add(this.cbTip_Rabot);
            this.Controls.Add(this.lblTip_Rabot);
            this.Controls.Add(this.lblZayavka);
            this.Controls.Add(this.cbZayavka);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUddate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Vip_no_RabotForm";
            this.Text = "Выполненные работы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUddate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbZayavka;
        private System.Windows.Forms.Label lblZayavka;
        private System.Windows.Forms.Label lblTip_Rabot;
        private System.Windows.Forms.ComboBox cbTip_Rabot;
    }
}