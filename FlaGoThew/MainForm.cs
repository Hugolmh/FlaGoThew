using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaGoThew
{
    public partial class MainForm : Form
    {
        private Panel panelContainer;

        public MainForm()
        {
            InitializeComponent();

            panelContainer = new Panel
            {
                Dock = DockStyle.Fill // Remplit toute la fenêtre
            };
            this.Controls.Add(panelContainer);
        }

        public void LoadPage(UserControl page)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPage(new LoginForm(this));
        }
    }
}
