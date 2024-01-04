// In the AppConfig file, enter the connection string, to establish the connection to required database
// (for the data source, give the server name of your computer). Data source and initial catalog are 
// your server name and database respectively, so change them as per your system config and the db 
// name that you created.
//  <connectionStrings>
// <add name="BlogDbContext" connectionString="data source= DESKTOP1NDC7IR; initial catalog=UNIVERSITY_ONE;integrated security=SSPI"
// providerName="System.Data.SqlClient"/>
 
// </connectionStrings>
// enable-migrations
// add-migration CreatePost
// update-database


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
