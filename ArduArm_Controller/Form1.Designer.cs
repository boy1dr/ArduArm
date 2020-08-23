namespace ArduArm_Controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkYaxisFlip = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.useGCode = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.speedAmount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valY = new System.Windows.Forms.Label();
            this.valX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valElbow = new System.Windows.Forms.Label();
            this.valShoulder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Line Loop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Draw Arm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 732);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(160, 720);
            this.trackBar1.Maximum = 35999;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(251, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shoulder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Elbow";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 50;
            this.trackBar2.Location = new System.Drawing.Point(453, 720);
            this.trackBar2.Maximum = 35999;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(251, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.TickFrequency = 1000;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(732, 618);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 85);
            this.button3.TabIndex = 16;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(934, 649);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 22);
            this.button7.TabIndex = 24;
            this.button7.Text = "Circles";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1032, 640);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 22);
            this.button8.TabIndex = 25;
            this.button8.Text = "Read";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "GCode Files|*.nc";
            this.openFileDialog1.InitialDirectory = "c:\\output";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(698, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 30);
            this.label10.TabIndex = 26;
            this.label10.Text = "ArduArm - Controller";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 308);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arm Simulator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(6, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 272);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.checkYaxisFlip);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(405, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 308);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canvas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(135, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 21);
            this.label18.TabIndex = 19;
            this.label18.Text = "label18";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(256, 280);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(43, 21);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Save";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkYaxisFlip
            // 
            this.checkYaxisFlip.AutoSize = true;
            this.checkYaxisFlip.Checked = true;
            this.checkYaxisFlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkYaxisFlip.Location = new System.Drawing.Point(6, 279);
            this.checkYaxisFlip.Name = "checkYaxisFlip";
            this.checkYaxisFlip.Size = new System.Drawing.Size(97, 25);
            this.checkYaxisFlip.TabIndex = 17;
            this.checkYaxisFlip.Text = "Flip Y axis";
            this.checkYaxisFlip.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 248);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 55);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.ToolTipText = "Read File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton5.Text = "Calibrate";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Concentric circles demo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Clear Canvas";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Exit program";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(251, 52);
            this.toolStripLabel1.Text = "ArduArm - Controller v1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.useGCode);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.speedAmount);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.valY);
            this.groupBox3.Controls.Add(this.valX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.valElbow);
            this.groupBox3.Controls.Add(this.valShoulder);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(718, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 308);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // useGCode
            // 
            this.useGCode.AutoSize = true;
            this.useGCode.Checked = true;
            this.useGCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useGCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.useGCode.Location = new System.Drawing.Point(222, 244);
            this.useGCode.Name = "useGCode";
            this.useGCode.Size = new System.Drawing.Size(67, 21);
            this.useGCode.TabIndex = 38;
            this.useGCode.Text = "GCode";
            this.useGCode.UseVisualStyleBackColor = true;
            this.useGCode.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(108, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 21);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Comm Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 29);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Text = "COM9";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightGray;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(6, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 29);
            this.label21.TabIndex = 35;
            this.label21.Text = "Comm Port";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(108, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 17);
            this.label19.TabIndex = 34;
            this.label19.Text = "1 fast - 1000 slow";
            // 
            // speedAmount
            // 
            this.speedAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedAmount.Location = new System.Drawing.Point(107, 158);
            this.speedAmount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.speedAmount.Name = "speedAmount";
            this.speedAmount.Size = new System.Drawing.Size(179, 27);
            this.speedAmount.TabIndex = 33;
            this.speedAmount.Text = "1";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightGray;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 27);
            this.label20.TabIndex = 32;
            this.label20.Text = "Speed";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(107, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(107, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "val X";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "val Y";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(107, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "0";
            // 
            // valY
            // 
            this.valY.BackColor = System.Drawing.Color.White;
            this.valY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valY.ForeColor = System.Drawing.Color.Black;
            this.valY.Location = new System.Drawing.Point(107, 359);
            this.valY.Name = "valY";
            this.valY.Size = new System.Drawing.Size(179, 19);
            this.valY.TabIndex = 18;
            this.valY.Text = "0";
            // 
            // valX
            // 
            this.valX.BackColor = System.Drawing.Color.White;
            this.valX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valX.ForeColor = System.Drawing.Color.Black;
            this.valX.Location = new System.Drawing.Point(107, 339);
            this.valX.Name = "valX";
            this.valX.Size = new System.Drawing.Size(179, 19);
            this.valX.TabIndex = 17;
            this.valX.Text = "0";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "X";
            // 
            // valElbow
            // 
            this.valElbow.BackColor = System.Drawing.Color.White;
            this.valElbow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valElbow.ForeColor = System.Drawing.Color.Black;
            this.valElbow.Location = new System.Drawing.Point(107, 48);
            this.valElbow.Name = "valElbow";
            this.valElbow.Size = new System.Drawing.Size(179, 19);
            this.valElbow.TabIndex = 10;
            this.valElbow.Text = "0";
            // 
            // valShoulder
            // 
            this.valShoulder.BackColor = System.Drawing.Color.White;
            this.valShoulder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valShoulder.ForeColor = System.Drawing.Color.Black;
            this.valShoulder.Location = new System.Drawing.Point(107, 28);
            this.valShoulder.Name = "valShoulder";
            this.valShoulder.Size = new System.Drawing.Size(179, 19);
            this.valShoulder.TabIndex = 9;
            this.valShoulder.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elbow";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shoulder";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "theta 1";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "theta 2";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(849, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Chris Mitchell - 2013";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(937, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "makenweb.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM9";
            this.serialPort1.ReceivedBytesThreshold = 4;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1023, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 298);
            this.textBox1.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 49);
            this.button4.TabIndex = 36;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(834, 484);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 33);
            this.button5.TabIndex = 37;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "GCode Files|*.nc";
            this.saveFileDialog1.InitialDirectory = "c:\\output\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1022, 390);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ArduArm-Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label valY;
        private System.Windows.Forms.Label valX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label valElbow;
        private System.Windows.Forms.Label valShoulder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox speedAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkYaxisFlip;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.CheckBox useGCode;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

