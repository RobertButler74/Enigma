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

        public static string SetDataInfo(EnigmaM3 enigmaMachine, string messageText = "", string cipherText = "", bool blDGV = false)
        {
            string ukw = enigmaMachine.reflector.type;
            string walzeL = enigmaMachine.rotorL.type;
            string walzeM = enigmaMachine.rotorM.type;
            string walzeR = enigmaMachine.rotorR.type;
            string cipherKEY = enigmaMachine.cipherKey;
            string rings = enigmaMachine.rings;

            string dataInfo;
            if (!blDGV)
            {
                dataInfo = "lbl";
                dataInfo += ukw + ": ";
                dataInfo += walzeL + "-" + rings.Substring(0, 1) + ", ";
                dataInfo += walzeM + "-" + rings.Substring(1, 1) + ", ";
                dataInfo += walzeR + "-" + rings.Substring(2, 1) + " | ";
                dataInfo += cipherKEY + " | ";

                for (int i = 1; i <= EnigmaMachine.plugs.Length - 1; i++)
                {
                    dataInfo += EnigmaMachine.plugs[i] + "-";
                }

                dataInfo = dataInfo.Substring(0, dataInfo.Length - 1);
            }
            else
            {
                dataInfo = "dgv";
                dataInfo += ukw + "|";
                dataInfo += walzeL + "-" + rings.Substring(0, 1) + "|";
                dataInfo += walzeM + "-" + rings.Substring(1, 1) + "|";
                dataInfo += walzeR + "-" + rings.Substring(2, 1) + "|";
                dataInfo += cipherKEY + "|";

                for (int i = 1; i <= EnigmaMachine.plugs.Length - 1; i++)
                {
                    dataInfo += EnigmaMachine.plugs[i] + "-";
                }

                dataInfo = dataInfo.Substring(0, dataInfo.Length - 1);
                dataInfo += "|";
                dataInfo += messageText + "|";
                dataInfo += cipherText;
            }
            
            return dataInfo;
        }
    }
}
