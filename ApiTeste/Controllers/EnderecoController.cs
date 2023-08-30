using System.Net;
using Microsoft.AspNetCore.Mvc;
using NETAPLICATIONS.Interfaces;

namespace NETAPLICATIONS.Controllers{


[ApiController]
[Route("api/v1/[controller]")]
public class EnderecoController : ControllerBase{

    private readonly IEndereco _endereco;

        public EnderecoController(IEndereco endereco)
        {
            _endereco = endereco;
        }

        [HttpGet("busca/{cep}")]
        public async Task<ActionResult> BuscarEndercoPorCep([FromRoute] string cep){


            
            var response  = await _endereco.BuscarEnderecoPorCep(cep);

            if(response.CodigoHttp == HttpStatusCode.OK){


                return Ok(response.DadosRetorno);

            } else {

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);


            }

        }
    }


}