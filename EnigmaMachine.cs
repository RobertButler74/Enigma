using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class EnigmaMachine
    {

        public static string[] plugs = new string[11];
        public static int counter = 0;

        public static void SetPlugs(int fromPlug, int toPlug)
        {
            int index;
            for (index = fromPlug; index <= toPlug; index++)
                SetPlug(index, toPlug);

            Array.Clear(plugs, 0, plugs.Length);
        }

        public static void SetPlug(int plugNumber, int maxPlugs = 10, int indexPlugStart = 0)
        {
            int index;
            int indexPlugNumber;
            int maxPlug;
            int origPlug;
            string plugFirst;
            string plugSecond;
            string plugCombi;
            int intContains;
            

            maxPlug = Combinations.PlugCombi.Length - 1 - maxPlugs + plugNumber;
            origPlug = plugNumber;
            for (index = indexPlugStart; index <= maxPlug; index++)
            {
                plugCombi = Combinations.PlugCombi[index];
                intContains = 0;
                for (indexPlugNumber = 1; indexPlugNumber <= plugNumber - 1; indexPlugNumber++)
                {
                    plugFirst = plugs[indexPlugNumber].Substring(0, 1);
                    plugSecond = plugs[indexPlugNumber].Substring(1, 1);
                    if (plugCombi.Contains(plugFirst) == true || plugCombi.Contains(plugSecond) == true)
                        intContains += 1;
                    else
                    {
                    }
                }

                if (intContains == 0)
                {
                    plugs[plugNumber] = plugCombi;
                    if (plugNumber + 1 < maxPlugs + 1)
                    {
                        plugNumber += 1;
                        SetPlug(plugNumber, maxPlugs, index + 1);
                        plugNumber = origPlug;
                    }
                    if (plugNumber == maxPlugs)
                    {
                        counter += 1;
                        string strCounter = counter.ToString("# ###");
                        strCounter = "Count: " + strCounter;
                        string msg = "Plugs: ";
                        for (int indexPlugs = 1; indexPlugs <= maxPlugs; indexPlugs++)
                        {
                            msg += plugs[indexPlugs];
                            msg += "-";
                        }
                        msg = msg.Substring(0, msg.Length - 1);
                        Debug.WriteLine(strCounter);
                        Debug.WriteLine(msg);
                        Debug.WriteLine("");
                    }
                }
            }
        }

        public static void EnigmaSetup(Nullable<int> ukw, Nullable<int> walzen = null, string cipherKEY = null, string rings = null, Nullable<int> anzahlWalzen = 5)
        {
            if (ukw == null)
            {
                int min;
                int max;
                min = 1;
                max = 2;
                // rings = "AAA"
                SetUKW(min, max, ukw, walzen, cipherKEY, rings);
            }
            else if (walzen == null)
            {
                SetWalzen((int)ukw, null, (string)cipherKEY, (string)rings, (int)anzahlWalzen);
            }
            else if (cipherKEY == null)
            {
                SetCipherKEY((int)ukw, (int)walzen, rings);
            }
            else if (rings == null)
            {
                SetRings((int)ukw, (int)walzen, cipherKEY);
            }
            else
            {
                EnigmaM3 enigmaMachine = CreateEnigma((int)ukw, (int)walzen, cipherKEY, rings);
                Cipher cipher = new Cipher(enigmaMachine);
                //cipher.C;
            }

        }

        public static void SetUKW(Nullable<int> min, Nullable<int> max, Nullable<int> ukw, Nullable<int> walzen, string cipherKey = null, string rings = null)
        {
            for (ukw = min; ukw <= max; ukw++)
                EnigmaSetup(ukw, walzen, cipherKey, rings);
        }

        public static void SetWalzen(int ukw, Nullable<int> walzen, string cipherKey, string rings, Nullable<int> anzahlWalzen)
        {
            int index;

            if (anzahlWalzen == 5)
            {
                for (index = 0; index <= Combinations.RotorCombi5.Length - 1; index++)
                {
                    walzen = Combinations.RotorCombi5[index];

                    EnigmaSetup(ukw, walzen, cipherKey, rings);
                }
            }
            else if (anzahlWalzen == 8)
            {
                for (index = 0; index <= Combinations.RotorCombi8.Length - 1; index++)
                {
                    walzen = Combinations.RotorCombi8[index];

                    EnigmaSetup(ukw, walzen, cipherKey, rings);
                }
            }
        }

        public static void SetCipherKEY(int ukw, int walzen, string rings)
        {
            int keyL;
            int keyM;
            int keyR;
            string cipherKEY;

            for (keyL = 65; keyL <= 90; keyL++)
            {
                for (keyM = 65; keyM <= 90; keyM++)
                {
                    for (keyR = 65; keyR <= 90; keyR++)
                    {
                        cipherKEY = Char.ConvertFromUtf32(keyL);
                        cipherKEY += Char.ConvertFromUtf32(keyM);
                        cipherKEY += Char.ConvertFromUtf32(keyR);

                        EnigmaSetup(ukw, walzen, cipherKEY, rings);
                    }
                }
            }
        }

        public static void SetRings(int ukw, int walzen, string cipherKEY)
        {
            int ringL;
            int ringM;
            int ringR;
            string rings;

            for (ringL = 65; ringL <= 90; ringL++)
            {
                for (ringM = 65; ringM <= 90; ringM++)
                {
                    for (ringR = 65; ringR <= 90; ringR++)
                    {
                        rings = Char.ConvertFromUtf32(ringL);
                        rings += Char.ConvertFromUtf32(ringM);
                        rings += Char.ConvertFromUtf32(ringR);

                        EnigmaSetup(ukw, walzen, cipherKEY, rings);
                    }
                }
            }
        }

        public static EnigmaM3 CreateEnigma(int ukw, int walzen, string cipherKEY, string rings)
        {
            Reflector reflector;
            Rotor rotorL;
            Rotor rotorM;
            Rotor rotorR;
            int walzeL;
            int walzeM;
            int walzeR;

            walzeL = System.Convert.ToInt32(walzen.ToString().Substring(0, 1));
            walzeM = System.Convert.ToInt32(walzen.ToString().Substring(1, 1));
            walzeR = System.Convert.ToInt32(walzen.ToString().Substring(2, 1));

            reflector = Reflectors.SetReflector(ukw);

            rotorL = Rotors.SetRotor(walzeL);
            rotorM = Rotors.SetRotor(walzeM);
            rotorR = Rotors.SetRotor(walzeR);

            Keyboard KB = new Keyboard();
            Plugboard PB = new Plugboard(plugs);

            EnigmaM3 enigmaMachine = new EnigmaM3(reflector, rotorL, rotorM, rotorR, PB, KB, rings, cipherKEY);

            return enigmaMachine;
        }

    }
}
