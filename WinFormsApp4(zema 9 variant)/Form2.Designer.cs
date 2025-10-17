namespace WinFormsApp4_zema_9_variant_
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

           
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(360, 30);
            this.lblTitle.Text = "Операция:";

            
            this.panelResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Location = new System.Drawing.Point(20, 65);
            this.panelResult.Size = new System.Drawing.Size(360, 100);
            this.panelResult.Padding = new System.Windows.Forms.Padding(10);

            
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblResult.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Text = "Результат: 0.00";

            this.panelResult.Controls.Add(this.lblResult);

            
            this.btnBack.Text = "Назад";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(140, 185);
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат расчёта";
            this.Load += new System.EventHandler(this.Form2_Load);

            this.ResumeLayout(false);
        }
    }
}
