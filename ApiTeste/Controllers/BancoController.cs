using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using NETAPLICATIONS.Interfaces;

namespace NETAPLICATIONS.Controllers{


[ApiController]
[Route("api/v1/[controller]")]
public class BancoController : ControllerBase
{
    private readonly IBanco _ibanco;

        public BancoController(IBanco ibanco)
        {
            _ibanco = ibanco;
        }

     [HttpGet("busca/todos")]
     public async Task<IActionResult> BuscarTodos(){


            var response = await _ibanco.BuscarTodosBancos();
            

             if(response.CodigoHttp == HttpStatusCode.OK){


                return Ok(response.DadosRetorno);

            } else {

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);


            }

        }



        [HttpGet("busca/codigo")]
        public async Task<IActionResult> BuscarBanco([RegularExpression("^[0-9]*$")]string codigoBanco){

            var response = await _ibanco.BuscarBanco(codigoBanco);
             if(response.CodigoHttp == HttpStatusCode.OK){


                return Ok(response.DadosRetorno);

            } else {

                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);


            }




        }



    



}


}