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
    public partial class Add : Form
    {
        private DBconnection instance;
        private MySqlConnection con;
        public Add()
        {
            InitializeComponent();
            instance = DBconnection.GetInstance();
            con = instance.GetConnection();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (brandNameInput.Text == "" && modelNoInput.Text == "" && displayTypeInput.Text == "" && resolutionInput.Text == "" && displaySizeInput.Text == "" && warrantyInput.Text == "" && stockInput.Text == "" && priceInput.Text == "")
                {
                    MessageBox.Show("Some information are missing!");
                }
                else
                {
                    string query = string.Empty;
                        query = "SELECT brand_name, model_no, display_type, resolution, display_size, warranty, price FROM table_1 WHERE model_no LIKE @modelNo";
                   
                    

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            brandNameInput.Text = "";
            modelNoInput.Text = "";
            displayTypeInput.Text = "";
            resolutionInput.Text = "";
            displaySizeInput.Text = "";
            warrantyInput.Text = "";
            stockInput.Text = "";
            priceInput.Text = "";
        }
    }
}
