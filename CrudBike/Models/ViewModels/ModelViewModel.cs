using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CrudBike.Models.ViewModels
{
    public class ModelViewModel
    {
       public Model Model { get; set; }

     //   public Model Make { get; set; }

        public IEnumerable<Make> Makes { get; set; }
    }
}
