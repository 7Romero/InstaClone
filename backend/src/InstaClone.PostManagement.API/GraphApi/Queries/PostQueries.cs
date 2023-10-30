using HotChocolate.Authorization;
using InstaClone.PostManagement.Core.Domain;

namespace InstaClone.PostManagement.API.GraphApi.Queries;

[Authorize]
[ExtendObjectType("Query")]
public class PostQueries
{
    public List<Post> GetPosts()
    {
        var posts = new List<Post>();

        return posts;
    }
}
