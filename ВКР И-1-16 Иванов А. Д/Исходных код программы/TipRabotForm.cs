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
    public partial class TipRabotForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public TipRabotForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\compo2.ico");
            Icon = iconForm;
            UpdateForm();
        }

        private void UpdateForm()
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Tip_Rabot_Insert", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Name_Tip_Rabot", tbTipRabot.Text);
                sqlCommand.Parameters.AddWithValue("@Tip_Rabot_Logical_Delete", 0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Тип работ добавлен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип работ добавлен не добавлен " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Tip_Rabot_Update", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_Tip_Rabot", Program.ID_TipRabot);
                sqlCommand.Parameters.AddWithValue("@Name_Tip_Rabot", tbTipRabot.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Тип работ добавлен изменен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип работ добавлен не изменен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Tip_Rabot_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Tip_Rabot", Program.ID_TipRabot);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("Tip_Rabot_Logical_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Tip_Rabot", Program.ID_TipRabot);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Тип работ добавлен удален");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип работ добавлент не удален " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }
    }
}
