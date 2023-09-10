using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product;

namespace FactoryPattern.Creators
{
    /*
    Los creadores concretos sobreescriben el método de fábrica (de la clase creator)
   para cambiar el tipo de producto que regresa.

    Esta clase se encarga de crear ConcreteProduct2
    */
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
