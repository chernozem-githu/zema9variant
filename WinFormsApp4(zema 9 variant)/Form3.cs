using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4_zema_9_variant_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void RunTests()
        {
            StringBuilder report = new StringBuilder();
            int выполнено = 0, провалено = 0;

            report.AppendLine("🧪 Тестирование функций:\r\n");

            // Считываем значения из текстбоксов
            double principal = 0, rate = 0, loan = 0, loanRate = 0;
            int years = 0, months = 0;

            bool пустоеПоле = false;

            if (!double.TryParse(txtPrincipal.Text, out principal)) пустоеПоле = true;
            if (!double.TryParse(txtRate.Text, out rate)) пустоеПоле = true;
            if (!int.TryParse(txtYears.Text, out years)) пустоеПоле = true;
            if (!double.TryParse(txtLoan.Text, out loan)) пустоеПоле = true;
            if (!double.TryParse(txtLoanRate.Text, out loanRate)) пустоеПоле = true;
            if (!int.TryParse(txtMonths.Text, out months)) пустоеПоле = true;

            if (пустоеПоле)
            {
                report.AppendLine("❌ Некоторые поля пустые или введены некорректные значения. Эти тесты будут отмечены как проваленные.\n");
            }

            // --- Тест Compound ---
            if (txtPrincipal.Text == "" || txtRate.Text == "" || txtYears.Text == "")
            {
                report.AppendLine("❌ Compound провал: пустое поле");
                провалено++;
            }
            else
            {
                var (успех1, результат1, ошибка1) = MathFunctions.TryCompound(principal, rate, years);
                if (успех1)
                {
                    report.AppendLine($"✅ Compound выполнено: {результат1}");
                    выполнено++;
                }
                else
                {
                    report.AppendLine($"❌ Compound провал: {ошибка1}");
                    провалено++;
                }
            }

            // --- Тест Annuity ---
            if (txtLoan.Text == "" || txtLoanRate.Text == "" || txtMonths.Text == "")
            {
                report.AppendLine("❌ Annuity провал: пустое поле");
                провалено++;
            }
            else
            {
                var (успех2, результат2, ошибка2) = MathFunctions.TryAnnuity(loan, loanRate, months);
                if (успех2)
                {
                    report.AppendLine($"✅ Annuity выполнено: {результат2}");
                    выполнено++;
                }
                else
                {
                    report.AppendLine($"❌ Annuity провал: {ошибка2}");
                    провалено++;
                }
            }

            // --- Тест ConvertCurrency ---
            if (txtPrincipal.Text == "" || txtRate.Text == "")
            {
                report.AppendLine("❌ ConvertCurrency провал: пустое поле");
                провалено++;
            }
            else
            {
                var (успех3, результат3, ошибка3) = MathFunctions.TryConvertCurrency(principal, rate);
                if (успех3)
                {
                    report.AppendLine($"✅ ConvertCurrency выполнено: {результат3}");
                    выполнено++;
                }
                else
                {
                    report.AppendLine($"❌ ConvertCurrency провал: {ошибка3}");
                    провалено++;
                }
            }

            // --- Тест Profit ---
            if (txtPrincipal.Text == "" || txtRate.Text == "")
            {
                report.AppendLine("❌ Profit провал: пустое поле");
                провалено++;
            }
            else
            {
                var (успех4, результат4, ошибка4) = MathFunctions.TryProfit(principal, rate); // если есть Profit
                if (успех4)
                {
                    report.AppendLine($"✅ Profit выполнено: {результат4}");
                    выполнено++;
                }
                else
                {
                    report.AppendLine($"❌ Profit провал: {ошибка4}");
                    провалено++;
                }
            }

            // --- Тест Profitability ---
            if (txtPrincipal.Text == "" || txtRate.Text == "")
            {
                report.AppendLine("❌ Profitability провал: пустое поле");
                провалено++;
            }
            else
            {
                var (успех5, результат5, ошибка5) = MathFunctions.TryProfitability(principal, rate);
                if (успех5)
                {
                    report.AppendLine($"✅ Profitability выполнено: {результат5}");
                    выполнено++;
                }
                else
                {
                    report.AppendLine($"❌ Profitability провал: {ошибка5}");
                    провалено++;
                }
            }

            report.AppendLine($"\n📊 Выполнено: {выполнено}, Провалено: {провалено}");
            txtTests.Text = report.ToString();
        }
    }
}
