using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    internal class Combinations
    {

        private static readonly int[] _rotorCombi5 = new[] { 123, 124, 125, 132, 134, 135, 142, 143, 145, 152, 153, 154, 213, 214, 215, 231, 234, 235, 241, 243, 245, 251, 253, 254, 312, 314, 315, 321, 324, 325, 341, 342, 345, 351, 352, 354, 412, 413, 415, 421, 423, 425, 431, 432, 435, 451, 452, 453, 512, 513, 514, 521, 523, 524, 531, 532, 534, 541, 542, 543 };

        private static readonly int[] _rotorCombi8 = new[] { 123, 124, 125, 126, 127, 128, 132, 134, 135, 136, 137, 138, 142, 143, 145, 146, 147, 148, 152, 153, 154, 156, 157, 158, 162, 163, 164, 165, 167, 168, 172, 173, 174, 175, 176, 178, 182, 183, 184, 185, 186, 187, 213, 214, 215, 216, 217, 218, 231, 234, 235, 236, 237, 238, 241, 243, 245, 246, 247, 248, 251, 253, 254, 256, 257, 258, 261, 263, 264, 265, 267, 268, 271, 273, 274, 275, 276, 278, 281, 283, 284, 285, 286, 287, 312, 314, 315, 316, 317, 318, 321, 324, 325, 326, 327, 328, 341, 342, 345, 346, 347, 348, 351, 352, 354, 356, 357, 358, 361, 362, 364, 365, 367, 368, 371, 372, 374, 375, 376, 378, 381, 382, 384, 385, 386, 387, 412, 413, 415, 416, 417, 418, 421, 423, 425, 426, 427, 428, 431, 432, 435, 436, 437, 438, 451, 452, 453, 456, 457, 458, 461, 462, 463, 465, 467, 468, 471, 472, 473, 475, 476, 478, 481, 482, 483, 485, 486, 487, 512, 513, 514, 516, 517, 518, 521, 523, 524, 526, 527, 528, 531, 532, 534, 536, 537, 538, 541, 542, 543, 546, 547, 548, 561, 562, 563, 564, 567, 568, 571, 572, 573, 574, 576, 578, 581, 582, 583, 584, 586, 587, 612, 613, 614, 615, 617, 618, 621, 623, 624, 625, 627, 628, 631, 632, 634, 635, 637, 638, 641, 642, 643, 645, 647, 648, 651, 652, 653, 654, 657, 658, 671, 672, 673, 674, 675, 678, 681, 682, 683, 684, 685, 687, 712, 713, 714, 715, 716, 718, 721, 723, 724, 725, 726, 728, 731, 732, 734, 735, 736, 738, 741, 742, 743, 745, 746, 748, 751, 752, 753, 754, 756, 758, 761, 762, 763, 764, 765, 768, 781, 782, 783, 784, 785, 786, 812, 813, 814, 815, 816, 817, 821, 823, 824, 825, 826, 827, 831, 832, 834, 835, 836, 837, 841, 842, 843, 845, 846, 847, 851, 852, 853, 854, 856, 857, 861, 862, 863, 864, 865, 867, 871, 872, 873, 874, 875, 876 };

        private static readonly string[] _plugCombi = new[] { "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV", "IW", "IX", "IY", "IZ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "JU", "JV", "JW", "JX", "JY", "JZ", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "KY", "KZ", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LU", "LV", "LW", "LX", "LY", "LZ", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "NZ", "OP", "OQ", "OR", "OS", "OT", "OU", "OV", "OW", "OX", "OY", "OZ", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "QR", "QS", "QT", "QU", "QV", "QW", "QX", "QY", "QZ", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "TU", "TV", "TW", "TX", "TY", "TZ", "UV", "UW", "UX", "UY", "UZ", "VW", "VX", "VY", "VZ", "WX", "WY", "WZ", "XY", "XZ", "YZ" };

        public Combinations()
        {

        }

        public static string[] PlugCombi
        {
            get { return _plugCombi; }
        }

        public static int[] RotorCombi5
        {
            get { return _rotorCombi5; }
        }

        public static int[] RotorCombi8
        {
            get { return _rotorCombi8; }
        }

    }
}
