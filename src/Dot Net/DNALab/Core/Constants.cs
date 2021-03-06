﻿namespace DNALab.Core
{
    using System.Collections.Generic;

    /// <summary>
    ///     Th static class with constants related to DNA Domain.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        ///     The letter abbreviation for adenine (A).
        /// </summary>
        public const string Adenine = "A";

        /// <summary>
        ///     The letter abbreviation for guanine (G).
        /// </summary>
        public const string Guanine = "G";

        /// <summary>
        ///     The letter abbreviation for (cytosine (C).
        /// </summary>
        public const string Cytosine = "C";

        /// <summary>
        ///     The letter abbreviation for thymine (T).
        /// </summary>
        public const string Thymine = "T";

        /// <summary>
        ///     The letter abbreviation for adenine (A), guanine (G), (cytosine (C), thymine (T).
        /// </summary>
        public const string Nucleotides = "AGCT";

        /// <summary>
        ///     The Length of 'Nucleotides Base pairs' of 'Nitrogenous Bases'.
        /// </summary>
        public const byte NucleotidesLength = 4;

        /// <summary>
        ///     Initializes the <see cref="Constants" /> class.
        /// </summary>
        static Constants()
        {
            ByteToDnaCodeMap = new Dictionary<byte, string>
            {
                {0, "AAAA"},
                {1, "AAAC"},
                {2, "AAAG"},
                {3, "AAAT"},
                {4, "AACA"},
                {5, "AACC"},
                {6, "AACG"},
                {7, "AACT"},
                {8, "AAGA"},
                {9, "AAGC"},
                {10, "AAGG"},
                {11, "AAGT"},
                {12, "AATA"},
                {13, "AATC"},
                {14, "AATG"},
                {15, "AATT"},
                {16, "ACAA"},
                {17, "ACAC"},
                {18, "ACAG"},
                {19, "ACAT"},
                {20, "ACCA"},
                {21, "ACCC"},
                {22, "ACCG"},
                {23, "ACCT"},
                {24, "ACGA"},
                {25, "ACGC"},
                {26, "ACGG"},
                {27, "ACGT"},
                {28, "ACTA"},
                {29, "ACTC"},
                {30, "ACTG"},
                {31, "ACTT"},
                {32, "AGAA"},
                {33, "AGAC"},
                {34, "AGAG"},
                {35, "AGAT"},
                {36, "AGCA"},
                {37, "AGCC"},
                {38, "AGCG"},
                {39, "AGCT"},
                {40, "AGGA"},
                {41, "AGGC"},
                {42, "AGGG"},
                {43, "AGGT"},
                {44, "AGTA"},
                {45, "AGTC"},
                {46, "AGTG"},
                {47, "AGTT"},
                {48, "ATAA"},
                {49, "ATAC"},
                {50, "ATAG"},
                {51, "ATAT"},
                {52, "ATCA"},
                {53, "ATCC"},
                {54, "ATCG"},
                {55, "ATCT"},
                {56, "ATGA"},
                {57, "ATGC"},
                {58, "ATGG"},
                {59, "ATGT"},
                {60, "ATTA"},
                {61, "ATTC"},
                {62, "ATTG"},
                {63, "ATTT"},
                {64, "CAAA"},
                {65, "CAAC"},
                {66, "CAAG"},
                {67, "CAAT"},
                {68, "CACA"},
                {69, "CACC"},
                {70, "CACG"},
                {71, "CACT"},
                {72, "CAGA"},
                {73, "CAGC"},
                {74, "CAGG"},
                {75, "CAGT"},
                {76, "CATA"},
                {77, "CATC"},
                {78, "CATG"},
                {79, "CATT"},
                {80, "CCAA"},
                {81, "CCAC"},
                {82, "CCAG"},
                {83, "CCAT"},
                {84, "CCCA"},
                {85, "CCCC"},
                {86, "CCCG"},
                {87, "CCCT"},
                {88, "CCGA"},
                {89, "CCGC"},
                {90, "CCGG"},
                {91, "CCGT"},
                {92, "CCTA"},
                {93, "CCTC"},
                {94, "CCTG"},
                {95, "CCTT"},
                {96, "CGAA"},
                {97, "CGAC"},
                {98, "CGAG"},
                {99, "CGAT"},
                {100, "CGCA"},
                {101, "CGCC"},
                {102, "CGCG"},
                {103, "CGCT"},
                {104, "CGGA"},
                {105, "CGGC"},
                {106, "CGGG"},
                {107, "CGGT"},
                {108, "CGTA"},
                {109, "CGTC"},
                {110, "CGTG"},
                {111, "CGTT"},
                {112, "CTAA"},
                {113, "CTAC"},
                {114, "CTAG"},
                {115, "CTAT"},
                {116, "CTCA"},
                {117, "CTCC"},
                {118, "CTCG"},
                {119, "CTCT"},
                {120, "CTGA"},
                {121, "CTGC"},
                {122, "CTGG"},
                {123, "CTGT"},
                {124, "CTTA"},
                {125, "CTTC"},
                {126, "CTTG"},
                {127, "CTTT"},
                {128, "GAAA"},
                {129, "GAAC"},
                {130, "GAAG"},
                {131, "GAAT"},
                {132, "GACA"},
                {133, "GACC"},
                {134, "GACG"},
                {135, "GACT"},
                {136, "GAGA"},
                {137, "GAGC"},
                {138, "GAGG"},
                {139, "GAGT"},
                {140, "GATA"},
                {141, "GATC"},
                {142, "GATG"},
                {143, "GATT"},
                {144, "GCAA"},
                {145, "GCAC"},
                {146, "GCAG"},
                {147, "GCAT"},
                {148, "GCCA"},
                {149, "GCCC"},
                {150, "GCCG"},
                {151, "GCCT"},
                {152, "GCGA"},
                {153, "GCGC"},
                {154, "GCGG"},
                {155, "GCGT"},
                {156, "GCTA"},
                {157, "GCTC"},
                {158, "GCTG"},
                {159, "GCTT"},
                {160, "GGAA"},
                {161, "GGAC"},
                {162, "GGAG"},
                {163, "GGAT"},
                {164, "GGCA"},
                {165, "GGCC"},
                {166, "GGCG"},
                {167, "GGCT"},
                {168, "GGGA"},
                {169, "GGGC"},
                {170, "GGGG"},
                {171, "GGGT"},
                {172, "GGTA"},
                {173, "GGTC"},
                {174, "GGTG"},
                {175, "GGTT"},
                {176, "GTAA"},
                {177, "GTAC"},
                {178, "GTAG"},
                {179, "GTAT"},
                {180, "GTCA"},
                {181, "GTCC"},
                {182, "GTCG"},
                {183, "GTCT"},
                {184, "GTGA"},
                {185, "GTGC"},
                {186, "GTGG"},
                {187, "GTGT"},
                {188, "GTTA"},
                {189, "GTTC"},
                {190, "GTTG"},
                {191, "GTTT"},
                {192, "TAAA"},
                {193, "TAAC"},
                {194, "TAAG"},
                {195, "TAAT"},
                {196, "TACA"},
                {197, "TACC"},
                {198, "TACG"},
                {199, "TACT"},
                {200, "TAGA"},
                {201, "TAGC"},
                {202, "TAGG"},
                {203, "TAGT"},
                {204, "TATA"},
                {205, "TATC"},
                {206, "TATG"},
                {207, "TATT"},
                {208, "TCAA"},
                {209, "TCAC"},
                {210, "TCAG"},
                {211, "TCAT"},
                {212, "TCCA"},
                {213, "TCCC"},
                {214, "TCCG"},
                {215, "TCCT"},
                {216, "TCGA"},
                {217, "TCGC"},
                {218, "TCGG"},
                {219, "TCGT"},
                {220, "TCTA"},
                {221, "TCTC"},
                {222, "TCTG"},
                {223, "TCTT"},
                {224, "TGAA"},
                {225, "TGAC"},
                {226, "TGAG"},
                {227, "TGAT"},
                {228, "TGCA"},
                {229, "TGCC"},
                {230, "TGCG"},
                {231, "TGCT"},
                {232, "TGGA"},
                {233, "TGGC"},
                {234, "TGGG"},
                {235, "TGGT"},
                {236, "TGTA"},
                {237, "TGTC"},
                {238, "TGTG"},
                {239, "TGTT"},
                {240, "TTAA"},
                {241, "TTAC"},
                {242, "TTAG"},
                {243, "TTAT"},
                {244, "TTCA"},
                {245, "TTCC"},
                {246, "TTCG"},
                {247, "TTCT"},
                {248, "TTGA"},
                {249, "TTGC"},
                {250, "TTGG"},
                {251, "TTGT"},
                {252, "TTTA"},
                {253, "TTTC"},
                {254, "TTTG"}
            };

            DnaCodeToByteMap = new Dictionary<string, byte>
            {
                {"AAAA", 0},
                {"AAAC", 1},
                {"AAAG", 2},
                {"AAAT", 3},
                {"AACA", 4},
                {"AACC", 5},
                {"AACG", 6},
                {"AACT", 7},
                {"AAGA", 8},
                {"AAGC", 9},
                {"AAGG", 10},
                {"AAGT", 11},
                {"AATA", 12},
                {"AATC", 13},
                {"AATG", 14},
                {"AATT", 15},
                {"ACAA", 16},
                {"ACAC", 17},
                {"ACAG", 18},
                {"ACAT", 19},
                {"ACCA", 20},
                {"ACCC", 21},
                {"ACCG", 22},
                {"ACCT", 23},
                {"ACGA", 24},
                {"ACGC", 25},
                {"ACGG", 26},
                {"ACGT", 27},
                {"ACTA", 28},
                {"ACTC", 29},
                {"ACTG", 30},
                {"ACTT", 31},
                {"AGAA", 32},
                {"AGAC", 33},
                {"AGAG", 34},
                {"AGAT", 35},
                {"AGCA", 36},
                {"AGCC", 37},
                {"AGCG", 38},
                {"AGCT", 39},
                {"AGGA", 40},
                {"AGGC", 41},
                {"AGGG", 42},
                {"AGGT", 43},
                {"AGTA", 44},
                {"AGTC", 45},
                {"AGTG", 46},
                {"AGTT", 47},
                {"ATAA", 48},
                {"ATAC", 49},
                {"ATAG", 50},
                {"ATAT", 51},
                {"ATCA", 52},
                {"ATCC", 53},
                {"ATCG", 54},
                {"ATCT", 55},
                {"ATGA", 56},
                {"ATGC", 57},
                {"ATGG", 58},
                {"ATGT", 59},
                {"ATTA", 60},
                {"ATTC", 61},
                {"ATTG", 62},
                {"ATTT", 63},
                {"CAAA", 64},
                {"CAAC", 65},
                {"CAAG", 66},
                {"CAAT", 67},
                {"CACA", 68},
                {"CACC", 69},
                {"CACG", 70},
                {"CACT", 71},
                {"CAGA", 72},
                {"CAGC", 73},
                {"CAGG", 74},
                {"CAGT", 75},
                {"CATA", 76},
                {"CATC", 77},
                {"CATG", 78},
                {"CATT", 79},
                {"CCAA", 80},
                {"CCAC", 81},
                {"CCAG", 82},
                {"CCAT", 83},
                {"CCCA", 84},
                {"CCCC", 85},
                {"CCCG", 86},
                {"CCCT", 87},
                {"CCGA", 88},
                {"CCGC", 89},
                {"CCGG", 90},
                {"CCGT", 91},
                {"CCTA", 92},
                {"CCTC", 93},
                {"CCTG", 94},
                {"CCTT", 95},
                {"CGAA", 96},
                {"CGAC", 97},
                {"CGAG", 98},
                {"CGAT", 99},
                {"CGCA", 100},
                {"CGCC", 101},
                {"CGCG", 102},
                {"CGCT", 103},
                {"CGGA", 104},
                {"CGGC", 105},
                {"CGGG", 106},
                {"CGGT", 107},
                {"CGTA", 108},
                {"CGTC", 109},
                {"CGTG", 110},
                {"CGTT", 111},
                {"CTAA", 112},
                {"CTAC", 113},
                {"CTAG", 114},
                {"CTAT", 115},
                {"CTCA", 116},
                {"CTCC", 117},
                {"CTCG", 118},
                {"CTCT", 119},
                {"CTGA", 120},
                {"CTGC", 121},
                {"CTGG", 122},
                {"CTGT", 123},
                {"CTTA", 124},
                {"CTTC", 125},
                {"CTTG", 126},
                {"CTTT", 127},
                {"GAAA", 128},
                {"GAAC", 129},
                {"GAAG", 130},
                {"GAAT", 131},
                {"GACA", 132},
                {"GACC", 133},
                {"GACG", 134},
                {"GACT", 135},
                {"GAGA", 136},
                {"GAGC", 137},
                {"GAGG", 138},
                {"GAGT", 139},
                {"GATA", 140},
                {"GATC", 141},
                {"GATG", 142},
                {"GATT", 143},
                {"GCAA", 144},
                {"GCAC", 145},
                {"GCAG", 146},
                {"GCAT", 147},
                {"GCCA", 148},
                {"GCCC", 149},
                {"GCCG", 150},
                {"GCCT", 151},
                {"GCGA", 152},
                {"GCGC", 153},
                {"GCGG", 154},
                {"GCGT", 155},
                {"GCTA", 156},
                {"GCTC", 157},
                {"GCTG", 158},
                {"GCTT", 159},
                {"GGAA", 160},
                {"GGAC", 161},
                {"GGAG", 162},
                {"GGAT", 163},
                {"GGCA", 164},
                {"GGCC", 165},
                {"GGCG", 166},
                {"GGCT", 167},
                {"GGGA", 168},
                {"GGGC", 169},
                {"GGGG", 170},
                {"GGGT", 171},
                {"GGTA", 172},
                {"GGTC", 173},
                {"GGTG", 174},
                {"GGTT", 175},
                {"GTAA", 176},
                {"GTAC", 177},
                {"GTAG", 178},
                {"GTAT", 179},
                {"GTCA", 180},
                {"GTCC", 181},
                {"GTCG", 182},
                {"GTCT", 183},
                {"GTGA", 184},
                {"GTGC", 185},
                {"GTGG", 186},
                {"GTGT", 187},
                {"GTTA", 188},
                {"GTTC", 189},
                {"GTTG", 190},
                {"GTTT", 191},
                {"TAAA", 192},
                {"TAAC", 193},
                {"TAAG", 194},
                {"TAAT", 195},
                {"TACA", 196},
                {"TACC", 197},
                {"TACG", 198},
                {"TACT", 199},
                {"TAGA", 200},
                {"TAGC", 201},
                {"TAGG", 202},
                {"TAGT", 203},
                {"TATA", 204},
                {"TATC", 205},
                {"TATG", 206},
                {"TATT", 207},
                {"TCAA", 208},
                {"TCAC", 209},
                {"TCAG", 210},
                {"TCAT", 211},
                {"TCCA", 212},
                {"TCCC", 213},
                {"TCCG", 214},
                {"TCCT", 215},
                {"TCGA", 216},
                {"TCGC", 217},
                {"TCGG", 218},
                {"TCGT", 219},
                {"TCTA", 220},
                {"TCTC", 221},
                {"TCTG", 222},
                {"TCTT", 223},
                {"TGAA", 224},
                {"TGAC", 225},
                {"TGAG", 226},
                {"TGAT", 227},
                {"TGCA", 228},
                {"TGCC", 229},
                {"TGCG", 230},
                {"TGCT", 231},
                {"TGGA", 232},
                {"TGGC", 233},
                {"TGGG", 234},
                {"TGGT", 235},
                {"TGTA", 236},
                {"TGTC", 237},
                {"TGTG", 238},
                {"TGTT", 239},
                {"TTAA", 240},
                {"TTAC", 241},
                {"TTAG", 242},
                {"TTAT", 243},
                {"TTCA", 244},
                {"TTCC", 245},
                {"TTCG", 246},
                {"TTCT", 247},
                {"TTGA", 248},
                {"TTGC", 249},
                {"TTGG", 250},
                {"TTGT", 251},
                {"TTTA", 252},
                {"TTTC", 253},
                {"TTTG", 254}
            };
        }

        /// <summary>
        ///     Gets the map between byte and 'DNA Base Pairs'.
        /// </summary>
        /// <value>
        ///     The byte to DNA code map (ex. {67, "CAAT"}).
        /// </value>
        public static IReadOnlyDictionary<byte, string> ByteToDnaCodeMap { get; }

        /// <summary>
        ///     Gets the map between 'DNA Base Pairs' and byte.
        /// </summary>
        /// <value>
        ///     The byte to DNA code map (ex. {"CAAT", 67}).
        /// </value>
        public static IReadOnlyDictionary<string, byte> DnaCodeToByteMap { get; }
    }
}