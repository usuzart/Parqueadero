using Parqueadero.Domain;
using Parqueadero.Domain.DomainService;
using System;
using System.Collections.Generic;

namespace Parqueadero.Infraestructure
{
    public class CrearPuesto : ICrearPuesto

    {
        private static IList<Domain.Puesto> PARQUADERO = new List<Domain.Puesto>();
        public CrearPuesto()
        { 
        }
        Domain.Puesto ICrearPuesto.CrearPuesto(Puesto puesto)    
        {
            PARQUADERO.Add(puesto);
            return puesto;
        }
    }
}
