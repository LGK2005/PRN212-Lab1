using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            CategoryId = id;
            CategoryName = name;
        }
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}
