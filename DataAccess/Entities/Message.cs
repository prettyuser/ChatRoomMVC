using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    [Table("Message")]
    public class Message : Entity<int>
    {
        [Required]
        [MaxLength(1000)]
        public string MessageText {get; set;}

        public DateTime DateTimeMessage { get; set; }

        [Required]
        [Display(Name="User")]
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
