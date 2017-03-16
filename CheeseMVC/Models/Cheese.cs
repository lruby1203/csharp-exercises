using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string desc;
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

    }
}
