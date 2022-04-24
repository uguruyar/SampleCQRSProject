using Microsoft.EntityFrameworkCore;
using SampleCQRS.Models;

namespace SampleCQRS.Services.Queries;

public class QueriesService : IQueriesService
{
    private readonly SampleCQRSContext _context;

    public QueriesService(SampleCQRSContext context)
    {
        _context = context ?? throw  new ArgumentOutOfRangeException(nameof(context));
    }

    public async Task<IEnumerable<Post>> GetAllPosts()
    {
        return await _context.Posts.ToListAsync();
    }
}