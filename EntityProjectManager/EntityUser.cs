using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityProjectManager
{
    [Table("EntityUser")]
    public class EntityUser
    {
        [Key]
        public int userId { get; set; }
        [StringLength(250)]
        public string firstName { get; set; }
        [StringLength(250)]
        public string lastName { get; set; }
        public int employeeId { get; set; }
    }
}
