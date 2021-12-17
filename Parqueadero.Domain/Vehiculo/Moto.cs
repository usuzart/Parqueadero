using Parqueadero.Domain.Vehiculo;
using System;
using System.Collections.Generic;

namespace Parqueadero.Domain.Vehiculo
{
    public class Moto : VehiculoPermitido
    {

        public override IEnumerable<NumeroLLantas> NumeroLlantas => new List<NumeroLLantas>()
        {
            {NumeroLLantas.dosRuedas },
            {NumeroLLantas.tresRuedas}
        };

        
    }
}
