namespace CoursePaper.Forms
{
    partial class PurchaseConfirmationDialog
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
            buttonBuy = new Button();
            buttonCancel = new Button();
            labelHeading = new Label();
            SuspendLayout();
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonBuy.Location = new Point(34, 216);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(187, 66);
            buttonBuy.TabIndex = 0;
            buttonBuy.Text = "Купить";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += ButtonBuy_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonCancel.Location = new Point(260, 216);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(187, 66);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelHeading
            // 
            labelHeading.Font = new Font("Segoe UI", 15F);
            labelHeading.Location = new Point(0, 0);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(491, 56);
            labelHeading.TabIndex = 2;
            labelHeading.Text = "Необходимо подтвердить покупку.";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PurchaseConfirmationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 294);
            ControlBox = false;
            Controls.Add(labelHeading);
            Controls.Add(buttonCancel);
            Controls.Add(buttonBuy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PurchaseConfirmationDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBuy;
        private Button buttonCancel;
        private Label labelHeading;
    }
}