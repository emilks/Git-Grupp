﻿namespace Git_Grupp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime CreatedDate { get; set; }

        //Det här är den ändringen jag gjort nu kl 09.30
        public float Rating { get; set; }

    }
}
