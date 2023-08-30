using NETAPLICATIONS.Dtos;


namespace NETAPLICATIONS.Interfaces
{
    public interface IBanco{

        
        Task<GenericResponse<List<BancoDTO>>> BuscarTodosBancos();
        Task<GenericResponse<BancoDTO>> BuscarBanco(string codigoBanco);

        

    }
    
}


