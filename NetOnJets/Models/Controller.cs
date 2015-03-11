using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOnJets.Models
{
    public class Controller
    {
        public bool ControllerSetup { get; set; }
        public string Name { get; set; }
        public ICollection<ControllerView> Views { get; set; } 
    }
}
