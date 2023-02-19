using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Rotor
    {

        public string notch1;
        public string notch2;

        public string right;
        public string middle;
        public string left;

        public string type;

        public Rotor(string _type, string wiring, string notch1, string notch2 = "")
        {
            this.right = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.middle = wiring;
            this.left = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.notch1 = notch1;
            this.notch2 = notch2;
            this.type = _type;
        }
        public string Forward(string signal)
        {
            int letterNum;
            letterNum = this.right.IndexOf(signal);
            signal = this.middle.Substring(letterNum, 1);
            letterNum = this.left.IndexOf(signal);

            char chrSignal = Convert.ToChar(letterNum + 65);

            signal = chrSignal.ToString();

            return signal;
        }
        public string Backward(string signal)
        {
            int letterNum;
            char chrSignal = Convert.ToChar(signal);
            letterNum = Convert.ToInt32(chrSignal) - 65;
            signal = this.left[letterNum].ToString();
            letterNum = this.middle.IndexOf(signal);
            signal = this.right[letterNum].ToString();

            return signal;
        }
        public void Rotate(int n = 1, bool forward = true)
        {
            for (var i = 0; i <= n - 1; i++)
            {
                if (forward)
                {
                    this.right = this.right[25] + this.right.Substring(0, this.right.Length - 1);
                    this.left = this.left.Substring(1, this.left.Length - 1) + this.left[0];
                }
                else
                {
                    this.right = this.right.Substring(1, this.right.Length - 1) + this.right[0];

                    this.left = this.left[25] + this.left.Substring(0, this.left.Length - 1);
                }
            }
        }
        public void RotateToLetter(string letter)
        {
            int n;
            char chrLetter = Convert.ToChar(letter);
            n = Convert.ToInt32(chrLetter) - 65;

            this.Rotate(n);
        }

        public void SetRing(string key)
        {
            int keyNum = Convert.ToInt32(Convert.ToChar(key) - 65);

            string strOldWiring;
            char chrOldLetter;
            int intOldLetter;
            int intNewLetter;
            char chrNewLetter;

            if (keyNum != 0)
            {
                for (int h = 1; h <= keyNum; h++)
                {
                    strOldWiring = this.middle;
                    string strNewWiring = string.Empty;

                    for (int i = 0; i <= 25; i++)
                    {
                        if (i == 0)
                        {
                            chrOldLetter = Convert.ToChar(strOldWiring.Substring(25, 1));
                            intOldLetter = Convert.ToInt32(chrOldLetter);
                        }
                        else
                        {
                            chrOldLetter = Convert.ToChar(strOldWiring.Substring(i - 1, 1));
                            intOldLetter = Convert.ToInt32(chrOldLetter);
                        }

                        if (intOldLetter + 1 > 90)
                        {
                            intNewLetter = 65;
                        }
                        else
                        {
                            intNewLetter = intOldLetter + 1;
                        }

                        chrNewLetter = Convert.ToChar(intNewLetter);

                        strNewWiring += chrNewLetter.ToString();
                    }
                    this.middle = strNewWiring;
                }
            }
        }

        public int SetRingMOD(int n_notch, int keynum)
        {
            // Special Function, because negative with MOD delivers the same nagative number back
            n_notch -= keynum;
            n_notch -= 64;
            n_notch %= 26;
            if (n_notch < 0)
                n_notch += 26;

            n_notch += 64;

            return n_notch;
        }

    }
}
