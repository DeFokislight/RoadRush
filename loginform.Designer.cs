namespace CaloriesApp
{
    partial class loginform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginpanel = new System.Windows.Forms.Panel();
            this.registerlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passbox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passpicture = new System.Windows.Forms.PictureBox();
            this.loginpicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginpanel2 = new System.Windows.Forms.Label();
            this.loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(153)))));
            this.loginpanel.Controls.Add(this.registerlabel);
            this.loginpanel.Controls.Add(this.loginbutton);
            this.loginpanel.Controls.Add(this.passbox);
            this.loginpanel.Controls.Add(this.loginbox);
            this.loginpanel.Controls.Add(this.passpicture);
            this.loginpanel.Controls.Add(this.loginpicture);
            this.loginpanel.Controls.Add(this.panel2);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(728, 454);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseDown);
            this.loginpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginpanel_MouseMove);
            // 
            // registerlabel
            // 
            this.registerlabel.AutoSize = true;
            this.registerlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerlabel.Location = new System.Drawing.Point(520, 401);
            this.registerlabel.Name = "registerlabel";
            this.registerlabel.Size = new System.Drawing.Size(196, 29);
            this.registerlabel.TabIndex = 5;
            this.registerlabel.Text = "Еще нет аккаунта?";
            this.registerlabel.Click += new System.EventHandler(this.registerlabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Silver;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.loginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbutton.Location = new System.Drawing.Point(257, 366);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(191, 64);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Войти";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passbox.Location = new System.Drawing.Point(169, 266);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(468, 45);
            this.passbox.TabIndex = 4;
            this.passbox.UseSystemPasswordChar = true;
            // 
            // loginbox
            // 
            this.loginbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.Location = new System.Drawing.Point(169, 166);
            this.loginbox.Multiline = true;
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(468, 60);
            this.loginbox.TabIndex = 3;
            // 
            // passpicture
            // 
            this.passpicture.Image = global::CaloriesApp.Properties.Resources.password;
            this.passpicture.Location = new System.Drawing.Point(47, 246);
            this.passpicture.Name = "passpicture";
            this.passpicture.Size = new System.Drawing.Size(65, 65);
            this.passpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passpicture.TabIndex = 2;
            this.passpicture.TabStop = false;
            // 
            // loginpicture
            // 
            this.loginpicture.Image = global::CaloriesApp.Properties.Resources.login;
            this.loginpicture.Location = new System.Drawing.Point(47, 166);
            this.loginpicture.Name = "loginpicture";
            this.loginpicture.Size = new System.Drawing.Size(65, 65);
            this.loginpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpicture.TabIndex = 1;
            this.loginpicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.loginpanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 100);
            this.panel2.TabIndex = 0;
            // 
            // loginpanel2
            // 
            this.loginpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginpanel2.ForeColor = System.Drawing.SystemColors.Control;
            this.loginpanel2.Location = new System.Drawing.Point(0, 0);
            this.loginpanel2.Name = "loginpanel2";
            this.loginpanel2.Size = new System.Drawing.Size(728, 100);
            this.loginpanel2.TabIndex = 0;
            this.loginpanel2.Text = "Авторизация";
            this.loginpanel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginpanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginpanel2_MouseDown);
            this.loginpanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginpanel2_MouseMove);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "loginform";
            this.Text = "LoginForm";
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loginpicture;
        private System.Windows.Forms.Label loginpanel2;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.PictureBox passpicture;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label registerlabel;
    }
}

