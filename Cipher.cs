using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Cipher
    {

        public static string message;
        public static string cipherText;
        public static int minIoC;
        public static string compare;

        public static bool blIoCDiff = false;
        public static bool blCompare = false;

        public static int intRefID;
        public static int intRefIoC;

        public Cipher()
        {

        }

        public Cipher(EnigmaM3 enigmaMachine)
        {
            CipherText(enigmaMachine);
        }        

        public static string EnigmaCipher(EnigmaM3 enigmaMachine)
        {
            // encipher message     
            string cipher_text;
            cipher_text = "";
            foreach (char letter in message)
                cipher_text += enigmaMachine.Encipher(letter.ToString());

            return cipher_text;
        }

        public void CipherText(EnigmaM3 enigmaMachine)
        {
            cipherText = EnigmaCipher(enigmaMachine);

            double IoC = Analyzation.MonogramIOC(cipherText);
            IoC = Math.Round(IoC, 5);
            int intIoC = Convert.ToInt32(IoC * 100000);
            int IoCDiff = 0;

            if (blIoCDiff)
            {
                IoCDiff = intIoC - intRefIoC;
            }

            if ((!blIoCDiff && intIoC >= minIoC && !blCompare) || (blIoCDiff && IoCDiff > 0 && !blCompare) || (blCompare && cipherText == compare))
            {
                SetData.SetDataInfo(enigmaMachine, message, cipherText);
            }
        }

    }
}
