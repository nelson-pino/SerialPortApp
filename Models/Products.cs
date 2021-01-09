namespace SerialPortApp.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Products
    {
        [Key]
        public int ProductID{ get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string Departament { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public string Ingredients { get; set; }
    }
}
