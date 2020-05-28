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

namespace Compo
{
    public partial class ZayavkaForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public ZayavkaForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            //Icon iconForm = new Icon(Application.StartupPath + "\\img\\Compo.ico");
            //Icon = iconForm;
            UpdateForm();
            ShowComboBox();
        }

        private void UpdateForm()
        {
            database.DatabaseSQL().Close();
        }

        private void ShowComboBox() //Вывод должности в comboBox
        {
            database.DatabaseSQL().Open();
            {
                cbGroup.DataSource = database.TableFill("select ID_Group from [dbo].[Group]", database.DatabaseSQL()).Tables[0];
                cbGroup.DisplayMember = "ID_Group";
                cbTT.DataSource = database.TableFill("select TT_Name from [dbo].[TT]", database.DatabaseSQL()).Tables[0];
                cbTT.DisplayMember = "TT_Name";
                cbStatus.DataSource = database.TableFill("select Status_Name from [dbo].[Status]", database.DatabaseSQL()).Tables[0];
                cbStatus.DisplayMember = "Status_Name";
            }
            database.DatabaseSQL().Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_Group from [dbo].[Group] where ID_Group = '{cbGroup.Text}'", database.DatabaseSQL());
                    Program.ID_Group = (int)cmd.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_TT from [dbo].[TT] where TT_Name = '{cbTT.Text}'", database.DatabaseSQL());
                    Program.ID_TT = (int)cmd.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_Status from [dbo].[Status] where Status_Name = '{cbStatus.Text}'", database.DatabaseSQL());
                    Program.ID_Status = (int)cmd.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {   
                SqlCommand sqlCommand = new SqlCommand("Zayavka_Insert", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Group_ID", Program.ID_Group);
                sqlCommand.Parameters.AddWithValue("@TT_ID", Program.ID_TT);
                sqlCommand.Parameters.AddWithValue("@Status_ID", Program.ID_Status);
                sqlCommand.Parameters.AddWithValue("@Data_Podachi", mtbDataPodachi.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Nachala_Rabot", mtbDataNachala.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Okonchania_Rabot", mtbOkonchaniya.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Zakritia_Zayavki", mtbZakritiya.Text);
                sqlCommand.Parameters.AddWithValue("@Spisok_Rapot", tbSpisokRabot.Text);
                sqlCommand.Parameters.AddWithValue("@Spisok_Materialov", tbSpisokMaterialov.Text);
                sqlCommand.Parameters.AddWithValue("@Kommentariy_TT", tbKomentariiTT.Text);
                sqlCommand.Parameters.AddWithValue("@Kommentariy_Group", tbKimentariiGroup.Text);
                sqlCommand.Parameters.AddWithValue("Zayavka_Logical_Delete", 0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Заявка добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заявка не добавлена " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Zayavka_Update", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_Zayavka", Program.ID_Zayavka);
                sqlCommand.Parameters.AddWithValue("@Group_ID", Program.ID_Group);
                sqlCommand.Parameters.AddWithValue("@TT_ID", Program.ID_TT);
                sqlCommand.Parameters.AddWithValue("@Status_ID", Program.ID_Status);
                sqlCommand.Parameters.AddWithValue("@Data_Podachi", mtbDataPodachi.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Nachala_Rabot", mtbDataNachala.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Okonchania_Rabot", mtbOkonchaniya.Text);
                sqlCommand.Parameters.AddWithValue("@Data_Zakritia_Zayavki", mtbZakritiya.Text);
                sqlCommand.Parameters.AddWithValue("@Spisok_Rapot", tbSpisokRabot.Text);
                sqlCommand.Parameters.AddWithValue("@Spisok_Materialov", tbSpisokMaterialov);
                sqlCommand.Parameters.AddWithValue("@Kommentariy_TT", tbKomentariiTT.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Заявка изменена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заявка не изменена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Zayavka_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Zayavka", Program.ID_Zayavka);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("Zayavka_Logical_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Zayavka", Program.ID_Zayavka);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Заявка удалена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заявка не удалена " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }
    }
}
