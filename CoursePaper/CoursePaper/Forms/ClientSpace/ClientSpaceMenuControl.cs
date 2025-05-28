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
    public partial class ClientSpaceMenuControl : UserControl
    {
        public event Action BackButtonClicked;

        public ClientSpaceMenuControl()
        {
            InitializeComponent();
        }

        private void ShowAddClientControl(object? sender, EventArgs e)
        {
            InvisibleAll();

            Panel panelAddNewClient = GetNewPanel();
            Controls.Add(panelAddNewClient);
            var control = new AddClientControl();
            control.Dock = DockStyle.Fill;
            panelAddNewClient.BringToFront();
            panelAddNewClient.Controls.Add(control);

            control.BackToMainButtonClicked += () =>
            {
                panelAddNewClient.Dispose();
                VisibleAll();
            };
        }

        private void ShowRelevantClients(object? sender, EventArgs e)
        {
            InvisibleAll();

            Panel panelRelevantClients = GetNewPanel();
            Controls.Add(panelRelevantClients);

            var control = new ClientDisplayControl();

            control.Dock = DockStyle.Fill;
            panelRelevantClients.BringToFront();
            panelRelevantClients.Controls.Add(control);

            control.BackToMainClicked += () =>
            {
                panelRelevantClients.Dispose();
                VisibleAll();
                BackButtonClicked.Invoke();
            };

            control.BackButtonClicked += () =>
            {
                panelRelevantClients.Dispose();
                VisibleAll();
            };
        }

        private void InvisibleAll()
        {
            labelHeading.Visible = false;
            buttonAddClient.Visible = false;
            buttonOpenRelevantClients.Visible = false;
            buttonGoMain.Visible = false;
        }

        private void VisibleAll()
        {
            labelHeading.Visible = true;
            buttonAddClient.Visible = true;
            buttonOpenRelevantClients.Visible = true;
            buttonGoMain.Visible = true;
        }

        private Panel GetNewPanel()
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Name = "panelAggregator";
            panel.Size = new Size(800, 450);
            panel.TabIndex = 0;
            return panel;
        }

        private void GoToMain(object sender, EventArgs e)
        {
            BackButtonClicked.Invoke();
        }
    }
}
