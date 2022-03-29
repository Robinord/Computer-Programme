/*
This programme will is Multiple Choice Questions quiz
list of MaoriWords = string[50 values]
list of the meanings = string [50 values]
if tickBox pressed:
    Call refresh method()
    Call score method()
    if pressed 10 times:
        Show Score
        Open Form2
Refresh Method()
    Option 1 = MaoriWords[Call Unique Random Number method(max value:49)]
    Option 2 = MaoriWords[Call Unique Random Number method(max value:49)]
    Option 3 = MaoriWords[Call Unique Random Number method(max value:49)]
    Meaning = Meaning of Option 1, Option 2 or Option 3
Check Score Method()
    If option Number chosen is equal to option used by meaning:
        Score + 1
Unique Random Number Method()
    While(Until Returns)
        Generate Random Number(below 50)
        if Random Number already used:
            Generate another Random Number(below 50)
        else:
            Save Random Number as Used Numbers
            Return Random Number
 */
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
        int flag = 0;//the counter for the amounts of time the tickbox has been clicked and the screen has been refreshed;
        Random rnd = new Random();
        int index = 0;//the counter for index for the new used number to go to
        int score = 0;//the counter for current score
        int optionNumber = 0;//the variable for which option is currently pressed
        int meaningIndex;//declared to make the index for the meaning 
        string[] maoriWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hīkoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kōhanga reo", "mahi", "mana", "manuhiri", "Māori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pā", "Pākehā", "pounamu", "puku", "rangatira", "taihoa", "tama", 
            "tamāhine", "tamariki", "tāne", "tangi", "taonga", "tapu", "te reo Māori", "tipuna", "tuatara ", "wahine",
            "wai", "waiata", "waka", "whaikōrero", "whakapapa", "whānau", "whenua" };
            //made an array for all the maori words
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
            //made an array with the meanings of the maori words at the same index
        int[] usedNumbers = new int[30];//made an array for the used numbers so they don't get repeated
        int[] optionIndex = new int[3];//made an array for the current indexes that the options are using

        public void Refresh()//made to refresh all the values on screen
        {
            optionIndex[0] = UniqueRnd(49);
            optionIndex[1] = UniqueRnd(49);
            optionIndex[2] = UniqueRnd(49);
            //stores a random index for each option in the optionIndex array
            meaningIndex = rnd.Next(3);
            engWord.Text = meaning[optionIndex[meaningIndex]];//chooses a random index from the any of the index the options are using
            option1.Text = maoriWords[optionIndex[0]];
            option2.Text = maoriWords[optionIndex[1]];
            option3.Text = maoriWords[optionIndex[2]];
        }
        public void CheckScore()
        {
            if (optionNumber-1 == meaningIndex && optionNumber != 0)//just to confirm that a score isn't added if no options are selected
            { 
                score++; 
            }
            //if the option number chosen is the same as the option's meaning that was displayed then add one to the score
        }

        public int UniqueRnd(int maxValue)//method to choose a different random number each time it is run
        {

            while (true)//while method keeps on going until a number is returned
            {
                bool unique = true;//assumes that the number is unique at first until proved otherwise
                int rndNumber = rnd.Next(maxValue + 1);//chooses a random number below 50

                foreach (int usedNumber in usedNumbers)//goes through each number in the usedNumbers array
                {  
                    if (rndNumber == usedNumber)
                    { 
                        unique = false;//if a number in the array is the same as this number then unique is false and a value isn't returned and the process repeats
                    }
                }
                if (unique == true)
                {
                    usedNumbers[index] = rndNumber;//puts the new unique random number in the array of used numbers
                    index++;//changes the current index of the used number to be placed in
                    return rndNumber;
                }
            }     
            
        }

        public Form1()
        {
            InitializeComponent();//initializing this form
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 1;//when option 1 is pressed
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 2;//when option  2 is pressed
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            optionNumber = 3;//when option 3 is pressed
        }

        private void tickBox_Click(object sender, EventArgs e)//When tick box is clicked
        {   
            if (flag == 0)//when clicked for the first time 
            {
                question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
            }
            if (flag >= 1)//so that score isn't checked the very first time the tickbox is clicked
            {
                CheckScore();
            }
            if (flag == 10)//when all the questions have been asked, it shows the score
            {
                if (score == 10)
                { 
                    MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");//opens a box to show text
                    this.Hide();//hides the current for when the new form opens
                    Form2 form = new Form2();
                    form.Show();
                }
                else
                {  
                    MessageBox.Show($"You got {score} out of 10", "Congratulations");//opens a box to show text
                    this.Hide();//hides the current for when the new form opens
                    Form2 form = new Form2();
                    form.Show();
                }
            }

            if (flag < 10)//to refresh the values on screen, except the very last time when all questions are done
            {
                Refresh();
            }

            flag++;//updates the counter for the number of time the TickBox has been pressed
        }
    }
}
