﻿using Microsoft.EntityFrameworkCore;
using FridgeServer.Models;
using System.Collections.Generic;

namespace FridgeServer.Data
{
    public class AppDbContext : DbContext
    {
        //Scoped constructor
        public AppDbContext(DbContextOptions<AppDbContext>  options) : base(options)
        {
        }



        //DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Grocery> userGroceries { get; set; }
        public DbSet<MoreInformation> moreInformations { get; set; }
        public DbSet<UserFriend> userFriends { get; set; }

    }//class
}
