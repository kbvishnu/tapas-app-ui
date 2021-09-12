using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAPAS.APP.UI.DataStore;
using TAPAS.APP.UI.Models;

namespace TAPAS.APP.UI.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDetails, UserDetailsViewModel>()
                .ForMember(dest =>
                dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest =>
                dest.TenantID, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest =>
                dest.IsApprovePermission, opt => opt.MapFrom(src => src.IsApprovePermission))
                .ForMember(dest =>
                dest.IsReportPermission, opt => opt.MapFrom(src => src.IsReportPermission))
                .ForMember(dest =>
                dest.IsSavePermission, opt => opt.MapFrom(src => src.IsSavePermission));
        }
        //.ForMember(dest =>
        //    dest.FName,
        //    opt => opt.MapFrom(src => src.FirstName))
        //.ForMember(dest =>
        //    dest.LName,
        //    opt => opt.MapFrom(src => src.LastName))
        //.ReverseMap();
    }
}
