namespace InstaX2000
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPlats = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTrainNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPerson = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVagn5 = new System.Windows.Forms.Label();
            this.lblVagn4 = new System.Windows.Forms.Label();
            this.lblVagn3 = new System.Windows.Forms.Label();
            this.lblVagn2 = new System.Windows.Forms.Label();
            this.lblVagn1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbVagn5 = new System.Windows.Forms.RadioButton();
            this.rdbVagn4 = new System.Windows.Forms.RadioButton();
            this.rdbVagn3 = new System.Windows.Forms.RadioButton();
            this.rdbVagn2 = new System.Windows.Forms.RadioButton();
            this.rdbVagn1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstVagn = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblVagnNummer = new System.Windows.Forms.Label();
            this.lstBoxKontroller = new System.Windows.Forms.ListBox();
            this.btnSkapaKontroll = new System.Windows.Forms.Button();
            this.lblTrain = new System.Windows.Forms.Label();
            this.trainDisplay1 = new InstaControlLibrary.TrainDisplay();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.databaseToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFileToolStripMenuItem.Text = "Load Data";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPlats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxTrainNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X2000 Train specifications";
            // 
            // cmbPlats
            // 
            this.cmbPlats.FormattingEnabled = true;
            this.cmbPlats.Location = new System.Drawing.Point(91, 96);
            this.cmbPlats.Name = "cmbPlats";
            this.cmbPlats.Size = new System.Drawing.Size(107, 21);
            this.cmbPlats.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plats:";
            // 
            // cmbStation
            // 
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(93, 62);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(105, 21);
            this.cmbStation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Station";
            // 
            // txtBoxTrainNumber
            // 
            this.txtBoxTrainNumber.Location = new System.Drawing.Point(93, 28);
            this.txtBoxTrainNumber.Name = "txtBoxTrainNumber";
            this.txtBoxTrainNumber.Size = new System.Drawing.Size(105, 20);
            this.txtBoxTrainNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Utförd av:";
            // 
            // txtBoxPerson
            // 
            this.txtBoxPerson.Location = new System.Drawing.Point(94, 19);
            this.txtBoxPerson.Name = "txtBoxPerson";
            this.txtBoxPerson.Size = new System.Drawing.Size(104, 20);
            this.txtBoxPerson.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBoxPerson);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontroll Info";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Location = new System.Drawing.Point(97, 67);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(101, 20);
            this.txtBoxDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vagnsnummer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVagn5);
            this.groupBox3.Controls.Add(this.lblVagn4);
            this.groupBox3.Controls.Add(this.lblVagn3);
            this.groupBox3.Controls.Add(this.lblVagn2);
            this.groupBox3.Controls.Add(this.lblVagn1);
            this.groupBox3.Controls.Add(this.trainDisplay1);
            this.groupBox3.Location = new System.Drawing.Point(16, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 85);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Översikt";
            // 
            // lblVagn5
            // 
            this.lblVagn5.AutoSize = true;
            this.lblVagn5.Location = new System.Drawing.Point(284, 13);
            this.lblVagn5.Name = "lblVagn5";
            this.lblVagn5.Size = new System.Drawing.Size(41, 13);
            this.lblVagn5.TabIndex = 18;
            this.lblVagn5.Text = "Vagn 5";
            // 
            // lblVagn4
            // 
            this.lblVagn4.AutoSize = true;
            this.lblVagn4.Location = new System.Drawing.Point(237, 13);
            this.lblVagn4.Name = "lblVagn4";
            this.lblVagn4.Size = new System.Drawing.Size(41, 13);
            this.lblVagn4.TabIndex = 17;
            this.lblVagn4.Text = "Vagn 4";
            // 
            // lblVagn3
            // 
            this.lblVagn3.AutoSize = true;
            this.lblVagn3.Location = new System.Drawing.Point(190, 13);
            this.lblVagn3.Name = "lblVagn3";
            this.lblVagn3.Size = new System.Drawing.Size(41, 13);
            this.lblVagn3.TabIndex = 16;
            this.lblVagn3.Text = "Vagn 3";
            // 
            // lblVagn2
            // 
            this.lblVagn2.AutoSize = true;
            this.lblVagn2.Location = new System.Drawing.Point(133, 13);
            this.lblVagn2.Name = "lblVagn2";
            this.lblVagn2.Size = new System.Drawing.Size(41, 13);
            this.lblVagn2.TabIndex = 15;
            this.lblVagn2.Text = "Vagn 2";
            // 
            // lblVagn1
            // 
            this.lblVagn1.AutoSize = true;
            this.lblVagn1.Location = new System.Drawing.Point(86, 13);
            this.lblVagn1.Name = "lblVagn1";
            this.lblVagn1.Size = new System.Drawing.Size(41, 13);
            this.lblVagn1.TabIndex = 14;
            this.lblVagn1.Text = "Vagn 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(402, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 144);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kontroll Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbVagn5);
            this.groupBox5.Controls.Add(this.rdbVagn4);
            this.groupBox5.Controls.Add(this.rdbVagn3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.rdbVagn2);
            this.groupBox5.Controls.Add(this.rdbVagn1);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lstVagn);
            this.groupBox5.Location = new System.Drawing.Point(243, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 256);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "X2000 Vagn";
            // 
            // rdbVagn5
            // 
            this.rdbVagn5.AutoSize = true;
            this.rdbVagn5.Location = new System.Drawing.Point(23, 154);
            this.rdbVagn5.Name = "rdbVagn5";
            this.rdbVagn5.Size = new System.Drawing.Size(59, 17);
            this.rdbVagn5.TabIndex = 9;
            this.rdbVagn5.TabStop = true;
            this.rdbVagn5.Text = "Vagn 5";
            this.rdbVagn5.UseVisualStyleBackColor = true;
            this.rdbVagn5.CheckedChanged += new System.EventHandler(this.rdbVagn5_CheckedChanged);
            // 
            // rdbVagn4
            // 
            this.rdbVagn4.AutoSize = true;
            this.rdbVagn4.Location = new System.Drawing.Point(23, 131);
            this.rdbVagn4.Name = "rdbVagn4";
            this.rdbVagn4.Size = new System.Drawing.Size(56, 17);
            this.rdbVagn4.TabIndex = 8;
            this.rdbVagn4.TabStop = true;
            this.rdbVagn4.Text = "Vagn4";
            this.rdbVagn4.UseVisualStyleBackColor = true;
            this.rdbVagn4.CheckedChanged += new System.EventHandler(this.rdbVagn4_CheckedChanged);
            // 
            // rdbVagn3
            // 
            this.rdbVagn3.AutoSize = true;
            this.rdbVagn3.Location = new System.Drawing.Point(23, 108);
            this.rdbVagn3.Name = "rdbVagn3";
            this.rdbVagn3.Size = new System.Drawing.Size(59, 17);
            this.rdbVagn3.TabIndex = 7;
            this.rdbVagn3.TabStop = true;
            this.rdbVagn3.Text = "Vagn 3";
            this.rdbVagn3.UseVisualStyleBackColor = true;
            this.rdbVagn3.CheckedChanged += new System.EventHandler(this.rdbVagn3_CheckedChanged);
            // 
            // rdbVagn2
            // 
            this.rdbVagn2.AutoSize = true;
            this.rdbVagn2.Location = new System.Drawing.Point(23, 85);
            this.rdbVagn2.Name = "rdbVagn2";
            this.rdbVagn2.Size = new System.Drawing.Size(59, 17);
            this.rdbVagn2.TabIndex = 6;
            this.rdbVagn2.TabStop = true;
            this.rdbVagn2.Text = "Vagn 2";
            this.rdbVagn2.UseVisualStyleBackColor = true;
            this.rdbVagn2.CheckedChanged += new System.EventHandler(this.rdbVagn2_CheckedChanged);
            // 
            // rdbVagn1
            // 
            this.rdbVagn1.AutoSize = true;
            this.rdbVagn1.Location = new System.Drawing.Point(23, 62);
            this.rdbVagn1.Name = "rdbVagn1";
            this.rdbVagn1.Size = new System.Drawing.Size(59, 17);
            this.rdbVagn1.TabIndex = 5;
            this.rdbVagn1.TabStop = true;
            this.rdbVagn1.Text = "Vagn 1";
            this.rdbVagn1.UseVisualStyleBackColor = true;
            this.rdbVagn1.CheckedChanged += new System.EventHandler(this.rdbVagn1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(141, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Visa alla typer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vagns typ";
            // 
            // lstVagn
            // 
            this.lstVagn.FormattingEnabled = true;
            this.lstVagn.Location = new System.Drawing.Point(141, 41);
            this.lstVagn.Name = "lstVagn";
            this.lstVagn.Size = new System.Drawing.Size(103, 160);
            this.lstVagn.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTrain);
            this.groupBox6.Controls.Add(this.lblStatus);
            this.groupBox6.Controls.Add(this.lblTyp);
            this.groupBox6.Controls.Add(this.lblVagnNummer);
            this.groupBox6.Controls.Add(this.lstBoxKontroller);
            this.groupBox6.Location = new System.Drawing.Point(517, 48);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 327);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Utförda Kontroller";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(185, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(107, 16);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(25, 13);
            this.lblTyp.TabIndex = 2;
            this.lblTyp.Text = "Typ";
            // 
            // lblVagnNummer
            // 
            this.lblVagnNummer.AutoSize = true;
            this.lblVagnNummer.Location = new System.Drawing.Point(11, 16);
            this.lblVagnNummer.Name = "lblVagnNummer";
            this.lblVagnNummer.Size = new System.Drawing.Size(32, 13);
            this.lblVagnNummer.TabIndex = 1;
            this.lblVagnNummer.Text = "Vagn";
            // 
            // lstBoxKontroller
            // 
            this.lstBoxKontroller.FormattingEnabled = true;
            this.lstBoxKontroller.Location = new System.Drawing.Point(12, 32);
            this.lstBoxKontroller.Name = "lstBoxKontroller";
            this.lstBoxKontroller.Size = new System.Drawing.Size(251, 277);
            this.lstBoxKontroller.TabIndex = 0;
            // 
            // btnSkapaKontroll
            // 
            this.btnSkapaKontroll.Location = new System.Drawing.Point(418, 313);
            this.btnSkapaKontroll.Name = "btnSkapaKontroll";
            this.btnSkapaKontroll.Size = new System.Drawing.Size(66, 62);
            this.btnSkapaKontroll.TabIndex = 19;
            this.btnSkapaKontroll.Text = "Skapa Kontroll";
            this.btnSkapaKontroll.UseVisualStyleBackColor = true;
            this.btnSkapaKontroll.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Location = new System.Drawing.Point(49, 16);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(26, 13);
            this.lblTrain.TabIndex = 4;
            this.lblTrain.Text = "Tåg";
            // 
            // trainDisplay1
            // 
            this.trainDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trainDisplay1.Location = new System.Drawing.Point(21, 29);
            this.trainDisplay1.Name = "trainDisplay1";
            this.trainDisplay1.Size = new System.Drawing.Size(320, 50);
            this.trainDisplay1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 541);
            this.Controls.Add(this.btnSkapaKontroll);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Insta800 av X2000";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxTrainNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPerson;
        private System.Windows.Forms.GroupBox groupBox2;
        private InstaControlLibrary.TrainDisplay trainDisplay1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPlats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstVagn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstBoxKontroller;
        private System.Windows.Forms.Button btnSkapaKontroll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblVagnNummer;
        private System.Windows.Forms.RadioButton rdbVagn5;
        private System.Windows.Forms.RadioButton rdbVagn4;
        private System.Windows.Forms.RadioButton rdbVagn3;
        private System.Windows.Forms.RadioButton rdbVagn2;
        private System.Windows.Forms.RadioButton rdbVagn1;
        private System.Windows.Forms.Label lblVagn5;
        private System.Windows.Forms.Label lblVagn4;
        private System.Windows.Forms.Label lblVagn3;
        private System.Windows.Forms.Label lblVagn2;
        private System.Windows.Forms.Label lblVagn1;
        private System.Windows.Forms.Label lblTrain;
    }
}

