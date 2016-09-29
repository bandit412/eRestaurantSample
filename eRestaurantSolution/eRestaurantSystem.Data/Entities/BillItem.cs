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
    [Table("BillItems")]
    public class BillItem
    {
        [Key]
        [Column(Order = 1)]
        public int BillID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }

        // Naviagtion Properties
        public virtual Bill Bills { get; set; }
        public virtual Item Items { get; set; }
    }
}
