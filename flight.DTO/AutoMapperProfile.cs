using flight.DAL.Models;
//using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace flight.DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<FlightDTO, Flight>();
            CreateMap<Flight, FlightDTO>();
        }

    }
}

