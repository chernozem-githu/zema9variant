using System;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class Form2 : Form
    {
        private string operation;
        private double result;

        public Form2(string operation, double result)
        {
            InitializeComponent();
            this.operation = operation;
            this.result = result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Операция: {operation}";
            lblResult.Text = $"Результат расчёта: {result:F2}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



