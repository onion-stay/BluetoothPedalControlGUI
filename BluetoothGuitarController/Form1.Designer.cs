namespace BluetoothGuitarController
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLvlChor = new System.Windows.Forms.TextBox();
            this.txtLvlRev = new System.Windows.Forms.TextBox();
            this.txtLvlDel = new System.Windows.Forms.TextBox();
            this.txtLvlDist = new System.Windows.Forms.TextBox();
            this.txtLvlMaster = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLvlChor = new System.Windows.Forms.TrackBar();
            this.tbLvlRev = new System.Windows.Forms.TrackBar();
            this.tbLvlDel = new System.Windows.Forms.TrackBar();
            this.tbLvlDist = new System.Windows.Forms.TrackBar();
            this.tbLvlMaster = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChorRate = new System.Windows.Forms.TextBox();
            this.txtChorDepth = new System.Windows.Forms.TextBox();
            this.tbChorRate = new System.Windows.Forms.TrackBar();
            this.tbChorDepth = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendFX = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRevReverb = new System.Windows.Forms.TextBox();
            this.tbRevReverb = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDelIntensity = new System.Windows.Forms.TextBox();
            this.txtDelDelay = new System.Windows.Forms.TextBox();
            this.tbDelDelay = new System.Windows.Forms.TrackBar();
            this.tbDelIntensity = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistTone = new System.Windows.Forms.TextBox();
            this.txtDistGain = new System.Windows.Forms.TextBox();
            this.tbDistTone = new System.Windows.Forms.TrackBar();
            this.tbDistGain = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProfiles = new System.Windows.Forms.ListBox();
            this.btnOpenProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progBarSendFX = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlChor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlMaster)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChorRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChorDepth)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRevReverb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelIntensity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistTone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistGain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.progBarSendFX);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPort);
            this.splitContainer1.Panel1.Controls.Add(this.cmbBaudRate);
            this.splitContainer1.Panel1.Controls.Add(this.btnClosePort);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenPort);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendFX);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbProfiles);
            this.splitContainer1.Panel2.Controls.Add(this.btnOpenProfile);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveProfile);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 564);
            this.splitContainer1.SplitterDistance = 919;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(186, 428);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(168, 36);
            this.btnClosePort.TabIndex = 10;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(12, 428);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(168, 36);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLvlChor);
            this.groupBox5.Controls.Add(this.txtLvlRev);
            this.groupBox5.Controls.Add(this.txtLvlDel);
            this.groupBox5.Controls.Add(this.txtLvlDist);
            this.groupBox5.Controls.Add(this.txtLvlMaster);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tbLvlChor);
            this.groupBox5.Controls.Add(this.tbLvlRev);
            this.groupBox5.Controls.Add(this.tbLvlDel);
            this.groupBox5.Controls.Add(this.tbLvlDist);
            this.groupBox5.Controls.Add(this.tbLvlMaster);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(557, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 409);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Effect Mixer";
            // 
            // txtLvlChor
            // 
            this.txtLvlChor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLvlChor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlChor.Location = new System.Drawing.Point(277, 63);
            this.txtLvlChor.Name = "txtLvlChor";
            this.txtLvlChor.ReadOnly = true;
            this.txtLvlChor.Size = new System.Drawing.Size(48, 22);
            this.txtLvlChor.TabIndex = 2;
            // 
            // txtLvlRev
            // 
            this.txtLvlRev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLvlRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlRev.Location = new System.Drawing.Point(210, 63);
            this.txtLvlRev.Name = "txtLvlRev";
            this.txtLvlRev.ReadOnly = true;
            this.txtLvlRev.Size = new System.Drawing.Size(48, 22);
            this.txtLvlRev.TabIndex = 2;
            // 
            // txtLvlDel
            // 
            this.txtLvlDel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLvlDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlDel.Location = new System.Drawing.Point(143, 63);
            this.txtLvlDel.Name = "txtLvlDel";
            this.txtLvlDel.ReadOnly = true;
            this.txtLvlDel.Size = new System.Drawing.Size(48, 22);
            this.txtLvlDel.TabIndex = 2;
            // 
            // txtLvlDist
            // 
            this.txtLvlDist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLvlDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlDist.Location = new System.Drawing.Point(76, 63);
            this.txtLvlDist.Name = "txtLvlDist";
            this.txtLvlDist.ReadOnly = true;
            this.txtLvlDist.Size = new System.Drawing.Size(48, 22);
            this.txtLvlDist.TabIndex = 2;
            // 
            // txtLvlMaster
            // 
            this.txtLvlMaster.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLvlMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlMaster.Location = new System.Drawing.Point(9, 63);
            this.txtLvlMaster.Name = "txtLvlMaster";
            this.txtLvlMaster.ReadOnly = true;
            this.txtLvlMaster.Size = new System.Drawing.Size(48, 22);
            this.txtLvlMaster.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chorus";
            // 
            // tbLvlChor
            // 
            this.tbLvlChor.Location = new System.Drawing.Point(277, 91);
            this.tbLvlChor.Maximum = 100;
            this.tbLvlChor.Name = "tbLvlChor";
            this.tbLvlChor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLvlChor.Size = new System.Drawing.Size(56, 304);
            this.tbLvlChor.TabIndex = 1;
            this.tbLvlChor.ValueChanged += new System.EventHandler(this.tbLvlChor_ValueChanged);
            // 
            // tbLvlRev
            // 
            this.tbLvlRev.Location = new System.Drawing.Point(210, 91);
            this.tbLvlRev.Maximum = 100;
            this.tbLvlRev.Name = "tbLvlRev";
            this.tbLvlRev.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLvlRev.Size = new System.Drawing.Size(56, 304);
            this.tbLvlRev.TabIndex = 1;
            this.tbLvlRev.ValueChanged += new System.EventHandler(this.tbLvlRev_ValueChanged);
            // 
            // tbLvlDel
            // 
            this.tbLvlDel.Location = new System.Drawing.Point(143, 91);
            this.tbLvlDel.Maximum = 100;
            this.tbLvlDel.Name = "tbLvlDel";
            this.tbLvlDel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLvlDel.Size = new System.Drawing.Size(56, 304);
            this.tbLvlDel.TabIndex = 1;
            this.tbLvlDel.ValueChanged += new System.EventHandler(this.tbLvlDel_ValueChanged);
            // 
            // tbLvlDist
            // 
            this.tbLvlDist.Location = new System.Drawing.Point(76, 91);
            this.tbLvlDist.Maximum = 100;
            this.tbLvlDist.Name = "tbLvlDist";
            this.tbLvlDist.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLvlDist.Size = new System.Drawing.Size(56, 304);
            this.tbLvlDist.TabIndex = 1;
            this.tbLvlDist.ValueChanged += new System.EventHandler(this.tbLvlDist_ValueChanged);
            // 
            // tbLvlMaster
            // 
            this.tbLvlMaster.Location = new System.Drawing.Point(9, 91);
            this.tbLvlMaster.Maximum = 100;
            this.tbLvlMaster.Name = "tbLvlMaster";
            this.tbLvlMaster.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLvlMaster.Size = new System.Drawing.Size(56, 304);
            this.tbLvlMaster.TabIndex = 1;
            this.tbLvlMaster.ValueChanged += new System.EventHandler(this.tbLvlMaster_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(207, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Reverb";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Delay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Distortion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Master";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtChorRate);
            this.groupBox4.Controls.Add(this.txtChorDepth);
            this.groupBox4.Controls.Add(this.tbChorRate);
            this.groupBox4.Controls.Add(this.tbChorDepth);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(284, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 202);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chorus";
            // 
            // txtChorRate
            // 
            this.txtChorRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChorRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChorRate.Location = new System.Drawing.Point(9, 144);
            this.txtChorRate.Name = "txtChorRate";
            this.txtChorRate.ReadOnly = true;
            this.txtChorRate.Size = new System.Drawing.Size(53, 22);
            this.txtChorRate.TabIndex = 2;
            // 
            // txtChorDepth
            // 
            this.txtChorDepth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChorDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChorDepth.Location = new System.Drawing.Point(9, 58);
            this.txtChorDepth.Name = "txtChorDepth";
            this.txtChorDepth.ReadOnly = true;
            this.txtChorDepth.Size = new System.Drawing.Size(53, 22);
            this.txtChorDepth.TabIndex = 2;
            // 
            // tbChorRate
            // 
            this.tbChorRate.LargeChange = 1;
            this.tbChorRate.Location = new System.Drawing.Point(72, 124);
            this.tbChorRate.Maximum = 100;
            this.tbChorRate.Name = "tbChorRate";
            this.tbChorRate.Size = new System.Drawing.Size(188, 56);
            this.tbChorRate.TabIndex = 1;
            this.tbChorRate.ValueChanged += new System.EventHandler(this.tbChorRate_ValueChanged);
            // 
            // tbChorDepth
            // 
            this.tbChorDepth.LargeChange = 1;
            this.tbChorDepth.Location = new System.Drawing.Point(72, 38);
            this.tbChorDepth.Maximum = 100;
            this.tbChorDepth.Name = "tbChorDepth";
            this.tbChorDepth.Size = new System.Drawing.Size(188, 56);
            this.tbChorDepth.TabIndex = 1;
            this.tbChorDepth.ValueChanged += new System.EventHandler(this.tbChorDepth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Depth";
            // 
            // btnSendFX
            // 
            this.btnSendFX.Enabled = false;
            this.btnSendFX.Location = new System.Drawing.Point(731, 428);
            this.btnSendFX.Name = "btnSendFX";
            this.btnSendFX.Size = new System.Drawing.Size(168, 67);
            this.btnSendFX.TabIndex = 9;
            this.btnSendFX.Text = "Send FX Settings";
            this.btnSendFX.UseVisualStyleBackColor = true;
            this.btnSendFX.Click += new System.EventHandler(this.btnSendFX_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRevReverb);
            this.groupBox3.Controls.Add(this.tbRevReverb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 202);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reverb";
            // 
            // txtRevReverb
            // 
            this.txtRevReverb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRevReverb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevReverb.Location = new System.Drawing.Point(10, 58);
            this.txtRevReverb.Name = "txtRevReverb";
            this.txtRevReverb.ReadOnly = true;
            this.txtRevReverb.Size = new System.Drawing.Size(53, 22);
            this.txtRevReverb.TabIndex = 2;
            // 
            // tbRevReverb
            // 
            this.tbRevReverb.LargeChange = 1;
            this.tbRevReverb.Location = new System.Drawing.Point(70, 38);
            this.tbRevReverb.Maximum = 100;
            this.tbRevReverb.Name = "tbRevReverb";
            this.tbRevReverb.Size = new System.Drawing.Size(188, 56);
            this.tbRevReverb.TabIndex = 1;
            this.tbRevReverb.ValueChanged += new System.EventHandler(this.tbRevReverb_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reverb";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDelIntensity);
            this.groupBox2.Controls.Add(this.txtDelDelay);
            this.groupBox2.Controls.Add(this.tbDelDelay);
            this.groupBox2.Controls.Add(this.tbDelIntensity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 202);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delay";
            // 
            // txtDelIntensity
            // 
            this.txtDelIntensity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDelIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelIntensity.Location = new System.Drawing.Point(9, 139);
            this.txtDelIntensity.Name = "txtDelIntensity";
            this.txtDelIntensity.ReadOnly = true;
            this.txtDelIntensity.Size = new System.Drawing.Size(53, 22);
            this.txtDelIntensity.TabIndex = 2;
            // 
            // txtDelDelay
            // 
            this.txtDelDelay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDelDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelDelay.Location = new System.Drawing.Point(9, 53);
            this.txtDelDelay.Name = "txtDelDelay";
            this.txtDelDelay.ReadOnly = true;
            this.txtDelDelay.Size = new System.Drawing.Size(53, 22);
            this.txtDelDelay.TabIndex = 2;
            // 
            // tbDelDelay
            // 
            this.tbDelDelay.LargeChange = 1;
            this.tbDelDelay.Location = new System.Drawing.Point(72, 33);
            this.tbDelDelay.Maximum = 100;
            this.tbDelDelay.Name = "tbDelDelay";
            this.tbDelDelay.Size = new System.Drawing.Size(188, 56);
            this.tbDelDelay.TabIndex = 1;
            this.tbDelDelay.ValueChanged += new System.EventHandler(this.tbDelDelay_ValueChanged);
            // 
            // tbDelIntensity
            // 
            this.tbDelIntensity.LargeChange = 1;
            this.tbDelIntensity.Location = new System.Drawing.Point(72, 119);
            this.tbDelIntensity.Maximum = 100;
            this.tbDelIntensity.Name = "tbDelIntensity";
            this.tbDelIntensity.Size = new System.Drawing.Size(188, 56);
            this.tbDelIntensity.TabIndex = 1;
            this.tbDelIntensity.ValueChanged += new System.EventHandler(this.tbDelIntensity_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Intensity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Delay";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDistTone);
            this.groupBox1.Controls.Add(this.txtDistGain);
            this.groupBox1.Controls.Add(this.tbDistTone);
            this.groupBox1.Controls.Add(this.tbDistGain);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distortion";
            // 
            // txtDistTone
            // 
            this.txtDistTone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDistTone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistTone.Location = new System.Drawing.Point(10, 139);
            this.txtDistTone.Name = "txtDistTone";
            this.txtDistTone.ReadOnly = true;
            this.txtDistTone.Size = new System.Drawing.Size(53, 22);
            this.txtDistTone.TabIndex = 2;
            // 
            // txtDistGain
            // 
            this.txtDistGain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDistGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistGain.Location = new System.Drawing.Point(10, 53);
            this.txtDistGain.Name = "txtDistGain";
            this.txtDistGain.ReadOnly = true;
            this.txtDistGain.Size = new System.Drawing.Size(53, 22);
            this.txtDistGain.TabIndex = 2;
            // 
            // tbDistTone
            // 
            this.tbDistTone.LargeChange = 1;
            this.tbDistTone.Location = new System.Drawing.Point(72, 119);
            this.tbDistTone.Maximum = 100;
            this.tbDistTone.Name = "tbDistTone";
            this.tbDistTone.Size = new System.Drawing.Size(188, 56);
            this.tbDistTone.TabIndex = 1;
            this.tbDistTone.ValueChanged += new System.EventHandler(this.tbDistTone_ValueChanged);
            // 
            // tbDistGain
            // 
            this.tbDistGain.LargeChange = 1;
            this.tbDistGain.Location = new System.Drawing.Point(72, 33);
            this.tbDistGain.Maximum = 100;
            this.tbDistGain.Name = "tbDistGain";
            this.tbDistGain.Size = new System.Drawing.Size(188, 56);
            this.tbDistGain.TabIndex = 1;
            this.tbDistGain.ValueChanged += new System.EventHandler(this.tbDistGain_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gain";
            // 
            // lbProfiles
            // 
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.ItemHeight = 16;
            this.lbProfiles.Location = new System.Drawing.Point(12, 97);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(168, 324);
            this.lbProfiles.TabIndex = 10;
            // 
            // btnOpenProfile
            // 
            this.btnOpenProfile.Location = new System.Drawing.Point(12, 13);
            this.btnOpenProfile.Name = "btnOpenProfile";
            this.btnOpenProfile.Size = new System.Drawing.Size(168, 36);
            this.btnOpenProfile.TabIndex = 9;
            this.btnOpenProfile.Text = "Open Profile Settings";
            this.btnOpenProfile.UseVisualStyleBackColor = true;
            this.btnOpenProfile.Click += new System.EventHandler(this.btnOpenProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(12, 55);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(168, 36);
            this.btnSaveProfile.TabIndex = 9;
            this.btnSaveProfile.Text = "Save Profile Settings";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(187, 501);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(167, 24);
            this.cmbBaudRate.TabIndex = 11;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(187, 471);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(167, 24);
            this.cmbPort.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "COM Port Selection";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Baud Rate Selection";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1121, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(109, 20);
            this.toolStripLabel.Text = "Not Connected";
            // 
            // progBarSendFX
            // 
            this.progBarSendFX.Location = new System.Drawing.Point(731, 501);
            this.progBarSendFX.Name = "progBarSendFX";
            this.progBarSendFX.Size = new System.Drawing.Size(168, 23);
            this.progBarSendFX.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Bluetooth Guitar FX";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlChor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLvlMaster)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChorRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChorDepth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRevReverb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDelIntensity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistTone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDistGain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbLvlChor;
        private System.Windows.Forms.TrackBar tbLvlRev;
        private System.Windows.Forms.TrackBar tbLvlDel;
        private System.Windows.Forms.TrackBar tbLvlDist;
        private System.Windows.Forms.TrackBar tbLvlMaster;
        private System.Windows.Forms.TrackBar tbChorRate;
        private System.Windows.Forms.TrackBar tbChorDepth;
        private System.Windows.Forms.TrackBar tbRevReverb;
        private System.Windows.Forms.TrackBar tbDelDelay;
        private System.Windows.Forms.TrackBar tbDelIntensity;
        private System.Windows.Forms.TrackBar tbDistTone;
        private System.Windows.Forms.TrackBar tbDistGain;
        private System.Windows.Forms.TextBox txtLvlChor;
        private System.Windows.Forms.TextBox txtLvlRev;
        private System.Windows.Forms.TextBox txtLvlDel;
        private System.Windows.Forms.TextBox txtLvlDist;
        private System.Windows.Forms.TextBox txtLvlMaster;
        private System.Windows.Forms.TextBox txtChorRate;
        private System.Windows.Forms.TextBox txtChorDepth;
        private System.Windows.Forms.TextBox txtRevReverb;
        private System.Windows.Forms.TextBox txtDelIntensity;
        private System.Windows.Forms.TextBox txtDelDelay;
        private System.Windows.Forms.TextBox txtDistTone;
        private System.Windows.Forms.TextBox txtDistGain;
        private System.Windows.Forms.ListBox lbProfiles;
        private System.Windows.Forms.Button btnSendFX;
        private System.Windows.Forms.Button btnOpenProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.ProgressBar progBarSendFX;
    }
}

