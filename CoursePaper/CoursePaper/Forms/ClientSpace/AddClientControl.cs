using CoursePaper.Domain;
using CoursePaper.Forms;
using CoursePaper.Infrastructure;
using NpgsqlTypes;

namespace CoursePaper
{
    internal partial class AddClientControl : UserControl
    {
        public event Action BackToMainButtonClicked;

        public AddClientControl()
        {
            InitializeComponent();
        }

        private async void AddClientControl_Load(object sender, EventArgs e)
        {
            var brands = await DataBase.GetAllNamesFrom("brands");
            comboBoxBrand.Items.AddRange(brands);

            comboBoxGearShiftBoxType.Items.AddRange(new string[] { "Автомат", "Механическая" });

            comboBoxCondition.Items.AddRange(new string[] { "Новая", "С пробегом" });

            var cities = await DataBase.GetAllNamesFrom("citys");
            comboBoxCity.Items.AddRange(cities);
        }

        private async void comboBoxBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            var nameSelectedBrand = comboBoxBrand.SelectedItem;

            if (nameSelectedBrand == null)
            {
                return;
            }

            await FillComboBoxModel(nameSelectedBrand.ToString());
        }

        private async Task FillComboBoxModel(string nameBrand)
        {
            comboBoxModel.Items.Clear();

            int brand_id = await DataBase.GetIdToNameAsync("brands", nameBrand);

            await foreach (var nameModel in DataBase.GetSingleValuesAsync($"SELECT name FROM models WHERE brand_id = {brand_id}"))
            {
                comboBoxModel.Items.Add(nameModel);
            }

            labelModel.Enabled = true;
            comboBoxModel.Enabled = true;
        }

        private async void SendSelectRequest(object sender, EventArgs e)
        {
            client = new Domain.Client();

            try
            {
                FillBrandId(client);
                FillModelId(client);
                FillCityId(client);
                FillEnginePower(client);
                FillGearShiftBoxType(client);
                FillCondition(client);
                FillReleaseYear(client);
                FillPrice(client);
                client.AddClientInDataBase();

                this.Enabled = false;

                using (var dialog = new AddClientDialog())
                {
                    var result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                        BackToMainButtonClicked.Invoke();
                }
            }
            catch (ArgumentException argExp)
            {
                MessageBox.Show($"{argExp.Message}\nПопробуйте ещё раз.");
            }
            catch (NullReferenceException nullExp)
            {
                MessageBox.Show($"{nullExp.Message}\nПопробуйте ещё раз.");
            }
            return;
        }

        private void FillBrandId(Client client)
        {
            string name = comboBoxBrand.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не выбрано название марки.");
            }
            client.Brand = new Brand(name);
        }

        private void FillModelId(Client client)
        {
            string name = comboBoxModel.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не выбрано название модели.");
            }
            client.Model = new Model(client.Brand, name);
        }

        private void FillCityId(Client client)
        {
            string name = comboBoxCity.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не выбран город.");
            }
            client.City =new City(name);
        }

        private void FillEnginePower(Client client)
        {
            if (TryGetRange(
                textBoxLowerEnginePower.Text, textBoxUpperEnginePower.Text,
                out int lower, out int upper))
            {
                client.EnginePowerRange = new NpgsqlRange<int>(lower, true, upper, true);
            }
            else
            {
                throw new ArgumentException("Получено неверное значение мощности двигателя автомобиля.");
            }
        }

        private void FillReleaseYear(Client client)
        {
            if (TryGetRange(
                textBoxLowerReleaseYear.Text, textBoxUpperReleaseYear.Text,
                out int lower, out int upper))
            {
                client.ReleaseYearRange = new NpgsqlRange<int>(lower, true, upper, true);
            }
            else
            {
                throw new ArgumentException("Получено неверное значение года выпуска автомобиля.");
            }
        }

        private void FillPrice(Client client)
        {
            if (TryGetRange(
                textBoxLowerPrice.Text, textBoxUpperPrice.Text,
                out int lower, out int upper))
            {
                client.PriceRange = new NpgsqlRange<int>(lower, true, upper, true);
            }
            else
            {
                throw new ArgumentException("Получено неверное значение цены автомобиля.");
            }
        }

        private void FillGearShiftBoxType(Client client)
        {
            var gearShiftBoxType = comboBoxGearShiftBoxType.SelectedItem;
            if (gearShiftBoxType == null)
                throw new ArgumentException("Не выбран тип коробки автомобиля.");
            client.GearShiftBoxType = gearShiftBoxType.ToString();
        }

        private void FillCondition(Client client)
        {
            var condition = comboBoxCondition.SelectedItem;
            if (condition == null)
                throw new ArgumentException("Не выбрано состояние автомобиля.");
            client.Condition = condition.ToString();
        }

        private bool TryGetRange(string lowerLimit, string upperLimit, out int intLowerLimit, out int intUpperLimit)
        {
            if (int.TryParse(lowerLimit, out int i))
                intLowerLimit = i;
            else
            {
                intLowerLimit = 0;
                intUpperLimit = 0;
                return false;
            }

            if (int.TryParse(upperLimit, out int j) && !(intLowerLimit > j))
                intUpperLimit = j;
            else
            {
                intLowerLimit = 0;
                intUpperLimit = 0;
                return false;
            }

            return true;
        }

        private void GoToMain(object sender, EventArgs e)
        {
            BackToMainButtonClicked.Invoke();
        }
    }
}
