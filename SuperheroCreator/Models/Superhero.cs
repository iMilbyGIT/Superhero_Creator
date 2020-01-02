using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroCreator.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        public string heroName { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchphrase { get; set; }
    }
}