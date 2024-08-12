using fiap_5nett_tech.Application.DataTransfer.Request;
using fiap_5nett_tech.Application.DataTransfer.Response;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace fiap_5nett_tech.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionController
    {
        private readonly IRegionInterface _regionInterface;
        public RegionController(IRegionInterface regionInterface)
        {
            _regionInterface = regionInterface;
        }
        /// <summary>
        /// Obtém todos os regioes
        /// </summary>
        /// <param name="name">O objeto de solicitação para buscar todas as regioes.</param>
        /// <response code="200">Retorna uma lista paginada de regioes.</response>
        /// <response code="400">Solicitação inválida.</response>
        /// <response code="500">Houve um erro interno no servidor.</response>
        /// <returns>Um objeto de resposta de contato paginado.</returns>
        [HttpGet]
        public List<RegionResponse> GetAll([FromQuery] string? name)
        {
            string regionName = name ?? string.Empty;
            return _regionInterface.GetAll(regionName);
        }
    }
}
