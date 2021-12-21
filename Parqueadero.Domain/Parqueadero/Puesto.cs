using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain
{
    public class Puesto : Entity<string>, IEquatable<Puesto>
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public Puesto(){}

        private Puesto(string nombre, int numero)
        {           
            this.Nombre = nombre;
            this.Numero = numero;
        }

        public static Puesto Crear(string nombre, int numero)
        {
            return new Puesto(nombre, numero);
        }

        public  bool Equals(Puesto other)
        {
            if (other == null) return false;
            return (this.Nombre.Equals(other.Nombre));
        }
    }
}
