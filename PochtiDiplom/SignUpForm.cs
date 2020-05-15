﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Compo
{
    public partial class SigUpForm : Form
    {
        
        DatabaseConnection database = new DatabaseConnection();
        public SigUpForm()
        {
            this.TopMost = true; //Вызов окна поверх других
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            //Icon iconForm = new Icon(Application.StartupPath + "\\img\\Compo.ico");
            //Icon = iconForm;
            this.Text = "Cотрудник";
            lblFam.Text = "Фамилия";
            lblName.Text = "Имя";
            lblOtch.Text = "Отчество";
            lblSer.Text = "Серия паспорта";
            lblNum.Text = "Номер паспорта";
            lblLogin.Text = "Логин";
            lblPassword.Text = "Пароль";
            lblRepPas.Text = "Повторите пароль";
            lblDolj.Text = "Должность";
            btnAdd.Text = "Добавить";
            btnDelete.Text = "Удалить";
            tbPas.PasswordChar = '*';
            tbRepPas.PasswordChar = '*';
            ShowDolj();
        }

        private void ShowDolj() //Вывод должности в comboBox
        {
            database.DatabaseSQL().Open();
            {
                cbDolj.DataSource = database.TableFill("select Dolj from [dbo].[Dolj]", database.DatabaseSQL()).Tables[0];
                cbDolj.DisplayMember = "Dolj";
            }
            database.DatabaseSQL().Close();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                database.DatabaseSQL().Open();
                {
                    SqlCommand cmd = new SqlCommand($"select ID_Dolj from [dbo].[Dolj] where Dolj = '{cbDolj.Text}'", database.DatabaseSQL());
                    Program.ID_Position = (int)cmd.ExecuteScalar();
                }
                database.DatabaseSQL().Close();
            }
            catch { }
        }


        private string GetHash(string input) //Хэширование пароля в БД
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {
                if (tbPas.Text == tbRepPas.Text)
                { 
                    string passwordHash = GetHash(tbPas.Text);
                    {
                        var sqlCommand = new SqlCommand("Sotr_Insert", database.DatabaseSQL());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@Fam_Sotr", tbFam.Text);
                        sqlCommand.Parameters.AddWithValue("@Name_Sotr", tbName.Text);
                        sqlCommand.Parameters.AddWithValue("@Otch_Sotr", tbOtch.Text);
                        sqlCommand.Parameters.AddWithValue("@Ser_Pas", mtbSer.Text);
                        sqlCommand.Parameters.AddWithValue("@Num_Pas", mtbNum.Text);
                        sqlCommand.Parameters.AddWithValue("@Login_Sotr", tbLogin.Text);
                        sqlCommand.Parameters.AddWithValue("@Password_Sotr", passwordHash);
                        sqlCommand.Parameters.AddWithValue("@Dolj_ID", Program.ID_Position);
                        sqlCommand.ExecuteNonQuery();
                        
                    }
                    MessageBox.Show("Сотрудник добавлен");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Сотрудник не добавлен" + ex.Message);
            }
            database.DatabaseSQL().Close();

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            database.DatabaseSQL().Open();
            try
            {   
                var sqlCommand = new SqlCommand("Sotr_Update", database.DatabaseSQL());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_Sotr", Program.ID_Sotr);
                sqlCommand.Parameters.AddWithValue("@Fam_Sotr", tbFam.Text);
                sqlCommand.Parameters.AddWithValue("@Name_Sotr", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@Otch_Sotr", tbOtch.Text);
                sqlCommand.Parameters.AddWithValue("@Ser_Pas", mtbSer.Text);
                sqlCommand.Parameters.AddWithValue("@Num_Pas", mtbNum.Text);
                sqlCommand.Parameters.AddWithValue("@Dolj_ID", Program.ID_Position);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Сотрудник изменен");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сотрудник не изменен " + ex.Message);
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
                    SqlCommand sqlCommand = new SqlCommand("Sotr_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Sotr", Program.ID_Sotr);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand("Sotr_Logical_Delete", database.DatabaseSQL());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ID_Sotr", Program.ID_Sotr);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Сотрудник удален");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сотрудник не удален " + ex.Message);
            }
            database.DatabaseSQL().Close();
        }
    }
}
