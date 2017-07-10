using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TodoApp.DbModel
{
    public class UserPassword
    {
        [Required]
        public User User { get; set; }

        [Key]
        public int Id { get; set; }
        
        public string Password { get; set; }
    }
}
