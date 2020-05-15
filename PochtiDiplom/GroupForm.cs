using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Compo
{
    public partial class GroupForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public GroupForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            ShowSotr();
            //Icon iconForm = new Icon(Application.StartupPath + "\\img\\Compo.ico");
            //Icon = iconForm;
        }

        private void ShowSotr() //Вывод должности в comboBox
        {
            database.DatabaseSQL().Open();
            {
                cbGroup.DataSource = database.TableFill("select [Fam_Sotr]+' '+[Name_Sotr]+' '+[Otch_Sotr] as Sotr from [dbo].[Sotr]", database.DatabaseSQL()).Tables[0];
                cbGroup.DisplayMember = "Sotr";
            }
            database.DatabaseSQL().Close();
        }
        private void CbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_Sotr from [dbo].[Sotr] where [Fam_Sotr]+' '+[Name_Sotr]+' '+[Otch_Sotr] = '{cbGroup.Text}'", database.DatabaseSQL());
                    Program.ID_Sotr = (int)cmd.ExecuteScalar();
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
                {
                    SqlCommand sqlCommand = new SqlCommand("Group_Insert", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Group", tbGroup.Text);
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Date",tbDate.Text);
                    sqlCommand.Parameters.AddWithValue("@Group_Logical_Delete",0);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Группа добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Группа не добавлена" + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                {
                    SqlCommand sqlCommand = new SqlCommand("Group_Update", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Group", tbGroup.Text);
                    sqlCommand.Parameters.AddWithValue("@Sotr_ID", Program.ID_Sotr);
                    sqlCommand.Parameters.AddWithValue("@Date", tbDate.Text);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Группа изменена");
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Группа  не изменена" + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                {
                    SqlCommand sqlCommand = new SqlCommand("Group_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Group", Program.ID_Group);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Группа удалена");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Группа не удалена " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }
    }
}
