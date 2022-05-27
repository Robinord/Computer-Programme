/*
This is the class that contains the data for both the forms
initiated all variables that will be used;
list of Maori Words = string[50 values]
list of the meanings = string [50 values]
list of alternate Maori words = string[50 values]
Constructor for form(secsLeft, counter, index, score, optionNumber, array usedNumbers, array optionIndex)
    This Variable = variable;

*/
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
        public int SecsLeft, Counter, Index, Score, OptionNumber;
        private int RndNumber;
        public int MeaningIndex;
        public static string[] MaoriWords = { "Aotearoa", "Aroha", "Awa", "Haka", "Hangi", "Hapu", "Hīkoi", "Hui", "Iti", "Iwi", "Kai",
            "Karakia", "Kaumatua", "Kauri", "Kiwi", "Koha", "Kōhanga Reo", "Mahi", "Mana", "Manuhiri", "Māori", "Marae",
            "Maunga", "Moa", "Moana", "Motu", "Nui", "Pā", "Pākehā", "Pounamu", "Puku", "Rangatira", "Taihoa", "Tama",
            "Tamāhine", "Tamariki", "Tāne", "Tangi", "Taonga", "Tapu", "Te Reo Māori", "Tipuna", "Tuatara ", "Wahine",
            "Wai", "Waiata", "Waka", "Whaikōrero", "Whakapapa", "Whānau", "Whenua" };
        public static string[] Meaning = { "New Zealand, long white cloud", "Love", "River", "Generic term for Māori dance",
            "Traditional feast prepared in earth oven", "Clan, sub-tribe; to be born", "Walk", "Gathering, meeting",
            "Small", "Tribe", "Food", "Prayer", "Elder", "Large native conifer", "Native flightless bird",
            "Gift, present (usually given by guest to hosts)",
            "Language nest, Maori immersion pre-school (0 to 4 years)", "Work or activity", "Prestige, reputation",
            "Guests, visitors", "Indigenous inhabitants of New Zealand",
            "The area for formal discourse in front of a meeting house", "Mountain",
            "Extinct large flightless bird", "Sea", "Island", "Large, many, big", "Hill fort",
            "New Zealander of non-Māori descent, usually European", "Greenstone, jade", "Belly, stomach",
            "Person of chiefly rank, boss", "To delay, to wait, to hold off to \n Allow maturation of plans etc.",
            "Son, young man, youth", "Daughter", "Children", "Man, husband, men, husbands", "Funeral",
            "Treasured possessions or cultural items, anything precious", "Sacred, not to be touched, to be avoided because sacred",
            "The language Māori people speak", "Ancestor", " Reptiles endemic to New Zealand, the order Rhynchocephalia",
            "Woman, wife", "Water", "Song or chant", "Canoe, canoe group", "The art and practise of speech-making",
            "Genealogy, to recite genealogy", "Family", "Land, homeland" };
        public static string[] CorrectionWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hikoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kohanga reo", "mahi", "mana", "manuhiri", "Maori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pa", "Pakeha", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamahine", "tamariki", "tane", "tangi", "taonga", "tapu", "Maori", "tipuna", "tuatara", "wahine",
            "wai", "waiata", "waka", "whaikorero", "whakapapa", "whanau", "whenua" };
        public int[] UsedNumbers, OptionIndex;

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

        public Frm(int secsLeft, int counter, int index, int score, int[] usedNumbers)
        {
            this.SecsLeft = secsLeft;
            this.Counter = counter;
            this.Index = index;
            this.Score = score;
            this.UsedNumbers = usedNumbers;
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
