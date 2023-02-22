using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    internal class Cipher
    {

        public static BackgroundWorker BGWCipher;

        public static string messageText;
        public static string cipherText;
        public static int minIoC;
        public static string compare;

        public static bool blIoCDiff = false;
        public static bool blCompare = false;

        public static int intRefID;
        public static int intRefIoC;

        public static int intIoC;
        public static int IoCDiff;

        public static bool blGuiUpdated = false;

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
            foreach (char letter in messageText)
                cipher_text += enigmaMachine.Encipher(letter.ToString());

            return cipher_text;
        }

        public void CipherText(EnigmaM3 enigmaMachine)
        {
            cipherText = EnigmaCipher(enigmaMachine);

            string dataInfo = SetData.SetDataInfo(enigmaMachine);

            BGWCipher.ReportProgress(0, dataInfo);
            //Debug.WriteLine(dataInfo.Substring(3));

            //while (!blGuiUpdated)
            //{
            //    await Task.Delay(1);
            //}

            //blGuiUpdated = false;

            double IoC = Analyzation.MonogramIOC(cipherText);
            IoC = Math.Round(IoC, 5);
            intIoC = Convert.ToInt32(IoC * 100000);

            IoCDiff = 0;

            if (blIoCDiff && intIoC > intRefIoC)
            {                
                IoCDiff = intIoC - intRefIoC;
            }

            if ((!blIoCDiff && intIoC >= minIoC && !blCompare) || (blIoCDiff && IoCDiff > 0 && !blCompare) || (blCompare && cipherText == compare))
            {
                dataInfo = SetData.SetDataInfo(enigmaMachine, messageText,cipherText, true);
                BGWCipher.ReportProgress(0, dataInfo);
                Thread.Sleep(50);

                //while (!blGuiUpdated)
                //{
                //    await Task.Delay(1);
                //}

                //blGuiUpdated = false;
            }

            /*
            Needed this time, because on the 2nd and 3rd scan, the IoCDiff in the table was
            negative, even though I just wanted them to be bigger then 0.
            This slowed the program down immensely. The 1st scan, went form 1 hour to 8 hours
            */
            if (blIoCDiff)
            {
                Thread.Sleep(250);
            }
        }       
    }
}
