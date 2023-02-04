using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Company : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
