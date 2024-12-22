using System.Windows.Forms;

namespace CaloriesApp
{
    partial class caloriesForm
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
            this.panelsecond = new System.Windows.Forms.Panel();
            this.labelday = new System.Windows.Forms.Label();
            this.labelpriem = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.helpbutton = new System.Windows.Forms.Button();
            this.panelsecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsecond
            // 
            this.panelsecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(153)))));
            this.panelsecond.Controls.Add(this.helpbutton);
            this.panelsecond.Controls.Add(this.labelday);
            this.panelsecond.Controls.Add(this.labelpriem);
            this.panelsecond.Controls.Add(this.clearbutton);
            this.panelsecond.Controls.Add(this.dataGridView1);
            this.panelsecond.Controls.Add(this.comboBox1);
            this.panelsecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsecond.Location = new System.Drawing.Point(0, 0);
            this.panelsecond.Name = "panelsecond";
            this.panelsecond.Size = new System.Drawing.Size(822, 542);
            this.panelsecond.TabIndex = 4;
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelday.Location = new System.Drawing.Point(12, 504);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(25, 29);
            this.labelday.TabIndex = 9;
            this.labelday.Text = "0";
            // 
            // labelpriem
            // 
            this.labelpriem.AutoSize = true;
            this.labelpriem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpriem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelpriem.Location = new System.Drawing.Point(12, 463);
            this.labelpriem.Name = "labelpriem";
            this.labelpriem.Size = new System.Drawing.Size(25, 29);
            this.labelpriem.TabIndex = 8;
            this.labelpriem.Text = "0";
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearbutton.Location = new System.Drawing.Point(631, 486);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(157, 31);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "Очистить";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.Grams,
            this.Calories,
            this.Proteins,
            this.Fats,
            this.Carbohydrates});
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 409);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // product
            // 
            this.product.Frozen = true;
            this.product.HeaderText = "Продукт";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.Width = 200;
            // 
            // Grams
            // 
            this.Grams.Frozen = true;
            this.Grams.HeaderText = "Гр.";
            this.Grams.MinimumWidth = 3;
            this.Grams.Name = "Grams";
            this.Grams.Width = 60;
            // 
            // Calories
            // 
            this.Calories.Frozen = true;
            this.Calories.HeaderText = "Ккал";
            this.Calories.MinimumWidth = 4;
            this.Calories.Name = "Calories";
            this.Calories.Width = 80;
            // 
            // Proteins
            // 
            this.Proteins.Frozen = true;
            this.Proteins.HeaderText = "Белки";
            this.Proteins.MinimumWidth = 3;
            this.Proteins.Name = "Proteins";
            this.Proteins.Width = 60;
            // 
            // Fats
            // 
            this.Fats.HeaderText = "Жиры";
            this.Fats.MinimumWidth = 3;
            this.Fats.Name = "Fats";
            this.Fats.Width = 60;
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.HeaderText = "Углеводы";
            this.Carbohydrates.MinimumWidth = 3;
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.Width = 80;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // helpbutton
            // 
            this.helpbutton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpbutton.Location = new System.Drawing.Point(699, 3);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(99, 33);
            this.helpbutton.TabIndex = 10;
            this.helpbutton.Text = "Помощь";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // caloriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.panelsecond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "caloriesForm";
            this.Text = "caloriesForm";
            this.panelsecond.ResumeLayout(false);
            this.panelsecond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsecond;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proteins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrates;
        private Label labelpriem;
        private Label labelday;
        private Button helpbutton;
    }
}