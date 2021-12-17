using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain.Vehiculo
{
    public abstract class Vehiculo
    {
        public string Name { get; set; }
        public string Placa { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }

        public abstract IEnumerable<NumeroLLantas> NumeroLlantas { get; }
    }
}
