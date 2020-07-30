using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWepApplication.Models
{
    public class Movie
    {
        int id;
        string name;
        float duration;
        public Movie() { }
        public Movie(int id,string name, float duration)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Duration { get => duration; set => duration = value; }
    }
}