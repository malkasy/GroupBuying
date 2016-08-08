using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GroupBuying.DAL.Models
{
    [Table("User")]
    public class User
    {
        #region Properties
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        #endregion

        #region relationships
        //[ForeignKey("JobID")]
        //public virtual Job Job { get; set; }


        //public virtual IEnumerable<Experiance> Experiances { get; set; }
        #endregion
    }
}
