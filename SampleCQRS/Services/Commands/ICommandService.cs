using SampleCQRS.Models;

namespace SampleCQRS.Services.Commands;

public interface ICommandService
{
    Task<Post> SavePost(string title, string content);
}