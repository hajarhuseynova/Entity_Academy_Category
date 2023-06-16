using Microsoft.EntityFrameworkCore;
using sample.Context;
using sample.Models;

sampleDb sampleDb=new sampleDb();


//getall

//List<Category> Categories = await sampleDb.Categories.ToListAsync();
//foreach(Category category in Categories)
//{
//    Console.WriteLine(category.Name);   
//    Console.WriteLine(category.Id);
//}

//endgetall

//get
//Category? category=await sampleDb.Categories.FirstOrDefaultAsync(x=>x.Id==2);
//if (category == null)
//{
//    Console.WriteLine("qaqa sehv var");
//}
//Console.WriteLine(category?.Name);
//endget

//remove
//int.TryParse(Console.ReadLine(), out int id);   
//Category? category = await sampleDb.Categories.FirstOrDefaultAsync(x => x.Id == id);

//if (category == null)
//{
//    Console.WriteLine("qaqa sehv var");
//}
//else
//{
//    sampleDb.Categories.Remove(category);

//    sampleDb.SaveChanges();
//}
//endremove

//create
//Console.WriteLine("enter data");
//string name=Console.ReadLine();
//Category category = new Category
//{
//    Name = name
//};
//sampleDb.Categories.Add(category);
//sampleDb.SaveChanges(); 
//endcreate

//update 
//Category category = sampleDb.Categories.Find(3);
//if (category != null)
//{
//    category.Name = "detushdi";
//    sampleDb.SaveChanges();
//}
//else
//{
//    Console.WriteLine("qaqa sehv");
//}
//endupdate

//tracking
//izlemir geriye query qaytararir iqueryable asnotracking ishledende
//IQueryable<Category> query=sampleDb.Categories.AsNoTracking();
//List<Category> Categories=query.ToList();
//foreach (Category category in Categories)
//{
//    Console.WriteLine(category.Name);   
//}   
//endtracking
//isdelete di false true olmaq sohbeti

//List<Category> Categories=sampleDb.Categories.
//    Where(x=>x.IsDeleted==false).
//    AsNoTracking().ToList();
//foreach (Category category in Categories)
//{
//    //wrong version
//    //if (!category.IsDeleted)
//    //{
//    //    Console.WriteLine(category.Name);
//    //}
//    Console.WriteLine(category.Name);
//}

//update asnotracking ishlenmir cunki databasede onu ishledende hecne deishdirmek olmu7r

//update metodu ile update edende asnotrackingin onemi yoxdu
Category Category = sampleDb.Categories.
AsNoTracking().FirstOrDefault(x => x.Id == 3);

Category.Name = "hajar";
sampleDb.Categories.Update(Category);
sampleDb.SaveChanges();

//endUpdate

