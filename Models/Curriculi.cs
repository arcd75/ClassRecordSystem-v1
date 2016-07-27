using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecordSystem.Models
{
    public class Curriculi
    {
        [Key]
        public int Course { get; set; }

        public int Subject { get; set; }
    }
}
