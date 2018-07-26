using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteAboutGazells.Shared.Models
{
    public class Gazelle
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public Gazelle() { }
        public Gazelle(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
