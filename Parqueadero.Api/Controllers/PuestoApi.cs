using Microsoft.AspNetCore.Mvc;
using Parqueadero.Application.ApplicationService;
using Parqueadero.Domain;

namespace Parqueadero.Api.Controllers
{
    [ApiController]
    [Route("api/puesto")]
    public class PuestoApi : SubBaseController<Puesto, string>
    {

        //private readonly ICrearPuestoApplicationService crearPuestoApplicationService;
        public PuestoApi(ICrudService<Puesto, string> crudService) : base(crudService)
        {
        }
    }
}
