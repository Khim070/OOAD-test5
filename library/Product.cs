using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlib
{
    public class Product
    {
        public String Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Category Category { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
