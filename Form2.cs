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
    public partial class Form2 : Form
    {

        int flag = 0;
        Random rnd = new Random();
        int index = 0;
        public string answer;
        public int score = 0;
        public int meaningIndex { get; private set; }
        string[] maoriWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hīkoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kōhanga reo", "mahi", "mana", "manuhiri", "Māori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pā", "Pākehā", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamāhine", "tamariki", "tāne", "tangi", "taonga", "tapu", "te reo Maori", "tipuna", "tuatara", "wahine",
            "wai", "waiata", "waka", "whaikōrero", "whakapapa", "whānau", "whenua" };
        string[] correctionWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hikoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kohanga reo", "mahi", "mana", "manuhiri", "Maori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pa", "Pakeha", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamahine", "tamariki", "tane", "tangi", "taonga", "tapu", "Maori", "tipuna", "tuatara", "wahine",
            "wai", "waiata", "waka", "whaikorero", "whakapapa", "whanau", "whenua" };
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
        int[] usedNumbers = new int[10];
        public void Refresh()
        {
            meaningIndex = uniqueRnd();
            engWord.Text = meaning[meaningIndex];
            Console.WriteLine(maoriWords[meaningIndex]);

        }
        public void CheckScore()
        {
            if (answer == null)
            {
                Console.WriteLine("*");
                answer = " ";
            }
                if (answer.ToLower() == (maoriWords[meaningIndex]).ToLower() || answer.ToLower() == (correctionWords[meaningIndex]).ToLower())
            { score++; Console.WriteLine(score + answer); }
            Console.WriteLine(answer);
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


        public Form2()
        {
            InitializeComponent();
        }


        private void input_TextChanged(object sender, EventArgs e)
        {
            answer = input.Text;
      
            
        }

        private void tickBox_Click(object sender, EventArgs e)
        {
            question.Text = "Write down the word with the same meaning. Press the checkbox to continue.";
            if (flag >= 1)
            {
                CheckScore();
            }
            if (flag == 10)
            {
                if (score == 10)
                {
                    MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"You got {score} out of 10", "Congratulations");
                    Application.Exit();


                }
            }

            if (flag < 10)
            {
                Refresh();
            }

            input.Clear();
            flag++;
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                question.Text = "Write down the word with the same meaning. Press the checkbox to continue.";
                if (flag >= 1)
                {
                    CheckScore();
                }
                if (flag == 10)
                {
                    if (score == 10)
                    {
                        MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show($"You got {score} out of 10", "Congratulations");
                        Application.Exit();


                    }
                }

                if (flag < 10)
                {
                    Refresh();
                }

                input.Clear();
                flag++;
            }
        }
    
    }
}
