using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecordSystem.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Access { get; set; }
    }
}
