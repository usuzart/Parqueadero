using Parqueadero.Application.ApplicationService.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Application.ApplicationService
{
    public interface ICrearPuesto
    {
        public void CrearPuesto(CrearPuestoDto crearPuestoDto);
    }
}
