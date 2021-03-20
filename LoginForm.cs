using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace WinFormSQLearn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.fieldPassword.AutoSize = false;
            this.fieldPassword.Height = this.fieldLogIn.Height;     //высота поля пароля = высота поля логина
        }

        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                //Работа с крестиком закрытия формы
        private void ButtonCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            ButtonCloseWindow.ForeColor = Color.DarkCyan;            
            //ButtonCloseWindow.ForeColor = DefaultBackColor;
        }

        private void ButtonCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            ButtonCloseWindow.ForeColor = DefaultBackColor;
        }


        // Цеплялка серой формы
        Point lastPoint;//  Координаты курсора 
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        // Цеплялка шапки формы
        private void labelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //Введенные данные сравниваем, подключ к базе с таблицей и при соответствии авторизует
            string loginUser = fieldLogIn.Text;
            String passwordUser = fieldPassword.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();  //Добавил using

            //для выборки данных относительно введеных
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUser AND `password` = @passwordUser", dataBase.getConnection()); // @заглушки

            //Меняю заглушки`Security`
            command.Parameters.Add("@loginUser", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@passwordUser", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);// Из адаптера заполняю тейбл

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
                
            } else
            {
                MessageBox.Show("No");
            }
        }




        //

    }
}
