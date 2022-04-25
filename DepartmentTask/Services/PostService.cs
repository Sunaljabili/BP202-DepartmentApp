using DepartmentTask.Data;
using DepartmentTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentTask.Services
{
   public   class PostService
    {
        AppDbContext DbContext = new AppDbContext();

        public void AddPost(string title,string content)
        {
            Post post = new Post()
            {
                Title = title,
                Content = content
            };
            DbContext.Posts.Add(post);
            DbContext.SaveChanges();
        }

        public void EditPostTitle(int id, string title)
        {
            var post = DbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
            post.Title = title;
            DbContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return DbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Post> GetAllPosts()
        {
            return DbContext.Posts.ToList();
        }

        public void DeletePostId(int id)
        {
            var post = DbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
            DbContext.Posts.Remove(post);
            DbContext.SaveChanges();
        }
    }
}
