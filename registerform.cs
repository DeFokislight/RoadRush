using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CaloriesApp
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
            this.passregisterbox.AutoSize = false;
            this.passregisterbox.Size = new Size(this.passregisterbox.Size.Width, this.registerbox.Size.Height);

            registerbox.Text = "Введите логин";
            passregisterbox.Text = "Введите пароль";
            namebox.Text = "Введите имя";
            surnamebox.Text = "Введите фамилию";
            passregisterbox.UseSystemPasswordChar = false;
        }
        Point lastpoint;
        private void registerbutton_Click(object sender, EventArgs e)
        {
            if (namebox.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (surnamebox.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (registerbox.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passregisterbox.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkuser())
                return;

            database db = new database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `password`, `name`, `surname`) VALUES (NULL, @login, @password, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = registerbox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passregisterbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namebox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnamebox.Text;

            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeconnection();
        }

        private void registerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void registerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void registerpanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void registerpanel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }


        private void namebox_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == "Введите имя")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }
        }

        private void namebox_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                namebox.Text = "Введите имя";
                namebox.ForeColor = Color.Black;
            }
        }

        private void surnamebox_Enter(object sender, EventArgs e)
        {
            if (surnamebox.Text == "Введите фамилию")
            {
                surnamebox.Text = "";
                surnamebox.ForeColor = Color.Black;
            }
        }

        private void surnamebox_Leave(object sender, EventArgs e)
        {
            if (surnamebox.Text == "")
            {
                surnamebox.Text = "Введите фамилию";
                surnamebox.ForeColor = Color.Black;
            }
        }

        private void registerbox_Enter(object sender, EventArgs e)
        {
            if (registerbox.Text == "Введите логин")
            {
                registerbox.Text = "";
                registerbox.ForeColor = Color.Black;
            }
        }

        private void registerbox_Leave(object sender, EventArgs e)
        {
            if (registerbox.Text == "")
            {
                registerbox.Text = "Введите логин";
                registerbox.ForeColor = Color.Black;
            }
        }

        private void passregisterbox_Enter(object sender, EventArgs e)
        {
            if (passregisterbox.Text == "Введите пароль")
            {
                passregisterbox.Text = "";
                passregisterbox.ForeColor = Color.Black;
                passregisterbox.UseSystemPasswordChar = true;

            }
        }

        private void passregisterbox_Leave(object sender, EventArgs e)
        {
            if (passregisterbox.Text == "")
            {
                passregisterbox.UseSystemPasswordChar = false;
                passregisterbox.Text = "Введите пароль";
                passregisterbox.ForeColor = Color.Black;
                
            }
        }
        public Boolean checkuser()
        {
            database db = new database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = registerbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                return true;
            }
            else
                return false; //уникальность пользователей

        }

        private void loginlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform loginForm = new loginform();
            loginForm.Show();
        }
    }    
}
