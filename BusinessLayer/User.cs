using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        [MinLength(3)]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public required string Username { get; set; }

        [Required]
        [MinLength(4)]
        public required string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<UserTask>? Tasks { get; set; }


    }
}
