using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MurachMVCBookstore.Models.DomainModels;

namespace MurachMVCBookstore.Models.DataLayer.SeedData
{
    internal class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = "novel", Name = "Novel" },
                new Genre { GenreId = "memoir", Name = "Memoir" },
                new Genre { GenreId = "mystery", Name = "Mystery" },
                new Genre { GenreId = "scifi", Name = "Science Fiction" },
                new Genre { GenreId = "history", Name = "History" }
            );
        }
    }
}