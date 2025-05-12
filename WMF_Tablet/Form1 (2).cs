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
        SqlCommand cmd;
        SqlDataReader dr;
        string myip = "localhost";
        string mstrConn1;
        string mstrConn2;
        string mstrConn3;

        int CommpanyIndex=0;//1=合澤(03)、2=合永(10),3=小澤(06)

        public static UserInfo mUserInfo =new UserInfo();
        public static PDAInfo mPdaInfo = new PDAInfo();
        GetDeviceData mGetDeviceData = new GetDeviceData();

        public frmLogin()
        {
            InitializeComponent();
            mstrConn1 = $"Data Source={myip};Database=FC_IdeaHouseDB;Integrated Security=false;User ID=sa;Password=1234;TrustServerCertificate=true;";
            mstrConn2 = $"Data Source={myip};Database=FC_IdeaHouseDB03;Integrated Security=false;User ID=sa;Password=1234;TrustServerCertificate=true;";
            mstrConn3 = $"Data Source= {myip};Database=FC_IdeaHouseDB06;Integrated Security=false;User ID=sa;Password=1234;TrustServerCertificate=true;";
            //cnn = new SqlConnection("Data Source=localhost;Database=FC_IdeaHouseDB;Integrated Security=false;UserID=sa;Password=1234;TrustServerCertificate=true;");
            //SqlCommand cmd = new SqlCommand("SELECT 產品編號,品名,價錢 FROM 巨巨", cnn);
            //cnn.Open();
            lblMachineNo.Text = "機號:"+mGetDeviceData.CpuID;
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
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "1";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "1";
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //CommpanyIndex = 0;//1=合澤(03)、2=合永(10),3=小澤(06)
            if (CommpanyIndex == 1)
            {
                if(cnn!=null && cnn.State==ConnectionState.Open) cnn.Close();
                cnn = new SqlConnection(mstrConn1);
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='" + txtAccount.Text + "' and Password='"+ txtPasswd.Text+"'", cnn);
                cnn.Open();
                SqlDataReader dr1 = cmd.ExecuteReader();
                if(dr1.HasRows)
                {
                    if(dr1.Read())
                    {
                        mUserInfo.CommpanyIndex = 1;
                        mUserInfo.UserName = dr1["UserName"].ToString();
                        mUserInfo.UserNo = dr1["UserNo"].ToString();
                        mUserInfo.Password = dr1["Password"].ToString();
                        mUserInfo.DeptNo = dr1["DeptNo"].ToString();
                        mUserInfo.Auth = dr1["Auth"].ToString();
                        
                    }
                    dr1.Close();

                    SqlCommand cmdPda = new SqlCommand("SELECT * FROM PDAInfo WHERE 1=1 AND IMEI='"+ mGetDeviceData.CpuID+"'",cnn);
                    SqlDataReader drpda = cmdPda.ExecuteReader();
                    if (drpda.HasRows)
                    {
                        if (drpda.Read())
                        {
                            mPdaInfo.IMEI = drpda["IMEI"].ToString();
                            mPdaInfo.PDAId = drpda["PDAId"].ToString();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("不明的機器編號");
                        return;
                    }
                    drpda.Close();
                    //
                    frmMainMenu frm2 = new frmMainMenu();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
            else if (CommpanyIndex == 2)
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
                cnn = new SqlConnection(mstrConn2);
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='" + txtAccount.Text + "' and Password='"+txtPasswd.Text+"'", cnn);
                cnn.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    if (dr2.Read())
                    {
                        mUserInfo.CommpanyIndex = 2;
                        mUserInfo.UserName = dr2["UserName"].ToString();
                        mUserInfo.UserNo = dr2["UserNo"].ToString();
                        mUserInfo.Password = dr2["Password"].ToString();
                        mUserInfo.DeptNo = dr2["DeptNo"].ToString();
                        mUserInfo.Auth = dr2["Auth"].ToString();
                        //
                       
                    }
                    dr2.Close();
                    SqlCommand cmdPda = new SqlCommand("SELECT * FROM PDAInfo WHERE 1=1 AND IMEI='" + mGetDeviceData.CpuID+ "'", cnn);
                    SqlDataReader drpda = cmdPda.ExecuteReader();
                    if (drpda.HasRows)
                    {
                        if (drpda.Read())
                        {
                            mPdaInfo.IMEI = drpda["IMEI"].ToString();
                            mPdaInfo.PDAId = drpda["PDAId"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("不明的機器編號");
                        return;
                    }
                    drpda.Close();
                    frmMainMenu frm2 = new frmMainMenu();
                    frm2.ShowDialog();
                }
                else
                {
                   
                        MessageBox.Show("帳號或密碼錯誤");
                    
                }
            }
            else if (CommpanyIndex == 3)
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
                cnn = new SqlConnection(mstrConn3);
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='" + txtAccount.Text + "' and Password='" + txtPasswd.Text + "'", cnn);
                cnn.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.HasRows)
                {
                    if (dr3.Read())
                    {
                        mUserInfo.CommpanyIndex = 3;
                        mUserInfo.UserName = dr3["UserName"].ToString();
                        mUserInfo.UserNo = dr3["UserNo"].ToString();
                        mUserInfo.Password = dr3["Password"].ToString();
                        mUserInfo.DeptNo = dr3["DeptNo"].ToString();
                        mUserInfo.Auth = dr3["Auth"].ToString();
                       
                    }
                    dr3.Close();
                    SqlCommand cmdPda = new SqlCommand("SELECT * FROM PDAInfo WHERE 1=1 AND IMEI='" + mGetDeviceData.CpuID + "'", cnn);
                    SqlDataReader drpda = cmdPda.ExecuteReader();
                    if (drpda.HasRows)
                    {
                        if (drpda.Read())
                        {
                            mPdaInfo.IMEI = drpda["IMEI"].ToString();
                            mPdaInfo.PDAId = drpda["PDAId"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("不明的機器編號");
                        return;
                    }
                    drpda.Close();
                    //
                    frmMainMenu frm2 = new frmMainMenu();
                    frm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
            else {
                MessageBox.Show("帳號或密碼錯誤");
            }
           
        }

        private void button02_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "2";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "2";
        }

        private void button03_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "3";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "3";
        }

        private void button04_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "4";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "4";
        }

        private void button05_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "5";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "5";
        }

        private void button06_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "6";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "7";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "7";
        }

        private void button08_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "8";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "8";
        }

        private void button09_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "9";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "9";
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                txtCalc.Text += "0";
            if (ActiveControl is System.Windows.Forms.TextBox)
                ActiveControl.Text += "0";
            
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            txtCalc.Text = "";
            lblShowName.Text = "";
            //int CommpanyIndex=0;//1=合澤(03)、2=合永(10),3=小澤(06)
            if (txtAccount.Text.Length != 0)
            {
                
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                
                cnn = new SqlConnection(mstrConn1);
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='"+ txtAccount.Text+"'", cnn);
                cnn.Open();
              
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    if (dr.Read())
                    {
                        lblShowName.Text = dr["UserName"].ToString();
                        CommpanyIndex = 1;

                    }
                }
                else
                {
                    cnn.Close();
                    cnn = new SqlConnection(mstrConn2);
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='" + txtAccount.Text+"'", cnn);
                    cnn.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        if (dr2.Read())
                        {
                            lblShowName.Text = dr2["UserName"].ToString();
                            CommpanyIndex = 2;

                        }
                    }
                    else
                    {
                        cnn.Close();
                        cnn = new SqlConnection(mstrConn3);
                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM UserInfo where 1=1 and UserNo='" + txtAccount.Text + "'", cnn);
                        cnn.Open();
                        SqlDataReader dr3 = cmd3.ExecuteReader();
                        if (dr3.HasRows)
                        {
                            if (dr3.Read())
                            {
                                lblShowName.Text = dr3["UserName"].ToString();
                                CommpanyIndex = 3;

                            }
                        }
                        else
                        {
                            CommpanyIndex = 0;
                            txtAccount.Text = "";
                        }
                    }
                }

            }
        }

        private void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            //txtCalc.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (ActiveControl is System.Windows.Forms.TextBox)
                if (txtCalc.Text.Length>0)
                txtCalc.Text=txtCalc.Text.Remove(txtCalc.Text.Length-1,1);

            if (ActiveControl is System.Windows.Forms.TextBox)
                if (ActiveControl.Text.Length>0)
                ActiveControl.Text=ActiveControl.Text.Remove(ActiveControl.Text.Length-1, 1);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            SysSetup mSysSetup = new SysSetup();
            mSysSetup.ShowDialog();
        }

        private void txtPasswd_Leave(object sender, EventArgs e)
        {
            txtCalc.Text = "";
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            txtCalc.Text = txtAccount.Text;
        }

        private void txtPasswd_Enter(object sender, EventArgs e)
        {
            txtCalc.Text = txtPasswd.Text;
        }
    }
}
