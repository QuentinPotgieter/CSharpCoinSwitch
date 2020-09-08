using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class HeadsOrTailsForm : Form
    {
        public HeadsOrTailsForm()
        {
            InitializeComponent();
        }

        // Click events to toggle visibilities
        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            headsPictureBox.Visible = true;
            tailsPictureBox.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = true;
            headsPictureBox.Visible = false;
        }

        // Closes the application
        private void resetButton_Click(object sender, EventArgs e)
        {
            tailsPictureBox.Visible = false;
            headsPictureBox.Visible = false;
        }

        // Closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
