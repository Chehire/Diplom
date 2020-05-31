namespace Compo
{
    partial class ZayavkaForm
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDatePodachi = new System.Windows.Forms.Label();
            this.lblDataNahala = new System.Windows.Forms.Label();
            this.lblZakritia = new System.Windows.Forms.Label();
            this.lblOkonchania = new System.Windows.Forms.Label();
            this.lblSpisokRapot = new System.Windows.Forms.Label();
            this.tbSpisokRabot = new System.Windows.Forms.TextBox();
            this.tbSpisokMaterialov = new System.Windows.Forms.TextBox();
            this.lblSpisokMaterialov = new System.Windows.Forms.Label();
            this.tbKimentariiGroup = new System.Windows.Forms.TextBox();
            this.lblKomentariiGroup = new System.Windows.Forms.Label();
            this.tbKomentariiTT = new System.Windows.Forms.TextBox();
            this.lblKommentariiTT = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTT = new System.Windows.Forms.ComboBox();
            this.mtbDataPodachi = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataNachala = new System.Windows.Forms.MaskedTextBox();
            this.mtbOkonchaniya = new System.Windows.Forms.MaskedTextBox();
            this.mtbZakritiya = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(9, 7);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(42, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Группа";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(9, 42);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(92, 13);
            this.lblTT.TabIndex = 3;
            this.lblTT.Text = "Тороговая точка";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 79);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус";
            // 
            // lblDatePodachi
            // 
            this.lblDatePodachi.AutoSize = true;
            this.lblDatePodachi.Location = new System.Drawing.Point(8, 115);
            this.lblDatePodachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePodachi.Name = "lblDatePodachi";
            this.lblDatePodachi.Size = new System.Drawing.Size(71, 13);
            this.lblDatePodachi.TabIndex = 11;
            this.lblDatePodachi.Text = "Дата подачи";
            // 
            // lblDataNahala
            // 
            this.lblDataNahala.AutoSize = true;
            this.lblDataNahala.Location = new System.Drawing.Point(153, 115);
            this.lblDataNahala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataNahala.Name = "lblDataNahala";
            this.lblDataNahala.Size = new System.Drawing.Size(103, 13);
            this.lblDataNahala.TabIndex = 26;
            this.lblDataNahala.Text = "Дата начала работ";
            // 
            // lblZakritia
            // 
            this.lblZakritia.AutoSize = true;
            this.lblZakritia.Location = new System.Drawing.Point(9, 151);
            this.lblZakritia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZakritia.Name = "lblZakritia";
            this.lblZakritia.Size = new System.Drawing.Size(85, 13);
            this.lblZakritia.TabIndex = 27;
            this.lblZakritia.Text = "Дата закрытия";
            // 
            // lblOkonchania
            // 
            this.lblOkonchania.AutoSize = true;
            this.lblOkonchania.Location = new System.Drawing.Point(153, 151);
            this.lblOkonchania.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOkonchania.Name = "lblOkonchania";
            this.lblOkonchania.Size = new System.Drawing.Size(121, 13);
            this.lblOkonchania.TabIndex = 28;
            this.lblOkonchania.Text = "Дата окончания работ";
            // 
            // lblSpisokRapot
            // 
            this.lblSpisokRapot.AutoSize = true;
            this.lblSpisokRapot.Location = new System.Drawing.Point(6, 186);
            this.lblSpisokRapot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpisokRapot.Name = "lblSpisokRapot";
            this.lblSpisokRapot.Size = new System.Drawing.Size(76, 13);
            this.lblSpisokRapot.TabIndex = 31;
            this.lblSpisokRapot.Text = "Список работ";
            // 
            // tbSpisokRabot
            // 
            this.tbSpisokRabot.Location = new System.Drawing.Point(8, 202);
            this.tbSpisokRabot.MaxLength = 300;
            this.tbSpisokRabot.Name = "tbSpisokRabot";
            this.tbSpisokRabot.Size = new System.Drawing.Size(283, 20);
            this.tbSpisokRabot.TabIndex = 32;
            // 
            // tbSpisokMaterialov
            // 
            this.tbSpisokMaterialov.Location = new System.Drawing.Point(8, 241);
            this.tbSpisokMaterialov.MaxLength = 300;
            this.tbSpisokMaterialov.Name = "tbSpisokMaterialov";
            this.tbSpisokMaterialov.Size = new System.Drawing.Size(283, 20);
            this.tbSpisokMaterialov.TabIndex = 34;
            // 
            // lblSpisokMaterialov
            // 
            this.lblSpisokMaterialov.AutoSize = true;
            this.lblSpisokMaterialov.Location = new System.Drawing.Point(9, 225);
            this.lblSpisokMaterialov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpisokMaterialov.Name = "lblSpisokMaterialov";
            this.lblSpisokMaterialov.Size = new System.Drawing.Size(108, 13);
            this.lblSpisokMaterialov.TabIndex = 33;
            this.lblSpisokMaterialov.Text = "Список материалов";
            // 
            // tbKimentariiGroup
            // 
            this.tbKimentariiGroup.Location = new System.Drawing.Point(8, 316);
            this.tbKimentariiGroup.MaxLength = 300;
            this.tbKimentariiGroup.Name = "tbKimentariiGroup";
            this.tbKimentariiGroup.Size = new System.Drawing.Size(283, 20);
            this.tbKimentariiGroup.TabIndex = 38;
            // 
            // lblKomentariiGroup
            // 
            this.lblKomentariiGroup.AutoSize = true;
            this.lblKomentariiGroup.Location = new System.Drawing.Point(9, 300);
            this.lblKomentariiGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKomentariiGroup.Name = "lblKomentariiGroup";
            this.lblKomentariiGroup.Size = new System.Drawing.Size(168, 13);
            this.lblKomentariiGroup.TabIndex = 37;
            this.lblKomentariiGroup.Text = "Комментарии дежурной группы";
            // 
            // tbKomentariiTT
            // 
            this.tbKomentariiTT.Location = new System.Drawing.Point(8, 277);
            this.tbKomentariiTT.MaxLength = 300;
            this.tbKomentariiTT.Name = "tbKomentariiTT";
            this.tbKomentariiTT.Size = new System.Drawing.Size(283, 20);
            this.tbKomentariiTT.TabIndex = 36;
            // 
            // lblKommentariiTT
            // 
            this.lblKommentariiTT.AutoSize = true;
            this.lblKommentariiTT.Location = new System.Drawing.Point(6, 261);
            this.lblKommentariiTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKommentariiTT.Name = "lblKommentariiTT";
            this.lblKommentariiTT.Size = new System.Drawing.Size(149, 13);
            this.lblKommentariiTT.TabIndex = 35;
            this.lblKommentariiTT.Text = "Коментарии торговой точки";
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(8, 22);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(283, 21);
            this.cbGroup.TabIndex = 39;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(8, 95);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(283, 21);
            this.cbStatus.TabIndex = 40;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbTT
            // 
            this.cbTT.FormattingEnabled = true;
            this.cbTT.Location = new System.Drawing.Point(8, 58);
            this.cbTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(283, 21);
            this.cbTT.TabIndex = 41;
            this.cbTT.SelectedIndexChanged += new System.EventHandler(this.cbTT_SelectedIndexChanged);
            // 
            // mtbDataPodachi
            // 
            this.mtbDataPodachi.Location = new System.Drawing.Point(8, 133);
            this.mtbDataPodachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbDataPodachi.Mask = "00/00/0000 90:00";
            this.mtbDataPodachi.Name = "mtbDataPodachi";
            this.mtbDataPodachi.Size = new System.Drawing.Size(135, 20);
            this.mtbDataPodachi.TabIndex = 42;
            this.mtbDataPodachi.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataNachala
            // 
            this.mtbDataNachala.Location = new System.Drawing.Point(156, 133);
            this.mtbDataNachala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbDataNachala.Mask = "00/00/0000 90:00";
            this.mtbDataNachala.Name = "mtbDataNachala";
            this.mtbDataNachala.Size = new System.Drawing.Size(135, 20);
            this.mtbDataNachala.TabIndex = 43;
            this.mtbDataNachala.ValidatingType = typeof(System.DateTime);
            // 
            // mtbOkonchaniya
            // 
            this.mtbOkonchaniya.Location = new System.Drawing.Point(156, 166);
            this.mtbOkonchaniya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbOkonchaniya.Mask = "00/00/0000 90:00";
            this.mtbOkonchaniya.Name = "mtbOkonchaniya";
            this.mtbOkonchaniya.Size = new System.Drawing.Size(135, 20);
            this.mtbOkonchaniya.TabIndex = 44;
            this.mtbOkonchaniya.ValidatingType = typeof(System.DateTime);
            // 
            // mtbZakritiya
            // 
            this.mtbZakritiya.Location = new System.Drawing.Point(8, 167);
            this.mtbZakritiya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbZakritiya.Mask = "00/00/0000 90:00";
            this.mtbZakritiya.Name = "mtbZakritiya";
            this.mtbZakritiya.Size = new System.Drawing.Size(135, 20);
            this.mtbZakritiya.TabIndex = 45;
            this.mtbZakritiya.ValidatingType = typeof(System.DateTime);
            // 
            // ZayavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 376);
            this.Controls.Add(this.mtbZakritiya);
            this.Controls.Add(this.mtbOkonchaniya);
            this.Controls.Add(this.mtbDataNachala);
            this.Controls.Add(this.mtbDataPodachi);
            this.Controls.Add(this.cbTT);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.tbKimentariiGroup);
            this.Controls.Add(this.lblKomentariiGroup);
            this.Controls.Add(this.tbKomentariiTT);
            this.Controls.Add(this.lblKommentariiTT);
            this.Controls.Add(this.tbSpisokMaterialov);
            this.Controls.Add(this.lblSpisokMaterialov);
            this.Controls.Add(this.tbSpisokRabot);
            this.Controls.Add(this.lblSpisokRapot);
            this.Controls.Add(this.lblOkonchania);
            this.Controls.Add(this.lblZakritia);
            this.Controls.Add(this.lblDataNahala);
            this.Controls.Add(this.lblDatePodachi);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.lblGroup);
            this.Name = "ZayavkaForm";
            this.Text = "Заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblTT;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDatePodachi;
        private System.Windows.Forms.Label lblDataNahala;
        private System.Windows.Forms.Label lblZakritia;
        private System.Windows.Forms.Label lblOkonchania;
        private System.Windows.Forms.Label lblSpisokRapot;
        public System.Windows.Forms.TextBox tbSpisokRabot;
        public System.Windows.Forms.TextBox tbSpisokMaterialov;
        private System.Windows.Forms.Label lblSpisokMaterialov;
        public System.Windows.Forms.TextBox tbKimentariiGroup;
        private System.Windows.Forms.Label lblKomentariiGroup;
        public System.Windows.Forms.TextBox tbKomentariiTT;
        private System.Windows.Forms.Label lblKommentariiTT;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTT;
        public System.Windows.Forms.MaskedTextBox mtbDataPodachi;
        public System.Windows.Forms.MaskedTextBox mtbDataNachala;
        public System.Windows.Forms.MaskedTextBox mtbOkonchaniya;
        public System.Windows.Forms.MaskedTextBox mtbZakritiya;
    }
}