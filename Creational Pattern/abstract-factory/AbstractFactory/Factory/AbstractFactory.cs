﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA createProductA();
        public abstract AbstractProductB createProductB();
    }
}
