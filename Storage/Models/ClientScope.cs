using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Storage.Models
{
    public class ClientScope
    {
        public string Name { get; set; }
        public bool Required { get; set; }
    }
}
