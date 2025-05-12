using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMF_Tablet
{
    public partial class frmMainMenu: Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 100);
            panel1.Location = new Point(0, 0);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920 - 100, 0);
            lblIMEI.Text = "機號:"+frmLogin.mPdaInfo.PDAId;
            lblOperator.Text = "操作者:"+frmLogin.mUserInfo.UserName;
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                Console.WriteLine("0");
                frmPurchaseOrder mfrmPurchaseOrder = new frmPurchaseOrder();
                mfrmPurchaseOrder.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Console.WriteLine("1");
                frmWarehouse mfrmWarehouse = new frmWarehouse();
                mfrmWarehouse.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇作業項目");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIncoming_goods_exit mfrmIncoming_goods_exit = new frmIncoming_goods_exit();
            mfrmIncoming_goods_exit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Console.WriteLine("0");
                frmOrderpicking1 mfrmOrderpicking1 = new frmOrderpicking1();
                mfrmOrderpicking1.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                Console.WriteLine("1");
                frmOrderpicking2 mfrmOrderpicking2 = new frmOrderpicking2();
                mfrmOrderpicking2.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇作業項目");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            frmSalesReturns mfrmSalesReturns = new frmSalesReturns();
            mfrmSalesReturns.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmTransferOperation mfrmTransferOperation = new frmTransferOperation();
            mfrmTransferOperation.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // frmInventory mfrmInventory = new frmInventory();
            //mfrmInventory.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmReprinting mfrmReprinting = new frmReprinting();
            mfrmReprinting.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmWarehouseInformation mfrmWarehouseInformation = new frmWarehouseInformation();
            mfrmWarehouseInformation.ShowDialog();
        }
    }
}
