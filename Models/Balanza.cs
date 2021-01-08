using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortApp.Models
{
    public class Balanza
    {
        public int BaudRate { get; set; }
        public string Parity { get; set; }
        public string StopBits { get; set; }
        public string HandShake { get; set; }
        public int BaudRaReceivedBytesThreshold { get; set; }
        public string OutputString { get; set; }

    }
}
