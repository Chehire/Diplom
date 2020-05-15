namespace Compo
{
    partial class StatusForm
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
            this.Status = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(62, 20);
            this.Status.TabIndex = 2;
            this.Status.Text = "Статус";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(12, 32);
            this.tbStatus.MaxLength = 16;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(325, 26);
            this.tbStatus.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(228, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = " Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteStatus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Записать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 106);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.Status);
            this.Name = "StatusForm";
            this.Text = " Статус";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Status;
        public System.Windows.Forms.TextBox tbStatus;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnAdd;
    }
}