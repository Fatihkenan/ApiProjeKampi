using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.MessageDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;
using AutoMapper.Features;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping : Profile //auto mapperdan gelen bir sınıf
    {
        public GeneralMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap(); //Feature ile ResultFeatureDto maplensin ve tam terside maplensin
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMesaageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
        }
    }
}
