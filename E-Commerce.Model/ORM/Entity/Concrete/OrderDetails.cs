using E_Commerce.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.ORM.Entity.Concrete
{
    public class OrderDetails:BaseEntity
    {
       
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity  { get; set; }
        public decimal Discount { get; set; }
        public Products Products { get; set; }
        public Orders Orders { get; set; }
        


    }
}
