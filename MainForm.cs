using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class MainForm : Form
    {
        private CafeManager cafeManager = new CafeManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void headingLbl_Click(object sender, EventArgs e)
        {

        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddItembtn_Click(object sender, EventArgs e)
        {
            string selectedItem = ItemComboBox.SelectedItem.ToString();
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            cafeManager.AddToOrder(selectedItem, quantity);

            MessageBox.Show("Item added to order!");
        }

        private void DisplayRecieptbtn_Click(object sender, EventArgs e)
        {
            string receipt = cafeManager.GenerateReceipt();
            MessageBox.Show(receipt);
        }

        private void Quantitylbl_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
