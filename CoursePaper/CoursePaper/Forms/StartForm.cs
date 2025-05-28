using CoursePaper.Forms;

namespace CoursePaper
{
    internal partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ShowAggregatorControl(object? sender, EventArgs e)
        {
            labelHeading.Visible = false;
            buttonAddCar.Visible = false;
            buttonOpenAggregator.Visible = false;
            buttonOpenClient.Visible = false;

            panelMain.Controls.Clear();
            var control = new AggregatorControl();
            control.Dock = DockStyle.Fill;

            control.BackButtonClicked += () =>
            {
                panelMain.Controls.Clear();

                labelHeading.Visible = true;
                buttonAddCar.Visible = true;
                buttonOpenAggregator.Visible = true;
                buttonOpenClient.Visible = true;
            };

            panelMain.Controls.Add(control);
        }

        private void ShowAddCarControl(object? sender, EventArgs e)
        {
            labelHeading.Visible = false;
            buttonAddCar.Visible = false;
            buttonOpenAggregator.Visible = false;
            buttonOpenClient.Visible = false;

            panelMain.Controls.Clear();
            var control = new AddCarControl();
            control.Dock = DockStyle.Fill;

            control.BackButtonClicked += () =>
            { 
                panelMain.Controls.Clear();

                labelHeading.Visible = true;
                buttonAddCar.Visible = true;
                buttonOpenAggregator.Visible = true;
                buttonOpenClient.Visible = true;
            };

            panelMain.Controls.Add(control);
        }

        private void ShowClientControl(object? sender, EventArgs e)
        {
            labelHeading.Visible = false;
            buttonAddCar.Visible = false;
            buttonOpenAggregator.Visible = false;
            buttonOpenClient.Visible = false;

            panelMain.Controls.Clear();
            var control = new ClientSpaceMenuControl();
            control.Dock = DockStyle.Fill;

            control.BackButtonClicked += () =>
            {
                panelMain.Controls.Clear();

                labelHeading.Visible = true;
                buttonAddCar.Visible = true;
                buttonOpenAggregator.Visible = true;
                buttonOpenClient.Visible = true;
            };

            panelMain.Controls.Add(control);
        }
    }
}
