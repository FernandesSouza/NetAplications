using NETAPLICATIONS.Dtos;


namespace NETAPLICATIONS.Interfaces
{
    public interface IEndereco{

          Task<GenericResponse<EnderecoDTO>> BuscarEnderecoPorCep(string cep);

          

    }
    
}


