using AutoMapper;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Automapper
{
    public class TestMapper : Profile
    {
        public TestMapper()
        {
            CreateMap<Test, TestDTO>()
                .ForMember(dest => dest.ReagentName, opt => opt.MapFrom(
                    src => src.Reagent.Name))
                .ForMember(dest => dest.WorkerName, opt => opt.MapFrom(
                    src => src.Worker.Name))
                .ReverseMap();
        }
    }
}
