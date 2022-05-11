using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Programme
{
    public class Frm
    {
        public bool Unique, Flag;
        public int RndNumber, SecsLeft, Counter, Index, Score, OptionNumber;
        public int MeaningIndex;
        public static string[] MaoriWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hīkoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kōhanga reo", "mahi", "mana", "manuhiri", "Māori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pā", "Pākehā", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamāhine", "tamariki", "tāne", "tangi", "taonga", "tapu", "te reo Māori", "tipuna", "tuatara ", "wahine",
            "wai", "waiata", "waka", "whaikōrero", "whakapapa", "whānau", "whenua" };
        public static string[] Meaning = { "(New Zealand, long white cloud)", "(love)", "(river)", "(generic term for Māori dance.)",
            "(traditional feast prepared in earth oven)", "(clan, sub-tribe; to be born)", "(walk)", "(gathering, meeting)",
            "(small)", "(tribe)", "(food)", "(prayer)", "(elder)", "(large native conifer)", "(native flightless bird)",
            "(gift, present (usually given by guest to hosts))",
            "(language nest, Maori immersion pre-school (0 to 4 years))", "(work or activity)", "(prestige, reputation)",
            "(guests, visitors)", "(indigenous inhabitants of New Zealand,\n the language of the indigenous inhabitants of New Zealand)",
            "(the area for formal discourse in front of a meeting house)", "(mountain)",
            "(extinct large flightless bird)", "(sea)", "(island)", "(large, many, big)", "(hill fort)",
            "(New Zealander of non-Māori descent, usually European)", "(greenstone, jade)", "(belly, stomach)",
            "(person of chiefly rank, boss)", "(to delay, to wait, to hold off to \n allow maturation of plans etc.)",
            "(son, young man, youth)", " (daughter)", " (children)", " (man, husband, men, husbands)", "(funeral)",
            "(treasured possessions or cultural items, anything precious)", "(sacred, not to be touched, to be avoided because sacred)",
            "(the language Māori people speak)", "(ancestor)", " (reptiles endemic to New Zealand, the order Rhynchocephalia)",
            "(woman, wife)", "(water)", "(song or chant)", "(canoe, canoe group)", " (the art and practise of speech-making)",
            "(genealogy, to recite genealogy)", "(extended family)", "(land, homeland)" };
        public int [] UsedNumbers, OptionIndex;

        public Frm(int secsLeft, int counter, int index, int score, int optionNumber, int[] usedNumbers, int[] optionIndex)
        {
            this.SecsLeft = secsLeft;
            this.Counter = counter;
            this.Index = index;
            this.Score = score;
            this.OptionNumber = optionNumber;
            this.UsedNumbers = usedNumbers;
            this.OptionIndex = optionIndex;
        }

        public int UniqueRnd(int maxValue)//method to choose a different random number each time it is run
        {
            Random rnd = new Random();
            while (true)//while method keeps on going until a number is returned
            {
                Unique = true;//assumes that the number is unique at first until proved otherwise
                RndNumber = rnd.Next(maxValue + 1);//chooses a random number below 50

                foreach (int usedNumber in UsedNumbers)//goes through each number in the usedNumbers array
                {
                    if (RndNumber == usedNumber)
                    {
                        Unique = false;//if a number in the array is the same as this number then unique is false and a value isn't returned and the process repeats
                    }
                }
                if (Unique == true)
                {
                    UsedNumbers[Index] = RndNumber;//puts the new unique random number in the array of used numbers
                    Index++;//changes the current index of the used number to be placed in
                    return RndNumber;
                }
            }
        }


    }
}
