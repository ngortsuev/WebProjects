﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFCore
{
    public class Continent
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", id, name);
        }
    }
}
