using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace SQLTableComparison
{
    public partial class ConfigurationForm : MetroFramework.Forms.MetroForm
    {
        string sourceMsg = "Source";
        string targetMsg = "Target";
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            SourcePasswordTextBox.PasswordChar = '*';
            TargetPasswordTextBox.PasswordChar = '*';           
        }



        private void DatabaseConfigurationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SourceServerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SourceServerNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SourceServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SourceServerNameLabel.Text = SourceServerNameTextBox.Text;
        }

        private void TargetServerTextBox_TextChanged(object sender, EventArgs e)
        {
            TargetServerNameLabel.Text = TargetServerTextBox.Text;
        }


        private void SourceTestConnection_Click(object sender, EventArgs e)
        {
            TestSqlConnection testSourceConnection = new TestSqlConnection(SourceServerNameTextBox.Text, SourceUsernameTextBox.Text, SourcePasswordTextBox.Text, SourceDatabaseTextBox.Text, SourceTableTextBox.Text);
            DisplayConnection(testSourceConnection.TestConnectionCall(), sourceMsg);
        }



        private void TargetTestConnection_Click(object sender, EventArgs e)
        {
            TestSqlConnection testTargetConnection = new TestSqlConnection(TargetServerTextBox.Text, TargetUsernameTextBox.Text, TargetPasswordTextBox.Text, TargetDatabaseTextBox.Text, TargetTableTextBox.Text);
            DisplayConnection(testTargetConnection.TestConnectionCall(), targetMsg);
        }
        private void SourceDatabaseTextBox_TextChanged(object sender, EventArgs e)
        {
            SourceDatabaseName.Text = SourceDatabaseTextBox.Text;
        }

        private void TargetDatabaseTextBox_TextChanged(object sender, EventArgs e)
        {
            TargetDatabaseName.Text = TargetDatabaseTextBox.Text;
        }

        private void CompareTablesButton_Click(object sender, EventArgs e)
        {
            TestSqlConnection testTargetConnection = new TestSqlConnection(TargetServerTextBox.Text, TargetUsernameTextBox.Text, TargetPasswordTextBox.Text, TargetDatabaseTextBox.Text, TargetTableTextBox.Text);
            TestSqlConnection testSourceConnection = new TestSqlConnection(SourceServerNameTextBox.Text, SourceUsernameTextBox.Text, SourcePasswordTextBox.Text, SourceDatabaseTextBox.Text, SourceTableTextBox.Text);

            if (testTargetConnection.TestConnectionCall() && testSourceConnection.TestConnectionCall() == true)
            {
                GetSQLTable compareSourceConn = new GetSQLTable(@SourceServerNameTextBox.Text, SourceUsernameTextBox.Text, SourcePasswordTextBox.Text, SourceDatabaseTextBox.Text, SourceTableTextBox.Text);
                
                GetSQLTable compareTestConn = new GetSQLTable(@TargetServerTextBox.Text, TargetUsernameTextBox.Text, TargetPasswordTextBox.Text, TargetDatabaseTextBox.Text, TargetTableTextBox.Text);
            }
            else
            {
                DisplayConnection(testSourceConnection.TestConnectionCall(), sourceMsg);
                DisplayConnection(testTargetConnection.TestConnectionCall(), targetMsg);

            }
        }


        void DisplayConnection(bool isSuccessful, string connectionType)
        {
            if (!isSuccessful)
            {
                MetroMessageBox.Show(this, "The Connection For " + connectionType + " Was Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, "The Connection For " + connectionType + " Was Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DatabaseDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}