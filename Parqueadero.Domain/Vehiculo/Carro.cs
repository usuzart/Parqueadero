using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain.Vehiculo
{
    public class Carro : VehiculoPermitido
    {

        public override IEnumerable<NumeroLLantas> NumeroLlantas => new List<NumeroLLantas>()
        {
            {NumeroLLantas.dosRuedas },
            {NumeroLLantas.cuatroRuedas},
        };
    }
}
