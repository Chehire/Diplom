namespace Compo
{
    partial class TTForm
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
            this.lblTT = new System.Windows.Forms.Label();
            this.tbNameTT = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(13, 27);
            this.lblTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(205, 20);
            this.lblTT.TabIndex = 9;
            this.lblTT.Text = "Название торговой точки";
            // 
            // tbNameTT
            // 
            this.tbNameTT.Location = new System.Drawing.Point(13, 52);
            this.tbNameTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameTT.MaxLength = 32;
            this.tbNameTT.Name = "tbNameTT";
            this.tbNameTT.Size = new System.Drawing.Size(334, 26);
            this.tbNameTT.TabIndex = 8;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(13, 108);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrice.MaxLength = 3;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(334, 26);
            this.tbPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 83);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(268, 20);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Количество установленных полок";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(13, 164);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdres.MaxLength = 255;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(334, 26);
            this.tbAdres.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Адрес";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(239, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = " Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Записать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 243);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.tbNameTT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TTForm";
            this.Text = "Торговые точки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTT;
        public System.Windows.Forms.TextBox tbNameTT;
        public System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
    }
}