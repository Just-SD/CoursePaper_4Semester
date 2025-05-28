namespace CoursePaper.Forms
{
    internal partial class FoundCarsDialog: Form
    {
        public bool ShowResults { get; private set; }
        private bool allowClose = false;

        public FoundCarsDialog(int carCount)
        {
            InitializeComponent();
            label1.Text = $"По вашему запросу найдено {carCount} автомобилей.";
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            ShowResults = false;
            this.DialogResult = DialogResult.TryAgain;
            allowClose = true;
            this.Close();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            ShowResults = true;
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
