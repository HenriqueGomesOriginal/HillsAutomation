using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillsAutomation.valueObject
{
    internal class QRCodeObject
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string QrCodeBase { get; set; }
        public string NumeroLote { get; set; }
        public bool Used { get; set; }
    }
}
