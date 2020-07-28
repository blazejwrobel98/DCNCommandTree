using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DCNCommandTree
{
    public partial class IP : Form
    {
        Device Urzadzenie = new Device();
        List<Panel> listPanel = new List<Panel>();
        int index;
        public IP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlPanel.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
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
            listPanel[index].Visible = false;
            index--;
            Show_panel();
        }

        private void next_Click(object sender, EventArgs e)
        {
            listPanel[index].Visible = false;
            index++;
            Show_panel();
        }

        private void Show_panel()
        {
            indexshow.Text = $"{index + 1} z {listPanel.Count}";
            listPanel[index].Visible = true;
            listPanel[index].BringToFront();
            if (index < listPanel.Count - 1)
            {
                next.Visible = true;
                finish.Visible = false;
            }
            else
            {
                next.Visible = false;
                finish.Visible = true;
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {
            Urzadzenie.IP = form_ip.Text.Trim();
            Urzadzenie.LOGIN = form_login.Text.Trim();
            Urzadzenie.PASSWORD = form_password.Text.Trim();
            Urzadzenie.REMEMBER = form_check.Checked;
            if (Urzadzenie.IP != "" && Urzadzenie.LOGIN != "")
            {
                form_ip.BackColor = Color.White;
                form_login.BackColor = Color.White;
                StartApp();
            }
            else
            {
                if (Urzadzenie.IP == "")
                {
                    form_ip.BackColor = Color.Red;
                }
                else
                {
                    form_ip.BackColor = Color.White;
                }
                if (Urzadzenie.LOGIN == "")
                {
                    form_login.BackColor = Color.Red;
                }
                else
                {
                    form_login.BackColor = Color.White;
                }
            }
        }
        private void StartApp()
        {
            panel2.Visible = false;
            next.Visible = false;
            finish.Visible = false;
            previous.Visible = false;
            indexshow.Visible = false;
            ControlPanel.Visible = true;
            ControlPanel.BringToFront();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
            control_ip.Text = Urzadzenie.IP;
            control_ip.Enabled = false;
            if (Connection.Test(Urzadzenie))
            {
                control_telnet_test_label.Text = "OK";
                control_telnet_test_label.ForeColor = Color.Green;
            }
            else
            {
                control_telnet_test_label.Text = "BŁĄD";
                control_telnet_test_label.ForeColor = Color.Red;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void control_telnet_progress_Click(object sender, EventArgs e)
        {

        }
    }
    public class Device
    {
        private string pn;
        private string fw;
        private string boot;
        private string id;
        private string ip;
        private string login;
        private string password;
        private bool remember;
        public string PN
        {
            get { return pn; }
            set { pn = value; }
        }
        public string FW
        {
            get { return fw; }
            set { fw = value; }
        }
        public string BOOT
        {
            get { return boot; }
            set { boot = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
        public string LOGIN
        {
            get { return login; }
            set { login = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public bool REMEMBER
        {
            get { return remember; }
            set { remember = value; }
        }
    }
    public class Connection
    {
        public static bool Test(Device Urzadzenie)
        {
            // create the client 
            Telnet client = new Telnet("servername");
            // start the Shell to send commands and read responses 
            Shell shell = client.StartShell();
            // set the prompt of the remote server's shell first 
            shell.Prompt = "servername# ";
            // read a welcome message 
            string welcome = shell.ReadAll();
            // display welcome message 
            Console.WriteLine(welcome);
            // send the 'df' command 
            shell.SendCommand("df");
            // read all response, effectively waiting for the command to end 
            string response = shell.ReadAll();
            // display the output 
            Console.WriteLine("Disk usage info:");
            Console.WriteLine(response);
            // close the shell 
            shell.Close();
        }
    }
}
