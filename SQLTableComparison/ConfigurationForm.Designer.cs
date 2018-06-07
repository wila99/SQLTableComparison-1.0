namespace SQLTableComparison
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.SourceLabel = new MetroFramework.Controls.MetroLabel();
            this.TargetLabel = new MetroFramework.Controls.MetroLabel();
            this.DatabaseDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TargetServerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.TargetDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.SourceServerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompareTablesButton = new MetroFramework.Controls.MetroButton();
            this.TargetTableTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetDatabaseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceTableTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceDatabaseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetServerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceServerNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TargetTestConnection = new MetroFramework.Controls.MetroButton();
            this.SourcePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.SourceTestConnection = new MetroFramework.Controls.MetroButton();
            this.TargetPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.ComparedTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SourceOut = new System.Windows.Forms.DataGridView();
            this.TargetOut = new System.Windows.Forms.DataGridView();
            this.DatabaseDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tabs.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ComparedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetOut)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SourceLabel.Location = new System.Drawing.Point(422, 16);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(70, 25);
            this.SourceLabel.TabIndex = 0;
            this.SourceLabel.Text = "Source";
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TargetLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TargetLabel.Location = new System.Drawing.Point(587, 16);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(66, 25);
            this.TargetLabel.TabIndex = 1;
            this.TargetLabel.Text = "Target";
            // 
            // DatabaseDetailsGroupBox
            // 
            this.DatabaseDetailsGroupBox.Controls.Add(this.pictureBox2);
            this.DatabaseDetailsGroupBox.Controls.Add(this.pictureBox1);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetServerNameLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetDatabaseName);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceServerNameLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceDatabaseName);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceLabel);
            this.DatabaseDetailsGroupBox.Location = new System.Drawing.Point(23, 63);
            this.DatabaseDetailsGroupBox.Name = "DatabaseDetailsGroupBox";
            this.DatabaseDetailsGroupBox.Size = new System.Drawing.Size(1161, 148);
            this.DatabaseDetailsGroupBox.TabIndex = 2;
            this.DatabaseDetailsGroupBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 53);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1106, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TargetServerNameLabel
            // 
            this.TargetServerNameLabel.Location = new System.Drawing.Point(787, 83);
            this.TargetServerNameLabel.Name = "TargetServerNameLabel";
            this.TargetServerNameLabel.Size = new System.Drawing.Size(318, 21);
            this.TargetServerNameLabel.TabIndex = 5;
            this.TargetServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TargetDatabaseName
            // 
            this.TargetDatabaseName.Location = new System.Drawing.Point(787, 109);
            this.TargetDatabaseName.Name = "TargetDatabaseName";
            this.TargetDatabaseName.Size = new System.Drawing.Size(318, 21);
            this.TargetDatabaseName.TabIndex = 6;
            this.TargetDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SourceServerNameLabel
            // 
            this.SourceServerNameLabel.Location = new System.Drawing.Point(58, 83);
            this.SourceServerNameLabel.Name = "SourceServerNameLabel";
            this.SourceServerNameLabel.Size = new System.Drawing.Size(200, 21);
            this.SourceServerNameLabel.TabIndex = 3;
            // 
            // SourceDatabaseName
            // 
            this.SourceDatabaseName.Location = new System.Drawing.Point(58, 109);
            this.SourceDatabaseName.Name = "SourceDatabaseName";
            this.SourceDatabaseName.Size = new System.Drawing.Size(200, 21);
            this.SourceDatabaseName.TabIndex = 4;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ConfigTab);
            this.Tabs.Controls.Add(this.ComparedTab);
            this.Tabs.Location = new System.Drawing.Point(23, 217);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 1;
            this.Tabs.Size = new System.Drawing.Size(1161, 578);
            this.Tabs.Style = MetroFramework.MetroColorStyle.Black;
            this.Tabs.TabIndex = 34;
            this.Tabs.UseSelectable = true;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // ConfigTab
            // 
            this.ConfigTab.BackColor = System.Drawing.Color.White;
            this.ConfigTab.Controls.Add(this.groupBox1);
            this.ConfigTab.Location = new System.Drawing.Point(4, 38);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Size = new System.Drawing.Size(1153, 536);
            this.ConfigTab.TabIndex = 0;
            this.ConfigTab.Text = "Configuration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompareTablesButton);
            this.groupBox1.Controls.Add(this.TargetTableTextBox);
            this.groupBox1.Controls.Add(this.TargetDatabaseTextBox);
            this.groupBox1.Controls.Add(this.SourceTableTextBox);
            this.groupBox1.Controls.Add(this.SourceDatabaseTextBox);
            this.groupBox1.Controls.Add(this.TargetServerTextBox);
            this.groupBox1.Controls.Add(this.SourceServerNameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.TargetTestConnection);
            this.groupBox1.Controls.Add(this.SourcePasswordTextBox);
            this.groupBox1.Controls.Add(this.TargetUsernameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.SourceTestConnection);
            this.groupBox1.Controls.Add(this.TargetPasswordTextBox);
            this.groupBox1.Controls.Add(this.SourceUsernameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroLabel17);
            this.groupBox1.Controls.Add(this.metroLabel18);
            this.groupBox1.Controls.Add(this.metroLabel19);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 530);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // CompareTablesButton
            // 
            this.CompareTablesButton.Location = new System.Drawing.Point(977, 491);
            this.CompareTablesButton.Name = "CompareTablesButton";
            this.CompareTablesButton.Size = new System.Drawing.Size(164, 33);
            this.CompareTablesButton.TabIndex = 34;
            this.CompareTablesButton.Text = "Compare Tables";
            this.CompareTablesButton.UseSelectable = true;
            this.CompareTablesButton.Click += new System.EventHandler(this.CompareTablesButton_Click);
            // 
            // TargetTableTextBox
            // 
            // 
            // 
            // 
            this.TargetTableTextBox.CustomButton.Image = null;
            this.TargetTableTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.TargetTableTextBox.CustomButton.Name = "";
            this.TargetTableTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetTableTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetTableTextBox.CustomButton.TabIndex = 1;
            this.TargetTableTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetTableTextBox.CustomButton.UseSelectable = true;
            this.TargetTableTextBox.CustomButton.Visible = false;
            this.TargetTableTextBox.Lines = new string[] {
        "TableTwo"};
            this.TargetTableTextBox.Location = new System.Drawing.Point(706, 287);
            this.TargetTableTextBox.MaxLength = 50;
            this.TargetTableTextBox.Name = "TargetTableTextBox";
            this.TargetTableTextBox.PasswordChar = '\0';
            this.TargetTableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetTableTextBox.SelectedText = "";
            this.TargetTableTextBox.SelectionLength = 0;
            this.TargetTableTextBox.SelectionStart = 0;
            this.TargetTableTextBox.ShortcutsEnabled = true;
            this.TargetTableTextBox.Size = new System.Drawing.Size(384, 23);
            this.TargetTableTextBox.TabIndex = 33;
            this.TargetTableTextBox.Text = "TableTwo";
            this.TargetTableTextBox.UseSelectable = true;
            this.TargetTableTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetTableTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TargetDatabaseTextBox
            // 
            // 
            // 
            // 
            this.TargetDatabaseTextBox.CustomButton.Image = null;
            this.TargetDatabaseTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.TargetDatabaseTextBox.CustomButton.Name = "";
            this.TargetDatabaseTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetDatabaseTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetDatabaseTextBox.CustomButton.TabIndex = 1;
            this.TargetDatabaseTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetDatabaseTextBox.CustomButton.UseSelectable = true;
            this.TargetDatabaseTextBox.CustomButton.Visible = false;
            this.TargetDatabaseTextBox.Lines = new string[] {
        "test"};
            this.TargetDatabaseTextBox.Location = new System.Drawing.Point(706, 233);
            this.TargetDatabaseTextBox.MaxLength = 50;
            this.TargetDatabaseTextBox.Name = "TargetDatabaseTextBox";
            this.TargetDatabaseTextBox.PasswordChar = '\0';
            this.TargetDatabaseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetDatabaseTextBox.SelectedText = "";
            this.TargetDatabaseTextBox.SelectionLength = 0;
            this.TargetDatabaseTextBox.SelectionStart = 0;
            this.TargetDatabaseTextBox.ShortcutsEnabled = true;
            this.TargetDatabaseTextBox.Size = new System.Drawing.Size(384, 23);
            this.TargetDatabaseTextBox.TabIndex = 32;
            this.TargetDatabaseTextBox.Text = "test";
            this.TargetDatabaseTextBox.UseSelectable = true;
            this.TargetDatabaseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetDatabaseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TargetDatabaseTextBox.TextChanged += new System.EventHandler(this.TargetDatabaseTextBox_TextChanged_1);
            // 
            // SourceTableTextBox
            // 
            // 
            // 
            // 
            this.SourceTableTextBox.CustomButton.Image = null;
            this.SourceTableTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.SourceTableTextBox.CustomButton.Name = "";
            this.SourceTableTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourceTableTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceTableTextBox.CustomButton.TabIndex = 1;
            this.SourceTableTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourceTableTextBox.CustomButton.UseSelectable = true;
            this.SourceTableTextBox.CustomButton.Visible = false;
            this.SourceTableTextBox.Lines = new string[] {
        "TableOne"};
            this.SourceTableTextBox.Location = new System.Drawing.Point(40, 287);
            this.SourceTableTextBox.MaxLength = 32767;
            this.SourceTableTextBox.Name = "SourceTableTextBox";
            this.SourceTableTextBox.PasswordChar = '\0';
            this.SourceTableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceTableTextBox.SelectedText = "";
            this.SourceTableTextBox.SelectionLength = 0;
            this.SourceTableTextBox.SelectionStart = 0;
            this.SourceTableTextBox.ShortcutsEnabled = true;
            this.SourceTableTextBox.Size = new System.Drawing.Size(384, 23);
            this.SourceTableTextBox.TabIndex = 28;
            this.SourceTableTextBox.Text = "TableOne";
            this.SourceTableTextBox.UseSelectable = true;
            this.SourceTableTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceTableTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourceDatabaseTextBox
            // 
            // 
            // 
            // 
            this.SourceDatabaseTextBox.CustomButton.Image = null;
            this.SourceDatabaseTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.SourceDatabaseTextBox.CustomButton.Name = "";
            this.SourceDatabaseTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourceDatabaseTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceDatabaseTextBox.CustomButton.TabIndex = 1;
            this.SourceDatabaseTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourceDatabaseTextBox.CustomButton.UseSelectable = true;
            this.SourceDatabaseTextBox.CustomButton.Visible = false;
            this.SourceDatabaseTextBox.Lines = new string[] {
        "test"};
            this.SourceDatabaseTextBox.Location = new System.Drawing.Point(40, 233);
            this.SourceDatabaseTextBox.MaxLength = 75;
            this.SourceDatabaseTextBox.Name = "SourceDatabaseTextBox";
            this.SourceDatabaseTextBox.PasswordChar = '\0';
            this.SourceDatabaseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceDatabaseTextBox.SelectedText = "";
            this.SourceDatabaseTextBox.SelectionLength = 0;
            this.SourceDatabaseTextBox.SelectionStart = 0;
            this.SourceDatabaseTextBox.ShortcutsEnabled = true;
            this.SourceDatabaseTextBox.Size = new System.Drawing.Size(384, 23);
            this.SourceDatabaseTextBox.TabIndex = 27;
            this.SourceDatabaseTextBox.Text = "test";
            this.SourceDatabaseTextBox.UseSelectable = true;
            this.SourceDatabaseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceDatabaseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SourceDatabaseTextBox.TextChanged += new System.EventHandler(this.SourceDatabaseTextBox_TextChanged_1);
            // 
            // TargetServerTextBox
            // 
            // 
            // 
            // 
            this.TargetServerTextBox.CustomButton.Image = null;
            this.TargetServerTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.TargetServerTextBox.CustomButton.Name = "";
            this.TargetServerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetServerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetServerTextBox.CustomButton.TabIndex = 1;
            this.TargetServerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetServerTextBox.CustomButton.UseSelectable = true;
            this.TargetServerTextBox.CustomButton.Visible = false;
            this.TargetServerTextBox.Lines = new string[] {
        "WIN10WARTER\\SQL2016XP"};
            this.TargetServerTextBox.Location = new System.Drawing.Point(706, 109);
            this.TargetServerTextBox.MaxLength = 50;
            this.TargetServerTextBox.Name = "TargetServerTextBox";
            this.TargetServerTextBox.PasswordChar = '\0';
            this.TargetServerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetServerTextBox.SelectedText = "";
            this.TargetServerTextBox.SelectionLength = 0;
            this.TargetServerTextBox.SelectionStart = 0;
            this.TargetServerTextBox.ShortcutsEnabled = true;
            this.TargetServerTextBox.Size = new System.Drawing.Size(384, 23);
            this.TargetServerTextBox.TabIndex = 29;
            this.TargetServerTextBox.Text = "WIN10WARTER\\SQL2016XP";
            this.TargetServerTextBox.UseSelectable = true;
            this.TargetServerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetServerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TargetServerTextBox.TextChanged += new System.EventHandler(this.TargetServerTextBox_TextChanged_1);
            // 
            // SourceServerNameTextBox
            // 
            // 
            // 
            // 
            this.SourceServerNameTextBox.CustomButton.Image = null;
            this.SourceServerNameTextBox.CustomButton.Location = new System.Drawing.Point(362, 1);
            this.SourceServerNameTextBox.CustomButton.Name = "";
            this.SourceServerNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourceServerNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceServerNameTextBox.CustomButton.TabIndex = 1;
            this.SourceServerNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourceServerNameTextBox.CustomButton.UseSelectable = true;
            this.SourceServerNameTextBox.CustomButton.Visible = false;
            this.SourceServerNameTextBox.Lines = new string[] {
        "WIN10WARTER\\SQL2016XP"};
            this.SourceServerNameTextBox.Location = new System.Drawing.Point(40, 109);
            this.SourceServerNameTextBox.MaxLength = 50;
            this.SourceServerNameTextBox.Name = "SourceServerNameTextBox";
            this.SourceServerNameTextBox.PasswordChar = '\0';
            this.SourceServerNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceServerNameTextBox.SelectedText = "";
            this.SourceServerNameTextBox.SelectionLength = 0;
            this.SourceServerNameTextBox.SelectionStart = 0;
            this.SourceServerNameTextBox.ShortcutsEnabled = true;
            this.SourceServerNameTextBox.Size = new System.Drawing.Size(384, 23);
            this.SourceServerNameTextBox.TabIndex = 24;
            this.SourceServerNameTextBox.Text = "WIN10WARTER\\SQL2016XP";
            this.SourceServerNameTextBox.UseSelectable = true;
            this.SourceServerNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceServerNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SourceServerNameTextBox.TextChanged += new System.EventHandler(this.SourceServerNameTextBox_TextChanged_1);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(682, 259);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Table";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(682, 205);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 25);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Database";
            // 
            // TargetTestConnection
            // 
            this.TargetTestConnection.Location = new System.Drawing.Point(987, 316);
            this.TargetTestConnection.Name = "TargetTestConnection";
            this.TargetTestConnection.Size = new System.Drawing.Size(103, 23);
            this.TargetTestConnection.TabIndex = 19;
            this.TargetTestConnection.Text = "Test Connection";
            this.TargetTestConnection.UseSelectable = true;
            this.TargetTestConnection.Click += new System.EventHandler(this.TargetTestConnection_Click);
            // 
            // SourcePasswordTextBox
            // 
            // 
            // 
            // 
            this.SourcePasswordTextBox.CustomButton.Image = null;
            this.SourcePasswordTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.SourcePasswordTextBox.CustomButton.Name = "";
            this.SourcePasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourcePasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourcePasswordTextBox.CustomButton.TabIndex = 1;
            this.SourcePasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourcePasswordTextBox.CustomButton.UseSelectable = true;
            this.SourcePasswordTextBox.CustomButton.Visible = false;
            this.SourcePasswordTextBox.Lines = new string[] {
        "strongSA1"};
            this.SourcePasswordTextBox.Location = new System.Drawing.Point(114, 173);
            this.SourcePasswordTextBox.MaxLength = 32767;
            this.SourcePasswordTextBox.Name = "SourcePasswordTextBox";
            this.SourcePasswordTextBox.PasswordChar = '\0';
            this.SourcePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourcePasswordTextBox.SelectedText = "";
            this.SourcePasswordTextBox.SelectionLength = 0;
            this.SourcePasswordTextBox.SelectionStart = 0;
            this.SourcePasswordTextBox.ShortcutsEnabled = true;
            this.SourcePasswordTextBox.Size = new System.Drawing.Size(310, 23);
            this.SourcePasswordTextBox.TabIndex = 26;
            this.SourcePasswordTextBox.Text = "strongSA1";
            this.SourcePasswordTextBox.UseSelectable = true;
            this.SourcePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourcePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TargetUsernameTextBox
            // 
            // 
            // 
            // 
            this.TargetUsernameTextBox.CustomButton.Image = null;
            this.TargetUsernameTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.TargetUsernameTextBox.CustomButton.Name = "";
            this.TargetUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetUsernameTextBox.CustomButton.TabIndex = 1;
            this.TargetUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetUsernameTextBox.CustomButton.UseSelectable = true;
            this.TargetUsernameTextBox.CustomButton.Visible = false;
            this.TargetUsernameTextBox.Lines = new string[] {
        "SA"};
            this.TargetUsernameTextBox.Location = new System.Drawing.Point(780, 144);
            this.TargetUsernameTextBox.MaxLength = 32767;
            this.TargetUsernameTextBox.Name = "TargetUsernameTextBox";
            this.TargetUsernameTextBox.PasswordChar = '\0';
            this.TargetUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetUsernameTextBox.SelectedText = "";
            this.TargetUsernameTextBox.SelectionLength = 0;
            this.TargetUsernameTextBox.SelectionStart = 0;
            this.TargetUsernameTextBox.ShortcutsEnabled = true;
            this.TargetUsernameTextBox.Size = new System.Drawing.Size(310, 23);
            this.TargetUsernameTextBox.TabIndex = 30;
            this.TargetUsernameTextBox.Text = "SA";
            this.TargetUsernameTextBox.UseSelectable = true;
            this.TargetUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(706, 173);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 19);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Password";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(706, 144);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(68, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Username";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(682, 81);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(60, 25);
            this.metroLabel12.TabIndex = 13;
            this.metroLabel12.Text = "Server";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(16, 259);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(50, 25);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "Table";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(16, 205);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 25);
            this.metroLabel14.TabIndex = 9;
            this.metroLabel14.Text = "Database";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(661, 26);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(204, 25);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "Target Connection Details";
            // 
            // SourceTestConnection
            // 
            this.SourceTestConnection.Location = new System.Drawing.Point(321, 316);
            this.SourceTestConnection.Name = "SourceTestConnection";
            this.SourceTestConnection.Size = new System.Drawing.Size(103, 23);
            this.SourceTestConnection.TabIndex = 7;
            this.SourceTestConnection.Text = "Test Connection";
            this.SourceTestConnection.UseSelectable = true;
            this.SourceTestConnection.Click += new System.EventHandler(this.SourceTestConnection_Click);
            // 
            // TargetPasswordTextBox
            // 
            // 
            // 
            // 
            this.TargetPasswordTextBox.CustomButton.Image = null;
            this.TargetPasswordTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.TargetPasswordTextBox.CustomButton.Name = "";
            this.TargetPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetPasswordTextBox.CustomButton.TabIndex = 1;
            this.TargetPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetPasswordTextBox.CustomButton.UseSelectable = true;
            this.TargetPasswordTextBox.CustomButton.Visible = false;
            this.TargetPasswordTextBox.Lines = new string[] {
        "strongSA1"};
            this.TargetPasswordTextBox.Location = new System.Drawing.Point(780, 173);
            this.TargetPasswordTextBox.MaxLength = 32767;
            this.TargetPasswordTextBox.Name = "TargetPasswordTextBox";
            this.TargetPasswordTextBox.PasswordChar = '\0';
            this.TargetPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetPasswordTextBox.SelectedText = "";
            this.TargetPasswordTextBox.SelectionLength = 0;
            this.TargetPasswordTextBox.SelectionStart = 0;
            this.TargetPasswordTextBox.ShortcutsEnabled = true;
            this.TargetPasswordTextBox.Size = new System.Drawing.Size(310, 23);
            this.TargetPasswordTextBox.TabIndex = 31;
            this.TargetPasswordTextBox.Text = "strongSA1";
            this.TargetPasswordTextBox.UseSelectable = true;
            this.TargetPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourceUsernameTextBox
            // 
            // 
            // 
            // 
            this.SourceUsernameTextBox.CustomButton.Image = null;
            this.SourceUsernameTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.SourceUsernameTextBox.CustomButton.Name = "";
            this.SourceUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourceUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceUsernameTextBox.CustomButton.TabIndex = 1;
            this.SourceUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourceUsernameTextBox.CustomButton.UseSelectable = true;
            this.SourceUsernameTextBox.CustomButton.Visible = false;
            this.SourceUsernameTextBox.Lines = new string[] {
        "SA"};
            this.SourceUsernameTextBox.Location = new System.Drawing.Point(114, 144);
            this.SourceUsernameTextBox.MaxLength = 32767;
            this.SourceUsernameTextBox.Name = "SourceUsernameTextBox";
            this.SourceUsernameTextBox.PasswordChar = '\0';
            this.SourceUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceUsernameTextBox.SelectedText = "";
            this.SourceUsernameTextBox.SelectionLength = 0;
            this.SourceUsernameTextBox.SelectionStart = 0;
            this.SourceUsernameTextBox.ShortcutsEnabled = true;
            this.SourceUsernameTextBox.Size = new System.Drawing.Size(310, 23);
            this.SourceUsernameTextBox.TabIndex = 25;
            this.SourceUsernameTextBox.Text = "SA";
            this.SourceUsernameTextBox.UseSelectable = true;
            this.SourceUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(40, 173);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(63, 19);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "Password";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(40, 144);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(68, 19);
            this.metroLabel17.TabIndex = 3;
            this.metroLabel17.Text = "Username";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.Location = new System.Drawing.Point(16, 81);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(60, 25);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Server";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.Location = new System.Drawing.Point(6, 26);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(211, 25);
            this.metroLabel19.TabIndex = 0;
            this.metroLabel19.Text = "Source Connection Details";
            // 
            // ComparedTab
            // 
            this.ComparedTab.BackColor = System.Drawing.Color.White;
            this.ComparedTab.Controls.Add(this.splitContainer1);
            this.ComparedTab.Location = new System.Drawing.Point(4, 38);
            this.ComparedTab.Name = "ComparedTab";
            this.ComparedTab.Size = new System.Drawing.Size(1153, 536);
            this.ComparedTab.TabIndex = 1;
            this.ComparedTab.Text = "Compared";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SourceOut);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TargetOut);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 536);
            this.splitContainer1.SplitterDistance = 576;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 37;
            // 
            // SourceOut
            // 
            this.SourceOut.AllowUserToAddRows = false;
            this.SourceOut.AllowUserToDeleteRows = false;
            this.SourceOut.BackgroundColor = System.Drawing.Color.White;
            this.SourceOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SourceOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.SourceOut.Enabled = false;
            this.SourceOut.Location = new System.Drawing.Point(0, 0);
            this.SourceOut.Name = "SourceOut";
            this.SourceOut.ReadOnly = true;
            this.SourceOut.ShowEditingIcon = false;
            this.SourceOut.ShowRowErrors = false;
            this.SourceOut.Size = new System.Drawing.Size(576, 536);
            this.SourceOut.TabIndex = 36;
            // 
            // TargetOut
            // 
            this.TargetOut.AllowUserToAddRows = false;
            this.TargetOut.AllowUserToDeleteRows = false;
            this.TargetOut.BackgroundColor = System.Drawing.Color.White;
            this.TargetOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TargetOut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TargetOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetOut.Location = new System.Drawing.Point(0, 0);
            this.TargetOut.Name = "TargetOut";
            this.TargetOut.ReadOnly = true;
            this.TargetOut.Size = new System.Drawing.Size(576, 536);
            this.TargetOut.TabIndex = 37;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.DatabaseDetailsGroupBox);
            this.Name = "ConfigurationForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SQL Table Comparison";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.DatabaseDetailsGroupBox.ResumeLayout(false);
            this.DatabaseDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.ConfigTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ComparedTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel SourceLabel;
        private MetroFramework.Controls.MetroLabel TargetLabel;
        private System.Windows.Forms.GroupBox DatabaseDetailsGroupBox;
        private MetroFramework.Controls.MetroLabel SourceServerNameLabel;
        private MetroFramework.Controls.MetroLabel SourceDatabaseName;
        private MetroFramework.Controls.MetroLabel TargetServerNameLabel;
        private MetroFramework.Controls.MetroLabel TargetDatabaseName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTabControl Tabs;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.TabPage ComparedTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TargetTableTextBox;
        private MetroFramework.Controls.MetroTextBox TargetDatabaseTextBox;
        private MetroFramework.Controls.MetroTextBox SourceTableTextBox;
        private MetroFramework.Controls.MetroTextBox SourceDatabaseTextBox;
        private MetroFramework.Controls.MetroTextBox TargetServerTextBox;
        private MetroFramework.Controls.MetroTextBox SourceServerNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton TargetTestConnection;
        private MetroFramework.Controls.MetroTextBox SourcePasswordTextBox;
        private MetroFramework.Controls.MetroTextBox TargetUsernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton SourceTestConnection;
        private MetroFramework.Controls.MetroTextBox TargetPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox SourceUsernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private System.Windows.Forms.DataGridView SourceOut;
        private MetroFramework.Controls.MetroButton CompareTablesButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView TargetOut;
    }
}

