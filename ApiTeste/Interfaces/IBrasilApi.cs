using NETAPLICATIONS.Dtos;
using NETAPLICATIONS.Models;

namespace NETAPLICATIONS.Interfaces
{
    public interface IBrasilApi{


        Task<GenericResponse<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<GenericResponse<List<BancoModel>>> BuscarTodosBancos();
        Task<GenericResponse<BancoModel>> BuscarBanco(string codigoBanco);

        


    }
}