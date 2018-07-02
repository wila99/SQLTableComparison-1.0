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
        ResultContext resultContext;
        Retrieve sourceRetrieve = new Retrieve();
        Retrieve targetRetrieve = new Retrieve();
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            SourcePasswordTextBox.PasswordChar = '*';
            TargetPasswordTextBox.PasswordChar = '*';
        }

        private void SourceTestConnection_Click(object sender, EventArgs e)
        {
            Connection testSourceConnection = new Connection { Database = SourceDatabaseTextBox.Text, Server = SourceServerNameTextBox.Text, Username = SourceUsernameTextBox.Text, Password = SourcePasswordTextBox.Text, Table = SourceTableTextBox.Text };
            testSourceConnection.SetConnection();
            DisplayConnection(testSourceConnection.TestConnection(), sourceMsg);
        }



        private void TargetTestConnection_Click(object sender, EventArgs e)
        {
            Connection testTargetConnection = new Connection { Database = TargetDatabaseTextBox.Text, Server = @TargetServerTextBox.Text, Username = TargetUsernameTextBox.Text, Password = TargetPasswordTextBox.Text, Table = TargetTableTextBox.Text };
            testTargetConnection.SetConnection();
            DisplayConnection(testTargetConnection.TestConnection(), targetMsg);
        }


        private void CompareTablesButton_Click(object sender, EventArgs e)
        {
            

            Connection sourceConnection = new Connection { Database = SourceDatabaseTextBox.Text, Server = SourceServerNameTextBox.Text, Username = SourceUsernameTextBox.Text, Password = SourcePasswordTextBox.Text, Table = SourceTableTextBox.Text };
            Connection targetConnection = new Connection { Database = TargetDatabaseTextBox.Text, Server = @TargetServerTextBox.Text, Username = TargetUsernameTextBox.Text, Password = TargetPasswordTextBox.Text, Table = TargetTableTextBox.Text };

            sourceConnection.SetConnection();
            targetConnection.SetConnection();

            if (sourceConnection.TestConnection() && targetConnection.TestConnection() == true)
            {
                sourceRetrieve.QueryTable(sourceConnection);
                targetRetrieve.QueryTable(targetConnection);

                CompareByRow compare = new CompareByRow(sourceRetrieve.dataSet.Tables[0], targetRetrieve.dataSet.Tables[0], 0);

                resultContext = compare.CompareTables();
                SourceOut.DataSource = sourceRetrieve.dataSet.Tables[0];
                TargetOut.DataSource = targetRetrieve.dataSet.Tables[0];


            }
            else
            {
                DisplayConnection(false, sourceMsg);
                DisplayConnection(false, targetMsg);

            }
        }


        void DisplayConnection(bool isSuccessful, string connectionType)
        {
            if (!isSuccessful)
            {
                MetroMessageBox.Show(this, $"The Connection For {connectionType} Was Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, $"The Connection For {connectionType} Was Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SourceServerNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            SourceServerNameLabel.Text = SourceServerNameTextBox.Text;
        }

        private void TargetServerTextBox_TextChanged_1(object sender, EventArgs e)
        {
            TargetServerNameLabel.Text = TargetServerTextBox.Text;

        }

        private void SourceDatabaseTextBox_TextChanged_1(object sender, EventArgs e)
        {
            SourceDatabaseName.Text = SourceDatabaseTextBox.Text;

        }

        private void TargetDatabaseTextBox_TextChanged_1(object sender, EventArgs e)
        {
            TargetDatabaseName.Text = TargetDatabaseTextBox.Text;
        }
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SourceOut.DataSource != null)
            {
                DataGridViewCellStyle diffStyle = new DataGridViewCellStyle();
                diffStyle.BackColor = Color.Orange;
                diffStyle.ForeColor = Color.Black;

                foreach (var item in resultContext.coCells)
                {
                    SourceOut.Rows[item.x].Cells[item.y].Style = diffStyle;
                }
            }
            if (TargetOut.DataSource != null)
            {
                DataGridViewCellStyle diffStyle = new DataGridViewCellStyle();
                diffStyle.BackColor = Color.Orange;
                diffStyle.ForeColor = Color.Black;

                foreach (var item in resultContext.coCells)
                {
                    TargetOut.Rows[item.x].Cells[item.y].Style = diffStyle;
                }
            }

        }


    }
}
