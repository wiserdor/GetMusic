using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetMusic.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "User Name: ")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(150, MinimumLength = 3)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        public string UserType { get; set; }
        public IEnumerable<Album> Purchases { get; set; }

    }
}