using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Products : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string Measurement { get; set; }
    }
}
