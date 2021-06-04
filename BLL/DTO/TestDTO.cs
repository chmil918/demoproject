using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTO
{
    public class TestDTO
    {
        public int Id { get; set; }
        [Required]
        public string Result { get; set; }
        [Required]
        public string ReagentName { get; set; }
        [Required]
        public string WorkerName { get; set; }
    }
}
