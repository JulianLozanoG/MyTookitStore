using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTookitStore.Models
{
    public class Operator
    {
        public int OPeratorID { get; set; }
        public int Name { get; set; }
        public int LastName { get; set; }
        public List<Identification> Identifications { get; set; }
    }
}