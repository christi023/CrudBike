using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudBike.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public string Name { get; set; }

        public Make Make { get; set; }

    //  [ForeignKey("Make")]

        public int MakeID { get; set; }
    }
}
