namespace WinFormsApp4_zema_9_variant_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCompound;
        private Button btnAnnuity;
        private Button btnCurrency;
        private Button btnProfit;
        private Button btnProfitability;
        private Button btnTests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCompound = new System.Windows.Forms.Button();
            this.btnAnnuity = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnProfit = new System.Windows.Forms.Button();
            this.btnProfitability = new System.Windows.Forms.Button();
            this.btnTests = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnCompound.Text = "Сложный процент";
            this.btnCompound.Location = new System.Drawing.Point(30, 20);
            this.btnCompound.Size = new System.Drawing.Size(200, 30);
            this.btnCompound.Click += new System.EventHandler(this.btnCompound_Click);

            this.btnAnnuity.Text = "Аннуитетный платёж";
            this.btnAnnuity.Location = new System.Drawing.Point(30, 60);
            this.btnAnnuity.Size = new System.Drawing.Size(200, 30);
            this.btnAnnuity.Click += new System.EventHandler(this.btnAnnuity_Click);

            this.btnCurrency.Text = "Конвертация валют";
            this.btnCurrency.Location = new System.Drawing.Point(30, 100);
            this.btnCurrency.Size = new System.Drawing.Size(200, 30);
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);

            this.btnProfit.Text = "Прибыль";
            this.btnProfit.Location = new System.Drawing.Point(30, 140);
            this.btnProfit.Size = new System.Drawing.Size(200, 30);
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);

            this.btnProfitability.Text = "Рентабельность";
            this.btnProfitability.Location = new System.Drawing.Point(30, 180);
            this.btnProfitability.Size = new System.Drawing.Size(200, 30);
            this.btnProfitability.Click += new System.EventHandler(this.btnProfitability_Click);

            this.btnTests.Text = "Тестирование";
            this.btnTests.Location = new System.Drawing.Point(30, 220);
            this.btnTests.Size = new System.Drawing.Size(200, 30);
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);

            this.ClientSize = new System.Drawing.Size(260, 280);
            this.Controls.Add(this.btnCompound);
            this.Controls.Add(this.btnAnnuity);
            this.Controls.Add(this.btnCurrency);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.btnProfitability);
            this.Controls.Add(this.btnTests);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финансовый калькулятор";
            this.ResumeLayout(false);
        }
    }
}
