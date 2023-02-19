using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class EnigmaM3
    {

        public Reflector reflector;
        public Rotor rotorL;
        public Rotor rotorM;
        public Rotor rotorR;
        public string rings;
        public string cipherKey;
        public Plugboard plugboard;
        public Keyboard keyboard;

        public EnigmaM3()
        {

        }

        public EnigmaM3(Reflector _reflector, Rotor _rotorL, Rotor _rotorM, Rotor _rotorR, Plugboard _plugboard, Keyboard _keyboard, string _rings, string _cipherKey)
        {
            this.reflector = _reflector;
            this.rotorL = _rotorL;
            this.rotorM = _rotorM;
            this.rotorR = _rotorR;
            this.plugboard = _plugboard;
            this.keyboard = _keyboard;
            this.rings = _rings;
            this.cipherKey = _cipherKey;

            SetKey(cipherKey);
            SetRings(rings);

        }
        public void SetRings(string rings = "AAA")
        {
            if (rings != "AAA")
            {
                this.rotorL.SetRing(Convert.ToString(rings[0]));
                this.rotorM.SetRing(Convert.ToString(rings[1]));
                this.rotorR.SetRing(Convert.ToString(rings[2]));
            }
        }
        public void SetKey(string key = "AAA")
        {
            if (key != "AAA")
            {
                if (Convert.ToString(key[0]) != "A")
                    this.rotorL.RotateToLetter(Convert.ToString(key[0]));

                if (Convert.ToString(key[1]) != "A")
                    this.rotorM.RotateToLetter(Convert.ToString(key[1]));

                if (Convert.ToString(key[2]) != "A")
                    this.rotorR.RotateToLetter(Convert.ToString(key[2]));
            }
        }
        public string Encipher(string letter)
        {

            // rotoate the rotors
            if (this.rotorM.left.Substring(0, 1) == this.rotorM.notch1 || this.rotorM.left.Substring(0, 1) == this.rotorM.notch2 && this.rotorR.left.Substring(0, 1) == this.rotorR.notch1 || this.rotorR.left.Substring(0, 1) == this.rotorR.notch2)
            {
                this.rotorL.Rotate();
                this.rotorM.Rotate();
                this.rotorR.Rotate();
            }
            else if (this.rotorM.left.Substring(0, 1) == this.rotorM.notch1 || this.rotorM.left.Substring(0, 1) == this.rotorM.notch2)
            {
                this.rotorL.Rotate();
                this.rotorM.Rotate();
                this.rotorR.Rotate();
            }
            else if (this.rotorR.left.Substring(0, 1) == this.rotorR.notch1 || this.rotorR.left.Substring(0, 1) == this.rotorR.notch2)
            {
                this.rotorM.Rotate();
                this.rotorR.Rotate();
            }
            else
                this.rotorR.Rotate();

            // pass signal through the machine
            string signal;
            signal = this.keyboard.Forward(letter);
            signal = this.plugboard.Forward(signal);
            signal = this.rotorR.Forward(signal);
            signal = this.rotorM.Forward(signal);
            signal = this.rotorL.Forward(signal);
            signal = this.reflector.Reflect(signal);
            signal = this.rotorL.Backward(signal);
            signal = this.rotorM.Backward(signal);
            signal = this.rotorR.Backward(signal);
            signal = this.plugboard.Backward(signal);
            letter = this.keyboard.Backward(signal);

            return letter;
        }

    }
}
