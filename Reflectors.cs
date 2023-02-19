using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Reflectors
    {

        public static Reflector SetReflector(int index)
        {
            Reflector tmpReflector = null;

            switch (index)
            {
                // A
                case 0:
                    {
                        tmpReflector = new Reflector("A", "EJMZALYXVBWFCRQUONTSPIKHGD");
                        break;
                    }
                // B
                case 1:
                    {
                        tmpReflector = new Reflector("B", "YRUHQSLDPXNGOKMIEBFZCWVJAT");
                        break;
                    }
                // C
                case 2:
                    {
                        tmpReflector = new Reflector("C", "FVPJIAOYEDRZXWGCTKUQSBNMHL");
                        break;
                    }
            }

            return tmpReflector;
        }

        public static string GetReflectorLetter(int ukw)
        {
            string strUKWLetter = null;

            switch (ukw)
            {
                case 0:
                    {
                        strUKWLetter = "A";
                        break;
                    }

                case 1:
                    {
                        strUKWLetter = "B";
                        break;
                    }

                case 2:
                    {
                        strUKWLetter = "C";
                        break;
                    }
            }

            return strUKWLetter;
        }

        public static int GetReflectorNumber(string ukw)
        {
            int ukwNumber = 0;

            switch (ukw)
            {
                case "A":
                    {
                        ukwNumber = 0;
                        break;
                    }

                case "B":
                    {
                        ukwNumber = 1;
                        break;
                    }

                case "C":
                    {
                        ukwNumber = 2;
                        break;
                    }
            }

            return ukwNumber;
        }

    }
}
