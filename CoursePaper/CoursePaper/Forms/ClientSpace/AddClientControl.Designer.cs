using CoursePaper.Domain;

namespace CoursePaper
{
    partial class AddClientControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGoMain = new Button();
            labelBrand = new Label();
            comboBoxBrand = new ComboBox();
            labelModel = new Label();
            labelReleaseYear = new Label();
            textBoxLowerReleaseYear = new TextBox();
            textBoxUpperReleaseYear = new TextBox();
            labelEnginePower = new Label();
            textBoxLowerEnginePower = new TextBox();
            textBoxUpperEnginePower = new TextBox();
            labelGearShiftBoxType = new Label();
            comboBoxGearShiftBoxType = new ComboBox();
            labelCondition = new Label();
            comboBoxCondition = new ComboBox();
            labelPrice = new Label();
            textBoxLowerPrice = new TextBox();
            textBoxUpperPrice = new TextBox();
            labelCity = new Label();
            comboBoxCity = new ComboBox();
            buttonSendAd = new Button();
            comboBoxModel = new ComboBox();
            labelHeding = new Label();
            SuspendLayout();
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
            buttonGoMain.Click += GoToMain;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 25F);
            labelBrand.Location = new Point(56, 50);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(122, 46);
            labelBrand.TabIndex = 3;
            labelBrand.Text = "Марка";
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBrand.Font = new Font("Segoe UI", 12F);
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.IntegralHeight = false;
            comboBoxBrand.Location = new Point(48, 99);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(270, 29);
            comboBoxBrand.Sorted = true;
            comboBoxBrand.TabIndex = 2;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedValueChanged;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Enabled = false;
            labelModel.Font = new Font("Segoe UI", 25F);
            labelModel.Location = new Point(366, 50);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(143, 46);
            labelModel.TabIndex = 3;
            labelModel.Text = "Модель";
            // 
            // labelReleaseYear
            // 
            labelReleaseYear.AutoSize = true;
            labelReleaseYear.Font = new Font("Segoe UI", 12F);
            labelReleaseYear.Location = new Point(48, 169);
            labelReleaseYear.Name = "labelReleaseYear";
            labelReleaseYear.Size = new Size(102, 21);
            labelReleaseYear.TabIndex = 4;
            labelReleaseYear.Text = "Год выпуска:";
            // 
            // textBoxLowerReleaseYear
            // 
            textBoxLowerReleaseYear.Font = new Font("Segoe UI", 15F);
            textBoxLowerReleaseYear.Location = new Point(172, 160);
            textBoxLowerReleaseYear.Multiline = true;
            textBoxLowerReleaseYear.Name = "textBoxLowerReleaseYear";
            textBoxLowerReleaseYear.PlaceholderText = "От";
            textBoxLowerReleaseYear.Size = new Size(60, 39);
            textBoxLowerReleaseYear.TabIndex = 5;
            // 
            // textBoxUpperReleaseYear
            // 
            textBoxUpperReleaseYear.Font = new Font("Segoe UI", 15F);
            textBoxUpperReleaseYear.Location = new Point(258, 160);
            textBoxUpperReleaseYear.Multiline = true;
            textBoxUpperReleaseYear.Name = "textBoxUpperReleaseYear";
            textBoxUpperReleaseYear.PlaceholderText = "До";
            textBoxUpperReleaseYear.Size = new Size(60, 39);
            textBoxUpperReleaseYear.TabIndex = 6;
            // 
            // labelEnginePower
            // 
            labelEnginePower.AutoSize = true;
            labelEnginePower.Font = new Font("Segoe UI", 14F);
            labelEnginePower.Location = new Point(88, 244);
            labelEnginePower.Name = "labelEnginePower";
            labelEnginePower.Size = new Size(200, 25);
            labelEnginePower.TabIndex = 7;
            labelEnginePower.Text = "Мощность двигателя:";
            // 
            // textBoxLowerEnginePower
            // 
            textBoxLowerEnginePower.Font = new Font("Segoe UI", 15F);
            textBoxLowerEnginePower.Location = new Point(106, 286);
            textBoxLowerEnginePower.Multiline = true;
            textBoxLowerEnginePower.Name = "textBoxLowerEnginePower";
            textBoxLowerEnginePower.PlaceholderText = "От";
            textBoxLowerEnginePower.Size = new Size(60, 39);
            textBoxLowerEnginePower.TabIndex = 8;
            // 
            // textBoxUpperEnginePower
            // 
            textBoxUpperEnginePower.Font = new Font("Segoe UI", 15F);
            textBoxUpperEnginePower.Location = new Point(207, 286);
            textBoxUpperEnginePower.Multiline = true;
            textBoxUpperEnginePower.Name = "textBoxUpperEnginePower";
            textBoxUpperEnginePower.PlaceholderText = "До";
            textBoxUpperEnginePower.Size = new Size(60, 39);
            textBoxUpperEnginePower.TabIndex = 9;
            // 
            // labelGearShiftBoxType
            // 
            labelGearShiftBoxType.AutoSize = true;
            labelGearShiftBoxType.Font = new Font("Segoe UI", 17F);
            labelGearShiftBoxType.Location = new Point(366, 244);
            labelGearShiftBoxType.Name = "labelGearShiftBoxType";
            labelGearShiftBoxType.Size = new Size(146, 31);
            labelGearShiftBoxType.TabIndex = 11;
            labelGearShiftBoxType.Text = "Тип коробки";
            // 
            // comboBoxGearShiftBoxType
            // 
            comboBoxGearShiftBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGearShiftBoxType.Font = new Font("Segoe UI", 12F);
            comboBoxGearShiftBoxType.FormattingEnabled = true;
            comboBoxGearShiftBoxType.Location = new Point(366, 286);
            comboBoxGearShiftBoxType.Name = "comboBoxGearShiftBoxType";
            comboBoxGearShiftBoxType.Size = new Size(172, 29);
            comboBoxGearShiftBoxType.TabIndex = 10;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 17F);
            labelCondition.Location = new Point(564, 244);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(124, 31);
            labelCondition.TabIndex = 13;
            labelCondition.Text = "Состояние";
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCondition.Font = new Font("Segoe UI", 12F);
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(564, 286);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(172, 29);
            comboBoxCondition.TabIndex = 12;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 25F);
            labelPrice.Location = new Point(48, 373);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(107, 46);
            labelPrice.TabIndex = 14;
            labelPrice.Text = "Цена:";
            // 
            // textBoxLowerPrice
            // 
            textBoxLowerPrice.Font = new Font("Segoe UI", 15F);
            textBoxLowerPrice.Location = new Point(157, 380);
            textBoxLowerPrice.Multiline = true;
            textBoxLowerPrice.Name = "textBoxLowerPrice";
            textBoxLowerPrice.PlaceholderText = "От";
            textBoxLowerPrice.Size = new Size(131, 39);
            textBoxLowerPrice.TabIndex = 15;
            // 
            // textBoxUpperPrice
            // 
            textBoxUpperPrice.Font = new Font("Segoe UI", 15F);
            textBoxUpperPrice.Location = new Point(308, 380);
            textBoxUpperPrice.Multiline = true;
            textBoxUpperPrice.Name = "textBoxUpperPrice";
            textBoxUpperPrice.PlaceholderText = "До";
            textBoxUpperPrice.Size = new Size(131, 39);
            textBoxUpperPrice.TabIndex = 17;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 15F);
            labelCity.Location = new Point(438, 167);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(72, 28);
            labelCity.TabIndex = 19;
            labelCity.Text = "Город:";
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Font = new Font("Segoe UI", 12F);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.IntegralHeight = false;
            comboBoxCity.Location = new Point(516, 166);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(172, 29);
            comboBoxCity.Sorted = true;
            comboBoxCity.TabIndex = 18;
            // 
            // buttonSendAd
            // 
            buttonSendAd.Font = new Font("Segoe UI", 17F);
            buttonSendAd.Location = new Point(516, 375);
            buttonSendAd.Name = "buttonSendAd";
            buttonSendAd.Size = new Size(179, 49);
            buttonSendAd.TabIndex = 0;
            buttonSendAd.Text = "Сохранить";
            buttonSendAd.Click += SendSelectRequest;
            // 
            // comboBoxModel
            // 
            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModel.Font = new Font("Segoe UI", 12F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.IntegralHeight = false;
            comboBoxModel.Location = new Point(366, 99);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(370, 29);
            comboBoxModel.Sorted = true;
            comboBoxModel.TabIndex = 21;
            // 
            // labelHeding
            // 
            labelHeding.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHeding.Location = new Point(56, 0);
            labelHeding.Name = "labelHeding";
            labelHeding.Size = new Size(670, 57);
            labelHeding.TabIndex = 22;
            labelHeding.Text = "Заполните форму для добавления клиента";
            labelHeding.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHeding);
            Controls.Add(comboBoxModel);
            Controls.Add(labelBrand);
            Controls.Add(comboBoxBrand);
            Controls.Add(labelModel);
            Controls.Add(labelReleaseYear);
            Controls.Add(textBoxLowerReleaseYear);
            Controls.Add(textBoxUpperReleaseYear);
            Controls.Add(labelEnginePower);
            Controls.Add(textBoxLowerEnginePower);
            Controls.Add(textBoxUpperEnginePower);
            Controls.Add(labelGearShiftBoxType);
            Controls.Add(comboBoxGearShiftBoxType);
            Controls.Add(labelCondition);
            Controls.Add(comboBoxCondition);
            Controls.Add(labelPrice);
            Controls.Add(textBoxLowerPrice);
            Controls.Add(textBoxUpperPrice);
            Controls.Add(labelCity);
            Controls.Add(comboBoxCity);
            Controls.Add(buttonSendAd);
            Controls.Add(buttonGoMain);
            Name = "AddClientControl";
            Size = new Size(800, 450);
            Load += AddClientControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGoMain;
        private Label labelBrand;
        private Label labelModel;
        private ComboBox comboBoxBrand;
        private Button buttonSendAd;

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
        private ComboBox comboBoxModel;

        private Client client;
        private Label labelHeding;
    }
}
