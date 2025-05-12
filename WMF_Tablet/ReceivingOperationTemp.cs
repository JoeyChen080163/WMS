using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMF_Tablet
{
    public class ReceivingOperationTemp
    {
        public int BoxSeq;//存檔流水號
        public String ReceivingDate { get; set; }//進貨日期
        public String BillNO { get; set; }//採單編號
        public String CustomerID { get; set; }//供應商編號
        public String CustomerName { get; set; }//供應商名稱
        public String ProdId { get; set; }//產品編號(料號)
        public String ProdName { get; set; }//品名
        public String BatchNumber { get; set; }//批號
        public int Quantity { get; set; }//數量
        public int BoxNumber { get; set; }//箱
        public int Mantissa { get; set; }  //尾數
        public int Subtotal { get; set; } //小計
        public int GrandTotal { get; set; } //累計
        public int WorkOrderNotEntered { get; set; } //工單未進
        public int OverchargeOfWorkOrders { get; set; } //工單超收
        public bool Pallet { get; set; } //是否板進
    }
}
