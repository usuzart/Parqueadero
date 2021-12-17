using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain.DomainService
{
    public interface  ICrearPuesto
    {
        public Puesto CrearPuesto( Puesto puesto);
    }
}
