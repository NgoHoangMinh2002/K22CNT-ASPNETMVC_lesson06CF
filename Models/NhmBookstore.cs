using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NhmLesson06CF.Models
{
    public class NhmBookstore : DbContext
    {
        public NhmBookstore():base("NhmBookStoreConnectionString") {}
    //khai bai cac thuoc tinh tuong ung voi cac bang trong csdl
    public DbSet<NhmCategory> NhmCategories { get; set; }
    public DbSet<NhmBook> NhmBooks { get; set; }

    }
}