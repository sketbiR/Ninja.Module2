using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

//aading commitdd

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            // InsertNinja();
            //InsertMultipleNinjas();
            SimpleNinjaQueries();
            Console.ReadKey();
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "Raed Ninja",
                ServedInOniwabanValue = 0,
                DateOfBirth = new System.DateTime(1970, 1, 1),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }

        }

        private static void InsertMultipleNinjas()
        {
            var ninja1 = new Ninja
            {
                Name = "Buthaina Ninja",
                ServedInOniwabanValue =1,
                DateOfBirth = new System.DateTime(1970, 1, 1),
                ClanId = 1
            };
            var ninja2 = new Ninja
            {
                Name = "Yasser Ninja",
                ServedInOniwabanValue = 0,
                DateOfBirth = new System.DateTime(1970, 1, 1),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja>{ ninja1,ninja2});
                context.SaveChanges();
            }

        }

        private static void SimpleNinjaQueries()
        {
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninjas = context.Ninjas.Where(n => n.Name.Contains("Shamma"));
                foreach (var ninja in ninjas)
                {
                    Console.WriteLine(ninja.Name);
                }
                //var query = context.Ninjas;
            }

        }

        //ublic class



    }
}
