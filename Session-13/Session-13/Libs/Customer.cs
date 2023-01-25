using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13.Libs {

    public class Customer {

        public Guid ID { get; set; }
        public string Name { get; set; }

        public Customer() {
            ID = Guid.NewGuid(); 
        }

    }
}
