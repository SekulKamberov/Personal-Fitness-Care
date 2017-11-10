namespace PersonalFitnessCare.Server.Common.Mapping
{
    using AutoMapper.Configuration;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}