using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Compo
{
    public partial class StatusForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        int Cena;

        public StatusForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\compo2.ico");
            Icon = iconForm;

        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            {
                try
                { 
                    SqlCommand sqlCommand = new SqlCommand("Status_Insert", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Status_Name", tbStatus.Text);
                    sqlCommand.Parameters.AddWithValue("@Status_Logical_Delete",0);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Статус добавлен");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Статус не добавлен " + ex.Message);
                }
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            {
                try
                {

                    SqlCommand sqlCommand = new SqlCommand("Status_Update", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Status", Program.ID_Status);
                    sqlCommand.Parameters.AddWithValue("@Status_Name",tbStatus.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Статус изменен");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Статус не изменен " + ex.Message);
                }
                database.DatabaseSQL().Close();
            }
            
        }

        private void btnDeleteStatus_Click(object sender, EventArgs e)
        {

            database.DatabaseSQL().Open();
            {
                try
                {
                    if (Program.ID_Dolj == 1)
                    {
                        SqlCommand sqlCommand = new SqlCommand("Status_Delete", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ID_Status", Program.ID_Status);
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand sqlCommand = new SqlCommand("Status_Logical_Delete", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@ID_Status", Program.ID_Status);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Статус удален");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Статус не удален" + ex.Message);
                }
                database.DatabaseSQL().Close();
            }
            
        }
    }
    
}
