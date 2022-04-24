using Microsoft.EntityFrameworkCore;

namespace SampleCQRS.Models;

public class SampleCQRSContext : DbContext
{
    public SampleCQRSContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Post>().HasData(
            new Post() {Id = 5, Title = "Episode 9", Content = "The Rise of Skywalker"},
            new Post() {Id = 2, Title = "Episode 2", Content = "Attack of the Clones"},
            new Post() {Id = 3, Title = "Episode 3", Content = "Revenge of the Sith"},
            new Post() {Id = 4, Title = "Episode 4", Content = "A New Hope"},
            new Post() {Id = 5, Title = "Episode 5", Content = "The Empire Strikes Back"},
            new Post() {Id = 6, Title = "Episode 6", Content = "Revenge of the Sith"},
            new Post() {Id = 7, Title = "Episode 7", Content = "The Force Awakens"},
            new Post() {Id = 8, Title = "Episode 8", Content = "The Last Jedi"},
            new Post() {Id = 9, Title = "Episode 9", Content = "The Rise of Skywalker"}
            );
    }

    public DbSet<Post> Posts { get; set; }
}