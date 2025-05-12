using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text;
using System.Management;

namespace WMF_Tablet
{
    public partial class SysSetup: Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public static string myip = "192.168.1.254";
        public static string myID = "sa";
        public static string myPW = "CHIchi!23";
        string mstrConn1;//1=合澤(03)
        string mstrConn2;//2=合永(10)
        string mstrConn3;//3=小澤(06)

        public SysSetup()
        {
            InitializeComponent();
        }

        private void SysSetup_Load(object sender, EventArgs e)
        {
            //cnn = new SqlConnection("Data Source=localhost;Database=FC_IdeaHouseDB;Integrated Security=false;User //ID=sa;Password=2jdiojxl;TrustServerCertificate=true;");
            //SqlCommand cmd = new SqlCommand("SELECT 產品編號,品名,價錢 FROM 巨巨", cnn);
            //cnn.Open();
            //cnn.Open();
            mstrConn1 = $"Data Source={myip};Database=FC_IdeaHouseDB03;Integrated Security=false;User ID={myID};Password={myPW};TrustServerCertificate=true;";
            mstrConn2 = $"Data Source={myip};Database=FC_IdeaHouseDB;Integrated Security=false;User ID={myID};Password={myPW};TrustServerCertificate=true;";
            mstrConn3 = $"Data Source= {myip};Database=FC_IdeaHouseDB06;Integrated Security=false;User ID={myID};Password={myPW};TrustServerCertificate=true;";
        }

        

        /// <summary>
        /// 取得所有 CPU 序號
        /// </summary>
        /// <param name="args"></param>




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcPrint.Items.Clear();
            cbcPrint2.Items.Clear();


            if (cbcCompany.SelectedIndex == 0)
            {
                cnn = new SqlConnection(mstrConn1);
                cnn.Open();

                cmd = new SqlCommand("SELECT * FROM PrinterConfig as a Left Join PrinterDefaultConfig as b on a.PrinterId=b.PrinterId;", cnn);
            }
            else if(cbcCompany.SelectedIndex == 1)
            {
                cnn = new SqlConnection(mstrConn2);
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM PrinterConfig as a Left Join PrinterDefaultConfig as b on a.PrinterId=b.PrinterId;", cnn);

            }
            else if (cbcCompany.SelectedIndex == 2)
            {
                cnn = new SqlConnection(mstrConn3);
                cnn.Open();
                cmd = new SqlCommand("SELECT * FROM PrinterConfig as a Left Join PrinterDefaultConfig as b on a.PrinterId=b.PrinterId;", cnn);

            }
            else
            {
                MessageBox.Show("請選擇公司別!!");
                return;
            }
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                cbcPrint.Items.Clear();
                cbcPrint2.Items.Clear();

                while (dr.Read())
                {
                    cbcPrint.Items.Add(dr["PrinterDescription"].ToString());
                    cbcPrint2.Items.Add(dr["PrinterAddress"].ToString());
                }
            }
        }

        private void SysSetup_FormClosed(object sender, FormClosedEventArgs e)
        {

            if(cnn!=null && cnn.State==ConnectionState.Open)
                cnn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbcCompany.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇公司別!!");
                return;
            }

            if (cbcPrint.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇標籤機!!");
                return;
            }

            string filePath = System.IO.Directory.GetCurrentDirectory()+"\\PrintSaveSetup.txt";

            try
            {
                using(StreamWriter sr=new StreamWriter(filePath))
                {
                    //string line;
                    sr.WriteLine(txtAccount.Text);
                    sr.WriteLine(cbcCompany.Items[cbcCompany.SelectedIndex]);
                    sr.WriteLine(cbcPrint.Items[cbcPrint.SelectedIndex]);
                    sr.WriteLine(cbcPrint2.Items[cbcPrint.SelectedIndex]);
                    sr.Close();
                }
                this.Close();
            }
            catch (Exception exe)
            {
                Console.WriteLine("讀取檔案時出錯：" + exe.Message);
            }
        }
    }
}
