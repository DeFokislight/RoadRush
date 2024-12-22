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

namespace CaloriesApp
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();

            this.passbox.AutoSize = false;
            this.passbox.Size = new Size(this.passbox.Size.Width, this.loginbox.Size.Height);
        }
        Point lastpoint;

        private void loginpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void loginpanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void loginpanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void loginpanel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            String userlogin = loginbox.Text;
            String userpass = passbox.Text;

            database db = new database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userlogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userpass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

         
            if (table.Rows.Count > 0)
            {
                this.Hide();
                mainform mainForm = new mainform();
                mainForm.Show();
            }



        }
        private void registerlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerform registerForm = new registerform();
            registerForm.Show();
        }
    }
}
    