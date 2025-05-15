using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMF_Tablet
{
    public partial class frmPurchaseOrder: Form
    {
        private string mstrConn1;//1=合澤(03)
        private string mstrConn2;//2=合永(10)
        private string mstrConn3;//3=小澤(06)
        private SqlConnection conn;
        private string mstr累計 ="";
        private string mstr總數量 = "";
        private int miSeq = 0;
        private int miPurchaseNo = 0;

        private List<ReceivingOperationTemp> mlstROT = new List<ReceivingOperationTemp>();

        public frmPurchaseOrder()
        {
            InitializeComponent();
            //txtPurchase.Focus();
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
            dtp進貨日期.Font = new Font("Courier New", 18.0F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));
            dtp進貨日期.CalendarFont = new Font("Courier New", 36F, FontStyle.Italic, GraphicsUnit.Point, ((Byte)(0)));
            
            lblIMEI.Text = "機號:" + frmLogin.mPdaInfo.PDAId;
            lblOperator.Text = "操作者:" + frmLogin.mUserInfo.UserName;

            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 100);
            panel1.Location = new Point(0, 0);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920 - 100, 0);
            txtPurchase.Select();
            if (frmLogin.company == frmLogin.Company.e合澤03)
            {
                mstrConn1 = $"Data Source={frmLogin.myip};Database=CHIComp03;Integrated Security=false;User ID={frmLogin.myID};Password={frmLogin.myPW};TrustServerCertificate=true;";
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
                    conn = new SqlConnection(mstrConn1);
            }
            else if(frmLogin.company == frmLogin.Company.e合永10)
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

            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("新細明體",26);
            //dataGridView1.DefaultCellStyle.Font = new Font("新細明體", 26);
            mlstROT.Clear();
            miSeq = 0;
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPurchase_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                txt料號.Select();
                
            }
        }

        private void txtPurchase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt料號_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt料號_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPurchase.Text == "")
                return;
            if (mlstROT.Count > 0)
                return;
            conn.Close();
            SqlCommand cmd = new SqlCommand("select * from ordBillSub as a Left Join comProduct as b on a.ProdID=b.ProdID where a.billNo='" + txtPurchase.Text + "';", conn);
            conn.Open();
            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.RowTemplate.Height = 80;
            dataGridView1.ColumnHeadersHeight = 30;
            DataColumn colItem1 = new DataColumn("採單", Type.GetType("System.String"));

            dt.Columns.Add(colItem1);
            DataColumn colItem2 = new DataColumn("產編", Type.GetType("System.String"));
            dt.Columns.Add(colItem2);
            DataColumn colItem3 = new DataColumn("品名", Type.GetType("System.String"));
            dt.Columns.Add(colItem3);
            DataColumn colItem4 = new DataColumn("單據", Type.GetType("System.String"));
            dt.Columns.Add(colItem4);
            DataColumn colItem5 = new DataColumn("己領", Type.GetType("System.String"));
            dt.Columns.Add(colItem5);
            DataColumn colItem6 = new DataColumn("單位", Type.GetType("System.String"));
            dt.Columns.Add(colItem6);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {

                    DataRow NewRow;
                    NewRow = dt.NewRow();
                    NewRow["採單"] = dr1["BillNO"].ToString();
                    NewRow["產編"] = dr1["ProdId"].ToString();
                    NewRow["品名"] = dr1["ProdName"].ToString();
                    NewRow["單據"] = dr1["Quantity"].ToString();

                    NewRow["己領"] = "";
                    NewRow["單位"] = dr1["ConverRate"].ToString();
                    frmLogin.cnn.Close();
                    SqlCommand cmdPurchase = new SqlCommand("select * from PurchaseLog where ProdID='" + dr1["ProdID"].ToString() + "' and FromNo='" + dr1["BillNO"].ToString() + "';", frmLogin.cnn);
                    frmLogin.cnn.Open();
                    SqlDataReader drPurchase = cmdPurchase.ExecuteReader();
                    //&& dr1["ProdID"].ToString() == drPurchase["ProdID"].ToString()

                    int miTmpQty = 0;
                    if (mlstROT.Count > 0)
                    {
                        for (int i = 0; i < mlstROT.Count; i++)
                        {
                            miTmpQty += mlstROT[i].Quantity;
                        }
                    }

                    if (drPurchase.HasRows)
                    {
                        if (drPurchase.Read())
                        {
                            string m已領數量 = drPurchase["Quantity"].ToString();
                            int mi己領tmp = int.Parse(m已領數量) + miTmpQty; 
                            NewRow["己領"] = m已領數量;
                        }
                    }
                    else
                    {
                        NewRow["己領"] = "";
                    }
                    dt.Rows.Add(NewRow);
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Visible = false;
            //自動調欄寬
            dataGridView1.AutoResizeColumns();
            //自動調欄高
            dataGridView1.AutoResizeRows();
            //dataGridView1.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.None;
            //dataGridView1.RowTemplate.Height = 100;
            miSeq = 0;
        }

        private void txt料號_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            


        }

        private void txt料號_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return )
            {
                
            }
        }

        private void txt箱_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                txt小計.Text = (int.Parse(txt數量.Text) * int.Parse(txt箱.Text) + int.Parse(txt尾數.Text)).ToString();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void txt料號_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearField();
            mstr累計 = "";
            //var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            string mstrPurchaseNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string mstrProdId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string mstr已領 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            conn.Close();
            SqlCommand cmd = new SqlCommand("select * from ordBillMain as a Left Join ordBillSub as b on a.billNo=b.BillNO  Left Join comCustomer as c on a.CustomerID=c.ID Left Join comProduct as d on b.ProdID=d.ProdID where a.billNo='" + mstrPurchaseNo + "' and b.ProdID='" + mstrProdId + "' ", conn);
            conn.Open();
            cmd.CommandTimeout = 12000;
            Console.Write(cmd.CommandText);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.HasRows)
            {
                if (dr1.Read())
                {
                    txt料號.Text = mstrProdId;
                    dtp進貨日期.Text = DateTime.Today.ToString();// DateTime.Parse(dr1["BillDate"].ToString("yyyyMMdd"));
                    txt供應商編號.Text = dr1["CustomerID"].ToString();
                    txt供應商名稱.Text = dr1["FullName"].ToString();
                    txt品名.Text = dr1["ProdName"].ToString();
                    txt數量.Text = dr1["ConverRate"].ToString();
                    mstr總數量 = dr1["Quantity"].ToString();
                    double temp = double.Parse(mstr總數量);
                    mstr總數量 = Math.Truncate(temp).ToString();
                    txt批號.Text = DateTime.Today.ToString("yyyyMMdd");
                    //txt箱.Text = dr1["PackAmt2"].ToString();
                    mstr累計 = mstr已領;

                    //txt累計.Text = mstr已領;
                    //if (txt小計.Text == "")
                    //{
                    //    txt小計.Text = txt累計.Text;
                    //}
                    txt尾數.Text = "0";
                }
            }
            txt箱.Select();
        }

        void Calc()
        {
            try
            {
                int total = int.Parse(txt數量.Text) * int.Parse((txt箱.Text == "") ? "0" : txt箱.Text) + int.Parse((txt尾數.Text == "") ? "0" : txt尾數.Text);
                txt小計.Text = total.ToString();
                int mi累計 = int.Parse(mstr累計 == "" ? "0" : mstr累計) + int.Parse(txt小計.Text == "" ? "0" : txt小計.Text);
                txt累計.Text = mi累計.ToString();
                txt工單未進.Text = (int.Parse(mstr總數量 == "" ? "0" : mstr總數量) - int.Parse(txt累計.Text == "" ? "0" : txt累計.Text)).ToString();
                int miIncome = int.Parse(txt工單未進.Text);
                int miIncome2 = 0;//工單超收
                if (miIncome < 0)
                {
                    miIncome2 = Math.Abs(miIncome);
                    txt工單超收.Text += miIncome2.ToString();
                    txt工單未進.Text = "";
                }

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Trim()== txt料號.Text.Trim())
                    {
                        Console.WriteLine(dataGridView1.Rows[i].Cells[4].Value);
                        dataGridView1.Rows[i].Cells[4].Value = txt累計.Text;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txt尾數_Leave(object sender, EventArgs e)
        {
            Calc();
        }

        private void txt箱_Leave(object sender, EventArgs e)
        {
            Calc();
        }

        void ClearField()
        {
            txt供應商編號.Text = "";
            txt供應商名稱.Text = "";
            txt品名.Text = "";
            txt批號.Text = "";
            txt數量.Text = "";
            txt箱.Text = "";
            txt尾數.Text = "";
            txt小計.Text = "";
            txt累計.Text = "";
            txt工單未進.Text = "";
            txt工單超收.Text = "";
            chk是否板進.Checked = false;
            mstr總數量 = "";
            mstr累計 = "";
            txt料號.Text = "";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {

        }

        void SavePurchaseLog(SavePurchaseLog mSavePurchaseLog)
        {
            frmLogin.cnn.Close();
            String mstrSavePurchaseLog =
            $@"INSERT INTO[dbo].[PurchaseLog]
            ([BillNo]
           , [BillDate]
           , [CustID]
           , [FromNO]
           , [ProdID]
           , [BatchID]
           , [BoxNum]
           , [BoxCount]
           , [Remainder]
           , [Quantity]
           , [TotalBox]
           , [ItemRemark]
           , [WorkPDAId]
           , [InsertDateTime]
           , [InsertUserNo]
           , [UploadDateTime]
           , [UploadUserNo]
           , [ExportDateTime])
            VALUES
           ('{mSavePurchaseLog.BillNo}',
            '{mSavePurchaseLog.BillDate}',
            '{mSavePurchaseLog.CustID}',
            '{mSavePurchaseLog.FromNO}',
            '{mSavePurchaseLog.ProdID}',
            '{mSavePurchaseLog.BatchID}',
            '{mSavePurchaseLog.BoxNum}',
            '{mSavePurchaseLog.BoxCount}',
            '{mSavePurchaseLog.Remainder}',
            '{mSavePurchaseLog.Quantity}',
            '{mSavePurchaseLog.TotalBox}',
            '{mSavePurchaseLog.ItemRemark}',
            '{mSavePurchaseLog.WorkPDAId}',
            '{mSavePurchaseLog.InsertDateTime}',
            '{mSavePurchaseLog.InsertUserNo}',
            '{mSavePurchaseLog.UploadDateTime}',
            '{mSavePurchaseLog.UploadUserNo}',
            '{mSavePurchaseLog.ExportDateTime}')";
            
            SqlCommand cmd = new SqlCommand(mstrSavePurchaseLog, frmLogin.cnn);
            frmLogin.cnn.Open();
            cmd.ExecuteNonQuery();
        }

        void SaveBoxLog(BoxLog mBoxLog)
        {
            frmLogin.cnn.Close();
            String mstrSaveBoxLog = 
                $@"INSERT INTO[dbo].[BoxLog]
                ([BoxNo]
               , [PurchaseNo]
               , [OrderNo]
               , [BoxSeq]
               , [ProdID]
               , [BatchID]
               , [Quantity]
               , [BoxCnt]
               , [ItemRemark]
               , [WareID]
               , [StorageID]
               , [isPrint]
               , [SaleNo]
               , [inStock]
               , [InsertDateTime]
               , [WorkPDAId]
               , [UpdateDateTime])
                VALUES
               ('{mBoxLog.BoxNo}',
               '{mBoxLog.PurchaseNo}',
               '{mBoxLog.OrderNo}',
               '{mBoxLog.BoxSeq}',
               '{mBoxLog.ProdID}',
               '{mBoxLog.BatchID}',
               '{mBoxLog.Quantity}',
               '{mBoxLog.BoxCnt}',
               '{mBoxLog.ItemRemark}',
               '{mBoxLog.WareID}',
               '{mBoxLog.StorageID}',
               '{mBoxLog.isPrint}',
               '{mBoxLog.SaleNo}',
               '{mBoxLog.inStock}',
               '{mBoxLog.InsertDateTime}',
               '{mBoxLog.WorkPDAId}')";
            
            SqlCommand cmd = new SqlCommand(mstrSaveBoxLog,frmLogin.cnn);
            frmLogin.cnn.Open();
            cmd.ExecuteNonQuery();

        }

      

        private void btnTempSaveData_Click(object sender, EventArgs e)
        {
            try {
                
                ReceivingOperationTemp mrot = new ReceivingOperationTemp();
                mrot.BoxSeq = ++miSeq;
                mrot.ReceivingDate = dtp進貨日期.Value.ToString();
                mrot.BillNO= txtPurchase.Text.Trim();
                mrot.CustomerID= txt供應商編號.Text.Trim();
                mrot.CustomerName= txt供應商名稱.Text.Trim();
                mrot.ProdId = txt料號.Text.Trim();
                mrot.ProdName= txt品名.Text.Trim();
                mrot.BatchNumber = txt批號.Text;
                mrot.Quantity = int.Parse(txt數量.Text);
                mrot.BoxNumber = int.Parse(txt箱.Text);
                mrot.Mantissa = int.Parse(txt尾數.Text);
                mrot.Subtotal = int.Parse(txt小計.Text);
                mrot.GrandTotal = int.Parse(txt累計.Text);
                mrot.WorkOrderNotEntered = txt工單未進.Text==""?0: int.Parse(txt工單未進.Text);
                mrot.OverchargeOfWorkOrders = txt工單超收.Text==""?0: int.Parse(txt工單超收.Text);
                mrot.Pallet = chk是否板進.Checked;

                mlstROT.Add(mrot);
                ClearField();
            }
            catch (Exception ex) { 
                //Font font = new Font("新細明體", 26);
                MessageBox.Show("資料未輸入完整!","警告訊息");
            }
        }

        private void btn確認_MouseDown(object sender, MouseEventArgs e)
        {

            if (mlstROT.Count < 1)
            {
                MessageBox.Show("尚未有暫存記錄!!");
                return;
            }

            int miBoxMaxSeq = 0;
            String mstrMaxBoxNo = "";
            int miToday = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            frmLogin.cnn.Close();
            string mstrQuerySeqMaxNo = "";
            mstrQuerySeqMaxNo = "Select * From BoxLog order by seq desc; ";
            SqlCommand cmd = new SqlCommand(mstrQuerySeqMaxNo, frmLogin.cnn);
            frmLogin.cnn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.HasRows)
            {
                if (dr1.Read())
                {
                    string mstrtmpboxno = dr1["BoxNo"].ToString();
                    int mithisDate = int.Parse(mstrtmpboxno.Substring(1, 8).ToString());
                    if (mithisDate != miToday)
                    {
                        mstrMaxBoxNo = "0";
                    }
                    else
                    {
                        Console.WriteLine(mstrtmpboxno.Length);
                        string tmp2 = mstrtmpboxno.Substring(9, 5);
                        mstrMaxBoxNo = tmp2;
                    }
                }
            }
            else
            {
                MessageBox.Show("查無最大存檔流水號!!");
                return;
            }



            int miMaxBoxNo = int.Parse(mstrMaxBoxNo);

            if (chk是否板進.Checked)
            {
                miMaxBoxNo += 1;
                BoxLog mBoxLogTemp = new BoxLog();
                string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
                mstrMaxBoxNo = string.Format("{0:00000}", miMaxBoxNo);
                mBoxLogTemp.BoxNo = string.Format("{0}{1}{2}", frmLogin.mPdaInfo.PDAId, mstrtodays, mstrMaxBoxNo);
                string mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
                String mstrPurchaseNo = string.Format("{0}{1}{2}{3}", "P", mstrtodays, frmLogin.mPdaInfo.PDAId, mstr2PurchaseNo);
                mBoxLogTemp.PurchaseNo = mstrPurchaseNo.ToString();
                mBoxLogTemp.OrderNo = txtPurchase.Text.ToString();
                mBoxLogTemp.ProdID = mlstROT[0].ProdId;
                int miboxseq = 0;

                mBoxLogTemp.BoxSeq = mlstROT[0].BoxSeq.ToString();
                mBoxLogTemp.BatchID = mlstROT[0].BatchNumber;
                mBoxLogTemp.Quantity = mlstROT[0].Quantity.ToString();
                mBoxLogTemp.BoxCnt = miboxseq.ToString();
                mBoxLogTemp.ItemRemark = "1";
                mBoxLogTemp.WareID = "";
                mBoxLogTemp.StorageID = "";
                mBoxLogTemp.isPrint = "0";
                mBoxLogTemp.SaleNo = "";
                mBoxLogTemp.inStock = "-1";
                mBoxLogTemp.InsertDateTime = DateTime.Now.ToString();
                mBoxLogTemp.WorkPDAId = frmLogin.mPdaInfo.PDAId;
                SaveBoxLog(mBoxLogTemp);
            }
            else
            {
                for (int i = 0; i < mlstROT.Count; i++)
                {
                    miMaxBoxNo += 1;
                    BoxLog mBoxLogTemp = new BoxLog();
                    string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
                    mstrMaxBoxNo = string.Format("{0:00000}", miMaxBoxNo);
                    mBoxLogTemp.BoxNo = string.Format("{0}{1}{2}", frmLogin.mPdaInfo.PDAId, mstrtodays, mstrMaxBoxNo);
                    string mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
                    String mstrPurchaseNo = string.Format("{0}{1}{2}{3}", "P", mstrtodays, frmLogin.mPdaInfo.PDAId, mstr2PurchaseNo);
                    mBoxLogTemp.PurchaseNo = mstrPurchaseNo.ToString();
                    mBoxLogTemp.OrderNo = txtPurchase.Text.ToString();
                    mBoxLogTemp.ProdID = mlstROT[i].ProdId;
                    int miboxseq = 0;
                    for (int j = 0; j < mlstROT.Count; j++)
                    {
                        if (mlstROT[i].ProdId == mBoxLogTemp.ProdID)
                        {
                            miboxseq += 1;
                        }
                    }
                    mBoxLogTemp.BoxSeq = mlstROT[i].BoxSeq.ToString();
                    mBoxLogTemp.BatchID = mlstROT[i].BatchNumber;
                    mBoxLogTemp.Quantity = mlstROT[i].Quantity.ToString();
                    mBoxLogTemp.BoxCnt = miboxseq.ToString();
                    mBoxLogTemp.ItemRemark = "0";
                    mBoxLogTemp.WareID = "";
                    mBoxLogTemp.StorageID = "";
                    mBoxLogTemp.isPrint = "0";
                    mBoxLogTemp.SaleNo = "";
                    mBoxLogTemp.inStock = "-1";
                    mBoxLogTemp.InsertDateTime = DateTime.Now.ToString();
                    mBoxLogTemp.WorkPDAId = frmLogin.mPdaInfo.PDAId;
                    SaveBoxLog(mBoxLogTemp);
                }
            }

            if (chk是否板進.Checked)
            {
               
                int miQ = 0;
                SavePurchaseLog mSavePurchaseLog = null;
                mSavePurchaseLog = new SavePurchaseLog();
                string mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
                string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
                String mstrPurchaseNo = string.Format("{0}{1}{2}{3}", "P", mstrtodays, frmLogin.mPdaInfo.PDAId, mstr2PurchaseNo);
                mSavePurchaseLog.BillNo = mstrPurchaseNo;
                mSavePurchaseLog.BillDate = mlstROT[0].BatchNumber;
                mSavePurchaseLog.CustID = mlstROT[0].CustomerID;
                mSavePurchaseLog.FromNO = txtPurchase.Text.ToString();
                mSavePurchaseLog.ProdID = mlstROT[0].ProdId;
                mSavePurchaseLog.BatchID = mlstROT[0].BatchNumber;
                mSavePurchaseLog.BoxNum = "";
                mSavePurchaseLog.BoxCount = "";
                mSavePurchaseLog.Remainder = "";
                miQ += mlstROT[0].Quantity;
                mSavePurchaseLog.Quantity = miQ.ToString();
                mSavePurchaseLog.TotalBox = "";
                //mSavePurchaseLog.ItemRemark = "1";
                mSavePurchaseLog.Pallet = 1;
                mSavePurchaseLog.WorkPDAId = frmLogin.mPdaInfo.PDAId;
                mSavePurchaseLog.InsertDateTime = DateTime.Now.ToString();
                mSavePurchaseLog.InsertUserNo = frmLogin.mUserInfo.UserNo;
                mSavePurchaseLog.UploadUserNo = "";
                mSavePurchaseLog.ExportDateTime = "";
                if (mSavePurchaseLog != null)
                    SavePurchaseLog(mSavePurchaseLog);
                MessageBox.Show("存檔成功!!");
            }
            else
            { 
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    int miQ = 0;
                    SavePurchaseLog mSavePurchaseLog = null;
                    for (int j = 0; j < mlstROT.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == mlstROT[j].ProdId)
                        {
                            mSavePurchaseLog = new SavePurchaseLog();
                            string mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
                            string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
                            String mstrPurchaseNo = string.Format("{0}{1}{2}{3}", "P", mstrtodays, frmLogin.mPdaInfo.PDAId, mstr2PurchaseNo);
                            mSavePurchaseLog.BillNo = mstrPurchaseNo;
                            mSavePurchaseLog.BillDate = mlstROT[j].BatchNumber;
                            mSavePurchaseLog.CustID = mlstROT[j].CustomerID;
                            mSavePurchaseLog.FromNO = txtPurchase.Text.ToString();
                            mSavePurchaseLog.ProdID = mlstROT[j].ProdId;
                            mSavePurchaseLog.BatchID = mlstROT[j].BatchNumber;
                            mSavePurchaseLog.BoxNum = "";
                            mSavePurchaseLog.BoxCount = "";
                            mSavePurchaseLog.Remainder = "";
                            miQ += mlstROT[j].Quantity;
                            mSavePurchaseLog.Quantity = miQ.ToString();
                            mSavePurchaseLog.TotalBox = "";
                            //mSavePurchaseLog.ItemRemark = "0";
                            mSavePurchaseLog.Pallet = 0;
                            mSavePurchaseLog.WorkPDAId = frmLogin.mPdaInfo.PDAId;
                            mSavePurchaseLog.InsertDateTime = DateTime.Now.ToString();
                            mSavePurchaseLog.InsertUserNo = frmLogin.mUserInfo.UserNo;
                            mSavePurchaseLog.UploadUserNo = "";
                            mSavePurchaseLog.ExportDateTime = "";
                        }
                    }
                    if (mSavePurchaseLog != null)
                        SavePurchaseLog(mSavePurchaseLog);
                }

                MessageBox.Show("存檔成功!!");
            }
        }

        private void txtPurchase_Leave(object sender, EventArgs e)
        {
            miPurchaseNo += 1;
            string mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
            frmLogin.cnn.Close();
            string mstrtodays = DateTime.Today.ToString("yyyyMMdd");
            String mstrPurchaseNo = string.Format("{0}{1}{2}{3}", "P", mstrtodays, frmLogin.mPdaInfo.PDAId, mstr2PurchaseNo);
            string mstrRptPurchaseNo = string.Format("Select * From BoxLog Where PurchaseNo='{0}'", mstrPurchaseNo);
            SqlCommand cmdRptPurchaseNo = new SqlCommand(mstrRptPurchaseNo, frmLogin.cnn);
            frmLogin.cnn.Open();
            SqlDataReader drRptPurchaseNo = cmdRptPurchaseNo.ExecuteReader();
            if (drRptPurchaseNo.HasRows)
            {
                miPurchaseNo += 1;
                mstr2PurchaseNo = string.Format("{0:000}", miPurchaseNo);
            }
        }

        private void btn確認_Click(object sender, EventArgs e)
        {

        }
    }
}
