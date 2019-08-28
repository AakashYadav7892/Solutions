using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDataToRAKDCAService
{
    class Invoice
    {
        public string InvoiceNO { get; set; }
        public string PaymentHistoryNumber { get; set; }
        public string Date { get; set; }
        public string CreatedBY { get; set; }
        public string Year { get; set; }
        public string DocumentHeadReference { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedTime { get; set; }
        public string InvoiceStatus { get; set; }

        public List<InvoiceDetails> InvoiceDetails;


    }
}
