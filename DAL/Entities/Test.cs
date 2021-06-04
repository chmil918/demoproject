using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        public string Result { get; set; }
        [Required]
        public int ReagentId { get; set; }
        [Required]
        public int WorkerId { get; set; }

        public virtual Reagent Reagent { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
