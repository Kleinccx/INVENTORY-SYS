using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InventorySys
{
    public partial class AddReceiveStocks : Form
    {
        public AddReceiveStocks()
        {
            InitializeComponent();
        }

        private void AddReleaseStockbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            string itemCodeRS = CodeItemTxt.Text;
            string itemNameRS =ItemNametxt.Text;
            int quantityRCS = int.Parse(RecieveQtytxt.Text);
            DateTime dateTimeRS = dateTimePicker1.Value;
            string categoryRS = "";
            string unitMeasureRS = "";

            string selectStocksQuery = "SELECT CategoryStocks, UnitMStocks FROM Stocks WHERE itemCodeStocks = @itemCodeRCS";
            string insertReleaseStocksQuery = "INSERT INTO ReceiveStocks (ItemCodeRCS, ItemNameRCS, CategoryRCS, UnitMeasureRCS, QuantityRCS, DateTimeRCS) VALUES (@itemCodeRCS, @itemNameRCS, @categoryRCS, @unitMeasureRCS, @QuantityRCS, @dateTimeRCS)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand selectStocksCommand = new OleDbCommand(selectStocksQuery, connection))
                {
                    selectStocksCommand.Parameters.AddWithValue("@itemCodeRCS", itemCodeRS);

                    using (OleDbDataReader reader = selectStocksCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryRS = reader["CategoryStocks"].ToString();
                            unitMeasureRS = reader["UnitMStocks"].ToString();
                        }
                    }
                }

                using (OleDbCommand insertReleaseStocksCommand = new OleDbCommand(insertReleaseStocksQuery, connection))
                {
                    insertReleaseStocksCommand.Parameters.AddWithValue("@itemCodeRCS", itemCodeRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@itemNameRCS", itemNameRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@categoryRCS", categoryRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@unitMeasureRCS", unitMeasureRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@QuantityRCS", quantityRCS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@dateTimeRCS", dateTimeRS);

                    insertReleaseStocksCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Stock released successfully. Quantity Released: {quantityRCS}", "Release Complete");
            this.Close();
        }
    }
}
