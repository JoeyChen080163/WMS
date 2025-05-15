using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMF_Tablet
{
    public  class SavePurchaseLog
    {
        public String BillNo { get; set; }
        public String BillDate { get; set; }
        public String CustID { get; set; }
        public String FromNO { get; set; }
        public String ProdID { get; set; }
        public String BatchID { get; set; }
        public String BoxNum { get; set; }
        public String BoxCount { get; set; }
        public String Remainder { get; set; }
        public String Quantity { get; set; }
        public String TotalBox { get; set; }
        public String ItemRemark { get; set; }
        public String WorkPDAId { get; set; }
        public String InsertDateTime { get; set; }
        public String InsertUserNo { get; set; }
        public String UploadDateTime { get; set; }
        public String UploadUserNo { get; set; }
        public String ExportDateTime { get; set; }
        public int Pallet { get; set; } //是否板進
    }
}
