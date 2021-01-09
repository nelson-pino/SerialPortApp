namespace SerialPortApp.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Products
    {
        [Key]
        public string ProductID{ get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        public string Departament { get; set; }
        public string UnitShop { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public string Ingredients { get; set; }
    }
}
