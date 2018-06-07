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
            this.DatabaseConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.TargetTableTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetDatabaseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceTableTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceDatabaseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetServerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceServerNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TargetTestConnection = new MetroFramework.Controls.MetroButton();
            this.SourcePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TargetServerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SourceTestConnection = new MetroFramework.Controls.MetroButton();
            this.TargetPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourcePasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceUsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceServerLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceConnectionLabel = new MetroFramework.Controls.MetroLabel();
            this.CompareTablesButton = new MetroFramework.Controls.MetroButton();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.DatabaseDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DatabaseConfigurationGroupBox.SuspendLayout();
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
            this.DatabaseDetailsGroupBox.Controls.Add(this.Tabs);
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
            this.DatabaseDetailsGroupBox.Size = new System.Drawing.Size(1075, 136);
            this.DatabaseDetailsGroupBox.TabIndex = 2;
            this.DatabaseDetailsGroupBox.TabStop = false;
            this.DatabaseDetailsGroupBox.Enter += new System.EventHandler(this.DatabaseDetailsGroupBox_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 53);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1021, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TargetServerNameLabel
            // 
            this.TargetServerNameLabel.Location = new System.Drawing.Point(796, 83);
            this.TargetServerNameLabel.Name = "TargetServerNameLabel";
            this.TargetServerNameLabel.Size = new System.Drawing.Size(200, 21);
            this.TargetServerNameLabel.TabIndex = 5;
            this.TargetServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TargetDatabaseName
            // 
            this.TargetDatabaseName.Location = new System.Drawing.Point(796, 102);
            this.TargetDatabaseName.Name = "TargetDatabaseName";
            this.TargetDatabaseName.Size = new System.Drawing.Size(200, 21);
            this.TargetDatabaseName.TabIndex = 6;
            this.TargetDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SourceServerNameLabel
            // 
            this.SourceServerNameLabel.AutoSize = true;
            this.SourceServerNameLabel.Location = new System.Drawing.Point(57, 83);
            this.SourceServerNameLabel.Name = "SourceServerNameLabel";
            this.SourceServerNameLabel.Size = new System.Drawing.Size(0, 0);
            this.SourceServerNameLabel.TabIndex = 3;
            this.SourceServerNameLabel.Click += new System.EventHandler(this.SourceServerNameLabel_Click);
            // 
            // SourceDatabaseName
            // 
            this.SourceDatabaseName.AutoSize = true;
            this.SourceDatabaseName.Location = new System.Drawing.Point(57, 102);
            this.SourceDatabaseName.Name = "SourceDatabaseName";
            this.SourceDatabaseName.Size = new System.Drawing.Size(0, 0);
            this.SourceDatabaseName.TabIndex = 4;
            // 
            // DatabaseConfigurationGroupBox
            // 
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetTableTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetDatabaseTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceTableTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceDatabaseTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetServerTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceServerNameTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel4);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel5);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetTestConnection);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourcePasswordTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetUsernameTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel6);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel7);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetServerLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel3);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel2);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel1);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceTestConnection);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetPasswordTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceUsernameTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourcePasswordLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceUsernameLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceServerLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceConnectionLabel);
            this.DatabaseConfigurationGroupBox.Location = new System.Drawing.Point(23, 205);
            this.DatabaseConfigurationGroupBox.Name = "DatabaseConfigurationGroupBox";
            this.DatabaseConfigurationGroupBox.Size = new System.Drawing.Size(1075, 382);
            this.DatabaseConfigurationGroupBox.TabIndex = 3;
            this.DatabaseConfigurationGroupBox.TabStop = false;
            this.DatabaseConfigurationGroupBox.Enter += new System.EventHandler(this.DatabaseConfigurationGroupBox_Enter);
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
            this.TargetTableTextBox.Lines = new string[0];
            this.TargetTableTextBox.Location = new System.Drawing.Point(619, 303);
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
            this.TargetDatabaseTextBox.Lines = new string[0];
            this.TargetDatabaseTextBox.Location = new System.Drawing.Point(619, 249);
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
            this.TargetDatabaseTextBox.UseSelectable = true;
            this.TargetDatabaseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetDatabaseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TargetDatabaseTextBox.TextChanged += new System.EventHandler(this.TargetDatabaseTextBox_TextChanged);
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
            this.SourceTableTextBox.Lines = new string[0];
            this.SourceTableTextBox.Location = new System.Drawing.Point(40, 303);
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
            this.SourceDatabaseTextBox.Lines = new string[0];
            this.SourceDatabaseTextBox.Location = new System.Drawing.Point(40, 249);
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
            this.SourceDatabaseTextBox.UseSelectable = true;
            this.SourceDatabaseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceDatabaseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SourceDatabaseTextBox.TextChanged += new System.EventHandler(this.SourceDatabaseTextBox_TextChanged);
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
            this.TargetServerTextBox.Lines = new string[0];
            this.TargetServerTextBox.Location = new System.Drawing.Point(619, 109);
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
            this.TargetServerTextBox.UseSelectable = true;
            this.TargetServerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetServerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TargetServerTextBox.TextChanged += new System.EventHandler(this.TargetServerTextBox_TextChanged);
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
            this.SourceServerNameTextBox.Lines = new string[0];
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
            this.SourceServerNameTextBox.UseSelectable = true;
            this.SourceServerNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceServerNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SourceServerNameTextBox.TextChanged += new System.EventHandler(this.SourceServerNameTextBox_TextChanged);
            this.SourceServerNameTextBox.Click += new System.EventHandler(this.SourceServerNameTextBox_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(595, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Table";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(595, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 25);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Database";
            // 
            // TargetTestConnection
            // 
            this.TargetTestConnection.Location = new System.Drawing.Point(900, 332);
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
            this.SourcePasswordTextBox.Lines = new string[0];
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
            this.TargetUsernameTextBox.Lines = new string[0];
            this.TargetUsernameTextBox.Location = new System.Drawing.Point(693, 144);
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
            this.TargetUsernameTextBox.UseSelectable = true;
            this.TargetUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(619, 173);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Password";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(619, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Username";
            // 
            // TargetServerLabel
            // 
            this.TargetServerLabel.AutoSize = true;
            this.TargetServerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TargetServerLabel.Location = new System.Drawing.Point(595, 81);
            this.TargetServerLabel.Name = "TargetServerLabel";
            this.TargetServerLabel.Size = new System.Drawing.Size(60, 25);
            this.TargetServerLabel.TabIndex = 13;
            this.TargetServerLabel.Text = "Server";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(16, 275);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Table";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 221);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Database";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(619, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Target Connection Details";
            // 
            // SourceTestConnection
            // 
            this.SourceTestConnection.Location = new System.Drawing.Point(321, 332);
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
            this.TargetPasswordTextBox.Lines = new string[0];
            this.TargetPasswordTextBox.Location = new System.Drawing.Point(693, 173);
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
            this.SourceUsernameTextBox.Lines = new string[0];
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
            this.SourceUsernameTextBox.UseSelectable = true;
            this.SourceUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourcePasswordLabel
            // 
            this.SourcePasswordLabel.AutoSize = true;
            this.SourcePasswordLabel.Location = new System.Drawing.Point(40, 173);
            this.SourcePasswordLabel.Name = "SourcePasswordLabel";
            this.SourcePasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.SourcePasswordLabel.TabIndex = 4;
            this.SourcePasswordLabel.Text = "Password";
            // 
            // SourceUsernameLabel
            // 
            this.SourceUsernameLabel.AutoSize = true;
            this.SourceUsernameLabel.Location = new System.Drawing.Point(40, 144);
            this.SourceUsernameLabel.Name = "SourceUsernameLabel";
            this.SourceUsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.SourceUsernameLabel.TabIndex = 3;
            this.SourceUsernameLabel.Text = "Username";
            // 
            // SourceServerLabel
            // 
            this.SourceServerLabel.AutoSize = true;
            this.SourceServerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceServerLabel.Location = new System.Drawing.Point(16, 81);
            this.SourceServerLabel.Name = "SourceServerLabel";
            this.SourceServerLabel.Size = new System.Drawing.Size(60, 25);
            this.SourceServerLabel.TabIndex = 1;
            this.SourceServerLabel.Text = "Server";
            // 
            // SourceConnectionLabel
            // 
            this.SourceConnectionLabel.AutoSize = true;
            this.SourceConnectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceConnectionLabel.Location = new System.Drawing.Point(6, 26);
            this.SourceConnectionLabel.Name = "SourceConnectionLabel";
            this.SourceConnectionLabel.Size = new System.Drawing.Size(211, 25);
            this.SourceConnectionLabel.TabIndex = 0;
            this.SourceConnectionLabel.Text = "Source Connection Details";
            // 
            // CompareTablesButton
            // 
            this.CompareTablesButton.Location = new System.Drawing.Point(934, 593);
            this.CompareTablesButton.Name = "CompareTablesButton";
            this.CompareTablesButton.Size = new System.Drawing.Size(164, 33);
            this.CompareTablesButton.TabIndex = 4;
            this.CompareTablesButton.Text = "Compare Tables";
            this.CompareTablesButton.UseSelectable = true;
            this.CompareTablesButton.Click += new System.EventHandler(this.CompareTablesButton_Click);
            // 
            // Tabs
            // 
            this.Tabs.Location = new System.Drawing.Point(256, 131);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(200, 100);
            this.Tabs.TabIndex = 34;
            this.Tabs.UseSelectable = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 649);
            this.Controls.Add(this.CompareTablesButton);
            this.Controls.Add(this.DatabaseConfigurationGroupBox);
            this.Controls.Add(this.DatabaseDetailsGroupBox);
            this.Name = "ConfigurationForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SQL Table Comparison";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.DatabaseDetailsGroupBox.ResumeLayout(false);
            this.DatabaseDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DatabaseConfigurationGroupBox.ResumeLayout(false);
            this.DatabaseConfigurationGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox DatabaseConfigurationGroupBox;
        private MetroFramework.Controls.MetroLabel SourceServerLabel;
        private MetroFramework.Controls.MetroLabel SourceConnectionLabel;
        private MetroFramework.Controls.MetroTextBox TargetPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox SourceUsernameTextBox;
        private MetroFramework.Controls.MetroLabel SourcePasswordLabel;
        private MetroFramework.Controls.MetroLabel SourceUsernameLabel;
        private MetroFramework.Controls.MetroButton SourceTestConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton TargetTestConnection;
        private MetroFramework.Controls.MetroTextBox SourcePasswordTextBox;
        private MetroFramework.Controls.MetroTextBox TargetUsernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel TargetServerLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton CompareTablesButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox TargetServerTextBox;
        private MetroFramework.Controls.MetroTextBox SourceServerNameTextBox;
        private MetroFramework.Controls.MetroTextBox SourceTableTextBox;
        private MetroFramework.Controls.MetroTextBox SourceDatabaseTextBox;
        private MetroFramework.Controls.MetroTextBox TargetTableTextBox;
        private MetroFramework.Controls.MetroTextBox TargetDatabaseTextBox;
        private MetroFramework.Controls.MetroTabControl Tabs;
    }
}

