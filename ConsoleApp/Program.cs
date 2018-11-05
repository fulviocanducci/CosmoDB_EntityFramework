using ConsoleApp.Database;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBCosmoContext db = new DBCosmoContext())
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();
                //
                var item = db.People.FirstOrDefault();
                item.Active = false;
                item.Name = item.Name.ToUpperInvariant();
                db.SaveChanges();
                //var p = new Models.People
                //{
                //    Name = "Hugo Leonardo Canducci Dias",
                //    Active = true,
                //    Created = DateTime.Parse("03/10/1980")
                //};
                //db.People.Add(p);
                //db.SaveChanges();
            }
            Console.WriteLine("Executado com sucesso");
        }
    }
}
