using librpc;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Mast1c0rePayloader
{
    public partial class Form1 : Form
    {
        public static PS4RPC PS4 = new PS4RPC(IniConfig.IP);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ipbox.Text = IniConfig.Newini.Read("PS4 IP", "IP");
            this.portbox.Text = IniConfig.Newini.Read("PS4 port", "port");
        }

        public static string path;


        public void SendPayload(string IP, string payloadPath, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                ReceiveTimeout = 1500,
                SendTimeout = 1500
            };
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(payloadPath);
            socket.Close();
        }

        public static Socket _psocket;
        public static bool pDConnected;
        public static string Exception;
        public static void SendPayload(string filename)
        {
            _psocket.SendFile(filename);
        }

        public static void DisconnectPayload()
        {
            pDConnected = false;
            _psocket.Close();
        }
        public static bool Connect2PS4(string ip, string port)
        {
            try
            {
                _psocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _psocket.ReceiveTimeout = 3000;
                _psocket.SendTimeout = 3000;
                _psocket.Connect(new IPEndPoint(IPAddress.Parse(ip), Int32.Parse(port)));
                pDConnected = true;
                return true;
            }
            catch (Exception ex)
            {
                pDConnected = false;
                Exception = ex.ToString();
                return false;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BIN ELF ISO files (*.bin,*.elf,*.iso)|*.bin;*.iso;*.elf|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            textBox1.Text = path;
        }
        private void labSaveIP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ipbox.Text == "")
                {
                    MessageBox.Show("Introduce una ip valida");
                }
                else
                {
                    IniConfig.Newini.Write("PS4 IP", "ip", ipbox.Text);
                    IniConfig.Newini.Write("PS4 PORT", "port", portbox.Text);
                    MessageBox.Show("IP: " + ipbox.Text + "\n" + "port: " + portbox.Text);
                    //this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error al cambiar la ip");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (ipbox.Text == "")
                {
                    MessageBox.Show("Please enter an IP address.");
                }
                else
                {
                    bool result = Connect2PS4(ipbox.Text, portbox.Text);
                    if (!result)
                    {
                        MessageBox.Show("Error while connecting.\n" + Exception);
                        payloadStatus.ForeColor = Color.Red;
                        payloadStatus.Text = "Failed";
                    }
                    else
                    {
                        payloadStatus.ForeColor = Color.Green;
                        payloadStatus.Text = "Successful";
                    }
                }
            }
            try
            {
                SendPayload(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while sending payload!\n" + ex);
            }
            try
            {
                DisconnectPayload();
                MessageBox.Show("Payload sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while disconnecting!\n" + ex);
            }
        }

        //PSDialog
        private void PSDialog_Click(object sender, EventArgs e)
        {
            this.Injector_PSDialog(this.ipbox.Text);
        }
        private void Injector_PSDialog(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSDialog";
            try
            {

                SendPayload(IP, str + "\\ps-dialog-PS4-0-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PSDialog";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PSLightBar
        private void PSLightBar_Click(object sender, EventArgs e)
        {
            this.Injector_PSLightBar(this.ipbox.Text);
        }
        private void Injector_PSLightBar(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSLightBar";
            try
            {

                SendPayload(IP, str + "\\ps-lightbar-PS4-0-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PSLightBar";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS5Dialog
        private void PS5Dialog_Click(object sender, EventArgs e)
        {
            this.Injector_PS5Dialog(this.ipbox.Text);
        }
        private void Injector_PS5Dialog(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSDialog";
            try
            {

                SendPayload(IP, str + "\\ps-dialog-PS5-0-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5Dialog";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS5LightBar
        private void PS5LightBar_Click(object sender, EventArgs e)
        {
            this.Injector_PS5LightBar(this.ipbox.Text);
        }
        private void Injector_PS5LightBar(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSLightBar";
            try
            {

                SendPayload(IP, str + "\\ps-lightbar-PS5-0-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5LightBar";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4Dialog10_01
        private void PS4Dialog10_01_Click(object sender, EventArgs e)
        {
            this.Injector_PS4Dialog10_01(this.ipbox.Text);
        }
        private void Injector_PS4Dialog10_01(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSDialog";
            try
            {

                SendPayload(IP, str + "\\ps-dialog-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS-dialog-PS4-10-01";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void PS5LightBar_6_50_Click(object sender, EventArgs e)
        {

        }
        //PS4_505N
        private void PS4_505N_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_505N(this.ipbox.Text);
        }
        private void Injector_PS4_505N(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSNotification";
            try
            {

                SendPayload(IP, str + "\\ps-notification-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4_505N";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_672N
        private void PS4_672N_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_672N(this.ipbox.Text);
        }
        private void Injector_PS4_672N(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSNotification";
            try
            {

                SendPayload(IP, str + "\\ps-notification-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4_672N";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_900N
        private void PS4_900N_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_900N(this.ipbox.Text);
        }
        private void Injector_PS4_900N(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSNotification";
            try
            {

                SendPayload(IP, str + "\\ps-notification-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4_900N";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_1001N
        private void PS4_1001N_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_1001N(this.ipbox.Text);
        }
        private void Injector_PS4_1001N(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSNotification";
            try
            {

                SendPayload(IP, str + "\\ps-notification-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4_10.01 Notification";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS5_650N
        private void PS5_650N_Click(object sender, EventArgs e)
        {
            this.Injector_PS5_650N(this.ipbox.Text);
        }
        private void Injector_PS5_650N(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSNotification";
            try
            {

                SendPayload(IP, str + "\\ps-notification-PS5-6-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5-6-50 Notification";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_505V
        private void PS4_505V_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_505V(this.ipbox.Text);
        }
        private void Injector_PS4_505V(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSVersionM";
            try
            {

                SendPayload(IP, str + "\\PS5VersionMast1c0re-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 VersionM";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_672V
        private void PS4_672V_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_672V(this.ipbox.Text);
        }
        private void Injector_PS4_672V(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSVersionM";
            try
            {

                SendPayload(IP, str + "\\PS5VersionMast1c0re-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 VersionM";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_900V
        private void PS4_900V_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_900V(this.ipbox.Text);
        }
        private void Injector_PS4_900V(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSVersionM";
            try
            {

                SendPayload(IP, str + "\\PS5VersionMast1c0re-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 VersionM";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4_1001V
        private void PS4_1001V_Click(object sender, EventArgs e)
        {
            this.Injector_PS4_1001V(this.ipbox.Text);
        }
        private void Injector_PS4_1001V(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSVersionM";
            try
            {

                SendPayload(IP, str + "\\PS5VersionMast1c0re-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 VersionM";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS5_650V
        private void PS5_650V_Click(object sender, EventArgs e)
        {
            this.Injector_PS5_650V(this.ipbox.Text);
        }
        private void Injector_PS5_650V(string IP)
        {
            string str = Application.StartupPath + "\\files\\PSVersionM";
            try
            {

                SendPayload(IP, str + "\\PS5VersionMast1c0re-PS5-6-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5 6.50 VersionM";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About f2 = new About();
            f2.ShowDialog();
        }
    }
}
