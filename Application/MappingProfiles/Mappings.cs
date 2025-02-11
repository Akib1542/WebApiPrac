﻿using Application.Models;
using AutoMapper;
using Domain;

namespace Application.MappingProfiles
{
    public class Mappings : Profile
    {
        public Mappings() 
        {
            CreateMap<NewGame, Game>();
            CreateMap<Game, GameDTO>();
        }
    }
}
