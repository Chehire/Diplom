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
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSotr = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(13, 160);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDate.MaxLength = 20;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(331, 26);
            this.tbDate.TabIndex = 36;
            this.tbDate.Tag = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 135);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Дата";
            // 
            // lblSotr
            // 
            this.lblSotr.AutoSize = true;
            this.lblSotr.Location = new System.Drawing.Point(12, 79);
            this.lblSotr.Name = "lblSotr";
            this.lblSotr.Size = new System.Drawing.Size(91, 20);
            this.lblSotr.TabIndex = 33;
            this.lblSotr.Text = "Сотрудник";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 33);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(144, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 33);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(11, 103);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(333, 28);
            this.cbGroup.TabIndex = 44;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.CbGroup_SelectedIndexChanged);
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(11, 34);
            this.tbGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGroup.MaxLength = 10;
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(331, 26);
            this.tbGroup.TabIndex = 46;
            this.tbGroup.Tag = "";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(13, 9);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(115, 20);
            this.lblGroup.TabIndex = 45;
            this.lblGroup.Text = "Номер группы";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 239);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSotr);
            this.Name = "GroupForm";
            this.Text = "Группа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSotr;
        public System.Windows.Forms.TextBox tbDate;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbGroup;
        public System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label lblGroup;
    }
}