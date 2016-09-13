using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBuying.DAL.Model
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Mail { get; set; }
        public bool IsAdmin { get; set; }
        [Required]
        public string CreditNumber { get; set; }
        [Required]
        public DateTime CreditExpiration { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
