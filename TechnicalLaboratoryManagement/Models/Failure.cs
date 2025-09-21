namespace TechnicalLaboratoryManagement.Models
{
    public class Failure
    {
        public int Id { get; set; }
        public int RobotId { get; set; }
        public Robot Robot { get; set; }
        public DateTime FailureDate { get; set; }
        public DateTime? RepairDate { get; set; }
        public string Description { get; set; }
        public string Cause { get; set; }
        public string Solution { get; set; }
        public decimal RepairCost { get; set; }
        public List<int> UsedComponentIds { get; set; } = new();
    }
}
