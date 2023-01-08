using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Module4_HW4.Models;

namespace Module4_HW4
{
    public class Starter
    {
        public static void Run()
        {
            ConfigController.ValidateConfig();
            var optionsBuilder =
                new DbContextOptionsBuilder<DatabaseContext>();
            var options = optionsBuilder
                    .UseSqlServer(
                    ConfigController.CurrentConfigs.ConnectionString)
                    .Options;

            using (DatabaseContext db = new DatabaseContext(options))
            {
               db.SaveChanges();
               Console.WriteLine("DB creation operation has been performed," +
                   "please check your SQL server");
            }
        }
    }
}
