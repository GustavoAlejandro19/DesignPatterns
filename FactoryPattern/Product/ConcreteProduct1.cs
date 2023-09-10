using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Product
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "Resultado de ConcretrProduct1";
        }

    }
}
