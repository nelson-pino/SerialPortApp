using System;
using System.ComponentModel.DataAnnotations;

namespace SerialPortApp.Models
{
    public class Batchs
    {
        public int Id { get; set; }
        [Required]
        public string BatchNumber { get; set; }
        public string Description { get; set; }
        public string Person { get; set; }
        public bool BatchStatus { get; set; }
        [Required]
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
    }
}
