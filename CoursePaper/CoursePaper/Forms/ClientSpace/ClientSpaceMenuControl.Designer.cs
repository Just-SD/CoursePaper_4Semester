namespace CoursePaper.Forms
{
    partial class ClientSpaceMenuControl
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
            labelHeading = new Label();
            buttonAddClient = new Button();
            buttonOpenRelevantClients = new Button();
            buttonGoMain = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.Font = new Font("Segoe UI", 27F);
            labelHeading.Location = new Point(12, 11);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(776, 118);
            labelHeading.TabIndex = 1;
            labelHeading.Text = "Что Вы хотите сделать?";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Font = new Font("Segoe UI", 20F);
            buttonAddClient.Location = new Point(25, 267);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(338, 91);
            buttonAddClient.TabIndex = 3;
            buttonAddClient.Text = "Добавить нового клиента";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += ShowAddClientControl;
            // 
            // buttonOpenRelevantClients
            // 
            buttonOpenRelevantClients.Font = new Font("Segoe UI", 20F);
            buttonOpenRelevantClients.Location = new Point(437, 267);
            buttonOpenRelevantClients.Name = "buttonOpenRelevantClients";
            buttonOpenRelevantClients.Size = new Size(338, 91);
            buttonOpenRelevantClients.TabIndex = 4;
            buttonOpenRelevantClients.Text = "Открыть список клиентов";
            buttonOpenRelevantClients.UseVisualStyleBackColor = true;
            buttonOpenRelevantClients.Click += ShowRelevantClients;
            // 
            // buttonGoMain
            // 
            buttonGoMain.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonGoMain.Location = new Point(12, 21);
            buttonGoMain.Name = "buttonGoMain";
            buttonGoMain.Size = new Size(38, 36);
            buttonGoMain.TabIndex = 21;
            buttonGoMain.Text = "❮";
            buttonGoMain.UseVisualStyleBackColor = true;
            buttonGoMain.Click += GoToMain;
            // 
            // ClientSpaceMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGoMain);
            Controls.Add(buttonAddClient);
            Controls.Add(buttonOpenRelevantClients);
            Controls.Add(labelHeading);
            Name = "ClientSpaceMenuControl";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Label labelHeading;
        private Button buttonAddClient;
        private Button buttonOpenRelevantClients;
        private Button buttonGoMain;
    }
}