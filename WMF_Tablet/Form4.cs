using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMF_Tablet
{
    public partial class frmWarehouse: Form
    {
        private string mstrConn1;//1=合澤(03)
        private string mstrConn2;//2=合永(10)
        private string mstrConn3;//3=小澤(06)
        private SqlConnection conn;
        private string mstrcbotmp;
        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 100);
            panel1.Location = new Point(0, 0);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920 - 100, 0);

            lblIMEI.Text = "機號:" + frmLogin.mPdaInfo.PDAId;
            lblOperator.Text = "操作者:" + frmLogin.mUserInfo.UserName;
            if (frmLogin.company == frmLogin.Company.e合澤03)
            {
                mstrConn1 = $"Data Source={frmLogin.myip};Database=CHIComp03;Integrated Security=false;User ID={frmLogin.myID};Password={frmLogin.myPW};TrustServerCertificate=true;";
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
                conn = new SqlConnection(mstrConn1);
            }
            else if (frmLogin.company == frmLogin.Company.e合永10)
            {
                mstrConn2 = $"Data Source={frmLogin.myip};Database=CHIComp10;Integrated Security=false;User ID={frmLogin.myID};Password={frmLogin.myPW};TrustServerCertificate=true;";
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
                conn = new SqlConnection(mstrConn2);
            }
            else if (frmLogin.company == frmLogin.Company.e小澤06)
            {
                mstrConn3 = $"Data Source= {frmLogin.myip};Database=CHIComp06;Integrated Security=false;User ID={frmLogin.myID};Password={frmLogin.myPW};TrustServerCertificate=true;";
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
                conn = new SqlConnection(mstrConn3);
            }
            frmLogin.cnn.Close();
            SqlCommand cmd = new SqlCommand("select distinct WareID ,WareHouse from [StorageInfo] ", frmLogin.cnn);
            frmLogin.cnn.Open();
            SqlDataReader drWareID = cmd.ExecuteReader();
            if (drWareID.HasRows)
            {
                while (drWareID.Read())
                {
                    cboWareID.Items.Add(drWareID["WareID"].ToString() +"   "+ drWareID["WareHouse"].ToString());
                }
            }
            drWareID.Close();
            string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
            SqlCommand cmdBill = new SqlCommand("SELECT BillNo FROM [FC_IdeaHouseDB03].[dbo].[PurchaseLog] where BillNo like '%"+ mstrtodays+"%'; ", frmLogin.cnn);
            SqlDataReader drBillNo = cmdBill.ExecuteReader();
            if (drBillNo.HasRows)
            {
                while (drBillNo.Read())
                {
                    cboWareID.Items.Add(drBillNo["WareID"].ToString() + "   " + drBillNo["WareHouse"].ToString());
                }
            }
            drBillNo.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cboBillNo_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboBillNo_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cboBillNo_TextUpdate(object sender, EventArgs e)
        {
            SqlCommand cmdBill = new SqlCommand("SELECT BillNo FROM [FC_IdeaHouseDB03].[dbo].[PurchaseLog] where BillNo like '%" + cboBillNo.Text.ToString() + "%'; ", frmLogin.cnn);
            SqlDataReader drBillNo = cmdBill.ExecuteReader();
            cboBillNo.Items.Clear();
            if (drBillNo.HasRows)
            {
                while (drBillNo.Read())
                {
                    cboBillNo.Items.Add(drBillNo["BillNo"].ToString());
                }
            }
            drBillNo.Close();
            drBillNo = null;
            //cboBillNo.Text = mstrcbotmp;
            cboBillNo.Select(cboBillNo.Text.Length, 0);

        }

       
        private void cboBillNo_SelectedValueChanged(object sender, EventArgs e)
        {
          
            
        }

        private void cboBillNo_Leave(object sender, EventArgs e)
        {
           
        }

        private void cboBillNo_Enter(object sender, EventArgs e)
        {
            
        }

        private void cboStorage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboStorage_TextUpdate(object sender, EventArgs e)
        {
            SqlCommand cmdStorageId = new SqlCommand("SELECT distinct StorageID FROM [FC_IdeaHouseDB03].[dbo].[StorageInfo] where StorageID like '%" + cboStorage.Text.ToString() + "%';", frmLogin.cnn);
            SqlDataReader drStorageId = cmdStorageId.ExecuteReader();
            cboStorage.Items.Clear();
            if (drStorageId.HasRows)
            {
                while (drStorageId.Read())
                {
                    cboStorage.Items.Add(drStorageId["StorageID"].ToString());
                }
            }
            drStorageId.Close();
            drStorageId = null;
            //cboBillNo.Text = mstrcbotmp;
            cboStorage.Select(cboStorage.Text.Length, 0);
        }

        private void txtQRCode_Enter(object sender, EventArgs e)
        {
            //OA15001/X2020120800001/50/1206/n
            //型號/XX/數量/單號/總單數
            String[] QRCode = txtQRCode.Text.Split('/');
        }
    }
}
