using NETAPLICATIONS.Dtos;
using NETAPLICATIONS.Models;

namespace AutoMapper
{
    public class BancoMapping: Profile{

        public BancoMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<BancoDTO, BancoModel>();
            CreateMap<BancoModel, BancoDTO>();

        }




    }
}