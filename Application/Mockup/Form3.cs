using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockup
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(CashierForm cashierForm)
        {
            InitializeComponent();
            //this.cbPizzas = new ComboBox();
            this.cbPizzas.Items.AddRange(cashierForm.cbPizzas.Items.Cast<Object>().ToArray());
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            CashierForm cashierForm = this.Owner as CashierForm;

            string newPizza = this.tbNewPizza.Text;

            cashierForm.cbPizzas.Items.Add(newPizza);
            this.cbPizzas.Items.Add(newPizza);

            this.tbNewPizza.Text = "";

            MessageBox.Show($"{newPizza} has been added to the menu.");
        }

        private void BtnRemove_Click(object sender, EventArgs e) {
            CashierForm cashierForm = this.Owner as CashierForm;

            object selectedItem = this.cbPizzas.SelectedItem;

            cashierForm.cbPizzas.Items.Remove(selectedItem);
            this.cbPizzas.Items.Remove(selectedItem);

            this.cbPizzas.Text = "";

            MessageBox.Show($"{selectedItem} has been removed from the menu.");
        }

        private void BtnBack_Click(object sender, EventArgs e) {

        }
    }
}
