using AutoMapper;
using Parqueadero.Domain;


namespace Parqueadero.Infraestructure
{
    class MapPorfile : Profile
    {
        public MapPorfile()
        {
            CreateMap<Puesto, CrearPuestoDto>();
        }
    }
    
}
