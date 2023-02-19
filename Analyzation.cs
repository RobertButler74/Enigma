using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Analyzation
    {

        /*
            ToDo:
                - add bigram(2 letter combinatons), trigram(3 letter combinations) and maybe quadgram(4 letter Combinations) Index of Coincedence(IOC) analyzation
                - add Chi-square analyzation(may be needed if IOC analyzation is not good enough=
                - add log(2 or 3, maybe depending on gram(bi, tri and quad) size.
        */

        //Monogram (1 letter)
        public static double MonogramIOC(string cipherText)
        {
            double dblIOC;

            string strCipherText;
            string strLetter;
            char chrLetter;
            int i;
            int occurCount;
            long zaehler = 0;
            long nenner = 0;

            for (i = 1; i <= 26; i++)
            {
                strCipherText = cipherText;
                chrLetter = Convert.ToChar(i + 64);
                strLetter = chrLetter.ToString();

                occurCount = strCipherText.Length - strCipherText.Replace(strLetter, "").Length;
                zaehler += occurCount;
                nenner += occurCount * (occurCount - 1);
            }

            dblIOC = nenner / (double)(zaehler * (zaehler - 1));

            return dblIOC;
        }
    }
}
