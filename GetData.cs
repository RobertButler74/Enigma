using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Enigma
{
    internal class GetData
    {

        public static string GetDataXmlFile;
        public static string GetDataTableName;

        public static void GetDataRotorRAndRingR()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(GetDataXmlFile);

            XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName(GetDataTableName);

            int ukw = 0;
            string walzeL = "";
            string walzeM = "";
            string walzeR = "";
            string cipherKEY = "";

            foreach (XmlNode xmlNodes in xmlNodeList)
            { 
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    switch(xmlNode.Name)
                    {

                        case "ID":
                            {
                                Cipher.intRefID = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "IOC":
                            {
                                Cipher.intRefIoC = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "Reflector":
                            {
                                ukw = Reflectors.GetReflectorNumber(xmlNode.InnerText);
                                break;
                            }
                        case "RotorLeft":
                            {
                                walzeL = xmlNode.InnerText;
                                walzeL = walzeL.Substring(0, walzeL.Length - 2);
                                break;
                            }
                        case "RotorMiddle":
                            {
                                walzeM = xmlNode.InnerText;
                                walzeM = walzeM.Substring(0, walzeM.Length - 2);
                                break;
                            }
                        case "RotorRight":
                            {
                                walzeR = xmlNode.InnerText;
                                walzeR = walzeR.Substring(0, walzeR.Length - 2);
                                break;
                            }
                        case "CipherKEY":
                            {
                                cipherKEY = xmlNode.InnerText;
                                break;
                            }
                    }
                }

                int walzen = Rotors.RomanToNum(walzeL) * 100;
                walzen += Rotors.RomanToNum(walzeM) * 10;
                walzen += Rotors.RomanToNum(walzeR);

                int intKeyR;
                int intRingR;
                int index;

                for (index = 1; index <= 25; index++)
                {
                    char chrKeyR = Convert.ToChar(cipherKEY.Substring(2, 1));
                    intKeyR = Convert.ToInt32(chrKeyR) - 64;
                    intRingR = 1;
                    intKeyR += index;
                    intRingR += index;

                    if (intKeyR > 26)
                        intKeyR -= 26;
                    if (intRingR > 26)
                        intRingR -= 26;

                    string newCipherKEY;
                    newCipherKEY = cipherKEY.Replace(cipherKEY.Substring(2), Char.ConvertFromUtf32(intKeyR + 64));
                    string rings = "AA" + Char.ConvertFromUtf32(intRingR + 64);
                    EnigmaMachine.EnigmaSetup(ukw, walzen, newCipherKEY, rings);
                }
            }            
        }

        public static void GetDataRotorMAndRingM()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(GetDataXmlFile);

            XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName(GetDataTableName);

            int ukw = 0;
            string walzeL = "";
            string walzeM = "";
            string walzeR = "";
            string ringR = "";
            string cipherKEY = "";

            foreach (XmlNode xmlNodes in xmlNodeList)
            {
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    switch (xmlNode.Name)
                    {

                        case "ID":
                            {
                                Cipher.intRefID = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "IOC":
                            {
                                Cipher.intRefIoC = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "Reflector":
                            {
                                ukw = Reflectors.GetReflectorNumber(xmlNode.InnerText);
                                break;
                            }
                        case "RotorLeft":
                            {
                                walzeL = xmlNode.InnerText;
                                walzeL = walzeL.Substring(0, walzeL.Length - 2);
                                break;
                            }
                        case "RotorMiddle":
                            {
                                walzeM = xmlNode.InnerText;
                                walzeM = walzeM.Substring(0, walzeM.Length - 2);
                                break;
                            }
                        case "RotorRight":
                            {
                                walzeR = xmlNode.InnerText;
                                ringR = walzeR.Substring(walzeR.Length - 1);
                                walzeR = walzeR.Substring(0, walzeR.Length - 2);
                                break;
                            }
                        case "CipherKEY":
                            {
                                cipherKEY = xmlNode.InnerText;
                                break;
                            }
                    }
                }

                int walzen = Rotors.RomanToNum(walzeL) * 100;
                walzen += Rotors.RomanToNum(walzeM) * 10;
                walzen += Rotors.RomanToNum(walzeR);

                int intKeyM;
                int intRingM;
                int index;

                for (index = 1; index <= 25; index++)
                {
                    char chrKeyM = Convert.ToChar(cipherKEY.Substring(1, 1));
                    intKeyM = Convert.ToInt32(chrKeyM) - 64;
                    intRingM = 1;
                    intKeyM += index;
                    intRingM += index;

                    if (intKeyM > 26)
                        intKeyM -= 26;
                    if (intRingM > 26)
                        intRingM -= 26;

                    string newCipherKEY;
                    newCipherKEY = cipherKEY.Replace(cipherKEY.Substring(1), Char.ConvertFromUtf32(intKeyM + 64));
                    newCipherKEY += cipherKEY[2];
                    string rings = "A" + Char.ConvertFromUtf32(intRingM + 64) + ringR;
                    EnigmaMachine.EnigmaSetup(ukw, walzen, newCipherKEY, rings);
                }
            }
        }

        public static void GetDataPlugs(int intPlugNumber)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(GetDataXmlFile);

            XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName(GetDataTableName);

            int ukw = 0;
            string walzeL = "";
            string walzeM = "";
            string walzeR = "";
            string ringL = "";
            string ringM = "";
            string ringR = "";
            string cipherKEY = "";


            foreach (XmlNode xmlNodes in xmlNodeList)
            {
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    switch (xmlNode.Name)
                    {

                        case "ID":
                            {
                                Cipher.intRefID = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "IOC":
                            {
                                Cipher.intRefIoC = Convert.ToInt32(xmlNode.InnerText);
                                break;
                            }
                        case "Reflector":
                            {
                                ukw = Reflectors.GetReflectorNumber(xmlNode.InnerText);
                                break;
                            }
                        case "RotorLeft":
                            {
                                walzeL = xmlNode.InnerText;
                                ringL = walzeL.Substring(walzeL.Length - 1);
                                walzeL = walzeL.Substring(0, walzeL.Length - 2);
                                break;
                            }
                        case "RotorMiddle":
                            {
                                walzeM = xmlNode.InnerText;
                                ringM = walzeM.Substring(walzeM.Length - 1);
                                walzeM = walzeM.Substring(0, walzeM.Length - 2);
                                break;
                            }
                        case "RotorRight":
                            {
                                walzeR = xmlNode.InnerText;
                                ringR = walzeR.Substring(walzeR.Length - 1);
                                walzeR = walzeR.Substring(0, walzeR.Length - 2);
                                break;
                            }
                        case "CipherKEY":
                            {
                                cipherKEY = xmlNode.InnerText;
                                break;
                            }
                        case "Plugs":
                            {
                                string[] arrTemp = xmlNode.InnerText.Split('-');

                                for(int i = 0; i <= 9; i++)
                                {
                                    EnigmaMachine.plugs[i + 1] = arrTemp[i];
                                }                   
                                break;
                            }
                    }
                }

                int walzen = Rotors.RomanToNum(walzeL) * 100;
                walzen += Rotors.RomanToNum(walzeM) * 10;
                walzen += Rotors.RomanToNum(walzeR);

                string rings = ringL;
                rings += ringM;
                rings += ringR;

                EnigmaMachine.SetPlugs(intPlugNumber, intPlugNumber, ukw, walzen, cipherKEY, rings);
            }
        }

    }
}
