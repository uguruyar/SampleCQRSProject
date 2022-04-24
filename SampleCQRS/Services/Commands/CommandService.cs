using SampleCQRS.Models;

namespace SampleCQRS.Services.Commands;

public class CommandService : ICommandService
{
    private readonly SampleCQRSContext _context;

    public CommandService(SampleCQRSContext context)
    {
        _context = context ?? throw  new ArgumentOutOfRangeException(nameof(context));
    }

    public async Task<Post> SavePost(string title, string content)
    {
        var post = new Post() {Title = title, Content = content};
        await _context.Posts.AddAsync(post);
        await _context.SaveChangesAsync();
        return post;
    }
}