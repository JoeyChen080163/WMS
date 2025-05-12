namespace WMF_Tablet
{
    partial class frmLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSysName = new System.Windows.Forms.Label();
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblShowName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.button02 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 3942);
            this.button1.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 3713);
            this.button2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSysName
            // 
            this.lblSysName.AutoSize = true;
            this.lblSysName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSysName.Font = new System.Drawing.Font("標楷體", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSysName.Location = new System.Drawing.Point(364, 41);
            this.lblSysName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(1086, 107);
            this.lblSysName.TabIndex = 3;
            this.lblSysName.Text = "IDEAHOUSE  倉儲管理";
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMachineNo.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMachineNo.Location = new System.Drawing.Point(1439, 73);
            this.lblMachineNo.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(131, 38);
            this.lblMachineNo.TabIndex = 4;
            this.lblMachineNo.Text = "機號：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.imgClose);
            this.panel1.Controls.Add(this.lblMachineNo);
            this.panel1.Controls.Add(this.lblSysName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2147, 300);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imgClose
            // 
            this.imgClose.Image = global::WMF_Tablet.Properties.Resources.close_100dp;
            this.imgClose.Location = new System.Drawing.Point(1678, 0);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(243, 310);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 7;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(230, 377);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(328, 96);
            this.lblAccount.TabIndex = 6;
            this.lblAccount.Text = "帳號：";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPasswd.Location = new System.Drawing.Point(230, 645);
            this.lblPasswd.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(328, 96);
            this.lblPasswd.TabIndex = 7;
            this.lblPasswd.Text = "密碼：";
            this.lblPasswd.Click += new System.EventHandler(this.lblPasswd_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(555, 350);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(583, 123);
            this.txtAccount.TabIndex = 8;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            this.txtAccount.Enter += new System.EventHandler(this.txtAccount_Enter);
            this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPasswd.Location = new System.Drawing.Point(555, 618);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(583, 123);
            this.txtPasswd.TabIndex = 9;
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            this.txtPasswd.Enter += new System.EventHandler(this.txtPasswd_Enter);
            this.txtPasswd.Leave += new System.EventHandler(this.txtPasswd_Leave);
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShowName.Location = new System.Drawing.Point(1182, 363);
            this.lblShowName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(616, 96);
            this.lblShowName.TabIndex = 10;
            this.lblShowName.Text = "顯示人員名稱";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(555, 880);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(584, 171);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button01
            // 
            this.button01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button01.CausesValidation = false;
            this.button01.Location = new System.Drawing.Point(1315, 646);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(106, 82);
            this.button01.TabIndex = 12;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = false;
            this.button01.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // txtCalc
            // 
            this.txtCalc.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCalc.Location = new System.Drawing.Point(1315, 575);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(312, 65);
            this.txtCalc.TabIndex = 24;
            // 
            // button02
            // 
            this.button02.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button02.CausesValidation = false;
            this.button02.Location = new System.Drawing.Point(1418, 646);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(106, 82);
            this.button02.TabIndex = 25;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = false;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button03
            // 
            this.button03.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button03.CausesValidation = false;
            this.button03.Location = new System.Drawing.Point(1521, 646);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(106, 82);
            this.button03.TabIndex = 26;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = false;
            this.button03.Click += new System.EventHandler(this.button03_Click);
            // 
            // button06
            // 
            this.button06.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button06.CausesValidation = false;
            this.button06.Location = new System.Drawing.Point(1521, 724);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(106, 82);
            this.button06.TabIndex = 29;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = false;
            this.button06.Click += new System.EventHandler(this.button06_Click);
            // 
            // button05
            // 
            this.button05.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button05.CausesValidation = false;
            this.button05.Location = new System.Drawing.Point(1418, 724);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(106, 82);
            this.button05.TabIndex = 28;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = false;
            this.button05.Click += new System.EventHandler(this.button05_Click);
            // 
            // button04
            // 
            this.button04.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button04.CausesValidation = false;
            this.button04.Location = new System.Drawing.Point(1315, 724);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(106, 82);
            this.button04.TabIndex = 27;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = false;
            this.button04.Click += new System.EventHandler(this.button04_Click);
            // 
            // button09
            // 
            this.button09.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button09.CausesValidation = false;
            this.button09.Location = new System.Drawing.Point(1521, 803);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(106, 82);
            this.button09.TabIndex = 32;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = false;
            this.button09.Click += new System.EventHandler(this.button09_Click);
            // 
            // button08
            // 
            this.button08.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button08.CausesValidation = false;
            this.button08.Location = new System.Drawing.Point(1418, 803);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(106, 82);
            this.button08.TabIndex = 31;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = false;
            this.button08.Click += new System.EventHandler(this.button08_Click);
            // 
            // button07
            // 
            this.button07.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button07.CausesValidation = false;
            this.button07.Location = new System.Drawing.Point(1315, 803);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(106, 82);
            this.button07.TabIndex = 30;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = false;
            this.button07.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Green;
            this.buttonSend.CausesValidation = false;
            this.buttonSend.Location = new System.Drawing.Point(1521, 880);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(106, 82);
            this.buttonSend.TabIndex = 35;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            // 
            // button00
            // 
            this.button00.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button00.CausesValidation = false;
            this.button00.Location = new System.Drawing.Point(1418, 880);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(106, 82);
            this.button00.TabIndex = 34;
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = false;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Aqua;
            this.buttonBack.CausesValidation = false;
            this.buttonBack.Location = new System.Drawing.Point(1315, 880);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(106, 82);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.BackColor = System.Drawing.Color.Red;
            this.btnSetup.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetup.Location = new System.Drawing.Point(101, 878);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(366, 171);
            this.btnSetup.TabIndex = 36;
            this.btnSetup.Text = "設定";
            this.btnSetup.UseVisualStyleBackColor = false;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1061);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button09);
            this.Controls.Add(this.button08);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人員登入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Label lblMachineNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnSetup;
    }
}

