﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<WriterUser,WriterRole,int>
    {
        //veritabanımızla bağlantı kurarız
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3EQDEM4; database=NetCoreProjeDb; integrated security=true");

        }

        //veritabana yansıtılacak yerler
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
       
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Test1> Test1s { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }



    }
}
