
namespace Mast1c0rePayloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portbox = new System.Windows.Forms.TextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.payloadStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PS4_900V = new System.Windows.Forms.Button();
            this.PS5_650V = new System.Windows.Forms.Button();
            this.PS4_1001V = new System.Windows.Forms.Button();
            this.PS4_505V = new System.Windows.Forms.Button();
            this.PS4_672V = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PS4_900N = new System.Windows.Forms.Button();
            this.PS5_650N = new System.Windows.Forms.Button();
            this.PS4_1001N = new System.Windows.Forms.Button();
            this.PS4_505N = new System.Windows.Forms.Button();
            this.PS4_672N = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PS4Dialog10_01 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PS5Dialog = new System.Windows.Forms.Button();
            this.PS5LightBar = new System.Windows.Forms.Button();
            this.PSDialog = new System.Windows.Forms.Button();
            this.PSLightBar = new System.Windows.Forms.Button();
            this.labSaveIP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "PS IP  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "PORT  :";
            // 
            // portbox
            // 
            this.portbox.BackColor = System.Drawing.Color.White;
            this.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.portbox.ForeColor = System.Drawing.Color.Black;
            this.portbox.Location = new System.Drawing.Point(200, 7);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(91, 25);
            this.portbox.TabIndex = 87;
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.White;
            this.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ipbox.ForeColor = System.Drawing.Color.Black;
            this.ipbox.Location = new System.Drawing.Point(51, 7);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(91, 25);
            this.ipbox.TabIndex = 85;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(12, 227);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(469, 24);
            this.button9.TabIndex = 4;
            this.button9.Text = "Send";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(359, 196);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 25);
            this.button10.TabIndex = 3;
            this.button10.Text = "Browse";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 25);
            this.textBox1.TabIndex = 89;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // payloadStatus
            // 
            this.payloadStatus.AutoSize = true;
            this.payloadStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadStatus.Location = new System.Drawing.Point(-1, 252);
            this.payloadStatus.Name = "payloadStatus";
            this.payloadStatus.Size = new System.Drawing.Size(42, 15);
            this.payloadStatus.TabIndex = 90;
            this.payloadStatus.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 160);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "v0.1.3 - Raw TCP Transfer Support";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PS4_900V);
            this.groupBox5.Controls.Add(this.PS5_650V);
            this.groupBox5.Controls.Add(this.PS4_1001V);
            this.groupBox5.Controls.Add(this.PS4_505V);
            this.groupBox5.Controls.Add(this.PS4_672V);
            this.groupBox5.Location = new System.Drawing.Point(356, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(120, 134);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PSVersionMast1c0re";
            // 
            // PS4_900V
            // 
            this.PS4_900V.Location = new System.Drawing.Point(6, 61);
            this.PS4_900V.Name = "PS4_900V";
            this.PS4_900V.Size = new System.Drawing.Size(94, 23);
            this.PS4_900V.TabIndex = 5;
            this.PS4_900V.Text = "PS4-9.00";
            this.PS4_900V.UseVisualStyleBackColor = true;
            this.PS4_900V.Click += new System.EventHandler(this.PS4_900V_Click);
            // 
            // PS5_650V
            // 
            this.PS5_650V.Location = new System.Drawing.Point(6, 107);
            this.PS5_650V.Name = "PS5_650V";
            this.PS5_650V.Size = new System.Drawing.Size(94, 23);
            this.PS5_650V.TabIndex = 6;
            this.PS5_650V.Text = "PS5-6.50";
            this.PS5_650V.UseVisualStyleBackColor = true;
            this.PS5_650V.Click += new System.EventHandler(this.PS5_650V_Click);
            // 
            // PS4_1001V
            // 
            this.PS4_1001V.Location = new System.Drawing.Point(6, 84);
            this.PS4_1001V.Name = "PS4_1001V";
            this.PS4_1001V.Size = new System.Drawing.Size(94, 23);
            this.PS4_1001V.TabIndex = 7;
            this.PS4_1001V.Text = "PS4-10.01";
            this.PS4_1001V.UseVisualStyleBackColor = true;
            this.PS4_1001V.Click += new System.EventHandler(this.PS4_1001V_Click);
            // 
            // PS4_505V
            // 
            this.PS4_505V.Location = new System.Drawing.Point(6, 15);
            this.PS4_505V.Name = "PS4_505V";
            this.PS4_505V.Size = new System.Drawing.Size(94, 23);
            this.PS4_505V.TabIndex = 3;
            this.PS4_505V.Text = "PS4-5.05";
            this.PS4_505V.UseVisualStyleBackColor = true;
            this.PS4_505V.Click += new System.EventHandler(this.PS4_505V_Click);
            // 
            // PS4_672V
            // 
            this.PS4_672V.Location = new System.Drawing.Point(6, 38);
            this.PS4_672V.Name = "PS4_672V";
            this.PS4_672V.Size = new System.Drawing.Size(94, 23);
            this.PS4_672V.TabIndex = 4;
            this.PS4_672V.Text = "PS4-6.72";
            this.PS4_672V.UseVisualStyleBackColor = true;
            this.PS4_672V.Click += new System.EventHandler(this.PS4_672V_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PS4_900N);
            this.groupBox4.Controls.Add(this.PS5_650N);
            this.groupBox4.Controls.Add(this.PS4_1001N);
            this.groupBox4.Controls.Add(this.PS4_505N);
            this.groupBox4.Controls.Add(this.PS4_672N);
            this.groupBox4.Location = new System.Drawing.Point(243, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 135);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PS-Notification";
            // 
            // PS4_900N
            // 
            this.PS4_900N.Location = new System.Drawing.Point(6, 61);
            this.PS4_900N.Name = "PS4_900N";
            this.PS4_900N.Size = new System.Drawing.Size(94, 23);
            this.PS4_900N.TabIndex = 1;
            this.PS4_900N.Text = "PS4-9.00";
            this.PS4_900N.UseVisualStyleBackColor = true;
            this.PS4_900N.Click += new System.EventHandler(this.PS4_900N_Click);
            // 
            // PS5_650N
            // 
            this.PS5_650N.Location = new System.Drawing.Point(6, 107);
            this.PS5_650N.Name = "PS5_650N";
            this.PS5_650N.Size = new System.Drawing.Size(94, 23);
            this.PS5_650N.TabIndex = 2;
            this.PS5_650N.Text = "PS5-6.50";
            this.PS5_650N.UseVisualStyleBackColor = true;
            this.PS5_650N.Click += new System.EventHandler(this.PS5_650N_Click);
            // 
            // PS4_1001N
            // 
            this.PS4_1001N.Location = new System.Drawing.Point(6, 84);
            this.PS4_1001N.Name = "PS4_1001N";
            this.PS4_1001N.Size = new System.Drawing.Size(94, 23);
            this.PS4_1001N.TabIndex = 2;
            this.PS4_1001N.Text = "PS4-10.01";
            this.PS4_1001N.UseVisualStyleBackColor = true;
            this.PS4_1001N.Click += new System.EventHandler(this.PS4_1001N_Click);
            // 
            // PS4_505N
            // 
            this.PS4_505N.Location = new System.Drawing.Point(6, 15);
            this.PS4_505N.Name = "PS4_505N";
            this.PS4_505N.Size = new System.Drawing.Size(94, 23);
            this.PS4_505N.TabIndex = 0;
            this.PS4_505N.Text = "PS4-5.05";
            this.PS4_505N.UseVisualStyleBackColor = true;
            this.PS4_505N.Click += new System.EventHandler(this.PS4_505N_Click);
            // 
            // PS4_672N
            // 
            this.PS4_672N.Location = new System.Drawing.Point(6, 38);
            this.PS4_672N.Name = "PS4_672N";
            this.PS4_672N.Size = new System.Drawing.Size(94, 23);
            this.PS4_672N.TabIndex = 0;
            this.PS4_672N.Text = "PS4-6.72";
            this.PS4_672N.UseVisualStyleBackColor = true;
            this.PS4_672N.Click += new System.EventHandler(this.PS4_672N_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PS4Dialog10_01);
            this.groupBox3.Location = new System.Drawing.Point(119, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PS4 10.01/PS5 6.50 ";
            // 
            // PS4Dialog10_01
            // 
            this.PS4Dialog10_01.Location = new System.Drawing.Point(6, 15);
            this.PS4Dialog10_01.Name = "PS4Dialog10_01";
            this.PS4Dialog10_01.Size = new System.Drawing.Size(106, 23);
            this.PS4Dialog10_01.TabIndex = 0;
            this.PS4Dialog10_01.Text = "PS4-Dialog10.01";
            this.PS4Dialog10_01.UseVisualStyleBackColor = true;
            this.PS4Dialog10_01.Click += new System.EventHandler(this.PS4Dialog10_01_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PS5Dialog);
            this.groupBox2.Controls.Add(this.PS5LightBar);
            this.groupBox2.Controls.Add(this.PSDialog);
            this.groupBox2.Controls.Add(this.PSLightBar);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PS4/PS5 FW 0.00";
            // 
            // PS5Dialog
            // 
            this.PS5Dialog.Location = new System.Drawing.Point(7, 61);
            this.PS5Dialog.Name = "PS5Dialog";
            this.PS5Dialog.Size = new System.Drawing.Size(94, 23);
            this.PS5Dialog.TabIndex = 1;
            this.PS5Dialog.Text = "PS5-Dialog";
            this.PS5Dialog.UseVisualStyleBackColor = true;
            this.PS5Dialog.Click += new System.EventHandler(this.PS5Dialog_Click);
            // 
            // PS5LightBar
            // 
            this.PS5LightBar.Location = new System.Drawing.Point(7, 84);
            this.PS5LightBar.Name = "PS5LightBar";
            this.PS5LightBar.Size = new System.Drawing.Size(94, 23);
            this.PS5LightBar.TabIndex = 2;
            this.PS5LightBar.Text = "PS5-LightBar";
            this.PS5LightBar.UseVisualStyleBackColor = true;
            this.PS5LightBar.Click += new System.EventHandler(this.PS5LightBar_Click);
            // 
            // PSDialog
            // 
            this.PSDialog.Location = new System.Drawing.Point(7, 15);
            this.PSDialog.Name = "PSDialog";
            this.PSDialog.Size = new System.Drawing.Size(94, 23);
            this.PSDialog.TabIndex = 0;
            this.PSDialog.Text = "PS4-Dialog";
            this.PSDialog.UseVisualStyleBackColor = true;
            this.PSDialog.Click += new System.EventHandler(this.PSDialog_Click);
            // 
            // PSLightBar
            // 
            this.PSLightBar.Location = new System.Drawing.Point(7, 38);
            this.PSLightBar.Name = "PSLightBar";
            this.PSLightBar.Size = new System.Drawing.Size(94, 23);
            this.PSLightBar.TabIndex = 0;
            this.PSLightBar.Text = "PS4-LightBar";
            this.PSLightBar.UseVisualStyleBackColor = true;
            this.PSLightBar.Click += new System.EventHandler(this.PSLightBar_Click);
            // 
            // labSaveIP
            // 
            this.labSaveIP.AutoSize = true;
            this.labSaveIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSaveIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaveIP.Location = new System.Drawing.Point(297, 13);
            this.labSaveIP.Name = "labSaveIP";
            this.labSaveIP.Size = new System.Drawing.Size(92, 13);
            this.labSaveIP.TabIndex = 93;
            this.labSaveIP.Text = "Save IP and Port";
            this.labSaveIP.Click += new System.EventHandler(this.labSaveIP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mast1c0rePayloader.Properties.Resources.send_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(442, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labSaveIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.payloadStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.ipbox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mast1c0rePayloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label payloadStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PS4_900N;
        private System.Windows.Forms.Button PS5_650N;
        private System.Windows.Forms.Button PS4_1001N;
        private System.Windows.Forms.Button PS4_505N;
        private System.Windows.Forms.Button PS4_672N;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PS4Dialog10_01;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PSDialog;
        private System.Windows.Forms.Button PSLightBar;
        private System.Windows.Forms.Button PS4_900V;
        private System.Windows.Forms.Button PS5_650V;
        private System.Windows.Forms.Button PS4_1001V;
        private System.Windows.Forms.Button PS4_505V;
        private System.Windows.Forms.Button PS4_672V;
        private System.Windows.Forms.Label labSaveIP;
        private System.Windows.Forms.Button PS5Dialog;
        private System.Windows.Forms.Button PS5LightBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

