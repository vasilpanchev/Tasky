using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public required string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey(nameof(User))]
        public int Username { get; set; }
        public required virtual User User { get; set; }

    }
}
