using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<Test> Tests { get; set; }
    }
}
