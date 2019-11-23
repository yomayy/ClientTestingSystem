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
    [KnownType(typeof(Question))]
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Text { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual Question Question { get; set; }
    }
}