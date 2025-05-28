using CoursePaper.Domain;
using System.Globalization;

namespace CoursePaper.Forms
{
    internal partial class CarDisplayControl : UserControl
    {
        public event Action BackButtonClicked;
        public event Action BackToMainClicked;
        private List<Domain.Car> cars;
        private NumberFormatInfo format;
        private Client client;

        public CarDisplayControl(List<Domain.Car> cars)
        {
            InitializeComponent();

            this.cars = cars;
            format = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            format.NumberGroupSeparator = " ";
        }

        public CarDisplayControl(List<Domain.Car> cars, Client client)
        {
            InitializeComponent();

            this.client = client;

            this.cars = cars;
            format = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            format.NumberGroupSeparator = " ";
        }

        private void CarDisplayControl_Load(object sender, EventArgs e)
        {
            int accountToOffset = 0;

            foreach (var car in cars)
            {
                CreatePanelOnceCar(car, accountToOffset);
                accountToOffset++;
            }
        }

        private void CreatePanelOnceCar(Car car, int accountToOffset)
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
            labelBrandName.Text = car.Brand.Name;
            labelBrandName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCityName
            // 
            labelCityName.Font = new Font("Segoe UI", 12F);
            labelCityName.Location = new Point(250, 95);
            labelCityName.Name = "labelBrandName";
            labelCityName.Size = new Size(170, 35);
            labelCityName.TabIndex = 0;
            labelCityName.Text = car.CityOfSale.Name;
            labelCityName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModelName
            // 
            labelModelName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelModelName.Location = new Point(254, -1);
            labelModelName.Name = "labelModelName";
            labelModelName.Size = new Size(523, 70);
            labelModelName.TabIndex = 1;
            labelModelName.Text = car.Model.Name;
            labelModelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGearShiftBoxType
            // 
            labelGearShiftBoxType.Font = new Font("Segoe UI", 12F);
            labelGearShiftBoxType.Location = new Point(8, 79);
            labelGearShiftBoxType.Name = "labelGearShiftBoxType";
            labelGearShiftBoxType.Size = new Size(113, 23);
            labelGearShiftBoxType.TabIndex = 2;
            labelGearShiftBoxType.Text = car.GearShiftBoxType;
            labelGearShiftBoxType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEnginePower
            // 
            labelEnginePower.Font = new Font("Segoe UI", 12F);
            labelEnginePower.Location = new Point(148, 79);
            labelEnginePower.Name = "labelEnginePower";
            labelEnginePower.Size = new Size(100, 23);
            labelEnginePower.TabIndex = 3;
            labelEnginePower.Text = $"{car.EnginePower} л.с.";
            labelEnginePower.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(611, 89);
            button1.Name = car.Id.ToString();
            button1.Size = new Size(114, 44);
            button1.TabIndex = 4;
            button1.Text = "Купить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ByCarButton;
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 12F);
            labelCondition.Location = new Point(8, 119);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(113, 23);
            labelCondition.TabIndex = 5;
            labelCondition.Text = car.Condition;
            labelCondition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.Font = new Font("Segoe UI", 14F);
            labelReleaseYear.Location = new Point(148, 119);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(100, 23);
            labelReleaseYear.TabIndex = 6;
            labelReleaseYear.Text = car.ReleaseYear.ToString();
            labelReleaseYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelPrice.Location = new Point(426, 89);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(160, 44);
            labelPrice.TabIndex = 7;
            labelPrice.Text = car.Price.ToString("#,0", format) + " ₽";
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
            this.Controls.Add(panelOnceCar);
            ResumeLayout(false);
        }

        private void ByCarButton(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null)
                return;
            int idCar = int.Parse(clickedButton.Name);
            this.Enabled = false;

            Car thisCar = cars.Where(x => x.Id == idCar).First();

            using (var dialog = new PurchaseConfirmationDialog(
                thisCar.Brand.Name,
                thisCar.Model.Name,
                thisCar.Price.ToString("#,0", format) + " ₽"))
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    DataBase.UnRelevantCar(idCar);
                    thisCar.IsRelevant = false;
                    if (client == null)
                    {
                        clickedButton.Enabled = false;
                        this.Enabled = true;
                    }
                    else
                        ReturnToMain();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Enabled = true;
                }
            }
        }

        private void GoToBack(object sender, EventArgs e)
        {
            BackButtonClicked.Invoke();
        }

        private void ReturnToMain()
        {
            DataBase.UnRelevantClient(client.Id);
            client.IsRelevant = false;
            using (var dialog = new CongratulationDialog())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BackToMainClicked.Invoke();
                }
            }
        }
    }
}
