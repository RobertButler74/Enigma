using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Reflector
    {

        public string left;
        public string right;
        public string type;

        public Reflector(string _type, string wiring)
        {
            this.right = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.left = wiring;
            this.type = _type;
        }

        public string Reflect(string signal)
        {
            int letterNum;
            letterNum = this.right.IndexOf(signal);
            signal = this.left.Substring(letterNum, 1);

            return signal;
        }

    }
}
