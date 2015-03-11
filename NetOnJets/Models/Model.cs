using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOnJets.Models
{
    public class Model
    {
        public bool ModelSetup { get; set; }
        public string ModelName { get; set; }
        public bool RepositorySetup { get; set; }
        public ICollection<ModelAttribute> ModelAttributes { get; set; }
    }
}
