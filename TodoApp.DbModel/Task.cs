using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core;

namespace TodoApp.DbModel
{
    public class Task
    {
        public Task Parent { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public StatusOfTask TaskStatus { get; set; }
    }
}
