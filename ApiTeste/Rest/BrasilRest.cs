using System.Dynamic;
using System.Text.Json;
using NETAPLICATIONS.Dtos;
using NETAPLICATIONS.Interfaces;
using NETAPLICATIONS.Models;

namespace NETAPLICATIONS.Rest
{
    public class BrasilRest : IBrasilApi
    {

         public async Task<GenericResponse<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {

             // defini uma variavel para receber o tipo de aquisição               
           var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
           // defini uma variavel para receber a instancia da classe GenericResponse do tipo EnderecoModel
           var response = new GenericResponse<EnderecoModel>();
           // esse using cria uma instancia  HttpClient para enviar soliciação Http para a API Brasil 
           using (var client = new HttpClient()){

                //defini uma variavel para receber o envio da requisião Http da request para a responseBrasilApi
                var responseBrasilApi = await client.SendAsync(request);
                // definindo uma variavel que vai receber responseBrasilApi que e lida como string transformada para texto
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                // o contentResp  e desserializado para um objeto do tipo EnderecoModel e armazenado no objResponse
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                // IsSuccessStatusCode verifica se foi bem sucedido com base no Http retornado
                if(responseBrasilApi.IsSuccessStatusCode){

                    // o status do http retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;

                    //a resposta dos dados Http que foram desserializados no objResponse retornam para DadosRetorno
                    response.DadosRetorno = objResponse;

                } else {


                    // retorna o status http para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                  
                    //Desserialização em um objeto ExpandObject  e armazenado no ErroRetorno
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }

        
           }
          // Retorna o resultado do método
           return response;
        }
        public async Task<GenericResponse<BancoModel>> BuscarBanco(string codigoBanco)
        {

             var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
           // defini uma variavel para receber a instancia da classe GenericResponse do tipo EnderecoModel
           var response = new GenericResponse<BancoModel>();
           // esse using cria uma instancia  HttpClient para enviar soliciação Http para a API Brasil 
           using (var client = new HttpClient()){

                //defini uma variavel para receber o envio da requisião Http da request para a responseBrasilApi
                var responseBrasilApi = await client.SendAsync(request);
                // definindo uma variavel que vai receber responseBrasilApi que e lida como string transformada para texto
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                // o contentResp  e desserializado para um objeto do tipo EnderecoModel e armazenado no objResponse
                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                // IsSuccessStatusCode verifica se foi bem sucedido com base no Http retornado
                if(responseBrasilApi.IsSuccessStatusCode){

                    // o status do http retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;

                    //a resposta dos dados Http que foram desserializados no objResponse retornam para DadosRetorno
                    response.DadosRetorno = objResponse;

                } else {


                    // retorna o status http para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                  
                    //Desserialização em um objeto ExpandObject  e armazenado no ErroRetorno
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }

        
           }
          // Retorna o resultado do método
           return response;
               
                
        }


        public async Task<GenericResponse<List<BancoModel>>> BuscarTodosBancos()
        {       
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
                 // defini uma variavel para receber a instancia da classe GenericResponse do tipo EnderecoModel
                 var response = new GenericResponse<List<BancoModel>>();
                // esse using cria uma instancia  HttpClient para enviar soliciação Http para a API Brasil 
                using (var client = new HttpClient()){

                //defini uma variavel para receber o envio da requisião Http da request para a responseBrasilApi
                var responseBrasilApi = await client.SendAsync(request);
                // definindo uma variavel que vai receber responseBrasilApi que e lida como stringe transformada para texto
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                // o contentResp  e desserializado para um objeto do tipo EnderecoModel e armazenado no objResponse
                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                // IsSuccessStatusCode verifica se foi bem sucedido com base no Http retornado
                if(responseBrasilApi.IsSuccessStatusCode){

                    // o status do http retorna para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;

                    //a resposta dos dados Http que foram desserializados no objResponse retornam para DadosRetorno
                    response.DadosRetorno = objResponse;

                } else {


                    // retorna o status http para CodigoHttp
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                  
                    //Desserialização em um objeto ExpandObject  e armazenado no ErroRetorno
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }

        
           }
          // Retorna o resultado do método
           return response;

            



            
        }
    }

}