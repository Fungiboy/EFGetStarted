using System;
using System.Linq;
using EFGetStarted;
using Microsoft.EntityFrameworkCore;

BloggingContext db = new();

db.Users.ExecuteDelete();
db.Posts.ExecuteDelete();
db.Blogs.ExecuteDelete();

db.Users.Add(new User { Name = "Foo" });
db.SaveChanges();

db.Blogs.Add(new Blog { Title = "How2Minecraft" });
db.Blogs.Add(new Blog { Title = "HowNOT2Minecraft" });
db.SaveChanges();

Blog blog = db.Blogs.Where(b => b.Title == "HowNOT2Minecraft").First();

db.Users.First().Posts.Add(new Post { Name = "MaybeMinecraft_tutorial", Content = "Maybe Some basic minecraft", Blog = blog });
db.Users.First().Posts.Add(new Post { Name = "NOTMinecraft_tutorial", Content = "NOT Some basic minecraft", Blog = blog });
db.Users.First().Posts.Add(new Post { Name = "Minecraft_tutorial", Content = "Some basic minecraft", Blog = blog});

db.SaveChanges();

Console.WriteLine(db.Posts.First().User.Posts.First().Blog.Posts.First().Name);