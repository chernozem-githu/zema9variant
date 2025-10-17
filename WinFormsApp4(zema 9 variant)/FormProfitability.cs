using System;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class FormProfitability : Form
    {
        public FormProfitability()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка ввода
                if (string.IsNullOrWhiteSpace(txtProfit.Text) || string.IsNullOrWhiteSpace(txtCost.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtProfit.Text, out double profit) || !double.TryParse(txtCost.Text, out double cost))
                {
                    MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (profit < 0 || cost <= 0)
                {
                    MessageBox.Show("Прибыль не может быть отрицательной, а затраты — равными нулю!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Расчёт рентабельности
                double result = MathFunctions.Profitability(profit, cost);

                // Вывод результата
                Form2 resultForm = new Form2("Рентабельность", result);
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


