using NETAPLICATIONS.Dtos;
using AutoMapper;
using NETAPLICATIONS.Models;

namespace AutoMapper
{
    public class EnderecoMapping : Profile{

        public EnderecoMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<EnderecoDTO, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoDTO>();

            
        }




    }
}