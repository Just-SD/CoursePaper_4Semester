using CoursePaper.Domain;

namespace CoursePaper.Forms
{
    internal partial class PurchaseConfirmationDialog : Form
    {
        private bool allowClose = false;

        public PurchaseConfirmationDialog(string nameBrand, string nameModel, string Price)
        {
            InitializeComponent();
            PurchaseConfirmationDialog_Load(nameBrand, nameModel, Price);
        }

        private void PurchaseConfirmationDialog_Load(string nameBrand, string nameModel, string price)
        {
            Label labelBrand = new Label();
            Label labelModel = new Label();
            Label labelPrice = new Label();
            SuspendLayout();

            // 
            // labelBrand
            // 
            labelBrand.Font = new Font("Segoe UI", 12F);
            labelBrand.Location = new Point(12, 56);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(470, 45);
            labelBrand.TabIndex = 3;
            labelBrand.Text = nameBrand;
            labelBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            labelModel.Font = new Font("Segoe UI", 11F);
            labelModel.Location = new Point(12, 101);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(470, 42);
            labelModel.TabIndex = 4;
            labelModel.Text = nameModel;
            labelModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelPrice.Location = new Point(12, 152);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(470, 51);
            labelPrice.TabIndex = 5;
            labelPrice.Text = price;
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(labelPrice);
            Controls.Add(labelModel);
            Controls.Add(labelBrand);
            ResumeLayout(false);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            allowClose = true;
            this.Close();
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            allowClose = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Блокирует закрытие alt + f4
            }

            base.OnFormClosing(e);
        }
    }
}
