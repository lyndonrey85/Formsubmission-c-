using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formsubmission.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        public string firstName { get; set; }

        [Required]
        [MinLength(4)]
        public string lastName { get; set; }

        [Required]
        [Range(1,110)]
        public int age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
     public abstract class BaseEntity
    {

    }
}