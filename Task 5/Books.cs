using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Books : Product
    {
        public int PageAmount { get; set; }
        public string Edition { get; set; }
        public string Authors { get; set; }
    }
}
