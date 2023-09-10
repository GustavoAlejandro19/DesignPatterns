using FactoryPattern.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Client
    {
        public void Main()
        {
            //Este puede servir para crear conexiones a bases de datos


            Console.WriteLine("Se va a utilizar un Product1:");
            ClientCode(new ConcreteCreator1());


            Console.WriteLine("Se va a utilizar un Product2:");
            ClientCode(new ConcreteCreator2());
        }

        /*
         El código cliente funciona con una instancia de un creator concreto (en este caso, creator1 o creator2.
        Al ser una interfaz, se le puede proporcionar cualquier creador.
         */
        public void ClientCode(Creator creator)
        {
            Console.WriteLine($@"Yo soy el código clinte, no tengo idea de qué tipo de creador recibí, 
                            pero aún así puedo implementar la acción en particular del objeto que se acaba de crear: {creator.SomeOperation()}");
        }
    }
}
