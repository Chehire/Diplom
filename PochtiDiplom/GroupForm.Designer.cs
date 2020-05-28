namespace Compo
{
    partial class GroupForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSotr = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSotr = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.tcGroup = new System.Windows.Forms.TabControl();
            this.tpGroupSotr = new System.Windows.Forms.TabPage();
            this.btnSnyat = new System.Windows.Forms.Button();
            this.btnIzmenit = new System.Windows.Forms.Button();
            this.btnNaznachit = new System.Windows.Forms.Button();
            this.cbNomerGpoupi = new System.Windows.Forms.ComboBox();
            this.tbCreateGroup = new System.Windows.Forms.TabPage();
            this.tcGroup.SuspendLayout();
            this.tpGroupSotr.SuspendLayout();
            this.tbCreateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 14);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Дата";
            // 
            // lblSotr
            // 
            this.lblSotr.AutoSize = true;
            this.lblSotr.Location = new System.Drawing.Point(14, 77);
            this.lblSotr.Name = "lblSotr";
            this.lblSotr.Size = new System.Drawing.Size(91, 20);
            this.lblSotr.TabIndex = 33;
            this.lblSotr.Text = "Сотрудник";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 33);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(140, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSotr
            // 
            this.cbSotr.FormattingEnabled = true;
            this.cbSotr.Location = new System.Drawing.Point(13, 101);
            this.cbSotr.Name = "cbSotr";
            this.cbSotr.Size = new System.Drawing.Size(338, 28);
            this.cbSotr.TabIndex = 44;
            this.cbSotr.SelectedIndexChanged += new System.EventHandler(this.CbGroup_SelectedIndexChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(14, 7);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(115, 20);
            this.lblGroup.TabIndex = 45;
            this.lblGroup.Text = "Номер группы";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(15, 37);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(337, 26);
            this.mtbDate.TabIndex = 47;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // tcGroup
            // 
            this.tcGroup.Controls.Add(this.tpGroupSotr);
            this.tcGroup.Controls.Add(this.tbCreateGroup);
            this.tcGroup.Location = new System.Drawing.Point(3, 9);
            this.tcGroup.Name = "tcGroup";
            this.tcGroup.SelectedIndex = 0;
            this.tcGroup.Size = new System.Drawing.Size(379, 211);
            this.tcGroup.TabIndex = 48;
            // 
            // tpGroupSotr
            // 
            this.tpGroupSotr.BackColor = System.Drawing.SystemColors.Control;
            this.tpGroupSotr.Controls.Add(this.btnSnyat);
            this.tpGroupSotr.Controls.Add(this.btnIzmenit);
            this.tpGroupSotr.Controls.Add(this.btnNaznachit);
            this.tpGroupSotr.Controls.Add(this.cbNomerGpoupi);
            this.tpGroupSotr.Controls.Add(this.lblGroup);
            this.tpGroupSotr.Controls.Add(this.lblSotr);
            this.tpGroupSotr.Controls.Add(this.cbSotr);
            this.tpGroupSotr.Location = new System.Drawing.Point(4, 29);
            this.tpGroupSotr.Name = "tpGroupSotr";
            this.tpGroupSotr.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroupSotr.Size = new System.Drawing.Size(371, 178);
            this.tpGroupSotr.TabIndex = 0;
            this.tpGroupSotr.Text = "Назначение сотрудника";
            // 
            // btnSnyat
            // 
            this.btnSnyat.Location = new System.Drawing.Point(244, 135);
            this.btnSnyat.Name = "btnSnyat";
            this.btnSnyat.Size = new System.Drawing.Size(107, 27);
            this.btnSnyat.TabIndex = 49;
            this.btnSnyat.Text = "Удалить";
            this.btnSnyat.UseVisualStyleBackColor = true;
            this.btnSnyat.Click += new System.EventHandler(this.btnSnyat_Click);
            // 
            // btnIzmenit
            // 
            this.btnIzmenit.Location = new System.Drawing.Point(131, 135);
            this.btnIzmenit.Name = "btnIzmenit";
            this.btnIzmenit.Size = new System.Drawing.Size(107, 27);
            this.btnIzmenit.TabIndex = 48;
            this.btnIzmenit.Text = "Изменить";
            this.btnIzmenit.UseVisualStyleBackColor = true;
            this.btnIzmenit.Click += new System.EventHandler(this.btnIzmenit_Click);
            // 
            // btnNaznachit
            // 
            this.btnNaznachit.Location = new System.Drawing.Point(13, 135);
            this.btnNaznachit.Name = "btnNaznachit";
            this.btnNaznachit.Size = new System.Drawing.Size(112, 27);
            this.btnNaznachit.TabIndex = 47;
            this.btnNaznachit.Text = "Назначить";
            this.btnNaznachit.UseVisualStyleBackColor = true;
            this.btnNaznachit.Click += new System.EventHandler(this.btnNaznachit_Click);
            // 
            // cbNomerGpoupi
            // 
            this.cbNomerGpoupi.FormattingEnabled = true;
            this.cbNomerGpoupi.Location = new System.Drawing.Point(13, 30);
            this.cbNomerGpoupi.Name = "cbNomerGpoupi";
            this.cbNomerGpoupi.Size = new System.Drawing.Size(338, 28);
            this.cbNomerGpoupi.TabIndex = 46;
            this.cbNomerGpoupi.SelectedIndexChanged += new System.EventHandler(this.cbNomerGpoupi_SelectedIndexChanged);
            // 
            // tbCreateGroup
            // 
            this.tbCreateGroup.BackColor = System.Drawing.SystemColors.Control;
            this.tbCreateGroup.Controls.Add(this.mtbDate);
            this.tbCreateGroup.Controls.Add(this.lblDate);
            this.tbCreateGroup.Controls.Add(this.btnUpdate);
            this.tbCreateGroup.Controls.Add(this.btnDelete);
            this.tbCreateGroup.Controls.Add(this.btnAdd);
            this.tbCreateGroup.Location = new System.Drawing.Point(4, 29);
            this.tbCreateGroup.Name = "tbCreateGroup";
            this.tbCreateGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreateGroup.Size = new System.Drawing.Size(371, 178);
            this.tbCreateGroup.TabIndex = 1;
            this.tbCreateGroup.Text = "Создать группу";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 231);
            this.Controls.Add(this.tcGroup);
            this.Name = "GroupForm";
            this.Text = "Группа";
            this.tcGroup.ResumeLayout(false);
            this.tpGroupSotr.ResumeLayout(false);
            this.tpGroupSotr.PerformLayout();
            this.tbCreateGroup.ResumeLayout(false);
            this.tbCreateGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSotr;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.TabControl tcGroup;
        private System.Windows.Forms.TabPage tpGroupSotr;
        private System.Windows.Forms.TabPage tbCreateGroup;
        public System.Windows.Forms.ComboBox cbSotr;
        public System.Windows.Forms.ComboBox cbNomerGpoupi;
        public System.Windows.Forms.Button btnSnyat;
        public System.Windows.Forms.Button btnIzmenit;
        public System.Windows.Forms.Button btnNaznachit;
    }
}