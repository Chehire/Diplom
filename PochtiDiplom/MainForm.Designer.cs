﻿namespace Compo
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZayavkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TipRabotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОбновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНеобходимогоПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаличияMSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаНаличияMSOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.здравствуйтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.chart_statistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VipolnennieRabotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.dirToolStripMenuItem,
            this.ОбновитьToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.здравствуйтеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.staticToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1626, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.ВыводToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ВыходToolStripMenuItem});
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.ФайлToolStripMenuItem.Text = "Файл";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.signOutToolStripMenuItem.Text = "Выход из учетной записи";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.SigOutToolStripMenuItem_Click);
            // 
            // ВыводToolStripMenuItem
            // 
            this.ВыводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.ВыводToolStripMenuItem.Name = "ВыводToolStripMenuItem";
            this.ВыводToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.ВыводToolStripMenuItem.Text = "Вывод";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.WordToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.PDFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(299, 6);
            // 
            // ВыходToolStripMenuItem
            // 
            this.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem";
            this.ВыходToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.ВыходToolStripMenuItem.Text = "Выход";
            this.ВыходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // dirToolStripMenuItem
            // 
            this.dirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doljToolStripMenuItem,
            this.employeeListToolStripMenuItem,
            this.TTToolStripMenuItem,
            this.GroupToolStripMenuItem,
            this.StatusToolStripMenuItem,
            this.ZayavkaToolStripMenuItem,
            this.TipRabotoolStripMenuItem,
            this.VipolnennieRabotiToolStripMenuItem});
            this.dirToolStripMenuItem.Name = "dirToolStripMenuItem";
            this.dirToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.dirToolStripMenuItem.Text = "Справочники";
            // 
            // doljToolStripMenuItem
            // 
            this.doljToolStripMenuItem.Name = "doljToolStripMenuItem";
            this.doljToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.doljToolStripMenuItem.Text = "Список должностей";
            this.doljToolStripMenuItem.Click += new System.EventHandler(this.DoljToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.employeeListToolStripMenuItem.Text = "Список сотрудников";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.EmployeeListToolStripMenuItem_Click);
            // 
            // TTToolStripMenuItem
            // 
            this.TTToolStripMenuItem.Name = "TTToolStripMenuItem";
            this.TTToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.TTToolStripMenuItem.Text = "Список торговых точек";
            this.TTToolStripMenuItem.Click += new System.EventHandler(this.TTToolStripMenuItem_Click);
            // 
            // GroupToolStripMenuItem
            // 
            this.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem";
            this.GroupToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.GroupToolStripMenuItem.Text = "Список дежурных групп";
            this.GroupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // StatusToolStripMenuItem
            // 
            this.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem";
            this.StatusToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.StatusToolStripMenuItem.Text = "Список статусов";
            this.StatusToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // ZayavkaToolStripMenuItem
            // 
            this.ZayavkaToolStripMenuItem.Name = "ZayavkaToolStripMenuItem";
            this.ZayavkaToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.ZayavkaToolStripMenuItem.Text = "Список заявок";
            this.ZayavkaToolStripMenuItem.Click += new System.EventHandler(this.ZayavkaToolStripMenuItem_Click);
            // 
            // TipRabotoolStripMenuItem
            // 
            this.TipRabotoolStripMenuItem.Name = "TipRabotoolStripMenuItem";
            this.TipRabotoolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.TipRabotoolStripMenuItem.Text = "Список типов работ";
            this.TipRabotoolStripMenuItem.Click += new System.EventHandler(this.TipRabotoolStripMenuItem_Click);
            // 
            // ОбновитьToolStripMenuItem
            // 
            this.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem";
            this.ОбновитьToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.ОбновитьToolStripMenuItem.Text = "Обновить";
            this.ОбновитьToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаНеобходимогоПОToolStripMenuItem,
            this.проверкаНаличияMSExcelToolStripMenuItem,
            this.проверкаНаличияMSOfficeToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // проверкаНеобходимогоПОToolStripMenuItem
            // 
            this.проверкаНеобходимогоПОToolStripMenuItem.Name = "проверкаНеобходимогоПОToolStripMenuItem";
            this.проверкаНеобходимогоПОToolStripMenuItem.Size = new System.Drawing.Size(334, 30);
            this.проверкаНеобходимогоПОToolStripMenuItem.Text = "Проверка наличия MS Word";
            this.проверкаНеобходимогоПОToolStripMenuItem.Click += new System.EventHandler(this.Status_Word_Click);
            // 
            // проверкаНаличияMSExcelToolStripMenuItem
            // 
            this.проверкаНаличияMSExcelToolStripMenuItem.Name = "проверкаНаличияMSExcelToolStripMenuItem";
            this.проверкаНаличияMSExcelToolStripMenuItem.Size = new System.Drawing.Size(334, 30);
            this.проверкаНаличияMSExcelToolStripMenuItem.Text = "Проверка наличия MS Excel";
            this.проверкаНаличияMSExcelToolStripMenuItem.Click += new System.EventHandler(this.Status_Excel_Click);
            // 
            // проверкаНаличияMSOfficeToolStripMenuItem
            // 
            this.проверкаНаличияMSOfficeToolStripMenuItem.Name = "проверкаНаличияMSOfficeToolStripMenuItem";
            this.проверкаНаличияMSOfficeToolStripMenuItem.Size = new System.Drawing.Size(334, 30);
            this.проверкаНаличияMSOfficeToolStripMenuItem.Text = "Проверка наличия MS Office";
            this.проверкаНаличияMSOfficeToolStripMenuItem.Click += new System.EventHandler(this.Cheack_MS_Office_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Visible = false;
            // 
            // здравствуйтеToolStripMenuItem
            // 
            this.здравствуйтеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПарольToolStripMenuItem});
            this.здравствуйтеToolStripMenuItem.Name = "здравствуйтеToolStripMenuItem";
            this.здравствуйтеToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.здравствуйтеToolStripMenuItem.Text = "Здравствуйте";
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.staticToolStripMenuItem.Text = "Статистика";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.changeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 64);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(76, 38);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(615, 30);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Поиск";
            // 
            // chart_statistic
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_statistic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_statistic.Legends.Add(legend1);
            this.chart_statistic.Location = new System.Drawing.Point(1193, 108);
            this.chart_statistic.Name = "chart_statistic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_statistic.Series.Add(series1);
            this.chart_statistic.Size = new System.Drawing.Size(421, 403);
            this.chart_statistic.TabIndex = 4;
            this.chart_statistic.Text = "chart1";
            // 
            // VipolnennieRabotiToolStripMenuItem
            // 
            this.VipolnennieRabotiToolStripMenuItem.Name = "VipolnennieRabotiToolStripMenuItem";
            this.VipolnennieRabotiToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.VipolnennieRabotiToolStripMenuItem.Text = "Список выполненных работ";
            this.VipolnennieRabotiToolStripMenuItem.Click += new System.EventHandler(this.VipolnennieRabotiToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 510);
            this.Controls.Add(this.chart_statistic);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ВыходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZayavkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TipRabotoolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolStripMenuItem ОбновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem здравствуйтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНеобходимогоПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаличияMSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаНаличияMSOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_statistic;
        private System.Windows.Forms.ToolStripMenuItem VipolnennieRabotiToolStripMenuItem;
    }
}

