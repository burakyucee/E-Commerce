
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
    public class Categories:BaseEntity

    {
       

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string  Description { get; set; }
        public string Picture { get; set; }

        public  List<Products> Products { get; set; }

    }
}
