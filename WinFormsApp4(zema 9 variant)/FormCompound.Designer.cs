namespace WinFormsApp4_zema_9_variant_
{
    partial class FormCompound
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtYears;
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblPrincipal.Text = "Начальная сумма:";
            this.lblPrincipal.Location = new System.Drawing.Point(30, 25);
            this.txtPrincipal.Location = new System.Drawing.Point(190, 25);
            this.txtPrincipal.Width = 150;

            this.lblRate.Text = "Процентная ставка (%):";
            this.lblRate.Location = new System.Drawing.Point(30, 65);
            this.txtRate.Location = new System.Drawing.Point(190, 65);
            this.txtRate.Width = 150;

            this.lblYears.Text = "Количество лет:";
            this.lblYears.Location = new System.Drawing.Point(30, 105);
            this.txtYears.Location = new System.Drawing.Point(190, 105);
            this.txtYears.Width = 150;

            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.Location = new System.Drawing.Point(50, 160);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnBack.Text = "Назад";
            this.btnBack.Location = new System.Drawing.Point(190, 160);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            { this.lblPrincipal, this.txtPrincipal, this.lblRate, this.txtRate, this.lblYears, this.txtYears, this.btnCalculate, this.btnBack });

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сложный процент";

            this.ResumeLayout(false);
        }
    }
}




