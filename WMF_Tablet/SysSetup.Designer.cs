namespace WMF_Tablet
{
    partial class SysSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysSetup));
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcCompany = new System.Windows.Forms.ComboBox();
            this.cbcPrint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcPrint2 = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(440, 37);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(583, 123);
            this.txtAccount.TabIndex = 10;
            this.txtAccount.Text = "192.168.1.254";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(4, 64);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(424, 96);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "伺服器：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(100, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 96);
            this.label1.TabIndex = 11;
            this.label1.Text = "公司：";
            // 
            // cbcCompany
            // 
            this.cbcCompany.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcCompany.FormattingEnabled = true;
            this.cbcCompany.Items.AddRange(new object[] {
            "合澤(03)",
            "合永(10)",
            "小澤(06)"});
            this.cbcCompany.Location = new System.Drawing.Point(440, 184);
            this.cbcCompany.Name = "cbcCompany";
            this.cbcCompany.Size = new System.Drawing.Size(583, 104);
            this.cbcCompany.TabIndex = 12;
            this.cbcCompany.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbcPrint
            // 
            this.cbcPrint.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcPrint.FormattingEnabled = true;
            this.cbcPrint.Items.AddRange(new object[] {
            "合澤(03)",
            "合永(10)",
            "小澤(06)"});
            this.cbcPrint.Location = new System.Drawing.Point(440, 310);
            this.cbcPrint.Name = "cbcPrint";
            this.cbcPrint.Size = new System.Drawing.Size(583, 104);
            this.cbcPrint.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 96);
            this.label2.TabIndex = 13;
            this.label2.Text = "標籤機：";
            // 
            // cbcPrint2
            // 
            this.cbcPrint2.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcPrint2.FormattingEnabled = true;
            this.cbcPrint2.Items.AddRange(new object[] {
            "合澤(03)",
            "合永(10)",
            "小澤(06)"});
            this.cbcPrint2.Location = new System.Drawing.Point(409, 294);
            this.cbcPrint2.Name = "cbcPrint2";
            this.cbcPrint2.Size = new System.Drawing.Size(583, 104);
            this.cbcPrint2.TabIndex = 16;
            this.cbcPrint2.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(272, 443);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(584, 171);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "確定";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // SysSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 637);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbcPrint2);
            this.Controls.Add(this.cbcPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbcCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系統設定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SysSetup_FormClosed);
            this.Load += new System.EventHandler(this.SysSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcCompany;
        private System.Windows.Forms.ComboBox cbcPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcPrint2;
        private System.Windows.Forms.Button btnLogin;
    }
}