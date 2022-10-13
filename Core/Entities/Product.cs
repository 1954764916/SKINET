using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Add-Migration InitialCreate  Entity Framework Core Tools/Design*/

namespace Core.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
