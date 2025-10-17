namespace WinFormsApp4_zema_9_variant_
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnRunTests;
        private System.Windows.Forms.TextBox txtTests;

        // Новые текстбоксы для ввода
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipal;

        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;

        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.TextBox txtLoan;

        private System.Windows.Forms.Label lblLoanRate;
        private System.Windows.Forms.TextBox txtLoanRate;

        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.TextBox txtMonths;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Label lblRateCurrency;
        private System.Windows.Forms.TextBox txtRateCurrency;

        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.TextBox txtRevenue;

        private System.Windows.Forms.Label lblCosts;
        private System.Windows.Forms.TextBox txtCosts;

        private System.Windows.Forms.Label lblRevenueProfit;
        private System.Windows.Forms.TextBox txtRevenueProfitability;

        private System.Windows.Forms.Label lblCostsProfit;
        private System.Windows.Forms.TextBox txtCostsProfitability;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblInfo = new System.Windows.Forms.Label();
            this.btnRunTests = new System.Windows.Forms.Button();
            this.txtTests = new System.Windows.Forms.TextBox();

            // --- Compound ---
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();

            // --- Annuity ---
            this.lblLoan = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.lblLoanRate = new System.Windows.Forms.Label();
            this.txtLoanRate = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();

            // --- ConvertCurrency ---
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblRateCurrency = new System.Windows.Forms.Label();
            this.txtRateCurrency = new System.Windows.Forms.TextBox();

            // --- Profit ---
            this.lblRevenue = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.lblCosts = new System.Windows.Forms.Label();
            this.txtCosts = new System.Windows.Forms.TextBox();

            // --- Profitability ---
            this.lblRevenueProfit = new System.Windows.Forms.Label();
            this.txtRevenueProfitability = new System.Windows.Forms.TextBox();
            this.lblCostsProfit = new System.Windows.Forms.Label();
            this.txtCostsProfitability = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // lblInfo
            this.lblInfo.Text = "Тестирование функций:";
            this.lblInfo.Location = new System.Drawing.Point(20, 10);
            this.lblInfo.AutoSize = true;

            // --- Compound ---
            this.lblPrincipal.Text = "Сумма:";
            this.lblPrincipal.Location = new System.Drawing.Point(20, 40);
            this.txtPrincipal.Location = new System.Drawing.Point(140, 38);
            this.txtPrincipal.Size = new System.Drawing.Size(80, 22);

            this.lblRate.Text = "Ставка %:";
            this.lblRate.Location = new System.Drawing.Point(20, 70);
            this.txtRate.Location = new System.Drawing.Point(140, 68);
            this.txtRate.Size = new System.Drawing.Size(80, 22);

            this.lblYears.Text = "Лет:";
            this.lblYears.Location = new System.Drawing.Point(20, 100);
            this.txtYears.Location = new System.Drawing.Point(140, 98);
            this.txtYears.Size = new System.Drawing.Size(80, 22);

            // --- Annuity ---
            this.lblLoan.Text = "Сумма кредита:";
            this.lblLoan.Location = new System.Drawing.Point(240, 40);
            this.txtLoan.Location = new System.Drawing.Point(380, 38);
            this.txtLoan.Size = new System.Drawing.Size(80, 22);

            this.lblLoanRate.Text = "Ставка %:";
            this.lblLoanRate.Location = new System.Drawing.Point(240, 70);
            this.txtLoanRate.Location = new System.Drawing.Point(380, 68);
            this.txtLoanRate.Size = new System.Drawing.Size(80, 22);

            this.lblMonths.Text = "Месяцев:";
            this.lblMonths.Location = new System.Drawing.Point(240, 100);
            this.txtMonths.Location = new System.Drawing.Point(380, 98);
            this.txtMonths.Size = new System.Drawing.Size(80, 22);

            // --- ConvertCurrency ---
            this.lblAmount.Text = "Сумма:";
            this.lblAmount.Location = new System.Drawing.Point(20, 140);
            this.txtAmount.Location = new System.Drawing.Point(140, 138);
            this.txtAmount.Size = new System.Drawing.Size(80, 22);

            this.lblRateCurrency.Text = "Курс:";
            this.lblRateCurrency.Location = new System.Drawing.Point(240, 140);
            this.txtRateCurrency.Location = new System.Drawing.Point(320, 138);
            this.txtRateCurrency.Size = new System.Drawing.Size(80, 22);

            // --- Profit ---
            this.lblRevenue.Text = "Доход:";
            this.lblRevenue.Location = new System.Drawing.Point(20, 180);
            this.txtRevenue.Location = new System.Drawing.Point(140, 178);
            this.txtRevenue.Size = new System.Drawing.Size(80, 22);

            this.lblCosts.Text = "Затраты:";
            this.lblCosts.Location = new System.Drawing.Point(240, 180);
            this.txtCosts.Location = new System.Drawing.Point(320, 178);
            this.txtCosts.Size = new System.Drawing.Size(80, 22);

            // --- Profitability ---
            this.lblRevenueProfit.Text = "Доход:";
            this.lblRevenueProfit.Location = new System.Drawing.Point(20, 220);
            this.txtRevenueProfitability.Location = new System.Drawing.Point(140, 218);
            this.txtRevenueProfitability.Size = new System.Drawing.Size(80, 22);

            this.lblCostsProfit.Text = "Затраты:";
            this.lblCostsProfit.Location = new System.Drawing.Point(240, 220);
            this.txtCostsProfitability.Location = new System.Drawing.Point(320, 218);
            this.txtCostsProfitability.Size = new System.Drawing.Size(80, 22);

            // btnRunTests
            this.btnRunTests.Text = "Запустить тесты";
            this.btnRunTests.Location = new System.Drawing.Point(20, 260);
            this.btnRunTests.Click += new System.EventHandler(this.btnRunTests_Click);

            // txtTests
            this.txtTests.Location = new System.Drawing.Point(20, 300);
            this.txtTests.Multiline = true;
            this.txtTests.Size = new System.Drawing.Size(440, 150);
            this.txtTests.ReadOnly = true;
            this.txtTests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Form3
            this.ClientSize = new System.Drawing.Size(480, 470);
            this.Controls.Add(this.lblInfo);

            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtYears);

            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblLoanRate);
            this.Controls.Add(this.txtLoanRate);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.txtMonths);

            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblRateCurrency);
            this.Controls.Add(this.txtRateCurrency);

            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.lblCosts);
            this.Controls.Add(this.txtCosts);

            this.Controls.Add(this.lblRevenueProfit);
            this.Controls.Add(this.txtRevenueProfitability);
            this.Controls.Add(this.lblCostsProfit);
            this.Controls.Add(this.txtCostsProfitability);

            this.Controls.Add(this.btnRunTests);
            this.Controls.Add(this.txtTests);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование функций";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
