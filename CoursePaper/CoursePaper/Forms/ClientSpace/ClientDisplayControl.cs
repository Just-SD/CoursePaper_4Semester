using CoursePaper.Domain;
using CoursePaper.Infrastructure;
using System.Globalization;
using System.Threading.Tasks;

namespace CoursePaper.Forms
{
    internal partial class ClientDisplayControl : UserControl
    {
        public event Action BackButtonClicked;
        public event Action BackToMainClicked;

        private List<Domain.Client> clients;
        private event Action InvisibleAll;
        private event Action VisibleAll;


        private NumberFormatInfo format;

        public ClientDisplayControl()
        {
            InitializeComponent();

            format = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            format.NumberGroupSeparator = " ";
        }

        private void CarDisplayControl_Load(object sender, EventArgs e)
        {
            int accountToOffset = 0;

            clients = new List<Client>();
            foreach (var client in DataBase.GetAllClients())
            {
                clients.Add(client);
                CreatePanelOnceClient(client, accountToOffset);
                accountToOffset++;
            }
        }

        private void CreatePanelOnceClient(Client client, int accountToOffset)
        {
            Panel panelOnceCar = new Panel();
            Label labelBrandName = new Label();
            Label labelModelName = new Label();
            Label labelGearShiftBoxType = new Label();
            Label labelEnginePower = new Label();
            Label labelCondition = new Label();
            Label labelReleaseYear = new Label();
            Label labelPrice = new Label();
            Label labelCityName = new Label();
            Button button1 = new Button();
            panelOnceCar.SuspendLayout();
            SuspendLayout();
            // 
            // labelBrandName
            // 
            labelBrandName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelBrandName.Location = new Point(-1, -1);
            labelBrandName.Name = "labelBrandName";
            labelBrandName.Size = new Size(249, 70);
            labelBrandName.TabIndex = 0;
            labelBrandName.Text = client.Brand.Name;
            labelBrandName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCityName
            // 
            labelCityName.Font = new Font("Segoe UI", 12F);
            labelCityName.Location = new Point(292, 93);
            labelCityName.Name = "labelBrandName";
            labelCityName.Size = new Size(221, 35);
            labelCityName.TabIndex = 0;
            labelCityName.Text = client.City.Name;
            labelCityName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModelName
            // 
            labelModelName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelModelName.Location = new Point(254, -1);
            labelModelName.Name = "labelModelName";
            labelModelName.Size = new Size(523, 70);
            labelModelName.TabIndex = 1;
            labelModelName.Text = client.Model.Name;
            labelModelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGearShiftBoxType
            // 
            labelGearShiftBoxType.Font = new Font("Segoe UI", 12F);
            labelGearShiftBoxType.Location = new Point(8, 79);
            labelGearShiftBoxType.Name = "labelGearShiftBoxType";
            labelGearShiftBoxType.Size = new Size(113, 23);
            labelGearShiftBoxType.TabIndex = 2;
            labelGearShiftBoxType.Text = client.GearShiftBoxType;
            labelGearShiftBoxType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEnginePower
            // 
            labelEnginePower.Font = new Font("Segoe UI", 12F);
            labelEnginePower.Location = new Point(157, 79);
            labelEnginePower.Name = "labelEnginePower";
            labelEnginePower.Size = new Size(120, 23);
            labelEnginePower.TabIndex = 3;
            labelEnginePower.Text = $"{client.EnginePowerRange.LowerBound} - {client.EnginePowerRange.UpperBound} л.с.";
            labelEnginePower.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(708, 88);
            button1.Name = client.Id.ToString();
            button1.Size = new Size(45, 44);
            button1.TabIndex = 4;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ShowCarDisplayControl;
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 12F);
            labelCondition.Location = new Point(8, 119);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(113, 23);
            labelCondition.TabIndex = 5;
            labelCondition.Text = client.Condition;
            labelCondition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.Font = new Font("Segoe UI", 14F);
            labelReleaseYear.Location = new Point(148, 119);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(138, 23);
            labelReleaseYear.TabIndex = 6;
            labelReleaseYear.Text = $"{client.ReleaseYearRange.LowerBound} - {client.ReleaseYearRange.UpperBound}";
            labelReleaseYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelPrice.Location = new Point(519, 84);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(158, 53);
            labelPrice.TabIndex = 7;
            labelPrice.Text = client.PriceRange.LowerBound.ToString("#,0", format) + " -\n- " +
                client.PriceRange.UpperBound.ToString("#,0", format) + " ₽";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelOnceCar
            // 
            panelOnceCar.BorderStyle = BorderStyle.FixedSingle;
            panelOnceCar.Controls.Add(labelPrice);
            panelOnceCar.Controls.Add(labelReleaseYear);
            panelOnceCar.Controls.Add(labelCondition);
            panelOnceCar.Controls.Add(button1);
            panelOnceCar.Controls.Add(labelEnginePower);
            panelOnceCar.Controls.Add(labelGearShiftBoxType);
            panelOnceCar.Controls.Add(labelModelName);
            panelOnceCar.Controls.Add(labelBrandName);
            panelOnceCar.Controls.Add(labelCityName);

            panelOnceCar.Location = new Point(3, 84 + 168 * accountToOffset);
            panelOnceCar.Name = "panelOnceCar";
            panelOnceCar.Size = new Size(778, 162);
            panelOnceCar.TabIndex = 0;

            InvisibleAll += () => panelOnceCar.Visible = false;
            VisibleAll += () => panelOnceCar.Visible = true;

            this.Controls.Add(panelOnceCar);
            ResumeLayout(false);
        }

        private async void ShowCarDisplayControl(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;
            int clientId = int.Parse(clickedButton.Name);
            Client thisClient = clients.Where(x => x.Id == clientId).First();

            List<Car> selectedCars = await GetCars(thisClient);

            InvisibleAll.Invoke();

            Panel panelCarDisplay = GetNewPanel();
            Controls.Add(panelCarDisplay);
            var control = new CarDisplayControl(selectedCars, thisClient);
            control.Dock = DockStyle.Fill;
            panelCarDisplay.BringToFront();
            panelCarDisplay.Controls.Add(control);

            control.BackToMainClicked += () =>
            {
                panelCarDisplay.Dispose();
                VisibleAll.Invoke();
                BackButtonClicked.Invoke();
            };
            control.BackButtonClicked += () =>
            {
                panelCarDisplay.Dispose();
                VisibleAll.Invoke();
            };
        }

        private async Task<List<Car>> GetCars(Client client)
        {
            List<Car> selectedCars = new List<Car>();

            DataToSelectCars data = client.ConvertToDataToSelectCars();

            var sql = data.GetFindCarsRequest();

            await foreach (var car in DataBase.GetCarsAsync(sql))
            {
                selectedCars.Add(car);
            }

            return selectedCars;
        }

        private Panel GetNewPanel()
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Name = "panelAggregator";
            panel.Size = new Size(800, 450);
            panel.TabIndex = 0;
            return panel;
        }

        private void GoToBack(object sender, EventArgs e)
        {
            BackButtonClicked.Invoke();
        }
    }
}
