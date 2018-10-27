using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using System;

namespace ThiTracNghiemWindows
{
    public partial class FrmChangCauHinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangCauHinh()
        {
            InitializeComponent();
            InitData();
        }
        private string serverName;
        private string authentication;
        private string login;
        private string password;
        private void InitData()
        {
            List<string> listAuthen = new List<string>() { "Windows Authentication", "SQL Server Authentication" };
            cbbAuthentication.DataSource = listAuthen;
        }
        private void cbbServerName_DropDown(object sender, EventArgs e)
        {
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                        cbbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    else
                        cbbServerName.Items.Add(servers.Rows[i]["ServerName"]);
                }
            }
        }
        private void cbbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAuthentication.SelectedIndex == 0)
            {
                txtLogin.Enabled = false;
                txtPass.Enabled = false;
            }
            else
            {
                txtLogin.Enabled = true;
                txtPass.Enabled = true;
            }
        }
        private void cbbServerName_Leave(object sender, EventArgs e)
        {
            serverName = cbbServerName.Text;
            if (!string.IsNullOrWhiteSpace(serverName))
            {
                if (cbbAuthentication.SelectedIndex == 0) // get database
                {
                    authentication = cbbAuthentication.Text;
                    cbbDatabase.DataSource = GetListDataBase(serverName, authentication);
                }
            }
        }
        private object GetListDataBase(string serverName, string authentication)
        {
            List<string> databaseName = new List<string>();
            string conString;
            try
            {
                if (authentication != null) // theo window
                {
                    conString = "Data Source= '" + serverName + "'; Integrated Security=True;";

                }
                else
                {
                    conString = "Data Source= '" + serverName + "';uid= '" + login + "' ;pwd= '" + password + "'";
                }
                SqlConnection connection = new SqlConnection(conString);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "SELECT name from sys.databases",
                    Connection = connection
                };
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        databaseName.Add(dr[0].ToString());
                    }
                }
            }

            catch (Exception)
            {
                cbbDatabase.Text = "";
            }

            return databaseName;
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            password = txtPass.Text;
            cbbDatabase.DataSource = GetListDataBase(serverName, null); // null : get list theo user + password
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtPass_Leave(sender, e);
        }
        private void btnCnnect_Click(object sender, EventArgs e)
        {
            string connection;
            string database = cbbDatabase.Text;
            if (string.IsNullOrWhiteSpace(database))
            {
                return;
            }
            if (cbbAuthentication.SelectedIndex == 0)
            {
                connection = "Data Source= " + serverName + "; Initial CataLog=" + database + "; Integrated Security=True;";
            }
            else
            {
                connection = "Data Source= " + serverName + "; Initial CataLog=" + database
                    + "; User ID = " + login + "; Password = " + password + "";
            }
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["Conn"].ConnectionString = connection;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}

