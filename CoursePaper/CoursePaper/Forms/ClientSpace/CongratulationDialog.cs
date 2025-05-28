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
    internal partial class CongratulationDialog : Form
    {
        private bool allowClose = false;

        public CongratulationDialog()
        {
            InitializeComponent();
        }

        private void GoToMain(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            allowClose = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Блокирует закрытие alt + f4
            }

            base.OnFormClosing(e);
        }
    }
}
