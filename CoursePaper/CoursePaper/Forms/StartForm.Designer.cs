namespace CoursePaper
{
    partial class StartForm
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
            panelMain = new Panel();
            labelHeading = new Label();
            buttonAddCar = new Button();
            buttonOpenAggregator = new Button();
            buttonOpenClient = new Button();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // labelHeading
            // 
            labelHeading.Font = new Font("Segoe UI", 27F);
            labelHeading.Location = new Point(12, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(776, 118);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Что Вы хотите сделать?";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Font = new Font("Segoe UI", 20F);
            buttonAddCar.Location = new Point(12, 159);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(338, 91);
            buttonAddCar.TabIndex = 1;
            buttonAddCar.Text = "Разместить объявление";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += ShowAddCarControl;
            // 
            // buttonOpenAggregator
            // 
            buttonOpenAggregator.Font = new Font("Segoe UI", 20F);
            buttonOpenAggregator.Location = new Point(450, 159);
            buttonOpenAggregator.Name = "buttonOpenAggregator";
            buttonOpenAggregator.Size = new Size(338, 91);
            buttonOpenAggregator.TabIndex = 2;
            buttonOpenAggregator.Text = "Открыть агрегатор";
            buttonOpenAggregator.UseVisualStyleBackColor = true;
            buttonOpenAggregator.Click += ShowAggregatorControl;
            // 
            // buttonOpenClient
            // 
            buttonOpenClient.Font = new Font("Segoe UI", 20F);
            buttonOpenClient.Location = new Point(238, 319);
            buttonOpenClient.Name = "buttonOpenClient";
            buttonOpenClient.Size = new Size(338, 91);
            buttonOpenClient.TabIndex = 3;
            buttonOpenClient.Text = "Открыть подбор для клиентов";
            buttonOpenClient.UseVisualStyleBackColor = true;
            buttonOpenClient.Click += ShowClientControl;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenClient);
            Controls.Add(labelHeading);
            Controls.Add(buttonAddCar);
            Controls.Add(buttonOpenAggregator);
            Controls.Add(panelMain);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автоподбор";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;

        private Label labelHeading;
        private Button buttonAddCar;
        private Button buttonOpenAggregator;
        private Button buttonOpenClient;
    }
}