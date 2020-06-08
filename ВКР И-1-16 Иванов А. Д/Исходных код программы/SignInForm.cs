﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Compo
{
    public partial class SignInForm : Form
    {
        DatabaseConnection DrySql = new DatabaseConnection();

        public SignInForm()
        {
            InitializeComponent();
            this.TopMost = true; //Вызов окна поверх других
            this.StartPosition = FormStartPosition.CenterScreen; //Расположение окна по центру монитора
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\compo2.ico");
            Icon = iconForm;
            tbPassword.PasswordChar = '*';
            this.Text = "Окно Авторизации";
            lblAutorization.Text = "Авторизация";
            lblAutorization.Left = (ClientSize.Width - lblAutorization.Width) / 2; //Расположение в центре экрана
            lblLogin.Text = "Логин";
            LblPassword.Text = "Пароль";
            btnOK.Text = "OK";
            btnClose.Text = "Закрыть";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StatusUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StatusUsers()
        {
            DrySql.DatabaseSQL().Open();
            string loginStatus = tbLogin.Text;
            string passwordStatus = GetHash(tbPassword.Text);
            string StatusCmd = $"Select [Login_Sotr], [Password_Sotr] from [dbo].[Sotr] where [Login_Sotr] = '{loginStatus}'  and [Password_Sotr] = '{passwordStatus}'";
            string StatusRole = $"Select [Dolj_ID] from [dbo].[Sotr] where [Login_Sotr] ='{loginStatus}'";



            var command = new SqlCommand(StatusCmd, DrySql.DatabaseSQL());
            var commandRole = new SqlCommand(StatusRole, DrySql.DatabaseSQL());
            command.Prepare();
            command.ExecuteNonQuery();
            if (loginStatus == (string)command.ExecuteScalar())
            {

                Program.ID_Dolj = (int)commandRole.ExecuteScalar();
                Program.Autoriz_Sotr = (tbLogin.Text);
                MessageBox.Show("Авторизация успешна");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль ведены не верно");
            }

            DrySql.DatabaseSQL().Close();
        } 

        private string GetHash(string input) //Хэширование пароля в БД
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
