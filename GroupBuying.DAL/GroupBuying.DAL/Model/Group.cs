using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GroupBuying.DAL.Model
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Store { get; set; }
        [Required]
        public int Branch { get; set; }
        public User User { get; set; }
        public int Status { get; set; }
        public Item Item { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
