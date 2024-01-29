using Domain.Models;
namespace Infrastructure.Services;

public class PostServecis
{
         List<Post> posts = new List<Post>();

    public List<Post> GetPost ()
    {
        return posts;
    }
    public void AddPost(Post post)
    {
          posts.Add(post);
    }
    public void UpdatePost(Post post)
    {
           foreach (var s in posts)
        {
            if(s.Id == post.Id)
            {
                s.Title = post.Title;
                s.Description = post.Description;
                s.Fee = post.Fee;
            }            
        }
    }
    public void Delete(int id)
    {
        foreach (var s in posts)
        {
            if(s.Id == id)
            {
                posts.Remove(s);
            }
        }   
    }
}
