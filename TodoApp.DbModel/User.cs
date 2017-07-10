using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.DbModel
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
       
    }
}
