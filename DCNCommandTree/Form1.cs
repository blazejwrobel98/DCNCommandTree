using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DCNCommandTree
{
    public partial class IP : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public IP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            Show_panel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            index--;
            Show_panel();
        }

        private void next_Click(object sender, EventArgs e)
        {
            index++;
            Show_panel();
        }

        private void Show_panel()
        {
            indexshow.Text = $"{index + 1} z {listPanel.Count}";
            listPanel[index].BringToFront();
            if (index < listPanel.Count - 1)
            {
                next.Visible = true;
            }
            else
            {
                next.Visible = false;
            }
            if (index > 0)
            {
                previous.Visible = true;
            }
            else
            {
                previous.Visible = false;
            }
        }
    }
}
