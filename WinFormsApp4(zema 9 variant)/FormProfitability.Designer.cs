namespace WinFormsApp4_zema_9_variant_
{
    partial class FormProfitability
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblProfit
            // 
            this.lblProfit.Text = "Прибыль:";
            this.lblProfit.Location = new System.Drawing.Point(20, 20);

            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(180, 20);
            this.txtProfit.Size = new System.Drawing.Size(150, 23);

            // 
            // lblCost
            // 
            this.lblCost.Text = "Затраты:";
            this.lblCost.Location = new System.Drawing.Point(20, 60);

            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(180, 60);
            this.txtCost.Size = new System.Drawing.Size(150, 23);

            // 
            // btnCalculate
            // 
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.Location = new System.Drawing.Point(40, 110);
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnBack
            // 
            this.btnBack.Text = "Назад";
            this.btnBack.Location = new System.Drawing.Point(200, 110);
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // FormProfitability
            // 
            this.ClientSize = new System.Drawing.Size(370, 170);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnBack);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт рентабельности";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


