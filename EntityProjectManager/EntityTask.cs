using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityProjectManager
{
    [Table("EntityTask")]
    public class EntityTask
    {
        [Key]
        public int taskId { get; set; }
        [StringLength(250)]
        public string task { get; set; }
        public int priority { get; set; }
        public EntityParentTask parentTask { get; set; }
        public EntityUser user { get; set; }
        public EntityProject project { get; set; }
        public bool isCompleted { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
