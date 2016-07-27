using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecordSystem.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        public string Parameter { get; set; }
        public string Value { get; set; }
    }
}
