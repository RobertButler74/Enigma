using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Plugboard
    {

        private string left;
        private string right;

        public Plugboard(string[] pairs)
        {
            this.left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.right = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string plug;
            string plugInverted;

            for (int i = 1; i <= pairs.Length - 1; i++)
            {
                if (pairs[i] == null || pairs[i] == "")
                {
                    break;
                }
                else
                {    
                    plug = pairs[i];
                    plugInverted = plug.Substring(1, 1) + plug.Substring(0, 1);
                    this.left = this.left.Replace(plug, plugInverted);                    
                }
            }
        }
        public string Forward(string signal)
        {
            int letterNum;
            letterNum = this.right.IndexOf(signal);
            signal = this.left.Substring(letterNum, 1);

            return signal;
        }
        public string Backward(string signal)
        {
            int letterNum;
            letterNum = this.left.IndexOf(signal);
            signal = this.right.Substring(letterNum, 1);

            return signal;
        }

    }
}
