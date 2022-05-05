using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_System.models
{
    class Detail
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
    }
}
