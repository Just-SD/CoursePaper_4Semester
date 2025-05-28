using CoursePaper.Forms;
using CoursePaper.Infrastructure;

namespace CoursePaper
{
    internal partial class AggregatorControl : UserControl
    {
        private Label labelBrand;
        private Label labelModel;
        private ComboBox comboBoxBrand;
        private CheckedListBox checkedListBoxModel;
        private Button applyBrand;
        private Button clearForm;

        private Label labelReleaseYear;
        private TextBox textBoxLowerReleaseYear;
        private TextBox textBoxUpperReleaseYear;

        private Label labelEnginePower;
        private TextBox textBoxLowerEnginePower;
        private TextBox textBoxUpperEnginePower;

        private Label labelGearShiftBoxType;
        private ComboBox comboBoxGearShiftBoxType;

        private Label labelCondition;
        private ComboBox comboBoxCondition;

        private Label labelPrice;
        private TextBox textBoxLowerPrice;
        private TextBox textBoxUpperPrice;

        private Label labelCity;
        private ComboBox comboBoxCity;

        private DataToSelectCars requestData;

        private bool correctData = true;
        public event Action BackButtonClicked;
        private List<Domain.Car> selectedCars;


        public AggregatorControl()
        {
            InitializeComponent();

            requestData = new DataToSelectCars();
        }

        private async void ChoiceForm_Load(object sender, EventArgs e)
        {
            // 
            // labelBrand
            // 
            labelBrand = new Label();
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 25F);
            labelBrand.Location = new Point(48, 50);
            labelBrand.Name = "label1";
            labelBrand.Size = new Size(122, 46);
            labelBrand.TabIndex = 3;
            labelBrand.Text = "Марка";
            this.Controls.Add(labelBrand);
            // 
            // comboBoxBrand
            // 
            comboBoxBrand = new ComboBox();
            //comboBoxBrand.CheckOnClick = true;
            comboBoxBrand.Font = new Font("Segoe UI", 12F);
            comboBoxBrand.FormattingEnabled = true;
            var brands = await DataBase.GetAllNamesFrom("brands");
            comboBoxBrand.Items.AddRange(brands);
            comboBoxBrand.Location = new Point(48, 99);
            comboBoxBrand.Name = "checkedListBox1";
            comboBoxBrand.Size = new Size(270, 0);
            comboBoxBrand.IntegralHeight = false;
            comboBoxBrand.MaxDropDownItems = 8;
            comboBoxBrand.TabIndex = 2;
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrand.SelectedIndexChanged += comboBox1_SelectedValueChanged;
            comboBoxBrand.Sorted = true;
            this.Controls.Add(comboBoxBrand);
            // 
            // labelModel
            // 
            labelModel = new Label();
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 25F);
            labelModel.Location = new Point(366, 50);
            labelModel.Name = "label1";
            labelModel.Size = new Size(122, 46);
            labelModel.TabIndex = 3;
            labelModel.Text = "Модель";
            labelModel.Enabled = false;
            this.Controls.Add(labelModel);
            // 
            // checkedListBoxModel
            // 
            this.checkedListBoxModel = new CheckedListBox();
            checkedListBoxModel.CheckOnClick = true;
            checkedListBoxModel.Font = new Font("Segoe UI", 12F);
            checkedListBoxModel.FormattingEnabled = true;
            checkedListBoxModel.Location = new Point(366, 99);
            checkedListBoxModel.Name = "checkedListBox1";
            checkedListBoxModel.Size = new Size(370, 100);
            checkedListBoxModel.TabIndex = 2;
            checkedListBoxModel.Enabled = false;
            checkedListBoxModel.Sorted = true;
            this.Controls.Add(checkedListBoxModel);
            // 
            // labelReleaseYear
            // 
            labelReleaseYear = new Label();
            labelReleaseYear.AutoSize = true;
            labelReleaseYear.Font = new Font("Segoe UI", 12F);
            labelReleaseYear.Location = new Point(48, 169);
            labelReleaseYear.Name = "label2";
            labelReleaseYear.Size = new Size(102, 21);
            labelReleaseYear.TabIndex = 4;
            labelReleaseYear.Text = "Год выпуска:";
            this.Controls.Add(labelReleaseYear);
            // 
            // textBoxLowerReleaseYear
            // 
            textBoxLowerReleaseYear = new TextBox();
            textBoxLowerReleaseYear.Font = new Font("Segoe UI", 15F);
            textBoxLowerReleaseYear.Location = new Point(172, 160);
            textBoxLowerReleaseYear.Multiline = true;
            textBoxLowerReleaseYear.Name = "textBox1";
            textBoxLowerReleaseYear.PlaceholderText = "От";
            textBoxLowerReleaseYear.Size = new Size(60, 39);
            textBoxLowerReleaseYear.TabIndex = 5;
            this.Controls.Add(textBoxLowerReleaseYear);
            // 
            // textBoxUpperReleaseYear
            // 
            textBoxUpperReleaseYear = new TextBox();
            textBoxUpperReleaseYear.Font = new Font("Segoe UI", 15F);
            textBoxUpperReleaseYear.Location = new Point(258, 160);
            textBoxUpperReleaseYear.Multiline = true;
            textBoxUpperReleaseYear.Name = "textBox2";
            textBoxUpperReleaseYear.PlaceholderText = "До";
            textBoxUpperReleaseYear.Size = new Size(60, 39);
            textBoxUpperReleaseYear.TabIndex = 6;
            this.Controls.Add(textBoxUpperReleaseYear);
            // 
            // labelEnginePower
            // 
            labelEnginePower = new Label();
            labelEnginePower.AutoSize = true;
            labelEnginePower.Font = new Font("Segoe UI", 14F);
            labelEnginePower.Location = new Point(88, 244);
            labelEnginePower.Name = "label3";
            labelEnginePower.Size = new Size(200, 25);
            labelEnginePower.TabIndex = 7;
            labelEnginePower.Text = "Мощность двигателя:";
            this.Controls.Add(labelEnginePower);
            // 
            // textBoxLowerEnginePower
            // 
            textBoxLowerEnginePower = new TextBox();
            textBoxLowerEnginePower.Font = new Font("Segoe UI", 15F);
            textBoxLowerEnginePower.Location = new Point(106, 286);
            textBoxLowerEnginePower.Multiline = true;
            textBoxLowerEnginePower.Name = "textBox3";
            textBoxLowerEnginePower.PlaceholderText = "От";
            textBoxLowerEnginePower.Size = new Size(60, 39);
            textBoxLowerEnginePower.TabIndex = 8;
            this.Controls.Add(textBoxLowerEnginePower);
            // 
            // textBoxUpperEnginePower
            // 
            textBoxUpperEnginePower = new TextBox();
            textBoxUpperEnginePower.Font = new Font("Segoe UI", 15F);
            textBoxUpperEnginePower.Location = new Point(207, 286);
            textBoxUpperEnginePower.Multiline = true;
            textBoxUpperEnginePower.Name = "textBox4";
            textBoxUpperEnginePower.PlaceholderText = "До";
            textBoxUpperEnginePower.Size = new Size(60, 39);
            textBoxUpperEnginePower.TabIndex = 9;
            this.Controls.Add(textBoxUpperEnginePower);
            // 
            // labelGearShiftBoxType
            // 
            labelGearShiftBoxType = new Label();
            labelGearShiftBoxType.AutoSize = true;
            labelGearShiftBoxType.Font = new Font("Segoe UI", 17F);
            labelGearShiftBoxType.Location = new Point(366, 244);
            labelGearShiftBoxType.Name = "labelGearShiftBoxType";
            labelGearShiftBoxType.Size = new Size(146, 31);
            labelGearShiftBoxType.TabIndex = 11;
            labelGearShiftBoxType.Text = "Тип коробки";
            this.Controls.Add(labelGearShiftBoxType);
            // 
            // comboBoxGearShiftBoxType
            // 
            comboBoxGearShiftBoxType = new ComboBox();
            comboBoxGearShiftBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGearShiftBoxType.Items.AddRange(new string[] { "Автомат", "Механическая" });
            comboBoxGearShiftBoxType.Font = new Font("Segoe UI", 12F);
            comboBoxGearShiftBoxType.FormattingEnabled = true;
            comboBoxGearShiftBoxType.Location = new Point(366, 286);
            comboBoxGearShiftBoxType.Name = "comboBoxGearShiftBoxType";
            comboBoxGearShiftBoxType.Size = new Size(172, 29);
            comboBoxGearShiftBoxType.TabIndex = 10;
            this.Controls.Add(comboBoxGearShiftBoxType);
            // 
            // labelCondition
            // 
            labelCondition = new Label();
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 17F);
            labelCondition.Location = new Point(564, 244);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(124, 31);
            labelCondition.TabIndex = 13;
            labelCondition.Text = "Состояние";
            this.Controls.Add(labelCondition);
            // 
            // comboBoxCondition
            // 
            comboBoxCondition = new ComboBox();
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Items.AddRange(new string[] { "Новая", "С пробегом" });
            comboBoxCondition.Font = new Font("Segoe UI", 12F);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(564, 286);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(172, 29);
            comboBoxCondition.TabIndex = 12;
            this.Controls.Add(comboBoxCondition);
            // 
            // labelPrice
            // 
            labelPrice = new Label();
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 25F);
            labelPrice.Location = new Point(48, 373);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(107, 46);
            labelPrice.TabIndex = 14;
            labelPrice.Text = "Цена:";
            this.Controls.Add(labelPrice);
            // 
            // textBoxLowerPrice
            // 
            textBoxLowerPrice = new TextBox();
            textBoxLowerPrice.Font = new Font("Segoe UI", 15F);
            textBoxLowerPrice.Location = new Point(157, 380);
            textBoxLowerPrice.Multiline = true;
            textBoxLowerPrice.Name = "textBoxLowerPrice";
            textBoxLowerPrice.PlaceholderText = "От";
            textBoxLowerPrice.Size = new Size(131, 39);
            textBoxLowerPrice.TabIndex = 15;
            this.Controls.Add(textBoxLowerPrice);
            // 
            // textBoxUpperPrice
            // 
            textBoxUpperPrice = new TextBox();
            textBoxUpperPrice.Font = new Font("Segoe UI", 15F);
            textBoxUpperPrice.Location = new Point(308, 380);
            textBoxUpperPrice.Multiline = true;
            textBoxUpperPrice.Name = "textBoxUpperPrice";
            textBoxUpperPrice.PlaceholderText = "До";
            textBoxUpperPrice.Size = new Size(131, 39);
            textBoxUpperPrice.TabIndex = 17;
            this.Controls.Add(textBoxUpperPrice);
            // 
            // labelCity
            // 
            labelCity = new Label();
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 15F);
            labelCity.Location = new Point(538, 13);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(72, 28);
            labelCity.TabIndex = 19;
            labelCity.Text = "Город:";
            this.Controls.Add(labelCity);
            // 
            // comboBoxCity
            // 
            comboBoxCity = new ComboBox();
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Font = new Font("Segoe UI", 12F);
            var cities = await DataBase.GetAllNamesFrom("citys");
            comboBoxCity.Items.AddRange(cities);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.IntegralHeight = false;
            comboBoxCity.MaxDropDownItems = 8;
            comboBoxCity.Sorted = true;
            comboBoxCity.Location = new Point(616, 12);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(172, 29);
            comboBoxCity.TabIndex = 18;
            this.Controls.Add(comboBoxCity);
            //
            // applyBrand
            //
            applyBrand = new Button();
            applyBrand.Font = new Font("Segoe UI", 17F);
            applyBrand.Location = new Point(466, 375);
            applyBrand.Name = "button1";
            applyBrand.Size = new Size(179, 49);
            applyBrand.TabIndex = 0;
            applyBrand.Text = "Показать";
            applyBrand.Click += SendSelectRequest;
            this.Controls.Add(applyBrand);
            //
            // clearForm
            //
            clearForm = new Button();
            clearForm.Font = new Font("Segoe UI", 13F);
            clearForm.Location = new Point(680, 375);
            clearForm.Name = "button2";
            clearForm.Size = new Size(108, 49);
            clearForm.TabIndex = 0;
            clearForm.Text = "Очистить";
            clearForm.Click += ClearForm;
            this.Controls.Add(clearForm);
        }

        private async void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxBrand.SelectedItem == null)
            {
                requestData.BrandId = null;
                return;
            }

            string nameSelectedBrand = comboBoxBrand.SelectedItem.ToString();
            requestData.BrandId = await DataBase.GetIdToNameAsync("brands", nameSelectedBrand);
            await FillChoiceModelCheckedListBox();
        }

        private async void SendSelectRequest(object sender, EventArgs e)
        {
            correctData = true;

            await GetSelectedModels();
            await comboBoxCity_SelectedValueChanged();
            await GetReleaseYear();
            await GetEnginePower();
            await GetPrice();
            await GetCondition();
            await GetGearShiftBoxTypeAsync();

            if (!correctData)
            {
                MessageBox.Show("Введены некорректные данные.\nИзмените значения и попробуйте ещё раз.");
                return;
            }

            string requestToSelectCar = requestData.GetFindCarsRequest();

            selectedCars = new List<Domain.Car>();
            await foreach (var car in DataBase.GetCarsAsync(requestToSelectCar))
            {
                selectedCars.Add(car);
            }

            this.Enabled = false;

            using (var dialog = new FoundCarsDialog(selectedCars.Count))
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.Yes && dialog.ShowResults)
                {
                    this.Enabled = true;
                    ShowCarDisplayControl();
                }
                else if (result == DialogResult.TryAgain && !dialog.ShowResults)
                {
                    this.Enabled = true;
                }
            }
        }

        private async Task FillChoiceModelCheckedListBox()
        {
            checkedListBoxModel.Items.Clear();

            await foreach (var nameModel in DataBase.GetSingleValuesAsync($"SELECT name FROM models WHERE brand_id = {requestData.BrandId}"))
            {
                checkedListBoxModel.Items.Add(nameModel);
            }

            labelModel.Enabled = true;
            checkedListBoxModel.Enabled = true;
        }

        private async Task comboBoxCity_SelectedValueChanged()
        {
            var nameSelectedCity = comboBoxCity.SelectedItem;

            if (nameSelectedCity == null)
            {
                requestData.CityOfSaleId = null;
                return;
            }

            int result = await DataBase.GetIdToNameAsync("citys", nameSelectedCity.ToString());
            requestData.CityOfSaleId = result;
        }

        private async Task GetSelectedModels()
        {
            List<int> idSelectedModels = new List<int>();

            foreach (var name in checkedListBoxModel.CheckedItems)
            {
                int result = await DataBase.GetIdToNameAsync("models", name.ToString());
                idSelectedModels.Add(result);
            }

            requestData.ModelsId = idSelectedModels;
        }

        private async Task GetReleaseYear()
        {
            if (!correctData)
                return;

            if (TryGetRange(
                textBoxLowerReleaseYear.Text, textBoxUpperReleaseYear.Text,
                out int? intLowerYear, out int? intUpperYear))
            {
                requestData.ReleaseYear = (intLowerYear, intUpperYear);
            }
            else
            {
                correctData = false;
            }
        }

        private async Task GetEnginePower()
        {
            if (!correctData)
                return;

            if (TryGetRange(
                textBoxLowerEnginePower.Text, textBoxUpperEnginePower.Text,
                out int? intLowerEnginePower, out int? intUpperEnginePower))
            {
                requestData.EnginePower = (intLowerEnginePower, intUpperEnginePower);
            }
            else
            {
                correctData = false;
            }
        }

        private async Task GetPrice()
        {
            if (!correctData)
                return;

            if (TryGetRange(
                textBoxLowerPrice.Text, textBoxUpperPrice.Text,
                out int? intLowerPrice, out int? intUpperPrice))
            {
                requestData.Price = (intLowerPrice, intUpperPrice);
            }
            else
            {
                correctData = false;
            }
        }

        private async Task GetCondition()
        {
            var condition = comboBoxCondition.SelectedItem;
            if (condition != null)
                requestData.Condition = condition.ToString();
            else
                requestData.Condition = null;
        }

        private async Task GetGearShiftBoxTypeAsync()
        {
            var type = comboBoxGearShiftBoxType.SelectedItem;
            if (type != null)
                requestData.GearShiftBoxType = type.ToString();
            else
                requestData.GearShiftBoxType = null;
        }

        private bool TryGetRange(string lowerLimit, string upperLimit, out int? intLowerLimit, out int? intUpperLimit)
        {
            if (lowerLimit == "")
                intLowerLimit = null;
            else if (int.TryParse(lowerLimit, out int i))
                intLowerLimit = i;
            else
            {
                intLowerLimit = null;
                intUpperLimit = null;
                return false;
            }

            if (upperLimit == "")
                intUpperLimit = null;
            else if (int.TryParse(upperLimit, out int i) && !(intLowerLimit > i))
                intUpperLimit = i;
            else
            {
                intLowerLimit = null;
                intUpperLimit = null;
                return false;
            }

            return true;
        }

        private void ClearForm(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedItem = null;
            checkedListBoxModel.Items.Clear();
            textBoxLowerReleaseYear.Text = string.Empty;
            textBoxUpperReleaseYear.Text = string.Empty;
            textBoxLowerEnginePower.Text = string.Empty;
            textBoxUpperEnginePower.Text = string.Empty;
            comboBoxGearShiftBoxType.SelectedItem = null;
            comboBoxCondition.SelectedItem = null;
            textBoxLowerPrice.Text = string.Empty;
            textBoxUpperPrice.Text = string.Empty;
            comboBoxCity.SelectedItem = null;

            labelModel.Enabled = false;
            checkedListBoxModel.Enabled = false;
        }

        private void ShowCarDisplayControl()
        {
            InvisibleAll();

            Panel panelAggregator = GetNewPanel();
            Controls.Add(panelAggregator);
            var control = new CarDisplayControl(selectedCars);
            control.Dock = DockStyle.Fill;
            panelAggregator.BringToFront();
            panelAggregator.Controls.Add(control);

            control.BackButtonClicked += () =>
            {
                panelAggregator.Dispose();
                VisibleAll();
            };
        }

        private void InvisibleAll()
        {
            buttonGoMain.Visible = false;
            labelBrand.Visible = false;
            labelModel.Visible = false;
            comboBoxBrand.Visible = false;
            checkedListBoxModel.Visible = false;
            applyBrand.Visible = false;
            clearForm.Visible = false;
            labelReleaseYear.Visible = false;
            textBoxLowerReleaseYear.Visible = false;
            textBoxUpperReleaseYear.Visible = false;
            labelEnginePower.Visible = false;
            textBoxLowerEnginePower.Visible = false;
            textBoxUpperEnginePower.Visible = false;
            labelGearShiftBoxType.Visible = false;
            comboBoxGearShiftBoxType.Visible = false;
            labelCondition.Visible = false;
            comboBoxCondition.Visible = false;
            labelPrice.Visible = false;
            textBoxLowerPrice.Visible = false;
            textBoxUpperPrice.Visible = false;
            labelCity.Visible = false;
            comboBoxCity.Visible = false;
        }

        private void VisibleAll()
        {
            buttonGoMain.Visible = true;
            labelBrand.Visible = true;
            labelModel.Visible = true;
            comboBoxBrand.Visible = true;
            checkedListBoxModel.Visible = true;
            applyBrand.Visible = true;
            clearForm.Visible = true;
            labelReleaseYear.Visible = true;
            textBoxLowerReleaseYear.Visible = true;
            textBoxUpperReleaseYear.Visible = true;
            labelEnginePower.Visible = true;
            textBoxLowerEnginePower.Visible = true;
            textBoxUpperEnginePower.Visible = true;
            labelGearShiftBoxType.Visible = true;
            comboBoxGearShiftBoxType.Visible = true;
            labelCondition.Visible = true;
            comboBoxCondition.Visible = true;
            labelPrice.Visible = true;
            textBoxLowerPrice.Visible = true;
            textBoxUpperPrice.Visible = true;
            labelCity.Visible = true;
            comboBoxCity.Visible = true;
        }

        private Panel GetNewPanel()
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 450);
            panel.TabIndex = 0;
            return panel;
        }

        private void GoToMain(object sender, EventArgs e)
        {
            BackButtonClicked.Invoke();
        }
    }
}
