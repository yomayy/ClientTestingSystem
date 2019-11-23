using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestingSystem.Models
{
    [Serializable]
    [KnownType(typeof(Category))]
    [KnownType(typeof(List<Question>))]
    public class Test
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public int CategoryId { get; set; }

        //[JsonIgnore]
        public virtual Category Category { get; set; }

        //[JsonIgnore]
        public virtual List<Question> Questions { get; set; }
    }
}