using CoursePaper.Domain;

namespace CoursePaper.Forms
{
    partial class AddCarControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxBrand = new ComboBox();
            comboBoxModel = new ComboBox();
            textBoxReleaseYear = new TextBox();
            comboBoxGearShiftBoxType = new ComboBox();
            comboBoxCondition = new ComboBox();
            textBoxPrice = new TextBox();
            labelBrand = new Label();
            labelBrandHelper = new Label();
            labelModelHelper = new Label();
            labelModel = new Label();
            labelReleaseYear = new Label();
            labelEnginePower = new Label();
            textBoxEnginePower = new TextBox();
            labelGearShiftBoxType = new Label();
            labelCondition = new Label();
            labelPrice = new Label();
            buttonSendAd = new Button();
            comboBoxCityOfSale = new ComboBox();
            labelCityHelper = new Label();
            labelCity = new Label();
            buttonGoMain = new Button();
            labelHeading = new Label();
            SuspendLayout();
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.Font = new Font("Segoe UI", 13F);
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.IntegralHeight = false;
            comboBoxBrand.Location = new Point(12, 121);
            comboBoxBrand.MaxDropDownItems = 5;
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(330, 31);
            comboBoxBrand.Sorted = true;
            comboBoxBrand.TabIndex = 0;
            comboBoxBrand.TextChanged += comboBoxBrand_SelectedValueChanged;
            // 
            // comboBoxModel
            // 
            comboBoxModel.Font = new Font("Segoe UI", 13F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.IntegralHeight = false;
            comboBoxModel.Location = new Point(388, 121);
            comboBoxModel.MaxDropDownItems = 5;
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(400, 31);
            comboBoxModel.Sorted = true;
            comboBoxModel.TabIndex = 1;
            // 
            // textBoxReleaseYear
            // 
            textBoxReleaseYear.Font = new Font("Segoe UI", 16F);
            textBoxReleaseYear.Location = new Point(688, 313);
            textBoxReleaseYear.Name = "textBoxReleaseYear";
            textBoxReleaseYear.Size = new Size(100, 36);
            textBoxReleaseYear.TabIndex = 7;
            // 
            // comboBoxGearShiftBoxType
            // 
            comboBoxGearShiftBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGearShiftBoxType.Font = new Font("Segoe UI", 13F);
            comboBoxGearShiftBoxType.FormattingEnabled = true;
            comboBoxGearShiftBoxType.Items.AddRange(new object[] { "Автомат", "Механическая" });
            comboBoxGearShiftBoxType.Location = new Point(12, 318);
            comboBoxGearShiftBoxType.Name = "comboBoxGearShiftBoxType";
            comboBoxGearShiftBoxType.Size = new Size(182, 31);
            comboBoxGearShiftBoxType.TabIndex = 5;
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Font = new Font("Segoe UI", 13F);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Items.AddRange(new object[] { "Новая", "С пробегом" });
            comboBoxCondition.Location = new Point(232, 318);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(182, 31);
            comboBoxCondition.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 16F);
            textBoxPrice.Location = new Point(201, 395);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(141, 36);
            textBoxPrice.TabIndex = 8;
            // 
            // labelBrand
            // 
            labelBrand.Font = new Font("Segoe UI", 18F);
            labelBrand.Location = new Point(12, 84);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(100, 34);
            labelBrand.TabIndex = 18;
            labelBrand.Text = "Марка";
            labelBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBrandHelper
            // 
            labelBrandHelper.Font = new Font("Segoe UI", 9F);
            labelBrandHelper.Location = new Point(132, 84);
            labelBrandHelper.Name = "labelBrandHelper";
            labelBrandHelper.Size = new Size(210, 34);
            labelBrandHelper.TabIndex = 17;
            labelBrandHelper.Text = "Выберите из существующих, или добавьте новую";
            labelBrandHelper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModelHelper
            // 
            labelModelHelper.Font = new Font("Segoe UI", 9F);
            labelModelHelper.Location = new Point(508, 84);
            labelModelHelper.Name = "labelModelHelper";
            labelModelHelper.Size = new Size(280, 34);
            labelModelHelper.TabIndex = 15;
            labelModelHelper.Text = "Выберите из существующих, или добавьте новую";
            labelModelHelper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            labelModel.Font = new Font("Segoe UI", 18F);
            labelModel.Location = new Point(388, 84);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(114, 34);
            labelModel.TabIndex = 16;
            labelModel.Text = "Модель";
            labelModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.Font = new Font("Segoe UI", 18F);
            labelReleaseYear.Location = new Point(498, 313);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(158, 34);
            labelReleaseYear.TabIndex = 14;
            labelReleaseYear.Text = "Год выпуска:";
            labelReleaseYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEnginePower
            // 
            labelEnginePower.Font = new Font("Segoe UI", 18F);
            labelEnginePower.Location = new Point(388, 201);
            labelEnginePower.Name = "labelEnginePower";
            labelEnginePower.Size = new Size(254, 34);
            labelEnginePower.TabIndex = 13;
            labelEnginePower.Text = "Мощность двигателя:";
            labelEnginePower.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEnginePower
            // 
            textBoxEnginePower.Font = new Font("Segoe UI", 16F);
            textBoxEnginePower.Location = new Point(688, 201);
            textBoxEnginePower.Name = "textBoxEnginePower";
            textBoxEnginePower.PlaceholderText = "л.с.";
            textBoxEnginePower.Size = new Size(100, 36);
            textBoxEnginePower.TabIndex = 4;
            // 
            // labelGearShiftBoxType
            // 
            labelGearShiftBoxType.Font = new Font("Segoe UI", 18F);
            labelGearShiftBoxType.Location = new Point(12, 281);
            labelGearShiftBoxType.Name = "labelGearShiftBoxType";
            labelGearShiftBoxType.Size = new Size(182, 34);
            labelGearShiftBoxType.TabIndex = 12;
            labelGearShiftBoxType.Text = "Тип коробки";
            labelGearShiftBoxType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 18F);
            labelCondition.Location = new Point(232, 281);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(182, 34);
            labelCondition.TabIndex = 11;
            labelCondition.Text = "Состояние";
            labelCondition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 18F);
            labelPrice.Location = new Point(51, 397);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(111, 34);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "Цена:";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSendAd
            // 
            buttonSendAd.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            buttonSendAd.Location = new Point(441, 384);
            buttonSendAd.Name = "buttonSendAd";
            buttonSendAd.Size = new Size(347, 52);
            buttonSendAd.TabIndex = 9;
            buttonSendAd.Text = "Разместить объявление";
            buttonSendAd.UseVisualStyleBackColor = true;
            buttonSendAd.Click += SendAd;
            // 
            // comboBoxCityOfSale
            // 
            comboBoxCityOfSale.Font = new Font("Segoe UI", 13F);
            comboBoxCityOfSale.FormattingEnabled = true;
            comboBoxCityOfSale.IntegralHeight = false;
            comboBoxCityOfSale.Location = new Point(12, 223);
            comboBoxCityOfSale.MaxDropDownItems = 5;
            comboBoxCityOfSale.Name = "comboBoxCityOfSale";
            comboBoxCityOfSale.Size = new Size(330, 31);
            comboBoxCityOfSale.Sorted = true;
            comboBoxCityOfSale.TabIndex = 3;
            // 
            // labelCityHelper
            // 
            labelCityHelper.Font = new Font("Segoe UI", 9F);
            labelCityHelper.Location = new Point(132, 186);
            labelCityHelper.Name = "labelCityHelper";
            labelCityHelper.Size = new Size(210, 34);
            labelCityHelper.TabIndex = 0;
            labelCityHelper.Text = "Выберите из существующих, или добавьте новый";
            labelCityHelper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            labelCity.Font = new Font("Segoe UI", 18F);
            labelCity.Location = new Point(12, 186);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(100, 34);
            labelCity.TabIndex = 21;
            labelCity.Text = "Город";
            labelCity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGoMain
            // 
            buttonGoMain.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonGoMain.Location = new Point(12, 21);
            buttonGoMain.Name = "buttonGoMain";
            buttonGoMain.Size = new Size(38, 36);
            buttonGoMain.TabIndex = 20;
            buttonGoMain.Text = "❮";
            buttonGoMain.UseVisualStyleBackColor = true;
            buttonGoMain.Click += buttonGoBack_Click;
            // 
            // labelHeading
            // 
            labelHeading.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHeading.Location = new Point(9, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(779, 55);
            labelHeading.TabIndex = 19;
            labelHeading.Text = "Заполните форму добавления машины";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGoMain);
            Controls.Add(labelCityHelper);
            Controls.Add(labelCity);
            Controls.Add(comboBoxCityOfSale);
            Controls.Add(buttonSendAd);
            Controls.Add(labelPrice);
            Controls.Add(labelCondition);
            Controls.Add(labelGearShiftBoxType);
            Controls.Add(labelEnginePower);
            Controls.Add(textBoxEnginePower);
            Controls.Add(labelReleaseYear);
            Controls.Add(labelModelHelper);
            Controls.Add(labelModel);
            Controls.Add(labelBrandHelper);
            Controls.Add(labelBrand);
            Controls.Add(labelHeading);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxCondition);
            Controls.Add(comboBoxGearShiftBoxType);
            Controls.Add(textBoxReleaseYear);
            Controls.Add(comboBoxModel);
            Controls.Add(comboBoxBrand);
            Name = "AddCarControl";
            Size = new Size(800, 450);
            Load += AddCarControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ComboBox comboBoxBrand;
        private ComboBox comboBoxModel;
        private TextBox textBoxReleaseYear;
        private ComboBox comboBoxGearShiftBoxType;
        private ComboBox comboBoxCondition;
        private TextBox textBoxPrice;
        private Label labelBrand;
        private Label labelBrandHelper;
        private Label labelModelHelper;
        private Label labelModel;
        private Label labelReleaseYear;
        private Label labelEnginePower;
        private TextBox textBoxEnginePower;
        private Label labelGearShiftBoxType;
        private Label labelCondition;
        private Label labelPrice;
        private Button buttonSendAd;
        private ComboBox comboBoxCityOfSale;
        private Label labelCityHelper;
        private Label labelCity;
        private Car car;
        private Button buttonGoMain;
        private Label labelHeading;
    }
}