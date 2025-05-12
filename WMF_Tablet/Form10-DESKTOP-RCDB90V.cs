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
    public partial class frmTransferOperation: Form
    {
        public frmTransferOperation()
        {
            InitializeComponent();
        }

        private void frmTransferOperation_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 100);
            panel1.Location = new Point(0, 0);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920 - 100, 0);
        }
    }
}
