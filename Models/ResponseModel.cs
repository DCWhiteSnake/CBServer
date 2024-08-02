namespace CoreBankingMock.Models
{
    public class ResponseBaseModel
    {
        public string responseMessage { get; set; }
        public string responseCode { get; set; }
        public DateTime TransactionDate { get; set; }
    }

    public class FundTransferRespModel : ResponseBaseModel
    {
        public string t24FTReference { get; set; }
        public bool Pending { get; set; }
    }
}
