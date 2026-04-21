namespace GLMS_Part2.Models
{
    public class ServiceRequest
    {
        //primary key
        public int ServiceRequestId { get; set; }
        public int ContractId { get; set; }

        public string Description { get; set; } = "";
        public double CostUSD { get; set; }
        public double CostZAR { get; set; }

        public string Status { get; set; } = "";

        public Contract? Contract { get; set; }
    }
}
