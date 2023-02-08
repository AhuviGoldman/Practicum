using Project.Common.DTOs;
using Project.Repositories.Entities;

namespace Project.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Person, PersonDTO>().ReversMap();
            CreateMap<Child, ChildDTO>().ReversMap();
        }
    }
}