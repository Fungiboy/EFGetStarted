using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace EFGetStarted;
public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    string _path = "blogging.db";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={_path}");
}

public class Post
{
    public int PostID { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }

    public int BlogID { get; set; }
    public Blog Blog { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}

public class Blog
{
    public int BlogID { get; set; }
    public string? Title { get; set; }

    public List<Post> Posts { get; } = new();
}

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public List<Post> Posts { get; } = new();
}

