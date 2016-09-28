using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.Data.Entities
{
    [Table("Waiters")]
    public class Waiter
    {
        [Key]
        public int WaiterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ReleaseDate { get; set; } // Can be NULL

        // Navigation properties based on the navigation properties
        //   displayed in LinqPad
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
