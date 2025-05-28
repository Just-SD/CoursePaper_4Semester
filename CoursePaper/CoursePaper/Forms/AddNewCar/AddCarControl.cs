using CoursePaper.Domain;
using CoursePaper.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursePaper.Forms
{
    internal partial class AddCarControl : UserControl
    {
        private bool isModelLoading = false;
        public event Action BackButtonClicked;

        public AddCarControl()
        {
            InitializeComponent();
        }

        private async void AddCarControl_Load(object sender, EventArgs e)
        {
            var brands = await DataBase.GetAllNamesFrom("brands");
            comboBoxBrand.Items.AddRange(brands);

            var citys = await DataBase.GetAllNamesFrom("citys");
            comboBoxCityOfSale.Items.AddRange(citys);
        }

        private async void comboBoxBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!comboBoxBrand.Items.Contains(comboBoxBrand.Text))
            {
                comboBoxModel.Items.Clear();
                return;
            }

            string nameSelectedBrand = comboBoxBrand.Text;

            await FillComboBoxModel(nameSelectedBrand);
        }

        private async Task FillComboBoxModel(string brandName)
        {
            isModelLoading = true;

            int brand_id = await DataBase.GetIdToNameAsync("brands", brandName);

            comboBoxModel.Items.Clear();

            await foreach (var nameModel in DataBase.GetSingleValuesAsync($"SELECT name FROM models WHERE brand_id = {brand_id}"))
            {
                comboBoxModel.Items.Add(nameModel);
            }

            isModelLoading = false;
        }

        private void SendAd(object sender, EventArgs e)
        {
            if (isModelLoading)
            {
                MessageBox.Show("Подождите, пока загружаются модели.");
                return;
            }

            car = new Domain.Car();

            try
            {
                FillBrand(car);
                FillModel(car);
                FillCityOfSale(car);
                FillEnginePower(car);
                FillGearShiftBoxType(car);
                FillCondition(car);
                FillReleaseYear(car);
                FillPrice(car);
                car.AddCarInDataBase();



                this.Enabled = false;

                using (var dialog = new AddCarDialog())
                {
                    var result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                        BackButtonClicked.Invoke();
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

        private void FillBrand(Car car)
        {
            string name = comboBoxBrand.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не введено название марки.");
            }
            car.Brand = new Brand(name);
        }

        private void FillModel(Car car)
        {
            string name = comboBoxModel.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не введено название модели.");
            }
            car.Model = new Model(car.Brand, name);
        }

        private void FillReleaseYear(Car car)
        {
            if (int.TryParse(textBoxReleaseYear.Text, out int year))
            {
                car.ReleaseYear = year;
            }
            else
            {
                throw new ArgumentException("Получено неверное значение года выпуска.");
            }
        }

        private void FillEnginePower(Car car)
        {
            if (int.TryParse(textBoxEnginePower.Text, out int year))
            {
                car.EnginePower = year;
            }
            else
            {
                throw new ArgumentException("Получено неверное значение мощности двигателя автомобиля.");
            }
        }

        private void FillGearShiftBoxType(Car car)
        {
            var gearShiftBoxType = comboBoxGearShiftBoxType.SelectedItem;
            if (gearShiftBoxType == null)
                throw new ArgumentException("Не выбран тип коробки автомобиля.");
            car.GearShiftBoxType = gearShiftBoxType.ToString();
        }

        private void FillCondition(Car car)
        {
            var condition = comboBoxCondition.SelectedItem;
            if (condition == null)
                throw new ArgumentException("Не выбрано состояние автомобиля.");
            car.Condition = condition.ToString();
        }

        private void FillPrice(Car car)
        {
            if (int.TryParse(textBoxPrice.Text, out int price))
            {
                car.Price = price;
            }
            else
            {
                throw new ArgumentException("Получено неверное значение цены автомобиля.");
            }
        }

        private void FillCityOfSale(Car car)
        {
            string name = comboBoxCityOfSale.Text;

            if (name.Length == 0)
            {
                throw new ArgumentException("Не введено название города.");
            }
            car.CityOfSale = new City(name);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked.Invoke();
        }
    }
}