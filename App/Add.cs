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
                if (string.IsNullOrEmpty(brandNameInput.Text) || string.IsNullOrEmpty(modelNoInput.Text) ||
                    string.IsNullOrEmpty(displayTypeInput.Text) || string.IsNullOrEmpty(resolutionInput.Text) ||
                    string.IsNullOrEmpty(displaySizeInput.Text) || string.IsNullOrEmpty(warrantyInput.Text) ||
                    string.IsNullOrEmpty(stockInput.Text) || string.IsNullOrEmpty(priceInput.Text))
                {
                    MessageBox.Show("Some information is missing!");
                }
                else
                {
                    string query = "INSERT INTO table_1 (brand_name, model_no, display_type, resolution, display_size, warranty, stock, price)" +
                                   "VALUES (@brandName, @modelNo, @displayType, @resolution, @displaySize, @warranty, @stock, @price)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@brandName", brandNameInput.Text);
                    cmd.Parameters.AddWithValue("@modelNo", modelNoInput.Text);
                    cmd.Parameters.AddWithValue("@displayType", displayTypeInput.Text);
                    cmd.Parameters.AddWithValue("@resolution", resolutionInput.Text);
                    cmd.Parameters.AddWithValue("@displaySize", displaySizeInput.Text);
                    cmd.Parameters.AddWithValue("@warranty", warrantyInput.Text);
                    cmd.Parameters.AddWithValue("@stock", int.Parse(stockInput.Text));
                    cmd.Parameters.AddWithValue("@price", priceInput.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");

                    clearBtn_Click(sender, e);
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
