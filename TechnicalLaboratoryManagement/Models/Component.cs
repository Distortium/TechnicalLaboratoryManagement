namespace TechnicalLaboratoryManagement.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public int ComponentTypeId { get; set; }
        //public ComponentType Type { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        //public List<RobotComponent> RobotComponents { get; set; } = new();
        //public List<WarehouseItem> WarehouseItems { get; set; } = new();
    }
}
