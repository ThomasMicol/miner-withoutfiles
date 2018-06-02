using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Descriptor
    {
        protected string Name;
        protected string Description;

        public void SetName(string name) { Name = name; }
        public void SetDescription(string description) { Description = description; }
        public string GetName() { return Name; }
        public string GetDescription() { return Description; }
    }
}
