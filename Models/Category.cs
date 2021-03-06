﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace AoqibaoStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Please enter a category name")]
        public string name { get; set; }
        [Display(Name = "Status")]
        public int status { get; set; }

        [Display(Name = "Create Date")]
        public DateTime createDate { get; set; }

        [Display(Name = "Category Image")]
        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }

    }

    public class CategoryDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}