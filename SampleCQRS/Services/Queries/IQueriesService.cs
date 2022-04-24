using SampleCQRS.Models;

namespace SampleCQRS.Services.Queries;

public interface IQueriesService
{
    Task<IEnumerable<Post>> GetAllPosts();
}