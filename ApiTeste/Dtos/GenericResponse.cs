using System.Dynamic;
using System.Net;

namespace NETAPLICATIONS.Dtos
{
    public class GenericResponse<T> where T : class{

                    //retorno das aquisições
                public HttpStatusCode CodigoHttp {get; set;}
                
                public T? DadosRetorno {get; set;}

                    //RETORNAR ERRO CONFORME A API EXTERNA
                public ExpandoObject? ErroRetorno{get; set;}

    }
}