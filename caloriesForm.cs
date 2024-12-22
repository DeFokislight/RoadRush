using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CaloriesApp
{

    public partial class caloriesForm : Form
    {
        // Класс для хранения данных о продукте
        private class Product
        {
            public string Name { get; set; }
            public double Grams { get; set; }
            public double Calories { get; set; }
            public double Proteins { get; set; }
            public double Fats { get; set; }
            public double Carbohydrates { get; set; }
        }



        string connectionString = "Data Source=products.db;Version=3;";

        private SQLiteConnection dbConnection;

        private Dictionary<string, List<Product>> mealData = new Dictionary<string, List<Product>>();


        public caloriesForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            this.Load += new EventHandler(caloriesForm_Load);

            this.StartPosition = FormStartPosition.CenterScreen; // Центр экрана
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фиксируем размеры
            this.MaximizeBox = false; // Отключить разворачивание
            this.MinimizeBox = true;  // Оставить сворачивание


        }




        // Метод для подключения к базе данных
        private void ConnectToDatabase()
        {
            dbConnection = new SQLiteConnection(connectionString);
            try
            {
                dbConnection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
        }





        private void caloriesForm_Load(object sender, EventArgs e)
        {

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;

            ConnectToDatabase(); // Подключаемся к БД при загрузке формы

            comboBox1.Items.Add("Завтрак");
            comboBox1.Items.Add("Обед");
            comboBox1.Items.Add("Ужин");

            // Значение по умолчанию
            comboBox1.SelectedIndex = 0;
            // Инициализация столбцов для DataGridView
            InitializeDataGridView();
            CreateTable();

        }
        



        private void InitializeDataGridView()
        {
            // Очистка таблицы при загрузке формы
            dataGridView1.Columns.Clear();

            // Добавляем столбцы
            dataGridView1.Columns.Add("product", "Продукт");
            dataGridView1.Columns.Add("Grams", "Граммы");
            dataGridView1.Columns.Add("Calories", "Калории");
            dataGridView1.Columns.Add("Proteins", "Белки");
            dataGridView1.Columns.Add("Fats", "Жиры");
            dataGridView1.Columns.Add("Carbohydrates", "Углеводы");
        }



        private void CreateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // SQL запрос для создания таблицы
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Products (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Calories REAL NOT NULL,
                        Proteins REAL NOT NULL,
                        Fats REAL NOT NULL,
                        Carbohydrates REAL NOT NULL
                    );";

                SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                try
                {
                    command.ExecuteNonQuery(); // Выполнение SQL запроса для создания таблицы
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании таблицы: {ex.Message}");
                }
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string selectedMeal = comboBox1.SelectedItem.ToString();

            // Очистка DataGridView перед загрузкой новых данных
            dataGridView1.Rows.Clear();

            // Загрузка данных для выбранного приема пищи
            if (mealData.ContainsKey(selectedMeal))
            {
                foreach (var product in mealData[selectedMeal])
                {
                    dataGridView1.Rows.Add(product.Name, product.Grams, product.Calories, product.Proteins, product.Fats, product.Carbohydrates);
                }
            }
        }




        // Обработчик окончания редактирования ячейки в DataGridView
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string selectedMeal = comboBox1.SelectedItem.ToString();

            // Получаем данные о продукте, которые были изменены
            string productName = dataGridView1.Rows[e.RowIndex].Cells["product"].Value.ToString();
            double grams = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Grams"].Value);



            // Рассчитываем БЖУ и калории
            var product = GetProductInfo(productName);
            if (product != null)
            {
                double calories = (product.Calories / 100) * grams;
                double proteins = (product.Proteins / 100) * grams;
                double fats = (product.Fats / 100) * grams;
                double carbohydrates = (product.Carbohydrates / 100) * grams;

                // Обновляем значения в DataGridView
                dataGridView1.Rows[e.RowIndex].Cells["Calories"].Value = calories;
                dataGridView1.Rows[e.RowIndex].Cells["Proteins"].Value = proteins;
                dataGridView1.Rows[e.RowIndex].Cells["Fats"].Value = fats;
                dataGridView1.Rows[e.RowIndex].Cells["Carbohydrates"].Value = carbohydrates;
            }



            if (product == null)
            {
                // Если продукта нет в базе данных, выводим сообщение
                MessageBox.Show("Такого продукта нет в базе данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Очищаем ячейки, чтобы пользователь мог ввести правильный продукт
                dataGridView1.Rows[e.RowIndex].Cells["product"].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells["Grams"].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells["Calories"].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells["Proteins"].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells["Fats"].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells["Carbohydrates"].Value = "";

                return;
            }




            // Сохраняем данные в словарь для текущего приема пищи
            if (!mealData.ContainsKey(selectedMeal))
            {
                mealData[selectedMeal] = new List<Product>();
            }

            // Добавляем или обновляем запись в словаре
            if (e.RowIndex < mealData[selectedMeal].Count)
            {
                // Обновляем существующую запись
                mealData[selectedMeal][e.RowIndex] = new Product
                {
                    Name = productName,
                    Grams = grams,
                    Calories = (product.Calories / 100) * grams,
                    Proteins = (product.Proteins / 100) * grams,
                    Fats = (product.Fats / 100) * grams,
                    Carbohydrates = (product.Carbohydrates / 100) * grams
                };
            }
            else
            {
                // Добавляем новую запись
                mealData[selectedMeal].Add(new Product
                {
                    Name = productName,
                    Grams = grams,
                    Calories = (product.Calories / 100) * grams,
                    Proteins = (product.Proteins / 100) * grams,
                    Fats = (product.Fats / 100) * grams,
                    Carbohydrates = (product.Carbohydrates / 100) * grams
                });
            }

            // Обновляем калории для текущего приема пищи
            UpdateMealCalories();

            // Обновляем общую калорийность за день
            UpdateTotalCalories();
        }






        // Метод для получения информации о продукте из базы данных
        private Product GetProductInfo(string productName)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Products WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", productName);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Product
                    {
                        Name = reader["Name"].ToString(),
                        Calories = Convert.ToDouble(reader["Calories"]),
                        Proteins = Convert.ToDouble(reader["Proteins"]),
                        Fats = Convert.ToDouble(reader["Fats"]),
                        Carbohydrates = Convert.ToDouble(reader["Carbohydrates"])
                    };
                }
                return null;
            }
        }






        // Обновление общей калорийности за день
        private void UpdateTotalCalories()
        {
            double totalCalories = 0;
            foreach (var meal in mealData)
            {
                foreach (var product in meal.Value)
                {
                    totalCalories += product.Calories;
                }
            }
            labelday.Text = $"Общие калории за день: {totalCalories}";
        }




        private void UpdateMealCalories()
        {
            double totalCaloriesForMeal = 0;

            // Перебираем все строки в DataGridView и суммируем калории для текущего приема пищи
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Calories"].Value != null)
                {
                    double calories = Convert.ToDouble(row.Cells["Calories"].Value);
                    totalCaloriesForMeal += calories;
                }
            }

            // Обновляем labelpriem с калориями для выбранного приема пищи
            labelpriem.Text = $"Калории для {comboBox1.SelectedItem}: {totalCaloriesForMeal}";
        }





        private void clearbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string selectedMeal = comboBox1.SelectedItem.ToString();
            if (mealData.ContainsKey(selectedMeal))
            {
                mealData[selectedMeal].Clear(); // Очистить список для выбранного приема пищи
            }
            labelday.Text = "0";
            labelpriem.Text = "0";

        }



        private void helpbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inform inForm = new inform();
            inForm.Show();
        }
    }
}