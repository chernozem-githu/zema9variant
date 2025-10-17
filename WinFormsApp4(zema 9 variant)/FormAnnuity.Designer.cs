namespace WinFormsApp4_zema_9_variant_
{
    partial class FormAnnuity
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtMonths;
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblAmount
            // 
            this.lblAmount.Text = "Сумма кредита:";
            this.lblAmount.Location = new System.Drawing.Point(20, 20);

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(180, 20);
            this.txtAmount.Size = new System.Drawing.Size(150, 23);

            // 
            // lblRate
            // 
            this.lblRate.Text = "Процентная ставка (%):";
            this.lblRate.Location = new System.Drawing.Point(20, 60);

            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(180, 60);
            this.txtRate.Size = new System.Drawing.Size(150, 23);

            // 
            // lblMonths
            // 
            this.lblMonths.Text = "Срок м:";
            this.lblMonths.Location = new System.Drawing.Point(20, 100);

            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(180, 100);
            this.txtMonths.Size = new System.Drawing.Size(150, 23);

            // 
            // btnCalculate
            // 
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.Location = new System.Drawing.Point(40, 150);
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnBack
            // 
            this.btnBack.Text = "Назад";
            this.btnBack.Location = new System.Drawing.Point(200, 150);
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // FormAnnuity
            // 
            this.ClientSize = new System.Drawing.Size(370, 210);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnBack);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аннуитетный платёж";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

