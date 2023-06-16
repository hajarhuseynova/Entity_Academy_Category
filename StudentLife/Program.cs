
using Microsoft.EntityFrameworkCore;
using StudentLife.Context;
using StudentLife.Models;

Console.WriteLine();


StudentLifeDbContext StudentLifeDbContext =new StudentLifeDbContext();

CreateAcademy();
   
void CreateCategory()
{
    Console.WriteLine("enter name:");
    StudentLifeDbContext.Add(new Category
    {
        Name =Console.ReadLine()
    });
    StudentLifeDbContext.SaveChanges();
}

void CreateAcademy()
{
    Category category = StudentLifeDbContext.Categories.Find(4);
    if(category == null)
    {
        Console.WriteLine("wrong");
        return;
    }

    Academy Academy=new Academy{
        Name =Console.ReadLine(),
        Address = Console.ReadLine(),
       Category=category
    };
    StudentLifeDbContext.Add(Academy);
    StudentLifeDbContext.SaveChanges();
}

void GetAllAcademy()
{
    List<Academy> academies=StudentLifeDbContext.Academy.Include(x=>x.Category).ToList();
}