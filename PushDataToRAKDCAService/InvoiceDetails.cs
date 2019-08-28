using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushDataToRAKDCAService
{
    class InvoiceDetails
    {
        //InvoiceDetailID field will be considered as Unique Number generated form Share point system
        public string InvoiceDetailID { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }  // considered as ServiceDescription
        public string CompanyCode { get; set; }
        public string InvoiceNO { get; set; }
        public string Currency { get; set; }
        public string GLNo { get; set; }
        public string GrossAmount { get; set; }
        public string NetAmount { get; set; }
        public string TaxAmount { get; set; }
        public string TaxCode { get; set; }
        public string TaxPercentage { get; set; }
        public string AssignmentField { get; set; }
        public string LineItemText { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }




    }
}
