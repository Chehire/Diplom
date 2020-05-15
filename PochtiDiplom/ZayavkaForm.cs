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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {   
                SqlCommand sqlCommand = new SqlCommand("Zayavka_Insert", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
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
