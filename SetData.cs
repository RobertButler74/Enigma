using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    internal class SetData
    {
        public SetData(EnigmaM3 enigmaMachine, string messageText, string cipherText)
        {
            SetDataInfo(enigmaMachine, messageText, cipherText);
        }

        public static void SetDataInfo(EnigmaM3 enigmaMachine, string _messageText, string _cipherText)
        {
            string ukw = enigmaMachine.reflector.type;
            string walzeL = enigmaMachine.rotorL.type;
            string walzeM = enigmaMachine.rotorM.type;
            string walzeR = enigmaMachine.rotorR.type;
            string cipherKEY = enigmaMachine.cipherKey;
            string rings = enigmaMachine.rings;
            string messageText = _messageText;
            string cipherText = _cipherText;



        }

    }
}
