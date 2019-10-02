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
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
           // serialPort1.Open();
        }

        public int cntOrder = 0;
        public int a = 2;
        public string ardu;
        public int arduino;

        public CashierForm(string request)
        {

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            cntOrder++;
            CookForm cook = new CookForm();
            cook.Show(this);
            lvControl.Items.Add(cntOrder.ToString());
            //lvControl.Items[cntOrder].SubItems.Add(cntOrder.ToString());
            lbOrder.Items.Clear();
            tbRequest.Text = "";
            cbPizzas.SelectedIndex = -1;
            cbSize.SelectedIndex = -1;
        }

        private void SerialPort1_DataReceived_1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ardu = serialPort1.ReadExisting();
            arduino = Convert.ToInt32(ardu);
     
           // tbRequest.Text = ardu;
           // lvControl.Items[arduino].SubItems.Add("Yes");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbRequest.Text = ardu;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lbOrder.Items.Add(cbSize.SelectedItem + " " +cbPizzas.SelectedItem + " " + tbRequest.Text);
            tbRequest.Text = "";
            cbPizzas.SelectedIndex = -1;
            cbSize.SelectedIndex = -1;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show(this);
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e) {
            object selectedItem = this.lbOrder.SelectedItem;
            this.lbOrder.Items.Remove(selectedItem);
        }
    }


}
