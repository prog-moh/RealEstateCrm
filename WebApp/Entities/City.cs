﻿namespace WebApp.Entities
{
    public class City
    {
        public int Id { get; set; }

        public string  Name  { get; set; }

        public virtual District  Districts { get; set; }
    }
}