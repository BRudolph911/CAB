using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRudolph_Sound_Manipulation.Classes
{
    public class Composite
    {
        public List<Wav> Layers { get; set; }

        public Composite()
        {
            Layers = new List<Wav>();
        }
    }
}