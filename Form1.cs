using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Programme
{
    public partial class Form1 : Form
    {
        int flag = 0;
        Random rnd = new Random();
        int index = 0;
        public int score = 0;
        int optionNumber = 0;
        public int meaningIndex { get; private set; }
        string[] maoriWords = { "Aotearoa ", "aroha", "awa ", "haka ", "hangi ", "hapu", "hīkoi", "hui ", "iti", "iwi ", "kai ",
            "karakia ", "kaumatua ", "kauri ", "kiwi ", "koha ", "kōhanga reo", "mahi ", "mana ", "manuhiri ", "Māori ", "marae ",
            "maunga", "moa", "moana ", "motu", "nui ", "pā ", "Pākehā ", "pounamu ", "puku ", "rangatira ", "taihoa ", "tama ", 
            "tamāhine ", "tamariki ", "tāne ", "tangi ", "taonga ", "tapu ", "te reo Māori ", "tipuna", "tuatara ", "wahine ",
            "wai", "waiata ", "waka ", "whaikōrero ", "whakapapa ", "whānau ", "whenua " };
        string[] meaning = { "(New Zealand, long white cloud)", "(love)", "(river)", "(generic term for Māori dance. )",
            "(traditional feast prepared in earth oven)", " (clan, sub-tribe; to be born )", "(walk)", " (gathering, meeting)", 
            " (small)", " (tribe)", "(food)", "(prayer)", "(elder)", "(large native conifer)", "(native flightless bird)", 
            "(gift, present (usually given by guest to hosts))", 
            " (language nest, Maori immersion pre-school (0 to 4 years))", "(work or activity)", "(prestige, reputation)", 
            "(guests, visitors)", "(indigenous inhabitants of New Zealand,\n the language of the indigenous inhabitants of New Zealand)",
            "(the area for formal discourse in front of a meeting house)", " (mountain)",
            "(extinct large flightless bird)", "(sea)", "(island)", "(large, many, big)", " (hill fort)", 
            "(New Zealander of non-Māori descent, usually European)", " (greenstone, jade)", " (belly, stomach)", 
            "(person of chiefly rank, boss )", "(to delay, to wait, to hold off to \n allow maturation of plans etc. )",
            "(son, young man, youth)", " (daughter)", " (children)", " (man, husband, men, husbands)", "(funeral)", 
            "(treasured possessions or cultural items, anything precious)", "(sacred, not to be touched, to be avoided because sacred)", 
            " (the Māori Language)", "(ancestor )", " (reptiles endemic to New Zealand, the order Rhynchocephalia)",
            "(woman, wife)", " (water)", "(song or chant)", "(canoe, canoe group)", " (the art and practise of speech-making )", 
            "(genealogy, to recite genealogy )", "(extended family)", "(land, homeland)" };
        int[] usedNumbers = new int[30];
        int[] optionIndex = new int[3];



        public Form1()
        {
            InitializeComponent();
        }

        public void Refresh()
        {


            optionIndex[0] = uniqueRnd();
            optionIndex[1] = uniqueRnd();
            optionIndex[2] = uniqueRnd();
            meaningIndex = rnd.Next(3);
            engWord.Text = meaning[optionIndex[meaningIndex]];
            option1.Text = maoriWords[optionIndex[0]];
            option2.Text = maoriWords[optionIndex[1]];
            option3.Text = maoriWords[optionIndex[2]];



        }
        public void CheckScore()
        {
            if (optionNumber-1 == meaningIndex && optionNumber != 0)
            { score++; }
          
        }

        public int uniqueRnd()
        {

            while (true)
            {
                bool unique = true;
                int rndNumber = rnd.Next(50);

                foreach (int usedNumber in usedNumbers)
                {  
                    if (rndNumber == usedNumber)
                    { 
                        unique = false;
                    }
                }
                if (unique == true)
                 {
                    usedNumbers[index] = rndNumber;
                    index++;
                    return rndNumber;
                    ;
                }
            }
            
        }


        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 1;
        }


        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 2;
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 3;
        }

        private void tickBox_Click(object sender, EventArgs e)
        {
            question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
            if (flag >= 1)
            {
                CheckScore();
            }
            if (flag == 10)
            {
                if (score == 10)
                {
                    MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");
                    Close();
                }
                else
                {
                    MessageBox.Show($"You got {score} out of 10", "Congratulations");
                    Close();
                }
            }

            if (flag < 10)
            {
                Refresh();
            }
            flag++;
        }




    }
}
