using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Entity
{
    public abstract class EntityBase
    {
        //Las propiedades base que tendrán todos los objetos
        public int Id { get; set; }
    }
}
