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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void stateItem_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
            this.Hide();
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();   
            search.Show();  
            this.Hide();    
        }
    }
}
