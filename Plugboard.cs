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
            int pos_B;
            int pos_A;
            string B;
            string A;

            for (int i = 1; i <= pairs.Length - 1; i++)
            {
                if (pairs[i] == null)
                {
                    break;
                }
                else
                {
                    A = pairs[i].Substring(0, 1);
                    B = pairs[i].Substring(1, 1);
                    pos_A = this.left.IndexOf(A);
                    pos_B = this.left.IndexOf(B);

                    this.left = this.left.Substring(1, pos_A) + B + this.left.Substring(pos_A + 1 + 1, this.left.Length - pos_A + 1);
                    this.left = this.left.Substring(1, pos_B) + A + this.left.Substring(pos_B + 1 + 1, this.left.Length - pos_A + 1);
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
