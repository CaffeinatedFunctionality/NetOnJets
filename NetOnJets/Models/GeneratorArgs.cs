using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerArgs;

namespace NetOnJets.Models
{
    public class GeneratorArgs
    {
        [ArgDescription("Controller Name")]
        [ArgShortcut("-c"), ArgShortcut("-controller")]
        public string ControllerName { get; set; }

        [ArgDescription("Model Name")]
        [ArgShortcut("-m"), ArgShortcut("-model")]
        public string ModelName { get; set; }
        
        [ArgDescription("Defines Views")]
        [ArgShortcut("-v")]
        public string[] Views { get; set; }
        
        [ArgDescription("Defines Attributes")]
        [ArgShortcut("-a")]
        public string[] Attributes { get; set; }
    }
}
