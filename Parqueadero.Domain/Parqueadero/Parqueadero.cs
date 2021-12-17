using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain
{
    public class Parqueadero : Entity<string>
    {
        public string Name { get; set; }
        public string Direccion { get; set; }


        public Parqueadero()
        {

        }

        private Parqueadero(string id, string name, string direccion)
        {
            this.Id = id;
            this.Name = name;
            this.Direccion = direccion;


        }

        public static Parqueadero Crear(string id, string name, string direccion)
        {
            return new Parqueadero(id, name, direccion);
        }
    }
    
}
