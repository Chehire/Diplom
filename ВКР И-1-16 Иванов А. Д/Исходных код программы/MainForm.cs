using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Compo
{
    public partial class MainForm : Form
    {
        DataBase_Configuration data = new DataBase_Configuration();
        DatabaseConnection database = new DatabaseConnection();
        public MainForm()
        {
            InitializeComponent();
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\compo2.ico");//Добавление иконки приложения
            Icon = iconForm;
            this.Text = "Compo";
            DataGridLocation();
            Dolj();
            lblSearch.Text = "Поиск";
            dataGridView1.RowHeadersVisible = false;
            LichniyKabinet();
            DataGridLocation();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            DataGridLocation();
        }

        private void DataGridLocation()
        {
            dataGridView1.Top = 50;
            dataGridView1.Left = 12;
            dataGridView1.Height = ClientSize.Height - 60;
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SigOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }

        private void LichniyKabinet()
        {
            database.DatabaseSQL().Close();
            database.DatabaseSQL().Open();
            string IF_Sotr = "";
            SqlCommand sqlCommand = new SqlCommand($"select [Name_Sotr]+' '+[Fam_Sotr] from [dbo].[Sotr] where [Login_Sotr] = '{Program.Autoriz_Sotr}'", database.DatabaseSQL());
            IF_Sotr = sqlCommand.ExecuteScalar().ToString();
            здравствуйтеToolStripMenuItem.Text = ("Здравствуйте " + IF_Sotr);
            database.DatabaseSQL().Close();
        }


        private void Dolj()
        {
            if (Program.ID_Dolj == 1) //Администратор
            {
                Restriction();
            }
            if (Program.ID_Dolj == 2) //Cтарший инженер
            {
                Restriction();
                doljToolStripMenuItem.Visible = false;
                employeeListToolStripMenuItem.Visible = false;
                StatusToolStripMenuItem.Visible = false;
                TipRabotoolStripMenuItem.Visible = false;

            }
            if (Program.ID_Dolj == 3) //Инженер
            {
                Restriction();
                doljToolStripMenuItem.Visible = false;
                employeeListToolStripMenuItem.Visible = false;
                TTToolStripMenuItem.Visible = false;
                StatusToolStripMenuItem.Visible = false;
                TipRabotoolStripMenuItem.Visible = false;
            }
        }

        private void Restriction()
        {
            doljToolStripMenuItem.Visible = true;
            employeeListToolStripMenuItem.Visible = true;
            GroupToolStripMenuItem.Visible = true;
            TTToolStripMenuItem.Visible = true;
            StatusToolStripMenuItem.Visible = true;
            ZayavkaToolStripMenuItem.Visible = true;
            TipRabotoolStripMenuItem.Visible = true;
            VipolnennieRabotiToolStripMenuItem.Visible = true;
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.Text == "Compo")
            {
                AddToolStripMenuItem.Visible = false;
            }
            else
            {
                AddToolStripMenuItem.Visible = true;
            }
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right)) //Выделение всей строки ПКМ
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.ShowDialog();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        private void Cheack_MS_Office_Click(object sender, EventArgs e)
        {
            string sVersion = string.Empty;
            Microsoft.Office.Interop.Word.Application appVersion = new Microsoft.Office.Interop.Word.Application();
            appVersion.Visible = false;
            switch (appVersion.Version.ToString())
            {
                case "7.0":
                    sVersion = "95";
                    break;
                case "8.0":
                    sVersion = "97";
                    break;
                case "9.0":
                    sVersion = "2000";
                    break;
                case "10.0":
                    sVersion = "2002";
                    break;
                case "11.0":
                    sVersion = "2003";
                    break;
                case "12.0":
                    sVersion = "2007";
                    break;
                case "14.0":
                    sVersion = "2010";
                    break;
                case "15.0":
                    sVersion = "2013";
                    break;
                case "16.0":
                    sVersion = "2016";
                    break;
                default:
                    sVersion = "Too Old!";
                    break;
            }
            MessageBox.Show("На компьюторе обнаружена версия MS Office : " + sVersion);
        }

        private void Status_Word_Click(object sender, EventArgs e)
        {
            using (var regWord = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Word.Application"))
            {
                if (regWord == null)
                {
                    MessageBox.Show("Microsoft Word не установлен");
                }
                else
                {
                    MessageBox.Show("Microsoft Word установлен");
                }
            }
        }

        private void Status_Excel_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                MessageBox.Show("Microsoft Excel не установлен");
            }
            else
            {
                MessageBox.Show("Microsoft Excel установлен");
            }
        }

        private void DoljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDolj();
        }

        private void EmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFillEmployeeList();
        }


        private void TTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTT();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGroup();
        }

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStatus();
        }

        private void ZayavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowZayavka();
        }

        private void TipRabotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTipRabot();
        }

        private void VipolnennieRabotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVipolnennieraboti();
        }

        private void ProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOtchet();
        }

        private void ShowDolj()
        {
            this.Text = "Compo | Должности";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select [ID_Dolj] as 'ID' ,[Dolj] as 'Название дожности', [Oklad] as 'Оклад',[Dolj_Logical_Delete] from [dbo].[Dolj]", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select [ID_Dolj] as 'ID' ,[Dolj] as 'Название дожности', [Oklad] as 'Оклад' from [dbo].[Dolj] where [Dolj_Logical_Delete] = 0", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowFillEmployeeList()
        {
            this.Text = "Compo | Сотрудники";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select * from View_Sotr", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select [ID],[Фамилия],[Имя],[Отчество],[Серия паспорта],[Номер паспорта],[Дата рождения],[Должность],[Оклад], from View_Sotr where [Sotr_Logical_Delete] = 0", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowTT()
        {
            this.Text = "Compo | Торговые точки";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select [ID_TT] as 'ID', [TT_Name] as 'Имя торговой точки', [Kol_vo_Ust_nix_Polok] as 'Кол-во установленных полок', [Adres] as 'Адрес', [TT_Logical_Delete] from  [dbo].[TT]", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select [ID_TT] as 'ID', [TT_Name] as 'Имя торговой точки', [Kol_vo_Ust_nix_Polok] as 'Кол-во установленных полок', [Adres] as 'Адрес' from [dbo].[TT] where [TT_Logical_Delete] = 0", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowGroup()
        {
            this.Text = "Compo | Дежурные группы";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select * from View_Group", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select * from View_Group", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowStatus()
        {
            this.Text = "Compo | Статусы";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("Select  [ID_Status] as 'ID', [Status_Name] as 'Статус', Status_Logical_Delete from [dbo].[Status]", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("Select  [ID_Status] as 'ID', [Status_Name] as 'Статус' from [dbo].[Status] where [Status_Logical_Delete] = 0", database.DatabaseSQL()).Tables[0];

            }
            database.DatabaseSQL().Close();
        }

        private void ShowZayavka()
        {
            this.Text = "Compo | Заявки";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select * from View_Zayavka", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("Select [ID], [№ Группы], [ТТ], [Адрес ТТ], [Статус], [Дата подачи], [Дата начала работ],[Дата окончания работ],[Дата закрытия заявки],[Список работ],[Список материалов], [Комментарий торговой точки],[Комментарий группы] from View_Zayavka where [Zayavka_Logical_Delete] = 0 ", database.DatabaseSQL()).Tables[0];

            }
            database.DatabaseSQL().Close();
        }

        private void ShowTipRabot()
        {
            this.Text = "Compo | Типы работ";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select [ID_Tip_Rabot] as 'ID', [Name_Tip_Rabot] as 'Тип работы', [Tip_Rabot_Logical_Delete] from [dbo].[Tip_Rabot]", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select [ID_Tip_Rabot] as 'ID', [Name_Tip_Rabot] as 'Тип работы' from [dbo].[Tip_Rabot] where [TipRabot_Logical_Delete] = 0", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowVipolnennieraboti()
        {
            this.Text = "Compo | Выполненные работы";
            database.DatabaseSQL().Open();
            {
                if (Program.ID_Dolj == 1)
                    dataGridView1.DataSource = database.TableFill("select [ID],[Тип работы],[ТТ],[Vip_no_Rabot_Logical_Delete] from View_Vip_no_Rabot", database.DatabaseSQL()).Tables[0];
                else
                    dataGridView1.DataSource = database.TableFill("select [ID],[Тип работы],[ТТ] from View_Vip_no_Rabot where [Vip_no_Rabot_Logical_Delete] = 0  ", database.DatabaseSQL()).Tables[0];
            }
            database.DatabaseSQL().Close();
        }

        private void ShowOtchet()
        {
            this.Text = "Compo | Популярные проблемы";
            database.DatabaseSQL().Open();
            {
                dataGridView1.DataSource = database.TableFill("select count ([Тип работы])as [Количество],[Тип работы] from [dbo].[View_Vip_no_Rabot] group by [Тип работы] order by [Тип работы]", database.DatabaseSQL()).Tables[0];

            }
            database.DatabaseSQL().Close();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Close();
            AddConMenuStripButton();
        }

        private void AddConMenuStripButton()
        {
            if (this.Text == "Compo | Должности")
            {
                DoljForm Dolj = new DoljForm();
                Dolj.btnUpdate.Enabled = false;
                Dolj.btnDelete.Enabled = false;
                Dolj.ShowDialog();
            }

            if (this.Text == "Compo | Сотрудники")
            {
                SigUpForm Employee = new SigUpForm();
                Employee.btnUpdate.Enabled = false;
                Employee.btnDelete.Enabled = false;
                Employee.ShowDialog();
            }

            if (this.Text == "Compo | Торговые точки")
            {
                TTForm TT = new TTForm();
                TT.btnUpdate.Enabled = false;
                TT.btnDelete.Enabled = false;
                TT.ShowDialog();
            }

            if (this.Text == "Compo | Дежурные группы")
            {
                GroupForm Group = new GroupForm();
                Group.btnUpdate.Enabled = false;
                Group.btnDelete.Enabled = false;
                Group.btnIzmenit.Enabled = false;
                Group.btnSnyat.Enabled = false;
                Group.ShowDialog();
            }

            if (this.Text == "Compo | Статусы")
            {
                StatusForm Status = new StatusForm();
                Status.btnUpdate.Enabled = false;
                Status.btnDelete.Enabled = false;
                Status.ShowDialog();
            }

            if (this.Text == "Compo | Заявки")
            {
                ZayavkaForm Zayavka = new ZayavkaForm();
                Zayavka.btnUpdate.Enabled = false;
                Zayavka.btnDelete.Enabled = false;
                Zayavka.ShowDialog();
            }

            if (this.Text == "Compo | Типы работ")
            {
                TipRabotForm TipRabot = new TipRabotForm();
                TipRabot.btnUpdate.Enabled = false;
                TipRabot.btnDelete.Enabled = false;
                TipRabot.ShowDialog();
            }

            if (this.Text == "Compo | Выполненные работы")
            {
                Vip_no_RabotForm Vip_no_Rabot = new Vip_no_RabotForm();
                Vip_no_Rabot.btnUpdate.Enabled = false;
                Vip_no_Rabot.btnDelete.Enabled = false;
                Vip_no_Rabot.ShowDialog();
            }
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Close();
            ChangeConMenuStripButton();
        }

        private void ChangeConMenuStripButton()
        {
            if (this.Text == "Compo | Должности")
            {
                DoljForm position = new DoljForm();
                Program.ID_Position = (int)dataGridView1.CurrentRow.Cells[0].Value;
                position.tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                position.tbOklad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                position.btnAdd.Enabled = false;
                position.ShowDialog();
            }

            if (this.Text == "Compo | Сотрудники")
            {
                SigUpForm Employee = new SigUpForm();
                Program.ID_Sotr = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Employee.tbFam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Employee.tbName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Employee.tbOtch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Employee.mtbSer.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Employee.mtbNum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Employee.mtbDateBirth.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Employee.cbDolj.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                Employee.btnAdd.Enabled = false;
                Employee.ShowDialog();
            }

            if (this.Text == "Compo | Торговые точки")
            {
                TTForm TT = new TTForm();
                Program.ID_TT = (int)dataGridView1.CurrentRow.Cells[0].Value;
                TT.tbNameTT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TT.tbPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TT.tbAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TT.btnAdd.Enabled = false;
                TT.ShowDialog();
            }

            if (this.Text == "Compo | Дежурные группы")
            {
                GroupForm Group = new GroupForm();
                Program.ID_Group = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Program.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Group.mtbDate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Group.btnAdd.Enabled = false;
                Group.btnNaznachit.Enabled = false;
                Group.ShowDialog();
            }

            if (this.Text == "Compo | Статусы")
            {
                StatusForm Status = new StatusForm();
                Program.ID_Status = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Status.tbStatus.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Status.btnAdd.Enabled = false;
                Status.ShowDialog();
            }


            if (this.Text == "Compo | Заявки")
            {
                ZayavkaForm Zayavka = new ZayavkaForm();
                Program.ID_Zayavka = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Zayavka.btnAdd.Enabled = false;
                Zayavka.Show();

            }

            if (this.Text == "Compo | Типы работ")
            {
                TipRabotForm TipRabot = new TipRabotForm();
                Program.ID_TipRabot = (int)dataGridView1.CurrentRow.Cells[0].Value;
                TipRabot.tbTipRabot.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TipRabot.btnAdd.Enabled = false;
                TipRabot.ShowDialog();
            }

            if (this.Text == "Compo | Выполненные работы")
            {
                Vip_no_RabotForm Vip_no_Rabot = new Vip_no_RabotForm();
                Program.ID_Vip_no_Rabot = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Vip_no_Rabot.btnAdd.Enabled = false;
                Vip_no_Rabot.ShowDialog();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            database.DatabaseSQL().Open();
            {
                    switch (this.Text)
                    {

                    case "Compo | Должности":
                        dataGridView1.DataSource = database.TableFill($"select [ID_Dolj], [Dolj], [Oklad] from [dbo].[Dolj] where [Dolj] like '%{tbSearch.Text}%'or  [Oklad] like '%{tbSearch.Text}%'", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Сотрудники":
                        dataGridView1.DataSource = database.TableFill($"select [ID],[Фамилия],[Имя],[Отчество],[Серия паспорта],[Номер паспорта],[Дата рождения],[Должность],[Оклад] from View_Sotr where [Фамилия]+' '+[Имя]+' '+[Отчество] like '%{tbSearch.Text}%' or [Дата рождения] like '%{tbSearch.Text}%'", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Торговые точки":
                        dataGridView1.DataSource = database.TableFill($"select [ID_TT] as 'ID', [TT_Name] as 'Имя торговой точки', [Kol_vo_Ust_nix_Polok] as 'Кол-во установленных полок', [Adres] as 'Адрес' from [dbo].[TT] where [TT_Name] like  '%{tbSearch.Text}%' or [Kol_vo_Ust_nix_Polok] like '%{tbSearch.Text}%' or [Adres] like '%{tbSearch.Text}%'", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Дежурные группы":
                        dataGridView1.DataSource = database.TableFill($"select * from View_Group where [№ Группы] like '%{tbSearch.Text}%' or [ФИО] like '%{tbSearch.Text}%' or [Дата]like '%{tbSearch.Text}%'", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Статусы":
                        dataGridView1.DataSource = database.TableFill($"Select  [ID_Status] as 'ID', [Status_Name] as 'Статус' from [dbo].[Status] where [Status_Name] like '{tbSearch.Text}'", database.DatabaseSQL()).Tables[0];
                        break;
                    case "Compo | Заявки":
                        dataGridView1.DataSource = database.TableFill($"Select [ID], [№ Группы], [ТТ], [Адрес ТТ], [Статус], [Дата подачи], [Дата начала работ],[Дата окончания работ],[Дата закрытия заявки],[Список работ],[Список материалов], [Комментарий торговой точки],[Комментарий группы] from View_Zayavka where [№ Группы] like '%{tbSearch.Text}%' or [ТТ] like '%{tbSearch.Text}%' or [Адрес ТТ] like '%{tbSearch.Text}%' or [Статус] like '%{tbSearch.Text}%' or [Дата подачи] like '%{tbSearch.Text}%' or [Дата начала работ] like '%{tbSearch.Text}%' or [Дата окончания работ] like '%{tbSearch.Text}%' or [Дата закрытия заявки] like '%{tbSearch.Text}%' or [Список работ] like '%{tbSearch.Text}%' or [Список материалов] like '%{tbSearch.Text}%' or  [Комментарий торговой точки] like '%{tbSearch.Text}%' or [Комментарий группы] like '%{tbSearch.Text}%' ", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Типы работ":
                        dataGridView1.DataSource = database.TableFill($"select [ID_Tip_Rabot] as 'ID', [Name_Tip_Rabot] as 'Тип работы' from [dbo].[Tip_Rabot] where  [Name_Tip_Rabot]  like '%{tbSearch.Text}%' ", database.DatabaseSQL()).Tables[0];
                    break;
                    case "Compo | Выполненные работы":
                        dataGridView1.DataSource = database.TableFill($"select [ID],[Тип работы],[ТТ] from View_Vip_no_Rabot where  [Тип работы]  like '%{tbSearch.Text}%' or [ТТ]  like '%{tbSearch.Text}%'", database.DatabaseSQL()).Tables[0];
                        break;
                }
            }
            database.DatabaseSQL().Close();
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Compo | Должности":
                    ShowDolj();
                    break;
                case "Compo | Сотрудники":
                    ShowFillEmployeeList();
                    break;
                case "Compo | Торговые точки":
                    ShowTT();
                    break;
                case "Compo | Дежурные группы":
                    ShowGroup();
                    break;
                case "Compo | Статусы":
                    ShowStatus();
                    break;                   
                case "Compo | Заявки":
                    ShowZayavka();
                    break;
                case "Compo | Типы работ":
                    ShowTipRabot();
                    break;
                case "Compo | Выполненные работы":
                    ShowVipolnennieraboti();
                    break;
                case "Compo | Популярные проблемы":
                    ShowOtchet();
                    break;
            }
        }


        private void WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Отчет " + System.DateTime.Now.ToShortDateString();


            switch (this.Text)
            {
                case "Compo | Сотрудники":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список сотрудников");
                    }
                    break;
                case "Compo | Статусы":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список статусов");
                    }
                    break;
                case "Compo | Должности":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список должностей");
                    }
                    break;
                case "Compo | Торговые точки":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список TT");
                    }
                    break;
                case "Compo | Заявки":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список заявок");
                    }
                    break;
                case "Compo | Дежурные группы":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список групп");
                    }
                    break;
                case "Compo | Типы работ":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список типов работ");
                    }
                    break;
                case "Compo | Выполненные работы":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Отчет о выполненных работах " + System.DateTime.Now.ToString());
                    }
                    break;
                case "Compo | Популярные проблемы":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Отчет популярных проблем " + System.DateTime.Now.ToString());
                    }
                    break;
            }
        }
            private void Export_Data_To_Word(DataGridView DGV, string filename, string headerTable)
            {
            
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                
                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    }

                    //table style 
                    oDoc.Application.Selection.Tables[1].set_Style("Классическая таблица 1");
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = headerTable;
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                oDoc.SaveAs2(filename);
            }
     }

        







        private async void PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            PdfClass pdfClass = new PdfClass();
            await Task.Run(() => pdfClass.ExportWordToPdf(fileDialog.FileName));
        }

    }
}

