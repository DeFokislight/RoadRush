namespace CaloriesApp
{
    partial class registerform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerpanel = new System.Windows.Forms.Panel();
            this.loginlabel = new System.Windows.Forms.Label();
            this.surnamebox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.passregisterbox = new System.Windows.Forms.TextBox();
            this.registerbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerpanel2 = new System.Windows.Forms.Label();
            this.registerpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerpanel
            // 
            this.registerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(153)))));
            this.registerpanel.Controls.Add(this.loginlabel);
            this.registerpanel.Controls.Add(this.surnamebox);
            this.registerpanel.Controls.Add(this.namebox);
            this.registerpanel.Controls.Add(this.registerbutton);
            this.registerpanel.Controls.Add(this.passregisterbox);
            this.registerpanel.Controls.Add(this.registerbox);
            this.registerpanel.Controls.Add(this.panel2);
            this.registerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerpanel.Location = new System.Drawing.Point(0, 0);
            this.registerpanel.Name = "registerpanel";
            this.registerpanel.Size = new System.Drawing.Size(800, 450);
            this.registerpanel.TabIndex = 1;
            this.registerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerpanel_MouseDown);
            this.registerpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerpanel_MouseMove);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginlabel.Location = new System.Drawing.Point(612, 392);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(164, 29);
            this.loginlabel.TabIndex = 7;
            this.loginlabel.Text = "Авторизоваться";
            this.loginlabel.Click += new System.EventHandler(this.loginlabel_Click);
            // 
            // surnamebox
            // 
            this.surnamebox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamebox.Location = new System.Drawing.Point(406, 281);
            this.surnamebox.Multiline = true;
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(322, 60);
            this.surnamebox.TabIndex = 6;
            this.surnamebox.Enter += new System.EventHandler(this.surnamebox_Enter);
            this.surnamebox.Leave += new System.EventHandler(this.surnamebox_Leave);
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namebox.Location = new System.Drawing.Point(406, 183);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(322, 60);
            this.namebox.TabIndex = 5;
            this.namebox.Enter += new System.EventHandler(this.namebox_Enter);
            this.namebox.Leave += new System.EventHandler(this.namebox_Leave);
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.Silver;
            this.registerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.registerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbutton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerbutton.Location = new System.Drawing.Point(262, 374);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(298, 64);
            this.registerbutton.TabIndex = 1;
            this.registerbutton.Text = "Зарегистрироваться";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // passregisterbox
            // 
            this.passregisterbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passregisterbox.Location = new System.Drawing.Point(31, 281);
            this.passregisterbox.Name = "passregisterbox";
            this.passregisterbox.Size = new System.Drawing.Size(306, 45);
            this.passregisterbox.TabIndex = 4;
            this.passregisterbox.UseSystemPasswordChar = true;
            this.passregisterbox.Enter += new System.EventHandler(this.passregisterbox_Enter);
            this.passregisterbox.Leave += new System.EventHandler(this.passregisterbox_Leave);
            // 
            // registerbox
            // 
            this.registerbox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerbox.Location = new System.Drawing.Point(31, 183);
            this.registerbox.Multiline = true;
            this.registerbox.Name = "registerbox";
            this.registerbox.Size = new System.Drawing.Size(306, 60);
            this.registerbox.TabIndex = 3;
            this.registerbox.Enter += new System.EventHandler(this.registerbox_Enter);
            this.registerbox.Leave += new System.EventHandler(this.registerbox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.registerpanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // registerpanel2
            // 
            this.registerpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerpanel2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerpanel2.ForeColor = System.Drawing.SystemColors.Control;
            this.registerpanel2.Location = new System.Drawing.Point(0, 0);
            this.registerpanel2.Name = "registerpanel2";
            this.registerpanel2.Size = new System.Drawing.Size(800, 100);
            this.registerpanel2.TabIndex = 0;
            this.registerpanel2.Text = "Регистрация";
            this.registerpanel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerpanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registerpanel2_MouseDown);
            this.registerpanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerpanel2_MouseMove);
            // 
            // registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "registerform";
            this.Text = "RegisterForm";
            this.registerpanel.ResumeLayout(false);
            this.registerpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerpanel;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.TextBox passregisterbox;
        private System.Windows.Forms.TextBox registerbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label registerpanel2;
        private System.Windows.Forms.TextBox surnamebox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label loginlabel;
    }
}