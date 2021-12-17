using AutoMapper;
using Parqueadero.Domain.InfraestructureService;


namespace Parqueadero.Infraestructure
{
    public class MapService : IMapService
    {
        private readonly IMapper mapper;
        public MapService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TTo Map<Tfrom, TTo>(Tfrom @object)
            where Tfrom : class
            where TTo : class, new()
        {
            return mapper.Map<Tfrom, TTo>(@object);
        }
    }
}
