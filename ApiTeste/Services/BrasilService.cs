using AutoMapper;
using NETAPLICATIONS.Dtos;
using NETAPLICATIONS.Interfaces;
using NETAPLICATIONS.Models;

namespace NETAPLICATIONS.Services
{
    public class BrasilService : IBanco 
    {   
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasil;

        public BrasilService(IMapper mapper, IBrasilApi brasil)
        {
            _mapper = mapper;
            _brasil = brasil;
        }

        public async Task<GenericResponse<BancoDTO>> BuscarBanco(string codigoBanco)
        {
           var banco = await _brasil.BuscarBanco(codigoBanco);

           return _mapper.Map<GenericResponse<BancoDTO>>(banco);
        }

            public async Task<GenericResponse<List<BancoDTO>>> BuscarTodosBancos()
            {

                var bancos = await _brasil.BuscarTodosBancos();

                return _mapper.Map<GenericResponse<List<BancoDTO>>>(bancos);


                
            
            }
    }
}