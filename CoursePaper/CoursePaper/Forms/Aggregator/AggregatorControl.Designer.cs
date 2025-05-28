namespace CoursePaper
{
    partial class AggregatorControl
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
            // AggregatorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGoMain);
            Name = "AggregatorControl";
            Size = new Size(800, 450);
            Load += ChoiceForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGoMain;
    }
}
