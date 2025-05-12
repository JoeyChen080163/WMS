using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace WMF_Tablet
{
    //09:27 許柏紳（bosun） 資料庫裡面有障密
    //09:27 許柏紳（bosun） 你可以登入我的
    //09:27 許柏紳（bosun） 194909:27 許柏紳（bosun） 資料庫裡面有障密
    //09:27 許柏紳（bosun） 你可以登入我的
    //09:27 許柏紳（bosun） 1949
    //手機APP登入畫面的設定需要密碼：83150813
    public partial class frmLogin : Form
    {
        SqlConnection cnn;
        public frmLogin()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source= 114.35.242.187;Database=FC_IdeaHouseDB;Integrated Security=false;User ID=sa;Password=2jdiojxl;TrustServerCertificate=true;");
            //SqlCommand cmd = new SqlCommand("SELECT 產品編號,品名,價錢 FROM 巨巨", cnn);
            //cnn.Open();

        }

        private void SetButton(System.Windows.Forms.Button button)
        {

            MethodInfo methodinfo = button.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod);
            methodinfo.Invoke(button, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, new object[] { ControlStyles.Selectable, false }, Application.CurrentCulture);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1200);
            panel1.Size = new Size(1920, 300);
            panel1.Location = new Point(0, 0);
            //lblSysName.Location = new Point(100, 200);
            //機號
            //lblMachineNo.Location = new Point(lblSysName.Location.X + lblSysName.Size.Width+50, lblSysName.Location.X + lblSysName.Size.Height/2);
            imgClose.Size = new Size(100, 100);
            imgClose.Location = new Point(1920-100,0);
            /*
            SqlConnection conn = new SqlConnection("data source=localhost; initial catalog = CHIComp03; user id = sa; password = 1234");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM comInvoice  where InvoiceNO='AC18892052';", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try

            {
                while (dr.Read())
                {
                    Console.WriteLine(dr[0].ToString() + "," + dr[1].ToString() + "," + dr[2].ToString() + "," + dr[3].ToString());
                }

            }
            finally
            {
                dr.Close();
            }
            */

            txtAccount.Select();
            SetButton(button01);
            SetButton(button02);
            SetButton(button03);
            SetButton(button04);
            SetButton(button05);
            SetButton(button06);
            SetButton(button07);
            SetButton(button08);
            SetButton(button09);
            SetButton(button00);
            SetButton(buttonBack);
            SetButton(buttonSend);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblPasswd_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            
            //frmLogin..ActiveControl
            //if (this.ActiveControl.Name == "txtAccount")
            //{
            //    ActiveControl.Text += "1";
            //}
            //else if (this.ActiveControl.Name == "txtPasswd")
            //{
            //    ActiveControl.Text += "1";
            //}

            txtCalc.Text += "1";

            ActiveControl.Text += "1";
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainMenu frm2 = new frmMainMenu();
            frm2.ShowDialog();
        }

        private void button02_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
            ActiveControl.Text += "2";
        }

        private void button03_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
            ActiveControl.Text += "3";
        }

        private void button04_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
            ActiveControl.Text += "4";
        }

        private void button05_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
            ActiveControl.Text += "5";
        }

        private void button06_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
            ActiveControl.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
            ActiveControl.Text += "7";
        }

        private void button08_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
            ActiveControl.Text += "8";
        }

        private void button09_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
            ActiveControl.Text += "9";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";

            ActiveControl.Text += "0";
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            txtCalc.Text = "";
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            txtCalc.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(txtCalc.Text.Length>0)
                txtCalc.Text=txtCalc.Text.Remove(txtCalc.Text.Length-1,1);

            if(ActiveControl.Text.Length>0)
                ActiveControl.Text=ActiveControl.Text.Remove(ActiveControl.Text.Length-1, 1);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            SysSetup mSysSetup = new SysSetup();
            mSysSetup.ShowDialog();
        }
    }
}
