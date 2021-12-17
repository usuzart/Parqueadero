using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Domain.InfraestructureService
{
    public interface IMapService
    {
        public TTo Map<Tfrom, TTo>(Tfrom @object)
            where TTo : class, new()
            where Tfrom : class;
    }
}
