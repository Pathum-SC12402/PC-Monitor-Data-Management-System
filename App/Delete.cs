using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Delete : Form
    {
        private DBconnection instance;
        private MySqlConnection con;
        public Delete()
        {
            InitializeComponent();
            instance = DBconnection.GetInstance();
            con = instance.GetConnection();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(modelNoInput.Text))
                {
                    MessageBox.Show("Please Enter Model Number Of The Monitor");
                }
                else
                {
                    string selectQuery = "SELECT * FROM table_1 WHERE model_no = @modelNo";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@modelNo", modelNoInput.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                        modelNoInput.Text = "";
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        string deleteQuery = "DELETE FROM table_1 WHERE model_no = @modelNo";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@modelNo", modelNoInput.Text);

                        con.Open();
                        deleteCmd.ExecuteNonQuery();

                        dt.Columns.Add("state", typeof(string));

                        foreach (DataRow row in dt.Rows)
                        {
                            row["state"] = "Deleted";
                        }

                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Data Deleted Successfully!");

                        modelNoInput.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  
            dashboard.Show();
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            modelNoInput.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
