using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; } 
        public bool Status { get; set; }

        //public virtual ICollection<Rating> Ratings { get; set; }
        //public virtual ICollection<Reservation> Reservations { get; set; }
        //public virtual ICollection<Transaction> Transactions { get; set; }
        //public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
