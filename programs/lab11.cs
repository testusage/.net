using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Prac
{
    public class Post
    {
        public int Id {get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BlogDbContext())
            {
                Console.Write("Enter title for the post:");
                var title = Console.ReadLine();
                var post_title = new Post()
                {
                    Id = 11,
                    DatePublished = DateTime.Now,
                    Title = title,
                    Body = "Body"
                };
                ctx.Posts.Add(post_title);
                ctx.SaveChanges();

                //fetching
                var query = from b in ctx.Posts select b;
                Console.WriteLine("All titles in the Posts table are:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }
    }
}
