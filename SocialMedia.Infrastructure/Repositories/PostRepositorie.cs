using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepositorie
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                UserId = x * 2,
                PostDescription = $"Description {x}",
                Date = DateTime.Now,
                PostImage = $"https://misapis.com/{x}"
            });

            return posts;
        }
    }
}
