using AutoMapper;
using MacierzEinsenhoweraDemo.Models.Api;
using MacierzEinsenhoweraDemo.Models.DbResults;
using MacierzEinsenhoweraDemo.Models.Entities;

namespace MacierzEinsenhoweraDemo.Configuration.AutoMapperConfiguration
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new TaskDbProfile());
                cfg.AddProfile(new MatrixDbProfile());
            });
        }
    }

    public class TaskDbProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<MatrixTask, QuarterItem>()
                .ForMember(dest => dest.QuarterItemID, opt => opt.MapFrom(src => src.MatrixTaskID));
        }
    }

    public class MatrixDbProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<QuarterItem, MatrixQuarter>()
                .ForMember(dest => dest.MatrixQuarterID, opt => opt.MapFrom(src => src.QuarterItemID));
            
            Mapper.CreateMap<TasksDb, MatrixTasksResponse>();
        }
    }
}