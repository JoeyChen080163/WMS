namespace WMF_Tablet
{
    partial class frmTransferOperation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblSysName = new System.Windows.Forms.Label();
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblPurchase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgClose);
            this.panel1.Controls.Add(this.lblSysName);
            this.panel1.Controls.Add(this.lblMachineNo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 11;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPurchase.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPurchase.Location = new System.Drawing.Point(18, 30);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(169, 38);
            this.lblPurchase.TabIndex = 8;
            this.lblPurchase.Text = "調撥作業";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1403, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "機號：";
            // 
            // imgClose
            // 
            this.imgClose.Image = global::WMF_Tablet.Properties.Resources.close_100dp;
            this.imgClose.Location = new System.Drawing.Point(1801, 0);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(100, 100);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 8;
            this.imgClose.TabStop = false;
            // 
            // lblSysName
            // 
            this.lblSysName.AutoSize = true;
            this.lblSysName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSysName.Font = new System.Drawing.Font("標楷體", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSysName.Location = new System.Drawing.Point(554, 19);
            this.lblSysName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(690, 67);
            this.lblSysName.TabIndex = 3;
            this.lblSysName.Text = "IDEAHOUSE  倉儲管理";
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMachineNo.Font = new System.Drawing.Font("標楷體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMachineNo.Location = new System.Drawing.Point(1403, 62);
            this.lblMachineNo.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(169, 38);
            this.lblMachineNo.TabIndex = 4;
            this.lblMachineNo.Text = "操作者：";
            // 
            // frmTransferOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransferOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "調撥作業";
            this.Load += new System.EventHandler(this.frmTransferOperation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Label lblMachineNo;
    }
}