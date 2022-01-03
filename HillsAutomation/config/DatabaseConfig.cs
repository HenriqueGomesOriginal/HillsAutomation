using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillsAutomation.config
{
    internal class DatabaseConfig
    {
        public string database { get; set; }
        public int port { get; set; }   
        public string host { get; set; }   
        public string user  { get; set; }
        public string password { get; set; }

    }
}
