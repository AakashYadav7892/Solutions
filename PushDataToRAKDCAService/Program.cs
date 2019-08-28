using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.RAKDCAServiceReference;
using Microsoft.SharePoint.Client;
using PushDataToRAKDCAService;

namespace ConsoleApp1
{
    class Program
    {
        static List<DT_DCA_SENDERFIFields> objDataList;
        static string spurl = ConfigurationManager.AppSettings["Sharepoint_URL"].ToString();
        static string UserName = ConfigurationManager.AppSettings["UserName"].ToString();
        static string pwd = ConfigurationManager.AppSettings["Password"].ToString();
        static void Main(string[] args)
        {

            //ProcessData();

            List<DT_DCA_SENDERFIFields> objBatchList = GetBatchData();
            Console.ReadKey();

        }

        private static List<DT_DCA_SENDERFIFields> GetBatchData()
        {
            List<DT_DCA_SENDERFIFields> objBatchList = new List<DT_DCA_SENDERFIFields>();
            objDataList = GetBatchList();
            objBatchList = objDataList.GroupBy(x => new { x.GLNumber, x.TaxCode, x.TaxPercentage, x.DocumentDate })
                    .Select(y => new DT_DCA_SENDERFIFields()
                    {
                        DocumentDate = y.First().DocumentDate.ToString(),
                        FiscalYear = y.First().FiscalYear.ToString(),
                        Documentheaderreference = "REVENUE COLLECTIONS",
                        ServiceCode = y.First().ServiceCode.ToString(),
                        ServiceDescription = y.First().ServiceDescription.ToString(),
                        CompanyCode = "DCA",
                        Currency = "AED",
                        GLNumber = y.Key.GLNumber,
                        NetAmount = y.Sum(c => Convert.ToDouble(c.NetAmount)).ToString(),
                        GrossAmount = y.Sum(c => Convert.ToDouble(c.GrossAmount)).ToString(),
                        TaxAmount = y.Sum(c => Convert.ToDouble(c.TaxAmount)).ToString(),
                        TaxCode = y.Key.TaxCode,
                        TaxPercentage = y.Key.TaxPercentage,
                        //AssignmentField = y.Select(c => c.AssignmentField).ToString(),
                        LineItemText = y.First().ServiceDescription.ToString(),
                        //UniqueNumbergeneratedfromSharepointsystem = "",
                        CreatedDate = y.First().CreatedDate.ToString(),
                        CreatedTime = y.First().CreatedTime.ToString(),
                        CreatedByUserId = y.Select(c => c.CreatedByUserId).ToString(),
                        CustomField1 = "",
                        CustomField2 = "",
                        CustomField3 = "",
                        CustomField4 = "",
                        CustomField5 = ""
                    }
                    ).ToList();
            return objBatchList;
        }


        private static List<DT_DCA_SENDERFIFields> GetBatchList()
        {
            DT_DCA_SENDERFIFields[] dt_DCA_Senders;

            List<DT_DCA_SENDERFIFields> objBatchList = new List<DT_DCA_SENDERFIFields>();

            List<Invoice> objList = GetInvoiceList();
            if (objList.Count > 0)
            {
                foreach (Invoice objInvoice in objList)
                {
                    if (objInvoice.InvoiceDetails.Count() > 0)
                    {
                        int i = 0;
                        dt_DCA_Senders = new DT_DCA_SENDERFIFields[objInvoice.InvoiceDetails.Count()];

                        foreach (InvoiceDetails objDetails in objInvoice.InvoiceDetails)
                        {
                           // dt_DCA_Senders = new DT_DCA_SENDERFIFields[objInvoice.InvoiceDetails.Count()];

                            DT_DCA_SENDERFIFields objModel = new DT_DCA_SENDERFIFields();
                            objModel.DocumentDate = objInvoice.Date;
                            objModel.FiscalYear = objInvoice.Year;
                            objModel.ServiceCode = objDetails.ServiceCode;
                            objModel.ServiceDescription = objDetails.ServiceName;
                            objModel.GLNumber = objDetails.GLNo;
                            objModel.NetAmount = objDetails.NetAmount;
                            objModel.GrossAmount = objDetails.GrossAmount;
                            objModel.TaxAmount = objDetails.TaxAmount;
                            objModel.TaxCode = objDetails.TaxCode;
                            objModel.TaxPercentage = objDetails.TaxPercentage;
                            objModel.LineItemText = objDetails.LineItemText;
                            objModel.CreatedDate = objInvoice.CreatedDate;
                            objModel.CreatedTime = objInvoice.CreatedTime;
                            objModel.CreatedByUserId = objInvoice.CreatedBY;
                            objModel.CustomField1 = objDetails.CustomField1;
                            objModel.CustomField2 = objDetails.CustomField2;
                            objModel.CustomField3 = objDetails.CustomField3;
                            objModel.CustomField4 = objDetails.CustomField4;
                            objModel.CustomField5 = objDetails.CustomField5;
                            objModel.UniqueNumbergeneratedfromSharepointsystem = objDetails.InvoiceDetailID;

                            dt_DCA_Senders[i] = objModel;
                            i = i + 1;

                            objBatchList.Add(objModel);

                        }

                       string Response = PushToService(dt_DCA_Senders);
                        //string Response = PushToService(objBatchList);
                        //if (!string.IsNullOrEmpty(Response))
                        //{
                        //    UpdateServiceResponse(objInvoice.InvoiceNO);
                        //}
                    }
                }
            }
            return objBatchList;

        }

        private static string PushToService(DT_DCA_SENDERFIFields[] dt_DCA_Senders)
        {
            // Instantiate the proxy  
            RAKDCAServiceReference.SI_DCA_OBClient proxy = new RAKDCAServiceReference.SI_DCA_OBClient("HTTP_Port");

            // Set the user’s credentials on the proxy  
            proxy.ClientCredentials.UserName.UserName = "TEST_USER007";
            proxy.ClientCredentials.UserName.Password = "init123";

            // Treat the test certificate as trusted  
            // proxy.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;


            // Call the service operation using the proxy     
            //DT_DCA_SENDERFIFields objModel = new DT_DCA_SENDERFIFields();
            //objModel.DocumentDate = "7/1/2019";
            //objModel.FiscalYear = "2019";
            //objModel.Documentheaderreference = "Document Head";
            //objModel.ServiceCode = "10055";
            //objModel.ServiceDescription = "Issuance of Airport Passes during December 2018";
            //objModel.CompanyCode = "4015";
            //objModel.Currency = "US Dollar";
            //objModel.GLNumber = "11101163";
            //objModel.NetAmount = "10";
            //objModel.GrossAmount = "10";
            //objModel.TaxAmount = "10";
            //objModel.TaxCode = "SS";
            //objModel.TaxPercentage = "10";
            //objModel.AssignmentField = "AssignmentField";
            //objModel.LineItemText = "LineItemText 01";
            //objModel.UniqueNumbergeneratedfromSharepointsystem = "10001";
            //objModel.CreatedDate = "2019/07/23";
            //objModel.CreatedTime = "10:30:05";
            //objModel.CreatedByUserId = "1";
            //objModel.CustomField1 = "Title";
            //objModel.CustomField2 = "Description";
            //objModel.CustomField3 = "WebURL";
            //objModel.CustomField4 = "FullName";
            //objModel.CustomField5 = "Address";

            //DT_DCA_SENDERFIFields[] dt_DCA_Senders = new DT_DCA_SENDERFIFields[1];
            //dt_DCA_Senders[0] = objModel;
            string response;
            using (OperationContextScope scope = new OperationContextScope(proxy.InnerChannel))
            {
                HttpRequestMessageProperty httpRequestProperty = new HttpRequestMessageProperty();
                httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(proxy.ClientCredentials.UserName.UserName + ":" + proxy.ClientCredentials.UserName.Password));
                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
                var obj = proxy.SI_DCA_OB(dt_DCA_Senders);
                response = obj.REFNUM;
            }
            return response;

        }

        private static List<Invoice> GetInvoiceList()
        {
            SecureString Password = new SecureString();
            foreach (char c in pwd)
                Password.AppendChar(c);
            List<Invoice> InvoiceList = new List<Invoice>();

            try
            {
                using (ClientContext context = new ClientContext(spurl))
                {
                    DateTime yesterdayDate = DateTime.Now.AddDays(-1);
                    CamlQuery query = new CamlQuery();
                    //query.ViewXml = "<View><Query><Where><Eq><FieldRef Name='Payment_x0020_Status' /><Value Type='Text'>Paid</Value></Eq><Eq><FieldRef Name='PaymentDate' /><Value Type='Text'>"+ yesterdayDate.ToString("s") + "</Value></Eq></Where></Query></View>";
                    query.ViewXml = "<View><Query><Where><Eq><FieldRef Name='Payment_x0020_Status' /><Value Type='Text'>Paid</Value></Eq></Where></Query></View>";
                    context.Credentials = new NetworkCredential(UserName, Password);
                    Microsoft.SharePoint.Client.List invoiceSharePointList = context.Web.Lists.GetByTitle("Invoice");
                    ListItemCollection invoiceListItem = invoiceSharePointList.GetItems(query);
                    context.Load(invoiceListItem);
                    context.Load(invoiceSharePointList.RootFolder);
                    context.ExecuteQuery();


                    if (invoiceListItem.Count > 0)
                    {
                        foreach (ListItem itmPass in invoiceListItem)
                        {
                            Invoice invoiceObject = new Invoice();
                            invoiceObject.InvoiceNO = Convert.ToString(itmPass["ID"]);
                            invoiceObject.Date = Convert.ToString(Convert.ToDateTime(itmPass["Created"]).ToString("dd.MM.yyyy"));//put paymentDate Here
                            invoiceObject.Year = Convert.ToString(Convert.ToDateTime(itmPass["Created"]).ToString("yyyy"));
                            //invoiceObject.DocumentHeadReference = "REVENUE COLLECTIONS";//need to confirm 
                            invoiceObject.CreatedBY = Convert.ToString(itmPass["Author"]);
                            invoiceObject.CreatedDate = Convert.ToString(Convert.ToDateTime(itmPass["Created"]).ToString("dd.MM.yyyy"));
                            invoiceObject.CreatedTime = Convert.ToString(Convert.ToDateTime(itmPass["Created"]).ToString("HH:mm:ss"));

                            invoiceObject.InvoiceDetails = GetInvoiceDetailList(invoiceObject.InvoiceNO);
                            InvoiceList.Add(invoiceObject);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return InvoiceList;
        }

        private static List<InvoiceDetails> GetInvoiceDetailList(string InvoiceNO)
        {
            SecureString Password = new SecureString();
            foreach (char c in pwd)
                Password.AppendChar(c);
            List<InvoiceDetails> InvoiceDetailList = new List<InvoiceDetails>();
            try
            {

                using (ClientContext context = new ClientContext(spurl))
                {
                    CamlQuery query = new CamlQuery();
                    query.ViewXml = "<View><Query><Where><Eq><FieldRef Name='Invoice_x0020_NO_x002e_' /><Value Type='Text'>" + InvoiceNO + "</Value></Eq></Where></Query></View>";

                    context.Credentials = new NetworkCredential(UserName, Password);
                    Microsoft.SharePoint.Client.List paymentDetailSharePointList = context.Web.Lists.GetByTitle("Invoice Details");
                    ListItemCollection paymentDetailListItem = paymentDetailSharePointList.GetItems(query);
                    Folder folder = paymentDetailSharePointList.RootFolder;
                    context.Load(paymentDetailListItem);
                    context.Load(paymentDetailSharePointList.RootFolder);
                    context.ExecuteQuery();


                    if (paymentDetailListItem.Count > 0)
                    {

                        foreach (ListItem itmPass in paymentDetailListItem)
                        {
                            InvoiceDetails InvoiceDetailsObject = new InvoiceDetails();
                            InvoiceDetailsObject.InvoiceDetailID = Convert.ToString(itmPass["ID"]);
                            InvoiceDetailsObject.ServiceName = Convert.ToString(itmPass["Service_x0020_Name"]);
                            InvoiceDetailsObject.ServiceCode = "test";//need to insert Service Code
                            //InvoiceDetailsObject.CompanyCode = "DCA";
                            //InvoiceDetailsObject.Currency = "AED";
                            InvoiceDetailsObject.GLNo = Convert.ToString(itmPass["GL_x0020_No"]);
                            InvoiceDetailsObject.GrossAmount = Convert.ToString(itmPass["Amount"]);
                            InvoiceDetailsObject.NetAmount = Convert.ToString(itmPass["Total_x0020_Amount"]);
                            InvoiceDetailsObject.TaxAmount = Convert.ToString(itmPass["Tax_x0020_Amount"]);
                            InvoiceDetailsObject.TaxCode = Convert.ToString(itmPass["Tax_x0020_Code"]);
                            InvoiceDetailsObject.TaxPercentage = Convert.ToString(itmPass["Tax_x0020__x0025_"]);
                            InvoiceDetailsObject.LineItemText = Convert.ToString(itmPass["Service_x0020_Name"]);
                            InvoiceDetailsObject.CustomField1 = "";
                            InvoiceDetailsObject.CustomField2 = "";
                            InvoiceDetailsObject.CustomField3 = "";
                            InvoiceDetailsObject.CustomField4 = "";
                            InvoiceDetailsObject.CustomField5 = "";

                            InvoiceDetailList.Add(InvoiceDetailsObject);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw;

            }

            return InvoiceDetailList;
        }

        private static bool UpdateServiceResponse(string invoiceNO)
        {
            bool status = false;
            try
            {
                using (ClientContext context = new ClientContext(spurl))
                {
                    SecureString Password = new SecureString();
                    foreach (char c in pwd)
                        Password.AppendChar(c);
                    CamlQuery query = new CamlQuery();
                    query.ViewXml = "<View><Query><Where><Eq><FieldRef Name='ID' /><Value Type='Text'>" + invoiceNO + "</Value></Eq></Where></Query></View>";

                    context.Credentials = new NetworkCredential(UserName, Password);
                    Microsoft.SharePoint.Client.List invoiceSharePointList = context.Web.Lists.GetByTitle("Invoice");
                    ListItemCollection invoiceListItem = invoiceSharePointList.GetItems(query);
                    context.Load(invoiceListItem);
                    context.ExecuteQuery();
                    var item = invoiceListItem[0];
                    item["Invoice_x0020_Status"] = "Pushed";
                    item.Update();
                    context.ExecuteQuery();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return status;
        }
    }
}
