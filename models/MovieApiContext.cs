using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class MovieApiContext : DbContext
    {
        public MovieApiContext(DbContextOptions<MovieApiContext> options)
            : base(options)
        {
        }
    }
}