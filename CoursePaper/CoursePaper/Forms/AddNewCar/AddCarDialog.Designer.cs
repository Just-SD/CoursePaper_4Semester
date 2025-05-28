namespace CoursePaper.Forms
{
    partial class AddCarDialog
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
            labelSuccessfulAddition = new Label();
            buttonGoMain = new Button();
            SuspendLayout();
            // 
            // labelSuccessfulAddition
            // 
            labelSuccessfulAddition.Font = new Font("Segoe UI", 15F);
            labelSuccessfulAddition.Location = new Point(12, 9);
            labelSuccessfulAddition.Name = "labelSuccessfulAddition";
            labelSuccessfulAddition.Size = new Size(226, 90);
            labelSuccessfulAddition.TabIndex = 0;
            labelSuccessfulAddition.Text = "Поздравляем!\nВаше объявление добавлено.";
            labelSuccessfulAddition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGoMain
            // 
            buttonGoMain.Font = new Font("Segoe UI", 12F);
            buttonGoMain.Location = new Point(50, 109);
            buttonGoMain.Name = "buttonGoMain";
            buttonGoMain.Size = new Size(142, 50);
            buttonGoMain.TabIndex = 1;
            buttonGoMain.Text = "Вернуться в меню";
            buttonGoMain.UseVisualStyleBackColor = true;
            buttonGoMain.Click += GoToMain;
            // 
            // AddCarDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 171);
            ControlBox = false;
            Controls.Add(buttonGoMain);
            Controls.Add(labelSuccessfulAddition);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCarDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Label labelSuccessfulAddition;
        private Button buttonGoMain;
    }
}