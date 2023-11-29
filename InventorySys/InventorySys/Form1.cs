using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySys
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void stocksInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StocksInventory stocks = new StocksInventory();
            stocks.ShowDialog();
        }

        private void releaseStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReleaseStockInventory stocks = new ReleaseStockInventory();
            stocks.ShowDialog();
        }

        private void recieveStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            ReceieveStockInvetory stocks = new ReceieveStockInvetory(); 
            stocks.ShowDialog();
        }
    }
}
