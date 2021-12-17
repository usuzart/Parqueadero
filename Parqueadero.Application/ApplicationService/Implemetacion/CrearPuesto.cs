using Parqueadero.Application.ApplicationService.Dto;
using Parqueadero.Domain;
using Parqueadero.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Application.ApplicationService.Implemetacion
{
    public class CrearPuesto : CrearPuestoApplicationService<Puesto, string>, ICrearPuesto
    {

        private readonly IRepository<Puesto, string> _puestoRepository;
        public CrearPuesto(IRepository<Puesto, string> respository) : base(respository)
        {
            this._puestoRepository = respository;
        }

        void ICrearPuesto.CrearPuesto(CrearPuestoDto crearPuestoDto)
        {
            throw new NotImplementedException();
        }
    }
}
