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
    public partial class TTForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public TTForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            //Icon iconForm = new Icon(Application.StartupPath + "\\img\\Compo.ico");
            //Icon = iconForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("TT_Insert", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TT_Name", tbNameTT.Text);
                sqlCommand.Parameters.AddWithValue("@Kol_vo_Ust_nix_Polok", tbPrice.Text);
                sqlCommand.Parameters.AddWithValue("@Adres", tbAdres.Text);
                sqlCommand.Parameters.AddWithValue("@TT_Logical_Delete",0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Торговая точка добавлена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Торговая точка не добавлена " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("TT_Update", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_TT", Program.ID_TT);
                sqlCommand.Parameters.AddWithValue("@TT_Name", tbNameTT.Text);
                sqlCommand.Parameters.AddWithValue("@Kol_vo_Ust_nix_Polok", tbPrice.Text);
                sqlCommand.Parameters.AddWithValue("@Adres", tbAdres.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Торговая точка изменена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Торговая точка изменена " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("TT_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_TT", Program.ID_TT);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("TT_Logical_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_TT", Program.ID_TT);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Торговая точка удалена");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Торговая точка не удалена " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }
    }
}
