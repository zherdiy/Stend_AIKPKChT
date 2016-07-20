namespace StendAIKPKChT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIP = new System.Windows.Forms.Button();
            this.tboxIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.groupBoxIP = new System.Windows.Forms.GroupBox();
            this.groupBoxDrive = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbTopLeft = new System.Windows.Forms.RadioButton();
            this.rbBottomRight = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMotorColonna = new System.Windows.Forms.RadioButton();
            this.rbMotorKaretka = new System.Windows.Forms.RadioButton();
            this.chboxSlow = new System.Windows.Forms.CheckBox();
            this.labelDrive1 = new System.Windows.Forms.Label();
            this.labelDriveX = new System.Windows.Forms.Label();
            this.btnDriveGo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWork = new System.Windows.Forms.TabPage();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSlowPoint = new System.Windows.Forms.Button();
            this.btnStopPoint = new System.Windows.Forms.Button();
            this.btnACPPoint = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxBB88 = new System.Windows.Forms.GroupBox();
            this.chlbBB88 = new System.Windows.Forms.CheckedListBox();
            this.btnBB88 = new System.Windows.Forms.Button();
            this.groupBoxADC = new System.Windows.Forms.GroupBox();
            this.btnADCClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbADC2 = new System.Windows.Forms.TextBox();
            this.tbADC1 = new System.Windows.Forms.TextBox();
            this.btnADCStart = new System.Windows.Forms.Button();
            this.groupBoxSost = new System.Windows.Forms.GroupBox();
            this.chLBSost = new System.Windows.Forms.CheckedListBox();
            this.btnSost = new System.Windows.Forms.Button();
            this.groupBoxSensors = new System.Windows.Forms.GroupBox();
            this.btnStartCoord = new System.Windows.Forms.Button();
            this.btnCleareCoord = new System.Windows.Forms.Button();
            this.labelSensor = new System.Windows.Forms.Label();
            this.tboxCoord = new System.Windows.Forms.TextBox();
            this.rbtnKaretka = new System.Windows.Forms.RadioButton();
            this.rbtnColonna = new System.Windows.Forms.RadioButton();
            this.groupBoxTC = new System.Windows.Forms.GroupBox();
            this.btnTestClear = new System.Windows.Forms.Button();
            this.btnTestSend = new System.Windows.Forms.Button();
            this.tboxTestReceived = new System.Windows.Forms.TextBox();
            this.tboxTestSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSost = new System.Windows.Forms.Timer(this.components);
            this.chBoxPermitClear = new System.Windows.Forms.CheckBox();
            this.chBoxCoordClear = new System.Windows.Forms.CheckBox();
            this.btnCoordSost = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxIP.SuspendLayout();
            this.groupBoxDrive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxBB88.SuspendLayout();
            this.groupBoxADC.SuspendLayout();
            this.groupBoxSost.SuspendLayout();
            this.groupBoxSensors.SuspendLayout();
            this.groupBoxTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(202, 29);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 23);
            this.btnIP.TabIndex = 0;
            this.btnIP.Text = "Connect";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.buttonIP_Click);
            // 
            // tboxIP
            // 
            this.tboxIP.Location = new System.Drawing.Point(91, 31);
            this.tboxIP.Name = "tboxIP";
            this.tboxIP.Size = new System.Drawing.Size(100, 20);
            this.tboxIP.TabIndex = 1;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(4, 33);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(81, 13);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "Input IP-adress:";
            this.labelIP.UseWaitCursor = true;
            // 
            // groupBoxIP
            // 
            this.groupBoxIP.Controls.Add(this.labelIP);
            this.groupBoxIP.Controls.Add(this.tboxIP);
            this.groupBoxIP.Controls.Add(this.btnIP);
            this.groupBoxIP.Location = new System.Drawing.Point(6, 6);
            this.groupBoxIP.Name = "groupBoxIP";
            this.groupBoxIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxIP.Size = new System.Drawing.Size(294, 78);
            this.groupBoxIP.TabIndex = 3;
            this.groupBoxIP.TabStop = false;
            this.groupBoxIP.Text = "Connect to Stend";
            // 
            // groupBoxDrive
            // 
            this.groupBoxDrive.Controls.Add(this.panel2);
            this.groupBoxDrive.Controls.Add(this.panel1);
            this.groupBoxDrive.Controls.Add(this.chboxSlow);
            this.groupBoxDrive.Controls.Add(this.labelDrive1);
            this.groupBoxDrive.Controls.Add(this.labelDriveX);
            this.groupBoxDrive.Controls.Add(this.btnDriveGo);
            this.groupBoxDrive.Location = new System.Drawing.Point(316, 90);
            this.groupBoxDrive.Name = "groupBoxDrive";
            this.groupBoxDrive.Size = new System.Drawing.Size(294, 100);
            this.groupBoxDrive.TabIndex = 5;
            this.groupBoxDrive.TabStop = false;
            this.groupBoxDrive.Text = "Motors and Drive";
            this.groupBoxDrive.Enter += new System.EventHandler(this.groupBoxDrive_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbTopLeft);
            this.panel2.Controls.Add(this.rbBottomRight);
            this.panel2.Location = new System.Drawing.Point(185, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 48);
            this.panel2.TabIndex = 14;
            // 
            // rbTopLeft
            // 
            this.rbTopLeft.AutoSize = true;
            this.rbTopLeft.Location = new System.Drawing.Point(8, 3);
            this.rbTopLeft.Name = "rbTopLeft";
            this.rbTopLeft.Size = new System.Drawing.Size(67, 17);
            this.rbTopLeft.TabIndex = 4;
            this.rbTopLeft.Text = "Top/Left";
            this.rbTopLeft.UseVisualStyleBackColor = true;
            this.rbTopLeft.CheckedChanged += new System.EventHandler(this.radioButtonTopLeft_CheckedChanged);
            // 
            // rbBottomRight
            // 
            this.rbBottomRight.AutoSize = true;
            this.rbBottomRight.Location = new System.Drawing.Point(8, 28);
            this.rbBottomRight.Name = "rbBottomRight";
            this.rbBottomRight.Size = new System.Drawing.Size(88, 17);
            this.rbBottomRight.TabIndex = 5;
            this.rbBottomRight.Text = "Bottom/Right";
            this.rbBottomRight.UseVisualStyleBackColor = true;
            this.rbBottomRight.CheckedChanged += new System.EventHandler(this.radioButtonBottomRight_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMotorColonna);
            this.panel1.Controls.Add(this.rbMotorKaretka);
            this.panel1.Location = new System.Drawing.Point(49, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 49);
            this.panel1.TabIndex = 13;
            // 
            // rbMotorColonna
            // 
            this.rbMotorColonna.AutoSize = true;
            this.rbMotorColonna.Location = new System.Drawing.Point(8, 3);
            this.rbMotorColonna.Name = "rbMotorColonna";
            this.rbMotorColonna.Size = new System.Drawing.Size(64, 17);
            this.rbMotorColonna.TabIndex = 2;
            this.rbMotorColonna.Text = "Colonna";
            this.rbMotorColonna.UseVisualStyleBackColor = true;
            this.rbMotorColonna.CheckedChanged += new System.EventHandler(this.radioButtonMotorColonna_CheckedChanged);
            // 
            // rbMotorKaretka
            // 
            this.rbMotorKaretka.AutoSize = true;
            this.rbMotorKaretka.Location = new System.Drawing.Point(8, 26);
            this.rbMotorKaretka.Name = "rbMotorKaretka";
            this.rbMotorKaretka.Size = new System.Drawing.Size(62, 17);
            this.rbMotorKaretka.TabIndex = 3;
            this.rbMotorKaretka.Text = "Karetka";
            this.rbMotorKaretka.UseVisualStyleBackColor = true;
            this.rbMotorKaretka.CheckedChanged += new System.EventHandler(this.radioButtonMotorKaretka_CheckedChanged);
            // 
            // chboxSlow
            // 
            this.chboxSlow.AutoSize = true;
            this.chboxSlow.Location = new System.Drawing.Point(9, 77);
            this.chboxSlow.Name = "chboxSlow";
            this.chboxSlow.Size = new System.Drawing.Size(83, 17);
            this.chboxSlow.TabIndex = 11;
            this.chboxSlow.Text = "Slow motion";
            this.chboxSlow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chboxSlow.UseVisualStyleBackColor = true;
            // 
            // labelDrive1
            // 
            this.labelDrive1.AutoSize = true;
            this.labelDrive1.Location = new System.Drawing.Point(6, 19);
            this.labelDrive1.Name = "labelDrive1";
            this.labelDrive1.Size = new System.Drawing.Size(37, 13);
            this.labelDrive1.TabIndex = 7;
            this.labelDrive1.Text = "Motor:";
            // 
            // labelDriveX
            // 
            this.labelDriveX.AutoSize = true;
            this.labelDriveX.Location = new System.Drawing.Point(127, 19);
            this.labelDriveX.Name = "labelDriveX";
            this.labelDriveX.Size = new System.Drawing.Size(52, 13);
            this.labelDriveX.TabIndex = 6;
            this.labelDriveX.Text = "Direction:";
            // 
            // btnDriveGo
            // 
            this.btnDriveGo.Location = new System.Drawing.Point(210, 71);
            this.btnDriveGo.Name = "btnDriveGo";
            this.btnDriveGo.Size = new System.Drawing.Size(75, 23);
            this.btnDriveGo.TabIndex = 5;
            this.btnDriveGo.Text = "GO!";
            this.btnDriveGo.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWork);
            this.tabControl1.Controls.Add(this.tabPageTest);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 586);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageWork
            // 
            this.tabPageWork.Location = new System.Drawing.Point(4, 22);
            this.tabPageWork.Name = "tabPageWork";
            this.tabPageWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWork.Size = new System.Drawing.Size(619, 560);
            this.tabPageWork.TabIndex = 0;
            this.tabPageWork.Text = "Измерение";
            this.tabPageWork.UseVisualStyleBackColor = true;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.groupBox1);
            this.tabPageTest.Controls.Add(this.groupBoxBB88);
            this.tabPageTest.Controls.Add(this.groupBoxADC);
            this.tabPageTest.Controls.Add(this.groupBoxSost);
            this.tabPageTest.Controls.Add(this.groupBoxSensors);
            this.tabPageTest.Controls.Add(this.groupBoxTC);
            this.tabPageTest.Controls.Add(this.groupBoxIP);
            this.tabPageTest.Controls.Add(this.groupBoxDrive);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(619, 560);
            this.tabPageTest.TabIndex = 1;
            this.tabPageTest.Text = "Тестовый режим";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSlowPoint);
            this.groupBox1.Controls.Add(this.btnStopPoint);
            this.groupBox1.Controls.Add(this.btnACPPoint);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparators";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Slow move point:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stop point:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ACP start point:";
            // 
            // btnSlowPoint
            // 
            this.btnSlowPoint.Location = new System.Drawing.Point(204, 94);
            this.btnSlowPoint.Name = "btnSlowPoint";
            this.btnSlowPoint.Size = new System.Drawing.Size(75, 23);
            this.btnSlowPoint.TabIndex = 5;
            this.btnSlowPoint.Text = "SEND";
            this.btnSlowPoint.UseVisualStyleBackColor = true;
            // 
            // btnStopPoint
            // 
            this.btnStopPoint.Location = new System.Drawing.Point(204, 55);
            this.btnStopPoint.Name = "btnStopPoint";
            this.btnStopPoint.Size = new System.Drawing.Size(75, 23);
            this.btnStopPoint.TabIndex = 4;
            this.btnStopPoint.Text = "SEND";
            this.btnStopPoint.UseVisualStyleBackColor = true;
            // 
            // btnACPPoint
            // 
            this.btnACPPoint.Location = new System.Drawing.Point(204, 16);
            this.btnACPPoint.Name = "btnACPPoint";
            this.btnACPPoint.Size = new System.Drawing.Size(75, 23);
            this.btnACPPoint.TabIndex = 3;
            this.btnACPPoint.Text = "SEND";
            this.btnACPPoint.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxBB88
            // 
            this.groupBoxBB88.Controls.Add(this.chlbBB88);
            this.groupBoxBB88.Controls.Add(this.btnBB88);
            this.groupBoxBB88.Location = new System.Drawing.Point(316, 196);
            this.groupBoxBB88.Name = "groupBoxBB88";
            this.groupBoxBB88.Size = new System.Drawing.Size(294, 101);
            this.groupBoxBB88.TabIndex = 10;
            this.groupBoxBB88.TabStop = false;
            this.groupBoxBB88.Text = "Drive BB88M";
            // 
            // chlbBB88
            // 
            this.chlbBB88.FormattingEnabled = true;
            this.chlbBB88.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chlbBB88.Location = new System.Drawing.Point(16, 15);
            this.chlbBB88.Name = "chlbBB88";
            this.chlbBB88.Size = new System.Drawing.Size(176, 79);
            this.chlbBB88.TabIndex = 1;
            // 
            // btnBB88
            // 
            this.btnBB88.Location = new System.Drawing.Point(210, 19);
            this.btnBB88.Name = "btnBB88";
            this.btnBB88.Size = new System.Drawing.Size(75, 23);
            this.btnBB88.TabIndex = 0;
            this.btnBB88.Text = "SEND";
            this.btnBB88.UseVisualStyleBackColor = true;
            // 
            // groupBoxADC
            // 
            this.groupBoxADC.Controls.Add(this.btnADCClear);
            this.groupBoxADC.Controls.Add(this.label4);
            this.groupBoxADC.Controls.Add(this.label3);
            this.groupBoxADC.Controls.Add(this.tbADC2);
            this.groupBoxADC.Controls.Add(this.tbADC1);
            this.groupBoxADC.Controls.Add(this.btnADCStart);
            this.groupBoxADC.Location = new System.Drawing.Point(316, 303);
            this.groupBoxADC.Name = "groupBoxADC";
            this.groupBoxADC.Size = new System.Drawing.Size(294, 78);
            this.groupBoxADC.TabIndex = 9;
            this.groupBoxADC.TabStop = false;
            this.groupBoxADC.Text = "ADC";
            // 
            // btnADCClear
            // 
            this.btnADCClear.Location = new System.Drawing.Point(210, 45);
            this.btnADCClear.Name = "btnADCClear";
            this.btnADCClear.Size = new System.Drawing.Size(75, 23);
            this.btnADCClear.TabIndex = 5;
            this.btnADCClear.Text = "CLEAR";
            this.btnADCClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Channel 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Channel 1:";
            // 
            // tbADC2
            // 
            this.tbADC2.Location = new System.Drawing.Point(92, 48);
            this.tbADC2.Name = "tbADC2";
            this.tbADC2.Size = new System.Drawing.Size(100, 20);
            this.tbADC2.TabIndex = 2;
            // 
            // tbADC1
            // 
            this.tbADC1.Location = new System.Drawing.Point(92, 21);
            this.tbADC1.Name = "tbADC1";
            this.tbADC1.Size = new System.Drawing.Size(100, 20);
            this.tbADC1.TabIndex = 1;
            // 
            // btnADCStart
            // 
            this.btnADCStart.Location = new System.Drawing.Point(210, 18);
            this.btnADCStart.Name = "btnADCStart";
            this.btnADCStart.Size = new System.Drawing.Size(75, 23);
            this.btnADCStart.TabIndex = 0;
            this.btnADCStart.Text = "START";
            this.btnADCStart.UseVisualStyleBackColor = true;
            // 
            // groupBoxSost
            // 
            this.groupBoxSost.Controls.Add(this.chLBSost);
            this.groupBoxSost.Controls.Add(this.btnSost);
            this.groupBoxSost.Location = new System.Drawing.Point(6, 387);
            this.groupBoxSost.Name = "groupBoxSost";
            this.groupBoxSost.Size = new System.Drawing.Size(604, 164);
            this.groupBoxSost.TabIndex = 8;
            this.groupBoxSost.TabStop = false;
            this.groupBoxSost.Text = "Condition PLIS and ATV";
            // 
            // chLBSost
            // 
            this.chLBSost.ColumnWidth = 145;
            this.chLBSost.FormattingEnabled = true;
            this.chLBSost.Location = new System.Drawing.Point(7, 19);
            this.chLBSost.MultiColumn = true;
            this.chLBSost.Name = "chLBSost";
            this.chLBSost.Size = new System.Drawing.Size(495, 139);
            this.chLBSost.TabIndex = 11;
            // 
            // btnSost
            // 
            this.btnSost.Location = new System.Drawing.Point(520, 19);
            this.btnSost.Name = "btnSost";
            this.btnSost.Size = new System.Drawing.Size(75, 23);
            this.btnSost.TabIndex = 1;
            this.btnSost.Text = "START";
            this.btnSost.UseVisualStyleBackColor = true;
            this.btnSost.Click += new System.EventHandler(this.btnSost_Click);
            // 
            // groupBoxSensors
            // 
            this.groupBoxSensors.Controls.Add(this.label8);
            this.groupBoxSensors.Controls.Add(this.btnCoordSost);
            this.groupBoxSensors.Controls.Add(this.chBoxCoordClear);
            this.groupBoxSensors.Controls.Add(this.chBoxPermitClear);
            this.groupBoxSensors.Controls.Add(this.btnStartCoord);
            this.groupBoxSensors.Controls.Add(this.btnCleareCoord);
            this.groupBoxSensors.Controls.Add(this.labelSensor);
            this.groupBoxSensors.Controls.Add(this.tboxCoord);
            this.groupBoxSensors.Controls.Add(this.rbtnKaretka);
            this.groupBoxSensors.Controls.Add(this.rbtnColonna);
            this.groupBoxSensors.Location = new System.Drawing.Point(5, 90);
            this.groupBoxSensors.Name = "groupBoxSensors";
            this.groupBoxSensors.Size = new System.Drawing.Size(295, 132);
            this.groupBoxSensors.TabIndex = 7;
            this.groupBoxSensors.TabStop = false;
            this.groupBoxSensors.Text = "Coordinate sensors";
            // 
            // btnStartCoord
            // 
            this.btnStartCoord.Location = new System.Drawing.Point(77, 97);
            this.btnStartCoord.Name = "btnStartCoord";
            this.btnStartCoord.Size = new System.Drawing.Size(75, 23);
            this.btnStartCoord.TabIndex = 5;
            this.btnStartCoord.Text = "START";
            this.btnStartCoord.UseVisualStyleBackColor = true;
            this.btnStartCoord.Click += new System.EventHandler(this.btnStartCoord_Click);
            // 
            // btnCleareCoord
            // 
            this.btnCleareCoord.Location = new System.Drawing.Point(204, 97);
            this.btnCleareCoord.Name = "btnCleareCoord";
            this.btnCleareCoord.Size = new System.Drawing.Size(75, 23);
            this.btnCleareCoord.TabIndex = 4;
            this.btnCleareCoord.Text = "CLEAR";
            this.btnCleareCoord.UseVisualStyleBackColor = true;
            this.btnCleareCoord.Click += new System.EventHandler(this.btnCleareCoord_Click);
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Location = new System.Drawing.Point(6, 74);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(61, 13);
            this.labelSensor.TabIndex = 3;
            this.labelSensor.Text = "Coordinate:";
            this.labelSensor.Click += new System.EventHandler(this.labelSensor1_Click);
            // 
            // tboxCoord
            // 
            this.tboxCoord.Location = new System.Drawing.Point(77, 71);
            this.tboxCoord.Name = "tboxCoord";
            this.tboxCoord.Size = new System.Drawing.Size(202, 20);
            this.tboxCoord.TabIndex = 2;
            this.tboxCoord.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rbtnKaretka
            // 
            this.rbtnKaretka.AutoSize = true;
            this.rbtnKaretka.Location = new System.Drawing.Point(7, 43);
            this.rbtnKaretka.Name = "rbtnKaretka";
            this.rbtnKaretka.Size = new System.Drawing.Size(62, 17);
            this.rbtnKaretka.TabIndex = 1;
            this.rbtnKaretka.TabStop = true;
            this.rbtnKaretka.Text = "Karetka";
            this.rbtnKaretka.UseVisualStyleBackColor = true;
            // 
            // rbtnColonna
            // 
            this.rbtnColonna.AutoSize = true;
            this.rbtnColonna.Location = new System.Drawing.Point(7, 20);
            this.rbtnColonna.Name = "rbtnColonna";
            this.rbtnColonna.Size = new System.Drawing.Size(64, 17);
            this.rbtnColonna.TabIndex = 0;
            this.rbtnColonna.TabStop = true;
            this.rbtnColonna.Text = "Colonna";
            this.rbtnColonna.UseVisualStyleBackColor = true;
            // 
            // groupBoxTC
            // 
            this.groupBoxTC.Controls.Add(this.btnTestClear);
            this.groupBoxTC.Controls.Add(this.btnTestSend);
            this.groupBoxTC.Controls.Add(this.tboxTestReceived);
            this.groupBoxTC.Controls.Add(this.tboxTestSend);
            this.groupBoxTC.Controls.Add(this.label2);
            this.groupBoxTC.Controls.Add(this.label1);
            this.groupBoxTC.Location = new System.Drawing.Point(316, 7);
            this.groupBoxTC.Name = "groupBoxTC";
            this.groupBoxTC.Size = new System.Drawing.Size(294, 77);
            this.groupBoxTC.TabIndex = 6;
            this.groupBoxTC.TabStop = false;
            this.groupBoxTC.Text = "Test connection with STM32 and PLIS";
            // 
            // btnTestClear
            // 
            this.btnTestClear.Location = new System.Drawing.Point(210, 40);
            this.btnTestClear.Name = "btnTestClear";
            this.btnTestClear.Size = new System.Drawing.Size(75, 23);
            this.btnTestClear.TabIndex = 5;
            this.btnTestClear.Text = "CLEAR";
            this.btnTestClear.UseVisualStyleBackColor = true;
            // 
            // btnTestSend
            // 
            this.btnTestSend.Location = new System.Drawing.Point(210, 18);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(75, 23);
            this.btnTestSend.TabIndex = 4;
            this.btnTestSend.Text = "SEND";
            this.btnTestSend.UseVisualStyleBackColor = true;
            // 
            // tboxTestReceived
            // 
            this.tboxTestReceived.Location = new System.Drawing.Point(92, 42);
            this.tboxTestReceived.Name = "tboxTestReceived";
            this.tboxTestReceived.Size = new System.Drawing.Size(100, 20);
            this.tboxTestReceived.TabIndex = 3;
            // 
            // tboxTestSend
            // 
            this.tboxTestSend.Location = new System.Drawing.Point(92, 19);
            this.tboxTestSend.Name = "tboxTestSend";
            this.tboxTestSend.Size = new System.Drawing.Size(100, 20);
            this.tboxTestSend.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resieved digit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test digit:";
            // 
            // timerSost
            // 
            this.timerSost.Interval = 1000;
            this.timerSost.Tick += new System.EventHandler(this.timerSost_Tick);
            // 
            // chBoxPermitClear
            // 
            this.chBoxPermitClear.AutoSize = true;
            this.chBoxPermitClear.Location = new System.Drawing.Point(77, 20);
            this.chBoxPermitClear.Name = "chBoxPermitClear";
            this.chBoxPermitClear.Size = new System.Drawing.Size(82, 17);
            this.chBoxPermitClear.TabIndex = 6;
            this.chBoxPermitClear.Text = "Permit Clear";
            this.chBoxPermitClear.UseVisualStyleBackColor = true;
            // 
            // chBoxCoordClear
            // 
            this.chBoxCoordClear.AutoSize = true;
            this.chBoxCoordClear.Location = new System.Drawing.Point(77, 43);
            this.chBoxCoordClear.Name = "chBoxCoordClear";
            this.chBoxCoordClear.Size = new System.Drawing.Size(86, 17);
            this.chBoxCoordClear.TabIndex = 7;
            this.chBoxCoordClear.Text = "Clear Sensor";
            this.chBoxCoordClear.UseVisualStyleBackColor = true;
            // 
            // btnCoordSost
            // 
            this.btnCoordSost.Location = new System.Drawing.Point(202, 37);
            this.btnCoordSost.Name = "btnCoordSost";
            this.btnCoordSost.Size = new System.Drawing.Size(75, 23);
            this.btnCoordSost.TabIndex = 8;
            this.btnCoordSost.Text = "SEND";
            this.btnCoordSost.UseVisualStyleBackColor = true;
            this.btnCoordSost.Click += new System.EventHandler(this.btnCoordSost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "СТЕНД АИК-ПКЧ-Т";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIP.ResumeLayout(false);
            this.groupBoxIP.PerformLayout();
            this.groupBoxDrive.ResumeLayout(false);
            this.groupBoxDrive.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBB88.ResumeLayout(false);
            this.groupBoxADC.ResumeLayout(false);
            this.groupBoxADC.PerformLayout();
            this.groupBoxSost.ResumeLayout(false);
            this.groupBoxSensors.ResumeLayout(false);
            this.groupBoxSensors.PerformLayout();
            this.groupBoxTC.ResumeLayout(false);
            this.groupBoxTC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.TextBox tboxIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.GroupBox groupBoxIP;
        private System.Windows.Forms.GroupBox groupBoxDrive;
        private System.Windows.Forms.Label labelDrive1;
        private System.Windows.Forms.Label labelDriveX;
        private System.Windows.Forms.Button btnDriveGo;
        private System.Windows.Forms.CheckBox chboxSlow;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWork;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.GroupBox groupBoxSensors;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.TextBox tboxCoord;
        private System.Windows.Forms.RadioButton rbtnKaretka;
        private System.Windows.Forms.RadioButton rbtnColonna;
        private System.Windows.Forms.GroupBox groupBoxTC;
        private System.Windows.Forms.Button btnTestClear;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.TextBox tboxTestReceived;
        private System.Windows.Forms.TextBox tboxTestSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCleareCoord;
        private System.Windows.Forms.RadioButton rbMotorKaretka;
        private System.Windows.Forms.RadioButton rbMotorColonna;
        private System.Windows.Forms.RadioButton rbBottomRight;
        private System.Windows.Forms.RadioButton rbTopLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxSost;
        private System.Windows.Forms.Button btnSost;
        private System.Windows.Forms.Timer timerSost;
        private System.Windows.Forms.CheckedListBox chLBSost;
        private System.Windows.Forms.GroupBox groupBoxBB88;
        private System.Windows.Forms.CheckedListBox chlbBB88;
        private System.Windows.Forms.Button btnBB88;
        private System.Windows.Forms.GroupBox groupBoxADC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbADC2;
        private System.Windows.Forms.TextBox tbADC1;
        private System.Windows.Forms.Button btnADCStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSlowPoint;
        private System.Windows.Forms.Button btnStopPoint;
        private System.Windows.Forms.Button btnACPPoint;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartCoord;
        private System.Windows.Forms.Button btnADCClear;
        private System.Windows.Forms.Button btnCoordSost;
        private System.Windows.Forms.CheckBox chBoxCoordClear;
        private System.Windows.Forms.CheckBox chBoxPermitClear;
        private System.Windows.Forms.Label label8;
    }
}

