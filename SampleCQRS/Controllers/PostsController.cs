using Microsoft.AspNetCore.Mvc;
using SampleCQRS.DTOs;
using SampleCQRS.Models;
using SampleCQRS.Services.Commands;
using SampleCQRS.Services.Queries;

namespace SampleCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IQueriesService _queries;
        private readonly ICommandService _command;

        public PostsController(IQueriesService queries, ICommandService command)
        {
            _queries = queries ?? throw new ArgumentNullException(nameof(queries));
            _command = command ?? throw new ArgumentNullException(nameof(command));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> Get()
        {
            return (await _queries.GetAllPosts()).ToList();
        }
        
        [HttpPost]
        public void SavePost([FromBody] SavePostDto savePost)
        {
            _command.SavePost(savePost.Title, savePost.Content);
        }
    }
}
