﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    public class City
    {
        public int id { get; set; }
        public int id_country { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", id, id_country, name);
        }
    }
}
