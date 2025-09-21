namespace TechnicalLaboratoryManagement.Models
{
    public class Robot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int RobotTypeId { get; set; }
        //public RobotType Type { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime ManufactureDate { get; set; }
        //public List<RobotComponent> Components { get; set; } = new();
        public List<Failure> Failures { get; set; } = new();
    }
}
