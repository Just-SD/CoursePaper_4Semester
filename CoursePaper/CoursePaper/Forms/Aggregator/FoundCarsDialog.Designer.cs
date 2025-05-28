namespace CoursePaper.Forms
{
    partial class FoundCarsDialog
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
            buttonEdit = new Button();
            buttonView = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10F);
            buttonEdit.Location = new Point(12, 91);
            buttonEdit.Name = "button1";
            buttonEdit.Size = new Size(95, 47);
            buttonEdit.TabIndex = 0;
            buttonEdit.Text = "Изменить данные";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // buttonView
            // 
            buttonView.Font = new Font("Segoe UI", 10F);
            buttonView.Location = new Point(143, 91);
            buttonView.Name = "button2";
            buttonView.Size = new Size(95, 47);
            buttonView.TabIndex = 1;
            buttonView.Text = "Посмотреть";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += ButtonView_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 88);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoundCarsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 150);
            Controls.Add(label1);
            Controls.Add(buttonView);
            Controls.Add(buttonEdit);
            Name = "FoundCarsDialog";
            Text = string.Empty;
            ResumeLayout(false);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        private Button buttonEdit;
        private Button buttonView;
        private Label label1;
    }
}