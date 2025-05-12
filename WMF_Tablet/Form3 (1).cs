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
    public partial class frmPurchaseOrder: Form
    {
        public frmPurchaseOrder()
        {
            InitializeComponent();
           
        }
        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Font = new Font("Courier New", 18.0F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));
            dateTimePicker1.CalendarFont = new Font("Courier New", 36F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));

            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 100);
            panel1.Location = new Point(0, 0);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920 - 100, 0);
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
