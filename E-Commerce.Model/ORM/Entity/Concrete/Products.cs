
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
    public class Products: BaseEntity
    {
      

        public int ProductID { get; set; }
        public string ProtuctName { get; set; }
        public int SupplierID { get; set; }

        
        public decimal QuantittyPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string UnitsInOrder { get; set; }

        public int RecorderLevel { get; set; }
        public string Discontinued { get; set; }

        public int CategoryID { get; set; }
        public  Categories Categories { get; set; }
        public Suppliers Suppliers { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }

}
