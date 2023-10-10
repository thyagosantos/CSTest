using CSTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    class Trade : ITrade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
    }
}
