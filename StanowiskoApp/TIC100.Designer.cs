namespace StaowiskoApp
{
    partial class formTIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTIC));
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonDisconnect = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxTic100Status = new System.Windows.Forms.RichTextBox();
            this.panelTic = new System.Windows.Forms.Panel();
            this.tabControlTic = new System.Windows.Forms.TabControl();
            this.ticTabPage = new System.Windows.Forms.TabPage();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxTurboPump = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFailTime = new System.Windows.Forms.TextBox();
            this.buttonSetFailTime = new System.Windows.Forms.Button();
            this.buttonGetFailTime = new System.Windows.Forms.Button();
            this.buttonGetTurboPumpSpeed = new System.Windows.Forms.Button();
            this.buttonGetTurboPumpStatus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTurboPumpStbyOn = new System.Windows.Forms.Button();
            this.buttontTurboPumWorkTime = new System.Windows.Forms.Button();
            this.buttonTurboPumpPower = new System.Windows.Forms.Button();
            this.buttonConfigTurboPump = new System.Windows.Forms.Button();
            this.buttonPumpTypeList = new System.Windows.Forms.Button();
            this.buttonOnTurboPump = new System.Windows.Forms.Button();
            this.buttonOffTurboPump = new System.Windows.Forms.Button();
            this.buttonTurboPumpStatus = new System.Windows.Forms.Button();
            this.groupBoxTicInfo = new System.Windows.Forms.GroupBox();
            this.buttonTicStatus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.swButton = new System.Windows.Forms.Button();
            this.modelButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clrButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTurboPumpStbyOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBackingPumpStatus = new System.Windows.Forms.Button();
            this.buttonBackingPumpOff = new System.Windows.Forms.Button();
            this.buttonBackingPumpOn = new System.Windows.Forms.Button();
            this.buttonBackingPumpType = new System.Windows.Forms.Button();
            this.buttonBackingPumpSpeed = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGetBackingSequence = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.toolStripStatus.SuspendLayout();
            this.panelTic.SuspendLayout();
            this.tabControlTic.SuspendLayout();
            this.ticTabPage.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxTurboPump.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTicInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnect,
            this.toolStripTextBox,
            this.toolStripButtonDisconnect});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatus.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(886, 25);
            this.toolStripStatus.TabIndex = 2;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.ReadOnly = true;
            this.toolStripTextBox.Size = new System.Drawing.Size(330, 25);
            this.toolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButtonDisconnect
            // 
            this.toolStripButtonDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDisconnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButtonDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisconnect.Image")));
            this.toolStripButtonDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect.Name = "toolStripButtonDisconnect";
            this.toolStripButtonDisconnect.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonDisconnect.Text = "Disconnect";
            this.toolStripButtonDisconnect.Click += new System.EventHandler(this.toolStripButtonDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 13);
            this.panel1.TabIndex = 3;
            // 
            // richTextBoxTic100Status
            // 
            this.richTextBoxTic100Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTic100Status.BackColor = System.Drawing.Color.Black;
            this.richTextBoxTic100Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxTic100Status.ForeColor = System.Drawing.Color.White;
            this.richTextBoxTic100Status.Location = new System.Drawing.Point(619, 43);
            this.richTextBoxTic100Status.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxTic100Status.Name = "richTextBoxTic100Status";
            this.richTextBoxTic100Status.Size = new System.Drawing.Size(260, 505);
            this.richTextBoxTic100Status.TabIndex = 0;
            this.richTextBoxTic100Status.Text = "";
            // 
            // panelTic
            // 
            this.panelTic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTic.BackColor = System.Drawing.Color.Silver;
            this.panelTic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTic.Controls.Add(this.tabControlTic);
            this.panelTic.Location = new System.Drawing.Point(9, 43);
            this.panelTic.Margin = new System.Windows.Forms.Padding(2);
            this.panelTic.Name = "panelTic";
            this.panelTic.Size = new System.Drawing.Size(606, 544);
            this.panelTic.TabIndex = 5;
            // 
            // tabControlTic
            // 
            this.tabControlTic.Controls.Add(this.ticTabPage);
            this.tabControlTic.Controls.Add(this.tabPage2);
            this.tabControlTic.Enabled = false;
            this.tabControlTic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlTic.Location = new System.Drawing.Point(2, 2);
            this.tabControlTic.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlTic.Name = "tabControlTic";
            this.tabControlTic.SelectedIndex = 0;
            this.tabControlTic.Size = new System.Drawing.Size(747, 669);
            this.tabControlTic.TabIndex = 0;
            // 
            // ticTabPage
            // 
            this.ticTabPage.BackColor = System.Drawing.Color.Gray;
            this.ticTabPage.Controls.Add(this.groupBoxStatus);
            this.ticTabPage.Controls.Add(this.groupBoxTicInfo);
            this.ticTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ticTabPage.Location = new System.Drawing.Point(4, 24);
            this.ticTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ticTabPage.Name = "ticTabPage";
            this.ticTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ticTabPage.Size = new System.Drawing.Size(739, 641);
            this.ticTabPage.TabIndex = 0;
            this.ticTabPage.Text = "Settings";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.groupBox3);
            this.groupBoxStatus.Controls.Add(this.groupBoxTurboPump);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxStatus.Location = new System.Drawing.Point(4, 67);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStatus.Size = new System.Drawing.Size(583, 439);
            this.groupBoxStatus.TabIndex = 10;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "DEVICES:";
            // 
            // groupBoxTurboPump
            // 
            this.groupBoxTurboPump.Controls.Add(this.groupBox2);
            this.groupBoxTurboPump.Controls.Add(this.groupBox1);
            this.groupBoxTurboPump.Controls.Add(this.buttontTurboPumWorkTime);
            this.groupBoxTurboPump.Controls.Add(this.buttonTurboPumpPower);
            this.groupBoxTurboPump.Controls.Add(this.buttonConfigTurboPump);
            this.groupBoxTurboPump.Controls.Add(this.buttonPumpTypeList);
            this.groupBoxTurboPump.Controls.Add(this.buttonOnTurboPump);
            this.groupBoxTurboPump.Controls.Add(this.buttonOffTurboPump);
            this.groupBoxTurboPump.Controls.Add(this.buttonTurboPumpStatus);
            this.groupBoxTurboPump.Location = new System.Drawing.Point(8, 22);
            this.groupBoxTurboPump.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTurboPump.Name = "groupBoxTurboPump";
            this.groupBoxTurboPump.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTurboPump.Size = new System.Drawing.Size(223, 267);
            this.groupBoxTurboPump.TabIndex = 0;
            this.groupBoxTurboPump.TabStop = false;
            this.groupBoxTurboPump.Text = "Turbo Pump:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFailTime);
            this.groupBox1.Controls.Add(this.buttonSetFailTime);
            this.groupBox1.Controls.Add(this.buttonGetFailTime);
            this.groupBox1.Controls.Add(this.buttonGetTurboPumpSpeed);
            this.groupBox1.Controls.Add(this.buttonGetTurboPumpStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(5, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed:";
            // 
            // textBoxFailTime
            // 
            this.textBoxFailTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFailTime.Location = new System.Drawing.Point(155, 21);
            this.textBoxFailTime.Name = "textBoxFailTime";
            this.textBoxFailTime.Size = new System.Drawing.Size(45, 23);
            this.textBoxFailTime.TabIndex = 16;
            this.textBoxFailTime.Text = "0 0";
            this.textBoxFailTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSetFailTime
            // 
            this.buttonSetFailTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetFailTime.Location = new System.Drawing.Point(107, 50);
            this.buttonSetFailTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetFailTime.Name = "buttonSetFailTime";
            this.buttonSetFailTime.Size = new System.Drawing.Size(93, 25);
            this.buttonSetFailTime.TabIndex = 15;
            this.buttonSetFailTime.Text = "Set Fail Time";
            this.buttonSetFailTime.UseVisualStyleBackColor = true;
            this.buttonSetFailTime.Click += new System.EventHandler(this.buttonSetFailTime_Click);
            // 
            // buttonGetFailTime
            // 
            this.buttonGetFailTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetFailTime.Location = new System.Drawing.Point(10, 50);
            this.buttonGetFailTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetFailTime.Name = "buttonGetFailTime";
            this.buttonGetFailTime.Size = new System.Drawing.Size(93, 25);
            this.buttonGetFailTime.TabIndex = 14;
            this.buttonGetFailTime.Text = "Get Fail Time";
            this.buttonGetFailTime.UseVisualStyleBackColor = true;
            this.buttonGetFailTime.Click += new System.EventHandler(this.buttonGetFailTime_Click);
            // 
            // buttonGetTurboPumpSpeed
            // 
            this.buttonGetTurboPumpSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetTurboPumpSpeed.Location = new System.Drawing.Point(10, 21);
            this.buttonGetTurboPumpSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetTurboPumpSpeed.Name = "buttonGetTurboPumpSpeed";
            this.buttonGetTurboPumpSpeed.Size = new System.Drawing.Size(68, 25);
            this.buttonGetTurboPumpSpeed.TabIndex = 13;
            this.buttonGetTurboPumpSpeed.Text = "GET";
            this.buttonGetTurboPumpSpeed.UseVisualStyleBackColor = true;
            this.buttonGetTurboPumpSpeed.Click += new System.EventHandler(this.buttonGetTurboPumpSpeed_Click);
            // 
            // buttonGetTurboPumpStatus
            // 
            this.buttonGetTurboPumpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetTurboPumpStatus.Location = new System.Drawing.Point(82, 21);
            this.buttonGetTurboPumpStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetTurboPumpStatus.Name = "buttonGetTurboPumpStatus";
            this.buttonGetTurboPumpStatus.Size = new System.Drawing.Size(68, 25);
            this.buttonGetTurboPumpStatus.TabIndex = 10;
            this.buttonGetTurboPumpStatus.Text = "STATUS";
            this.buttonGetTurboPumpStatus.UseVisualStyleBackColor = true;
            this.buttonGetTurboPumpStatus.Click += new System.EventHandler(this.buttonGetTurboPumpStatus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(10, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "STATUS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTurboPumpStbyOn
            // 
            this.buttonTurboPumpStbyOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTurboPumpStbyOn.Location = new System.Drawing.Point(82, 21);
            this.buttonTurboPumpStbyOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTurboPumpStbyOn.Name = "buttonTurboPumpStbyOn";
            this.buttonTurboPumpStbyOn.Size = new System.Drawing.Size(57, 25);
            this.buttonTurboPumpStbyOn.TabIndex = 14;
            this.buttonTurboPumpStbyOn.Text = "ON";
            this.buttonTurboPumpStbyOn.UseVisualStyleBackColor = true;
            this.buttonTurboPumpStbyOn.Click += new System.EventHandler(this.buttonTurboPumpStbyOn_Click);
            // 
            // buttontTurboPumWorkTime
            // 
            this.buttontTurboPumWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttontTurboPumWorkTime.Location = new System.Drawing.Point(4, 78);
            this.buttontTurboPumWorkTime.Margin = new System.Windows.Forms.Padding(2);
            this.buttontTurboPumWorkTime.Name = "buttontTurboPumWorkTime";
            this.buttontTurboPumWorkTime.Size = new System.Drawing.Size(140, 25);
            this.buttontTurboPumWorkTime.TabIndex = 12;
            this.buttontTurboPumWorkTime.Text = "WORK TIME";
            this.buttontTurboPumWorkTime.UseVisualStyleBackColor = true;
            this.buttontTurboPumWorkTime.Click += new System.EventHandler(this.buttontTurboPumWorkTime_Click);
            // 
            // buttonTurboPumpPower
            // 
            this.buttonTurboPumpPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTurboPumpPower.Location = new System.Drawing.Point(148, 49);
            this.buttonTurboPumpPower.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTurboPumpPower.Name = "buttonTurboPumpPower";
            this.buttonTurboPumpPower.Size = new System.Drawing.Size(68, 25);
            this.buttonTurboPumpPower.TabIndex = 9;
            this.buttonTurboPumpPower.Text = "POWER";
            this.buttonTurboPumpPower.UseVisualStyleBackColor = true;
            // 
            // buttonConfigTurboPump
            // 
            this.buttonConfigTurboPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfigTurboPump.Location = new System.Drawing.Point(76, 49);
            this.buttonConfigTurboPump.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfigTurboPump.Name = "buttonConfigTurboPump";
            this.buttonConfigTurboPump.Size = new System.Drawing.Size(68, 25);
            this.buttonConfigTurboPump.TabIndex = 8;
            this.buttonConfigTurboPump.Text = "CONFIG";
            this.buttonConfigTurboPump.UseVisualStyleBackColor = true;
            this.buttonConfigTurboPump.Click += new System.EventHandler(this.buttonConfigTurboPump_Click);
            // 
            // buttonPumpTypeList
            // 
            this.buttonPumpTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPumpTypeList.Location = new System.Drawing.Point(4, 49);
            this.buttonPumpTypeList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPumpTypeList.Name = "buttonPumpTypeList";
            this.buttonPumpTypeList.Size = new System.Drawing.Size(68, 25);
            this.buttonPumpTypeList.TabIndex = 7;
            this.buttonPumpTypeList.Text = "TYPE";
            this.buttonPumpTypeList.UseVisualStyleBackColor = true;
            this.buttonPumpTypeList.Click += new System.EventHandler(this.buttonPumpTypeList_Click);
            // 
            // buttonOnTurboPump
            // 
            this.buttonOnTurboPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOnTurboPump.Location = new System.Drawing.Point(4, 20);
            this.buttonOnTurboPump.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOnTurboPump.Name = "buttonOnTurboPump";
            this.buttonOnTurboPump.Size = new System.Drawing.Size(68, 25);
            this.buttonOnTurboPump.TabIndex = 6;
            this.buttonOnTurboPump.Text = "ON";
            this.buttonOnTurboPump.UseVisualStyleBackColor = true;
            this.buttonOnTurboPump.Click += new System.EventHandler(this.buttonOnTurboPump_Click);
            // 
            // buttonOffTurboPump
            // 
            this.buttonOffTurboPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOffTurboPump.Location = new System.Drawing.Point(76, 20);
            this.buttonOffTurboPump.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOffTurboPump.Name = "buttonOffTurboPump";
            this.buttonOffTurboPump.Size = new System.Drawing.Size(68, 25);
            this.buttonOffTurboPump.TabIndex = 5;
            this.buttonOffTurboPump.Text = "OFF";
            this.buttonOffTurboPump.UseVisualStyleBackColor = true;
            this.buttonOffTurboPump.Click += new System.EventHandler(this.buttonOffTurboPump_Click);
            // 
            // buttonTurboPumpStatus
            // 
            this.buttonTurboPumpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTurboPumpStatus.Location = new System.Drawing.Point(148, 20);
            this.buttonTurboPumpStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTurboPumpStatus.Name = "buttonTurboPumpStatus";
            this.buttonTurboPumpStatus.Size = new System.Drawing.Size(68, 25);
            this.buttonTurboPumpStatus.TabIndex = 4;
            this.buttonTurboPumpStatus.Text = "STATUS";
            this.buttonTurboPumpStatus.UseVisualStyleBackColor = true;
            this.buttonTurboPumpStatus.Click += new System.EventHandler(this.buttonTurboPumpStatus_Click);
            // 
            // groupBoxTicInfo
            // 
            this.groupBoxTicInfo.Controls.Add(this.buttonTicStatus);
            this.groupBoxTicInfo.Controls.Add(this.button3);
            this.groupBoxTicInfo.Controls.Add(this.swButton);
            this.groupBoxTicInfo.Controls.Add(this.modelButton);
            this.groupBoxTicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxTicInfo.Location = new System.Drawing.Point(4, 5);
            this.groupBoxTicInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTicInfo.Name = "groupBoxTicInfo";
            this.groupBoxTicInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTicInfo.Size = new System.Drawing.Size(583, 61);
            this.groupBoxTicInfo.TabIndex = 9;
            this.groupBoxTicInfo.TabStop = false;
            this.groupBoxTicInfo.Text = "Info";
            // 
            // buttonTicStatus
            // 
            this.buttonTicStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTicStatus.Location = new System.Drawing.Point(220, 24);
            this.buttonTicStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTicStatus.Name = "buttonTicStatus";
            this.buttonTicStatus.Size = new System.Drawing.Size(66, 25);
            this.buttonTicStatus.TabIndex = 3;
            this.buttonTicStatus.Text = "STATUS";
            this.buttonTicStatus.UseVisualStyleBackColor = true;
            this.buttonTicStatus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(150, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "SERIAL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // swButton
            // 
            this.swButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.swButton.Location = new System.Drawing.Point(80, 24);
            this.swButton.Margin = new System.Windows.Forms.Padding(2);
            this.swButton.Name = "swButton";
            this.swButton.Size = new System.Drawing.Size(66, 25);
            this.swButton.TabIndex = 1;
            this.swButton.Text = "SW VER";
            this.swButton.UseVisualStyleBackColor = true;
            this.swButton.Click += new System.EventHandler(this.swButton_Click);
            // 
            // modelButton
            // 
            this.modelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelButton.Location = new System.Drawing.Point(9, 24);
            this.modelButton.Margin = new System.Windows.Forms.Padding(2);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(66, 25);
            this.modelButton.TabIndex = 0;
            this.modelButton.Text = "TYPE";
            this.modelButton.UseVisualStyleBackColor = true;
            this.modelButton.Click += new System.EventHandler(this.modelButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(739, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clrButton
            // 
            this.clrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clrButton.Location = new System.Drawing.Point(619, 552);
            this.clrButton.Margin = new System.Windows.Forms.Padding(2);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(259, 33);
            this.clrButton.TabIndex = 7;
            this.clrButton.Text = "CLEAR";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTurboPumpStbyOff);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonTurboPumpStbyOn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(5, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 61);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standby:";
            // 
            // buttonTurboPumpStbyOff
            // 
            this.buttonTurboPumpStbyOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTurboPumpStbyOff.Location = new System.Drawing.Point(143, 21);
            this.buttonTurboPumpStbyOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTurboPumpStbyOff.Name = "buttonTurboPumpStbyOff";
            this.buttonTurboPumpStbyOff.Size = new System.Drawing.Size(57, 25);
            this.buttonTurboPumpStbyOff.TabIndex = 17;
            this.buttonTurboPumpStbyOff.Text = "OFF";
            this.buttonTurboPumpStbyOff.UseVisualStyleBackColor = true;
            this.buttonTurboPumpStbyOff.Click += new System.EventHandler(this.buttonTurboPumpStbyOff_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGetBackingSequence);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonBackingPumpSpeed);
            this.groupBox3.Controls.Add(this.buttonBackingPumpType);
            this.groupBox3.Controls.Add(this.buttonBackingPumpOff);
            this.groupBox3.Controls.Add(this.buttonBackingPumpOn);
            this.groupBox3.Controls.Add(this.buttonBackingPumpStatus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(8, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 140);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backing Pump:";
            // 
            // buttonBackingPumpStatus
            // 
            this.buttonBackingPumpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackingPumpStatus.Location = new System.Drawing.Point(5, 21);
            this.buttonBackingPumpStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackingPumpStatus.Name = "buttonBackingPumpStatus";
            this.buttonBackingPumpStatus.Size = new System.Drawing.Size(68, 25);
            this.buttonBackingPumpStatus.TabIndex = 17;
            this.buttonBackingPumpStatus.Text = "STATUS";
            this.buttonBackingPumpStatus.UseVisualStyleBackColor = true;
            this.buttonBackingPumpStatus.Click += new System.EventHandler(this.buttonBackingPumpStatus_Click);
            // 
            // buttonBackingPumpOff
            // 
            this.buttonBackingPumpOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackingPumpOff.Location = new System.Drawing.Point(148, 21);
            this.buttonBackingPumpOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackingPumpOff.Name = "buttonBackingPumpOff";
            this.buttonBackingPumpOff.Size = new System.Drawing.Size(68, 25);
            this.buttonBackingPumpOff.TabIndex = 19;
            this.buttonBackingPumpOff.Text = "OFF";
            this.buttonBackingPumpOff.UseVisualStyleBackColor = true;
            this.buttonBackingPumpOff.Click += new System.EventHandler(this.buttonBackingPumpOff_Click);
            // 
            // buttonBackingPumpOn
            // 
            this.buttonBackingPumpOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackingPumpOn.Location = new System.Drawing.Point(76, 21);
            this.buttonBackingPumpOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackingPumpOn.Name = "buttonBackingPumpOn";
            this.buttonBackingPumpOn.Size = new System.Drawing.Size(68, 25);
            this.buttonBackingPumpOn.TabIndex = 18;
            this.buttonBackingPumpOn.Text = "ON";
            this.buttonBackingPumpOn.UseVisualStyleBackColor = true;
            this.buttonBackingPumpOn.Click += new System.EventHandler(this.buttonBackingPumpOn_Click);
            // 
            // buttonBackingPumpType
            // 
            this.buttonBackingPumpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackingPumpType.Location = new System.Drawing.Point(4, 50);
            this.buttonBackingPumpType.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackingPumpType.Name = "buttonBackingPumpType";
            this.buttonBackingPumpType.Size = new System.Drawing.Size(68, 25);
            this.buttonBackingPumpType.TabIndex = 20;
            this.buttonBackingPumpType.Text = "TYPE";
            this.buttonBackingPumpType.UseVisualStyleBackColor = true;
            this.buttonBackingPumpType.Click += new System.EventHandler(this.buttonBackingPumpType_Click);
            // 
            // buttonBackingPumpSpeed
            // 
            this.buttonBackingPumpSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackingPumpSpeed.Location = new System.Drawing.Point(76, 50);
            this.buttonBackingPumpSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackingPumpSpeed.Name = "buttonBackingPumpSpeed";
            this.buttonBackingPumpSpeed.Size = new System.Drawing.Size(68, 25);
            this.buttonBackingPumpSpeed.TabIndex = 21;
            this.buttonBackingPumpSpeed.Text = "SPEED";
            this.buttonBackingPumpSpeed.UseVisualStyleBackColor = true;
            this.buttonBackingPumpSpeed.Click += new System.EventHandler(this.buttonBackingPumpSpeed_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(4, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 54);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sequence:";
            // 
            // buttonGetBackingSequence
            // 
            this.buttonGetBackingSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGetBackingSequence.Location = new System.Drawing.Point(148, 50);
            this.buttonGetBackingSequence.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetBackingSequence.Name = "buttonGetBackingSequence";
            this.buttonGetBackingSequence.Size = new System.Drawing.Size(68, 25);
            this.buttonGetBackingSequence.TabIndex = 15;
            this.buttonGetBackingSequence.Text = "SEQ";
            this.buttonGetBackingSequence.UseVisualStyleBackColor = true;
            this.buttonGetBackingSequence.Click += new System.EventHandler(this.buttonGetBackingSequence_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(11, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(72, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stop";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(144, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "50 %";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // formTIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 596);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.richTextBoxTic100Status);
            this.Controls.Add(this.panelTic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formTIC";
            this.Text = "TIC100";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formTIC_FormClosed);
            this.Load += new System.EventHandler(this.formTIC_Load);
            this.Shown += new System.EventHandler(this.formTIC_Shown);
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.panelTic.ResumeLayout(false);
            this.tabControlTic.ResumeLayout(false);
            this.ticTabPage.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxTurboPump.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTicInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxTic100Status;
        private System.Windows.Forms.Panel panelTic;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.TabControl tabControlTic;
        private System.Windows.Forms.TabPage ticTabPage;
        private System.Windows.Forms.GroupBox groupBoxTicInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button swButton;
        private System.Windows.Forms.Button modelButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button buttonTicStatus;
        private System.Windows.Forms.GroupBox groupBoxTurboPump;
        private System.Windows.Forms.Button buttonTurboPumpStatus;
        private System.Windows.Forms.Button buttonOnTurboPump;
        private System.Windows.Forms.Button buttonOffTurboPump;
        private System.Windows.Forms.Button buttonPumpTypeList;
        private System.Windows.Forms.Button buttonConfigTurboPump;
        private System.Windows.Forms.Button buttonTurboPumpStbyOn;
        private System.Windows.Forms.Button buttonGetTurboPumpSpeed;
        private System.Windows.Forms.Button buttontTurboPumWorkTime;
        private System.Windows.Forms.Button buttonGetTurboPumpStatus;
        private System.Windows.Forms.Button buttonTurboPumpPower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFailTime;
        private System.Windows.Forms.Button buttonSetFailTime;
        private System.Windows.Forms.Button buttonGetFailTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTurboPumpStbyOff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonBackingPumpStatus;
        private System.Windows.Forms.Button buttonBackingPumpOff;
        private System.Windows.Forms.Button buttonBackingPumpOn;
        private System.Windows.Forms.Button buttonBackingPumpSpeed;
        private System.Windows.Forms.Button buttonBackingPumpType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonGetBackingSequence;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}