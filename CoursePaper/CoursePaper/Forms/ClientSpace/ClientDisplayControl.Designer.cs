using CoursePaper.Domain;

namespace CoursePaper.Forms
{
    partial class ClientDisplayControl
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
            buttonGoBack = new Button();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHeading.Location = new Point(3, 0);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(778, 72);
            labelHeading.TabIndex = 22;
            labelHeading.Text = "Список требований наших клиентов";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGoBack
            // 
            buttonGoBack.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonGoBack.Location = new Point(12, 21);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(38, 36);
            buttonGoBack.TabIndex = 23;
            buttonGoBack.Text = "❮";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += GoToBack;
            // 
            // ClientDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(buttonGoBack);
            Controls.Add(labelHeading);
            Name = "ClientDisplayControl";
            Size = new Size(783, 450);
            Load += CarDisplayControl_Load;
            InvisibleAll += () => labelHeading.Visible = false;
            InvisibleAll += () => buttonGoBack.Visible = false;
            VisibleAll += () => labelHeading.Visible = true;
            VisibleAll += () => buttonGoBack.Visible = true;
            ResumeLayout(false);
        }

        #endregion
        private Label labelHeading;
        private Button buttonGoBack;
    }
}