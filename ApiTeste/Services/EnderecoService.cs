using AutoMapper;
using NETAPLICATIONS.Dtos;
using NETAPLICATIONS.Interfaces;

namespace NETAPLICATIONS.Services
{
    public class EnderecoService : IEndereco
    {
        private readonly IMapper? _mapper;
        private readonly IBrasilApi? _brasilApi;

        public EnderecoService(IMapper? mapper, IBrasilApi? brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<GenericResponse<EnderecoDTO>> BuscarEnderecoPorCep(string cep)
        {
            var endereco = await _brasilApi!.BuscarEnderecoPorCep(cep);
            return  _mapper!.Map<GenericResponse<EnderecoDTO>>(endereco);    
        }
    }
}