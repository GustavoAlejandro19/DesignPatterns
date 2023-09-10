using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Product
{
    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "Resultado de ConcreteProduct2";
        }
    }
}
