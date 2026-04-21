namespace GLMS_Part2.Models
{
    public class Contract
    {
        //foreign key. will link to cloent
        public int ContractId { get; set; }
        public int ClientId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //status - dradt, active, expired, on hold
        public string Status { get; set; } = "";
        public string ServiceLevel { get; set; } = "";

        public string? FilePath { get; set; } 

        public Client? Client { get; set; }
    }
}
