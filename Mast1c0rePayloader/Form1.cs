using librpc;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
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
                ReceiveTimeout = 0,
                SendTimeout = 0
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
                    MessageBox.Show("Mast1c0rePayloader 1.0.2" + "\n" + "IP: " + ipbox.Text + "\n" + "port: " + portbox.Text);
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

        //gameloader505
        private void butgameloader_Click(object sender, EventArgs e)
        {
            this.Injector_gameloader(this.ipbox.Text);
        }
        private void Injector_gameloader(string IP)
        {
            string str = Application.StartupPath + "\\files\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //gameloader672
        private void butgameloader672_Click(object sender, EventArgs e)
        {
            this.Injector_gameloader672(this.ipbox.Text);
        }
        private void Injector_gameloader672(string IP)
        {
            string str = Application.StartupPath + "\\files\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //gameloader900
        private void gameloader900_Click(object sender, EventArgs e)
        {
            this.Injector_gameloader900(this.ipbox.Text);
        }
        private void Injector_gameloader900(string IP)
        {
            string str = Application.StartupPath + "\\files\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //gameloader1001
        private void gameloader1001_Click(object sender, EventArgs e)
        {
            this.Injector_gameloader1001(this.ipbox.Text);
        }
        private void Injector_gameloader1001(string IP)
        {
            string str = Application.StartupPath + "\\files\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }

        private void gameloader650_Click(object sender, EventArgs e)
        {
            this.Injector_gameloader650(this.ipbox.Text);
        }
        private void Injector_gameloader650(string IP)
        {
            string str = Application.StartupPath + "\\files\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS5-6-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5 6.50 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //v104//
        //PS4505
        private void butPS4505_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4505(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4505(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4672
        private void butPS4672_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4672(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4672(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4900
        private void butPS4900_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4900(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4900(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS41001
        private void butPS41001_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS41001(this.ipbox.Text);
        }
        private void Injector_gameloaderPS41001(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS41050
        private void butPS41050_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS41050(this.ipbox.Text);
        }
        private void Injector_gameloaderPS41050(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.50 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS5650
        private void butPS5650_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS5650(this.ipbox.Text);
        }
        private void Injector_gameloaderPS5650(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS5-6-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS6 6.50 GameLoader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4usb505
        private void butPS4usb505_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4usb505(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4usb505(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 GameUSB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";
            }
        }
        //PS4usb672
        private void butPS4usb672_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4usb672(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4usb672(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 GameUSB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //PS4usb900
        private void butPS4usb900_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4usb900(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4usb900(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 GameUSB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //PS4usb1001
        private void butPS4usb1001_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4usb1001(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4usb1001(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 GameUSB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //PS4usb1050
        private void butPS4usb1050_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4usb1050(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4usb1050(string IP)
        {
            string str = Application.StartupPath + "\\files\\v104\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-10-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.50 GameUSB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //OkagePS2EmuCompatibility
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1IFw3zu56KvVPiAf0aP2ITdp73aRdi6mdaVwqe9O9eb8/edit#gid=1021143822");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter A = new StreamWriter(Application.StartupPath + "\\" + "iso_elf.bat");

                A.WriteLine(" python send-game.py " + "-i " + ipbox.Text + " -f " + textBox1.Text + "\npause");
                A.Close();
                if (File.Exists("iso_elf.bat"))
                {
                    this.payloadStatus.Text = "Extract...";
                    Thread thread = new Thread(new ThreadStart(ThreadProc));
                    new System.Diagnostics.Process
                    {
                        StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "iso_elf.bat"
                            }
                    }.Start();
                    MessageBox.Show(" successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.payloadStatus.Text = "Extract complete!";


                }
                else
                {
                    MessageBox.Show("You're missing the targeted file! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }



            }
            catch
            {
                MessageBox.Show("Error al cambiar la ip");
            }
        }

        private void ThreadProc()
        {
            throw new NotImplementedException();
        }

        //v105
        private void butv5PS4505_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps4505(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps4505(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butbutv5PS4672_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps4672(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps4672(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butbutv5PS4900_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps4900(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps4900(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butbutv5PS41001_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps41001(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps41001(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps41050(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps41050(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.50 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butbutv5PS41070_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderPS4v5ps41070(this.ipbox.Text);
        }
        private void Injector_gameloaderPS4v5ps41070(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS4-10-70.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.70 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butv5PS5650_Click(object sender, EventArgs e)
        {
            this.Injector_gameloaderv5ps5650(this.ipbox.Text);
        }
        private void Injector_gameloaderv5ps5650(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameLoader";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-network-game-loader-PS5-6-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS5 6.50 Game loader ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //usbps4
        private void butV5PS4505usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS4505usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS4505usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-5-05.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 5.05 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butV5PS4672usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS4672usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS4672usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-6-72.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 6.72 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butV5PS4900usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS4900usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS4900usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-9-00.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 9.00 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butV5PS41001usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS41001usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS41001usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-10-01.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.01 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butV5PS41050usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS41050usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS41050usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-10-50.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.50 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }

        private void butV5PS41070usb_Click(object sender, EventArgs e)
        {
            this.Injector_gameV5PS41070usb(this.ipbox.Text);
        }
        private void Injector_gameV5PS41070usb(string IP)
        {
            string str = Application.StartupPath + "\\files\\v105\\GameUSB";
            try
            {

                SendPayload(IP, str + "\\mast1c0re-ps2-usb-game-loader-PS4-10-70.elf", Convert.ToInt32(this.portbox.Text));
                payloadStatus.ForeColor = Color.FromArgb(20, 163, 4);
                payloadStatus.Text = "Successful. PS4 10.70 Game USB ";


            }
            catch
            {
                int num = (int)MessageBox.Show("Payload injection failed.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.payloadStatus.ForeColor = Color.Red;
                this.payloadStatus.Text = "Payload failed";

            }
        }
        //usb ps5

    }
}
