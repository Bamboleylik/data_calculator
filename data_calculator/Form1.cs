using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace data_calculator
{
    public partial class Form1 : Form
    {
        private const string SaveFilePath = "saved_date.txt";
        private DateTime targetDate;
        private bool isValidDate = false;

        public Form1()
        {
            InitializeComponent();
            LoadSavedDate();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ParseDate();
            UpdateTimeRemaining();
        }

        private void ParseDate()
        {
            string input = txtDate.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Будь ласка, введіть дату!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidDate = false;
                return;
            }

            if (!DateTime.TryParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out targetDate))
            {
                MessageBox.Show("Некоректний формат дати! Введіть у форматі: dd.MM.yyyy HH:mm:ss", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidDate = false;
                return;
            }

            if (targetDate <= DateTime.Now)
            {
                MessageBox.Show("Вказана дата вже минула!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidDate = false;
                return;
            }

            isValidDate = true;
        }

        private void UpdateTimeRemaining()
        {
            if (!isValidDate) return;

            TimeSpan remaining = targetDate - DateTime.Now;

            lblYears.Text = $"Роки: {remaining.TotalDays / 365.25:F2}";
            lblMonths.Text = $"Місяці: {remaining.TotalDays / 30.44:F2}";
            lblDays.Text = $"Дні: {remaining.TotalDays:F0}";
            lblHours.Text = $"Години: {remaining.TotalHours:F0}";
            lblMinutes.Text = $"Хвилини: {remaining.TotalMinutes:F0}";
            lblSeconds.Text = $"Секунди: {remaining.TotalSeconds:F0}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate.Clear();
            lblYears.Text = "Роки: ";
            lblMonths.Text = "Місяці: ";
            lblDays.Text = "Дні: ";
            lblHours.Text = "Години: ";
            lblMinutes.Text = "Хвилини: ";
            lblSeconds.Text = "Секунди: ";
            isValidDate = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidDate)
            {
                MessageBox.Show("Неможливо зберегти! Введіть коректну дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.WriteAllText(SaveFilePath, txtDate.Text);
            MessageBox.Show("Дата збережена!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSavedDate();
        }

        private void LoadSavedDate()
        {
            if (File.Exists(SaveFilePath))
            {
                string savedDate = File.ReadAllText(SaveFilePath).Trim();

                if (string.IsNullOrWhiteSpace(savedDate))
                {
                    MessageBox.Show("Файл порожній або містить некоректні дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtDate.Text = savedDate;
                ParseDate();
                UpdateTimeRemaining();
            }
        }
    }
}
