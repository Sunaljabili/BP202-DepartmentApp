using DepartmentTask.Data;
using DepartmentTask.Data.Entities;
using DepartmentTask.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DepartmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            PostService postServices = new PostService();
            AppDbContext dbContext = new AppDbContext();

            //Add
            //postServices.AddPost("25Aprel", "Frontend Bashlayir");
            //postServices.AddPost("24Aprel", "Backend Bitdi");
            //postServices.AddPost("30Iyun", "Layihe Bitdi");
            //postServices.EditPostTitle(1, "Salam Dostlar");
            //Console.WriteLine(postServices.GetPostById(9).Content); 
            //foreach (var item in postServices.GetAllPosts())
            //{
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine(item.Content);
            //}
            //postServices.DeletePostId(2);
        }
    }
}
