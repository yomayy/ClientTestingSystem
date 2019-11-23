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
    [KnownType(typeof(Test))]
    [KnownType(typeof(List<Answer>))]
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Text { get; set; }

        [Required]
        public int TestId { get; set; }

        [JsonIgnore]
        public virtual Test Test { get; set; }

        [JsonIgnore]
        public virtual List<Answer> Answers { get; set; }
    }
}