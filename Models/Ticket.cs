namespace SerialPortApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Ticket
    {
        [Key]
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Peso_Bruto { get; set; }
        public int Peso_tara { get; set; }
        public int Peso_Neto { get; set; }
        public string Operador { get; set; }
        public int NumeroLote { get; set; }
        public string  NumeroCodeBar { get; set; }
        public string comentario { get; set; }
        public decimal UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public string Ubicacion { get; set; }

    }
}
