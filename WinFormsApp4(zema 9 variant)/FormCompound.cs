using System;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class FormCompound : Form
    {
        public FormCompound()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtPrincipal.Text, out double principal) || principal <= 0)
                    throw new ArgumentException("Введите положительное значение суммы.");

                if (!double.TryParse(txtRate.Text, out double rate) || rate <= 0)
                    throw new ArgumentException("Введите положительное значение процента.");

                if (!int.TryParse(txtYears.Text, out int years) || years <= 0)
                    throw new ArgumentException("Введите положительное значение лет.");

                double result = MathFunctions.Compound(principal, rate, years);

                new Form2("Сложный процент", result).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // просто закрывает текущую форму и возвращает к Form1
        }
    }
}
