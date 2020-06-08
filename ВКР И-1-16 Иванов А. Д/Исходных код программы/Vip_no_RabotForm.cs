using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Compo
{
    public partial class Vip_no_RabotForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public Vip_no_RabotForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\compo2.ico");
            Icon = iconForm;
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            UpdateForm();
            ShowComboBox();
        }

        private void UpdateForm()
        {
            database.DatabaseSQL().Close();
        }

        private void ShowComboBox()
        {
            database.DatabaseSQL().Open();
            {
                cbZayavka.DataSource = database.TableFill("select ТТ from [dbo].[View_Zayavka]", database.DatabaseSQL()).Tables[0];
                cbZayavka.DisplayMember = "ТТ";
                cbTip_Rabot.DataSource = database.TableFill("select [Name_Tip_Rabot] as Name  from [dbo].[Tip_Rabot]", database.DatabaseSQL()).Tables[0];
                cbTip_Rabot.DisplayMember = "Name";
            }
            database.DatabaseSQL().Close();
        }


        private void cbZayavka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand com = new SqlCommand($"select [ID] from [dbo].[View_Zayavka] where [ТТ] = '{cbZayavka.Text}'", database.DatabaseSQL());
                    Program.ID_Zayavka = (int)com.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }

        private void cbTip_Rabot_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_Tip_Rabot from [dbo].[Tip_Rabot] where Name_Tip_Rabot = '{cbTip_Rabot.Text}'", database.DatabaseSQL());
                    Program.ID_TipRabot = (int)cmd.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Vip_no_Rabot_Insert", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Zayavka_ID", Program.ID_Zayavka);
                sqlCommand.Parameters.AddWithValue("@Tip_Rabot_ID", Program.ID_TipRabot);
                sqlCommand.Parameters.AddWithValue("Vip_no_Rabot_Logical_Delete", 0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Тип выполненной работы добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип выполненной работы не добавлен " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnUddate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Vip_no_Rabot_Update", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_Vip_no_Rabot", Program.ID_Vip_no_Rabot);
                sqlCommand.Parameters.AddWithValue("@Zayavka_ID", Program.ID_Zayavka);
                sqlCommand.Parameters.AddWithValue("@Tip_Rabot_ID", Program.ID_TipRabot);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Тип выполненной работы обновлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип выполненной работы не обновлен " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                if (Program.ID_Dolj == 1)
                {
                    SqlCommand sqlCommand = new SqlCommand("Vip_no_Rabot_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Vip_no_Rabot", Program.ID_Vip_no_Rabot);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("Vip_no_Rabot_Logical_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Vip_no_Rabot", Program.ID_Vip_no_Rabot);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Тип выполненной работы удален");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип выполненной работы не удален " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

      
        
    }
}
