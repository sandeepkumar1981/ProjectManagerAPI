using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityProjectManager
{
    [Table("EntityParentTask")]
    public class EntityParentTask
    {
        [Key]
        public int id { get; set; }

        [StringLength(250)]
        public string parentTaskName { get; set; }
    }
}
