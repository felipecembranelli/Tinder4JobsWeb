using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tinder4Jobs.Data;
using Tinder4Jobs.DTO;
using Tinder4Jobs.Model;

namespace Tinder4Jobs.Web.Mappings
{
    public class DtoToDomainModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToDomainModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LinkedinCompanyDTO, LinkedinCompany>().ForMember(x => x.Id, opt => opt.Ignore())
                                                            .ForMember(x => x.CompanyId, opt => opt.MapFrom(source => source.Id))
                                                           .ForMember(x => x.Name, opt => opt.MapFrom(source=>source.Name));

            Mapper.CreateMap<LinkedinJobPosterDTO, LinkedinJobPoster>().ForMember(x => x.Id, opt => opt.Ignore())
                                                            .ForMember(x => x.JobPosterId, opt => opt.MapFrom(source => source.Id))         // problema está aqui
                                                           .ForMember(x => x.FirstName, opt => opt.MapFrom(source => source.FirstName))
                                                           .ForMember(x => x.LastName, opt => opt.MapFrom(source => source.LastName));

            Mapper.CreateMap<LinkedinJobDTO, LinkedinJob>().ForMember(x => x.Id, opt => opt.Ignore())
                                                            .ForMember(x => x.JobPosterId, opt => opt.Ignore())
                                                            .ForMember(x => x.CompanyId, opt => opt.Ignore())
                                                            .ForMember(x => x.JobId, opt => opt.MapFrom(source => source.Id))
                                                           .ForMember(x => x.LinkedinCompany, opt => opt.MapFrom(
                                                                                            source => new LinkedinCompanyDTO
                                                                                            {
                                                                                                Id = source.Company.Id,
                                                                                                Name = source.Company.Name,
                                                                                            }))
                                                            .ForMember(x => x.DescriptionSnippet, opt => opt.MapFrom(source => source.DescriptionSnippet))
                                                            .ForMember(x => x.LinkedinJobPoster, opt => opt.MapFrom(
                                                                source => new LinkedinJobPosterDTO
                                                                {
                                                                    Id = source.JobPoster.Id,                   // problema está aqui
                                                                    FirstName = source.JobPoster.FirstName,
                                                                    LastName = source.JobPoster.LastName
                                                                }))
                                                            .ForMember(x => x.LocationDescription, opt => opt.MapFrom(source => source.LocationDescription))
                                                           ;

        }
    }
}