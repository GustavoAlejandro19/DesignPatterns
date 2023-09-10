using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product;

namespace FactoryPattern.Creators
{
    /*La clase creadora declara el método fábrica que va a regresar
     un objeto de la clase Producto. Las sublcases de esta clase usualmente proveen
    la implementación de este método.
     */
    public abstract class Creator
    {
        /*Este es el método creador, a veces las clases creadoras pueden proveer su propia
        implementación de este método.
        */
        public abstract IProduct FactoryMethod();


        /*
         A pesar de su nombre, la funcionalidad principal de la clase creator no es crear objetos.
        Usualmente contiene alguna lógica core referente a los tipos de objeto que regresa. Las subclases
        pueden cambiar esta lógica indirectamente sobreescribiendo este método y regresando un diferente tipo de
        producto.

        NOTA: aquí se podrían poner métodos como open connection, close connection :o
         */
        public string SomeOperation()
        {
            // Crear un producto
            var product = FactoryMethod(); //magia! se manda a llamar el del hijo, el que nos regresará una instancia del producto concreto
            // Usar el producto
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
