using System;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class FormAnnuity : Form
    {
        public FormAnnuity()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка ввода
                if (string.IsNullOrWhiteSpace(txtAmount.Text) ||
                    string.IsNullOrWhiteSpace(txtRate.Text) ||
                    string.IsNullOrWhiteSpace(txtMonths.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtAmount.Text, out double amount) ||
                    !double.TryParse(txtRate.Text, out double rate) ||
                    !int.TryParse(txtMonths.Text, out int months))
                {
                    MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (amount <= 0 || rate < 0 || months <= 0)
                {
                    MessageBox.Show("Значения должны быть положительными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Расчёт аннуитетного платежа
                double result = MathFunctions.Annuity(amount, rate, months);

                // Переход к окну результата
                Form2 resultForm = new Form2("Аннуитетный платёж", result);
                resultForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

