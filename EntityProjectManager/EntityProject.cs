using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityProjectManager
{
    [Table("EntityProject")]
    public class EntityProject
    {
        [Key]
        public int projectId { get; set; }
        [StringLength(250)]
        public string projectName { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int priority { get; set; }

        public EntityUser manager { get; set; }
        public bool isCompleted { get; set; }
        public int numberofTasks { get; set; }
        public int completedTasks { get; set; }

    }
}
