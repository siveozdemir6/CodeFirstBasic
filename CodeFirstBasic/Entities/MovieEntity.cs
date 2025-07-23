﻿namespace CodeFirstBasic.Entities
{
    public class MovieEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Genre { get; set; }

        public int ReleaseYear { get; set; }
    }
}
