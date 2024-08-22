using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App
{
    public partial class Status : Form
    {
        private DBconnection instance;
        private MySqlConnection con;

        public Status()
        {
            InitializeComponent();
            instance = DBconnection.GetInstance();
            con = instance.GetConnection();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (brandNameInput.Text == "" && modelNoInput.Text == "")
                {
                    MessageBox.Show("Please Enter model number or brand name");
                }
                else
                {
                    string query = string.Empty;

                    if (modelNoInput.Text != "")
                    {
                        query = "SELECT brand_name, model_no, stock FROM table_1 WHERE model_no LIKE @modelNo";
                    }
                    else if (brandNameInput.Text != "")
                    {
                        query = "SELECT brand_name, model_no, stock FROM table_1 WHERE brand_name LIKE @brandName";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    if (modelNoInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@modelNo", modelNoInput.Text + "%");
                    }
                    else if (brandNameInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@brandName", brandNameInput.Text + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                        brandNameInput.Text = "";
                        modelNoInput.Text = "";
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dt.Columns.Add("state", typeof(string));

                        foreach (DataRow row in dt.Rows)
                        {
                            int stock = Convert.ToInt32(row["stock"]);

                            if (stock == 0)
                            {
                                row["state"] = "Out of Stock";
                            }
                            else if (stock < 10)
                            {
                                row["state"] = "Low";
                            }
                            else
                            {
                                row["state"] = "Normal";
                            }
                        }

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        public void clearBtn_Click(object sender, EventArgs e)
        {
            brandNameInput.Text = "";
            modelNoInput.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
