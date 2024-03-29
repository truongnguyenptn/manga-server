﻿using System.ComponentModel.DataAnnotations;

namespace BEComicWeb.Model.StoryModel
{
    public class Categories
    {
        [Key]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set;}
        public Categories()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
