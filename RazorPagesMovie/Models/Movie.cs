﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;

    }
}
