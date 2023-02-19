using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Rotors
    {

        public static Rotor SetRotor(int index)
        {
            Rotor tmpRotor = null;

            switch (index)
            {
                // I
                case 1:
                    {
                        tmpRotor = new Rotor("I", "EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
                        break;
                    }
                // II
                case 2:
                    {
                        tmpRotor = new Rotor("II", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "E");
                        break;
                    }
                // III
                case 3:
                    {
                        tmpRotor = new Rotor("III", "BDFHJLCPRTXVZNYEIWGAKMUSQO", "V");
                        break;
                    }
                // IV
                case 4:
                    {
                        tmpRotor = new Rotor("IV", "ESOVPZJAYQUIRHXLNFTGKDCMWB", "J");
                        break;
                    }
                // V
                case 5:
                    {
                        tmpRotor = new Rotor("V", "VZBRGITYUPSDNHLXAWMJQOFECK", "Z");
                        break;
                    }
                // VI
                case 6:
                    {
                        tmpRotor = new Rotor("VI", "JPGVOUMFYQBENHZRDKASXLICTW", "M", "Z");
                        break;
                    }
                // VII
                case 7:
                    {
                        tmpRotor = new Rotor("VII", "NZJHGRCXMYSWBOUFAIVLPEKQDT", "M", "Z");
                        break;
                    }
                // VIII
                case 8:
                    {
                        tmpRotor = new Rotor("VIII", "FKQHTLXOCBJSPDZRAMEWNIUYGV", "M", "Z"); ;
                        break;
                    }
            }

            return tmpRotor;
        }

        public static string NumToRoman(int rotorNumber)
        {
            string strNumToRoman = null;

            switch (rotorNumber)
            {
                case 1:
                    {
                        strNumToRoman = "I";
                        break;
                    }

                case 2:
                    {
                        strNumToRoman = "II";
                        break;
                    }

                case 3:
                    {
                        strNumToRoman = "III";
                        break;
                    }

                case 4:
                    {
                        strNumToRoman = "IV";
                        break;
                    }

                case 5:
                    {
                        strNumToRoman = "V";
                        break;
                    }

                case 6:
                    {
                        strNumToRoman = "VI";
                        break;
                    }

                case 7:
                    {
                        strNumToRoman = "VII";
                        break;
                    }

                case 8:
                    {
                        strNumToRoman = "VIII";
                        break;
                    }
            }

            return strNumToRoman;
        }

        public static int RomanToNum(string rotorNumber)
        {
            int intRomanToNum = 0;

            switch (rotorNumber)
            {
                case "I":
                    {
                        intRomanToNum = 1;
                        break;
                    }

                case "II":
                    {
                        intRomanToNum = 2;
                        break;
                    }

                case "III":
                    {
                        intRomanToNum = 3;
                        break;
                    }

                case "IV":
                    {
                        intRomanToNum = 4;
                        break;
                    }

                case "V":
                    {
                        intRomanToNum = 5;
                        break;
                    }

                case "VI":
                    {
                        intRomanToNum = 6;
                        break;
                    }

                case "VII":
                    {
                        intRomanToNum = 7;
                        break;
                    }

                case "VIII":
                    {
                        intRomanToNum = 8;
                        break;
                    }
            }

            return intRomanToNum;
        }

    }
}
