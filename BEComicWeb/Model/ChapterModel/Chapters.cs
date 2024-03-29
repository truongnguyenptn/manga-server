﻿using System.ComponentModel.DataAnnotations;

namespace BEComicWeb.Model.ChapterModel
{
    public class Chapters
    {
        [Key]
        public string? Id { get; set; }
        public string StoryId { get; set; }
        public int? ChapterNumber { get; set; }
        public string? Name { get; set; }
        public int? Cost { get; set; }
        public string? Image { get; set; }
        public int? Views { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public Chapters()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
