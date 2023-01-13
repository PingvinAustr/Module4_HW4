﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Module4_HW4
{
    public class Starter
    {
        public static void Run()
        {
            ConfigController.ValidateConfig();
            var optionsBuilder =
                new DbContextOptionsBuilder<DatabaseContext>();
            var options = optionsBuilder.Options;
            using (DatabaseContext db = new DatabaseContext(options))
            {
               db.SaveChanges();
               Console.WriteLine("DB creation operation has been performed," +
                   "please check your SQL server");
            }
        }
    }
}
