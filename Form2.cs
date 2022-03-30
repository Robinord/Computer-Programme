/*
This programme will ask the user for the maori word corresponding to the meaning displayed
list of Maori Words = string[50 values]
list of alternate Maori words = string[50 values]
list of the meanings = string [50 values]
if close button pressed:
    Exit the whole programme
if tickBox pressed:
    Call Run method()
if Enter key pressed:
    Suppress system sound 
    Call Run Method()
Run Method()
    Call refresh screen method()
    Call score method()
    if used 10 times:
        Show Score
        Exit Application
    Update the progress Label
Refresh screen Method()
    Meaning = Meanings[Call Unique Random Number method(max value: 49)]
Check Score Method()
    If Text Entered is the maori word or the alternative maori word which corresponds to the meaning:
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
    public partial class Form2 : Form
    {
        int flag = 0;//the counter for the amounts of time the tickbox has been clicked and the screen has been refreshed;
        Random rnd = new Random();
        int index = 0;//the counter for index for the new used number to go to
        string answer;// the text entered in the textbox
        int score = 0;//the counter for current score
        int meaningIndex;//declared to make the index for the meaning 
        int timeSpent = 0;
        string[] maoriWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hīkoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kōhanga reo", "mahi", "mana", "manuhiri", "Māori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pā", "Pākehā", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamāhine", "tamariki", "tāne", "tangi", "taonga", "tapu", "te reo Maori", "tipuna", "tuatara", "wahine",
            "wai", "waiata", "waka", "whaikōrero", "whakapapa", "whānau", "whenua" };
            //made an array for all the maori words
        string[] correctionWords = { "Aotearoa", "aroha", "awa", "haka", "hangi", "hapu", "hikoi", "hui", "iti", "iwi", "kai",
            "karakia", "kaumatua", "kauri", "kiwi", "koha", "kohanga reo", "mahi", "mana", "manuhiri", "Maori", "marae",
            "maunga", "moa", "moana", "motu", "nui", "pa", "Pakeha", "pounamu", "puku", "rangatira", "taihoa", "tama",
            "tamahine", "tamariki", "tane", "tangi", "taonga", "tapu", "Maori", "tipuna", "tuatara", "wahine",
            "wai", "waiata", "waka", "whaikorero", "whakapapa", "whanau", "whenua" };
            //made an array for the alternative maori that could be entered by the user
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
        int[] usedNumbers = new int[10];//made an array for the used numbers so they don't get repeated
        public void RefreshScreen()//made to refresh the meaning displayed on screen
        {
            meaningIndex = uniqueRnd(49);//stores a random unique index with max value 49
            engWord.Text = meaning[meaningIndex];
        }
        public void CheckScore()
        {
            if (answer == null)//to noot run into error if user doesn't enter anything
            {
                answer = " ";
            }
            if (answer.ToLower() == (maoriWords[meaningIndex]).ToLower() || answer.ToLower() == (correctionWords[meaningIndex]).ToLower())//to check if the answer entered is right
            {
                score++;
            }
        }

        public int uniqueRnd(int maxValue)//method to choose a different random number each time it is run
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

        public void Run()
        {
            if (flag == 0)//when clicked for the first time 
            {
                question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
                timer1.Start();
            }
            if (flag >= 1)//so that score isn't checked the very first time the tickbox is clicked
            {
                CheckScore();
            }
            if (flag == 10)//when all the questions have been asked, it shows the score
            {
                timer1.Stop();
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
            if (flag < 10)//to refresh the value on screen, except the very last time when all questions are done
            {
                RefreshScreen();
                progress.Text = $"Question: {flag + 1} / 10";
            }
            input.Clear();//to clear the text in the inputbox
            flag++;//updates the counter for the number of time the TickBox has been pressed
        }

        public Form2()
        {
            InitializeComponent();//initializing this form
        }


        private void input_TextChanged(object sender, EventArgs e)//to keep account of the text entered
        {
            answer = input.Text;
        }

        private void tickBox_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//to run the same code as tickbox when enter key pressed
            {
                e.SuppressKeyPress = true;//to suppress the system sound of pressing enter in a single lined text box
                Run();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            timeLeft.Text = $"Time left: {100 - timeSpent} secs";


            if (timeSpent >= 100)
            {
                timer1.Stop();
                if (score == 10)
                {
                    MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");
                }
                else
                {
                    MessageBox.Show($"You got {score} out of 10", "Congratulations");
                }
                Application.Exit();
            }

            timeSpent++;

        }
    
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//so that the previous hidden form 1 closes along aswell
        }
    }
}
