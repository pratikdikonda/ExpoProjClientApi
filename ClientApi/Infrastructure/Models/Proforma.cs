using System.ComponentModel.DataAnnotations;
namespace ClientApi.Infrastructure.Models
{
    public class Proforma
    {
        [Required]
        public int documateNumber { get; set; }
        public string exporterName { get; set; }
        public string exporterAddress { get; set; }
        public string consignee { get; set; }
        public string consigneeAddress { get; set; }
        public int proformaInvoiceNo { get; set; }
        public DateTime proformaDate { get; set; }
        public string exportersRef { get; set; }
        public string buyerOrderNo { get; set; }
        public DateTime buyerOrderDate { get; set; }
        public string othersRef { get; set; }
        public string otherbuyer1 { get; set; }

        public string otherbuyer2 { get; set; }
        public string otherbuyer3 { get; set; }
        public string otherbuyer4 { get; set; }
        public string otherbuyer5 { get; set; }
        public string countryOfOrigin { get; set; }
        public string countryOfFinalDestination { get; set; }
        public string preCarraigeBy { get; set; }
        public string placeOfReceipt { get; set; }
        public string termsOfDelivery { get; set; }

        public string portOfLoding { get; set; }

        public string portOfDischarge { get; set; }

        public string finalDestination { get; set; }

        public string hsnCode { get; set; }

        public int  catId { get; set; }


    }
}
