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
    [Table("Tables")]
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        public int TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        // Navigation Properties
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
