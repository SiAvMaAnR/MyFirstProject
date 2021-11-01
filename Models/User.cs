using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*Incorrect name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Incorrect age")]
        public uint Age { get; set; }
    }
}
