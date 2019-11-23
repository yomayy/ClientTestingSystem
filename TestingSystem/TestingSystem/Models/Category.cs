using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TestingSystem.Models
{
    [Serializable]
    [KnownType(typeof(List<Test>))]
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual List<Test> Tests { get; set; }
    }
}