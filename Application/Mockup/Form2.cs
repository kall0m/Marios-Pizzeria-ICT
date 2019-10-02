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
    public partial class CookForm : Form
    {
        public CookForm()
        {
            InitializeComponent();
        }

        public int orderNumber;

        private void FrmCook_Load(object sender, EventArgs e)
        {
            CashierForm ComeIn = this.Owner as CashierForm;
           // lbSpecial.Text = ComeIn.tbRequest.Text;
           // lblPizza.Text = Convert.ToString(ComeIn.cbPizza.SelectedItem);
           for (int i = 0; i < ComeIn.lbOrder.Items.Count; i++)
            {
                lbWholeOrder.Items.Add(ComeIn.lbOrder.Items[i]);
            }
            orderNumber = ComeIn.cntOrder;
            lblOrderN.Text = "Order number: " + orderNumber.ToString();
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            CashierForm ComeIn = this.Owner as CashierForm;
            ComeIn.lvControl.Items[orderNumber].SubItems.Add("Yes");
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CashierForm ComeIn = this.Owner as CashierForm;
            ComeIn.lvControl.Items[orderNumber].Remove();
            ComeIn.cntOrder = ComeIn.cntOrder - 1;
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CashierForm ComeIn = this.Owner as CashierForm;
            //ComeIn.lvControl.Items[orderNumber].SubItems.Add("Order Approved");
        }
    }
}
