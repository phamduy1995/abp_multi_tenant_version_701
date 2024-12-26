using AutoMapper;
using projectName.Books;
using projectName.Entities.Books;

namespace projectName;

public class projectNameApplicationAutoMapperProfile : Profile
{
    public projectNameApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
