using AutoMapper;
using Desafio_Rhitmo.Dto;
using Desafio_Rhitmo.Model;

namespace Desafio_Rhitmo.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CadastroCartaoDto, CadastroCartao>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
