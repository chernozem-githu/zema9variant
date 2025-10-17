using System;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // кнопка "Сложный процент"
        private void btnCompound_Click(object sender, EventArgs e)
        {
            FormCompound form = new FormCompound();
            form.ShowDialog();
        }

        // кнопка "Аннуитетный платёж"
        private void btnAnnuity_Click(object sender, EventArgs e)
        {
            FormAnnuity form = new FormAnnuity();
            form.ShowDialog();
        }

        // кнопка "Конвертация валют"
        private void btnCurrency_Click(object sender, EventArgs e)
        {
            FormCurrency form = new FormCurrency();
            form.ShowDialog();
        }

        // кнопка "Прибыль"
        private void btnProfit_Click(object sender, EventArgs e)
        {
            FormProfit form = new FormProfit();
            form.ShowDialog();
        }

        // кнопка "Рентабельность"
        private void btnProfitability_Click(object sender, EventArgs e)
        {
            FormProfitability form = new FormProfitability();
            form.ShowDialog();
        }

        // кнопка "Тестирование"
        private void btnTests_Click(object sender, EventArgs e)
        {
            Form3 testForm = new Form3();
            testForm.ShowDialog();
        }
    }
}

