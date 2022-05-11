/*
This programme will ask the user for the maori word corresponding to the meaning displayed
list of Maori Words = string[50 values]
list of alternate Maori words = string[50 values]
list of the meanings = string [50 values]
Timer Event()
    If 80 seconds passed;
        Exit Method()
if close button pressed:
    Exit the whole programme
if tickBox pressed:
    Call Run method()
if Enter key pressed:
    Suppress system sound 
    Call Run Method()
Run Method()
    Call Refresh screen method()
    Call Score method()
    if used 10 times:
        Call Exit Method()
    Update the progress Label
Exit Method()
    Show score
    Exit Application
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
        Frm frm2 = new Frm(80, 0, 0, 0, new int[10]);
        Random rnd = new Random();
        string answer;
        public void RefreshScreen()//made to refresh the meaning displayed on screen
        {
            frm2.MeaningIndex = frm2.UniqueRnd(49);//made the value a variable because it is used again in Check Score method
            engWord.Text = Frm.Meaning[frm2.MeaningIndex];
            engWord.ForeColor = Color.Black;
            question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
        }
        public void CheckScore()
        {
            question.Text = "Press checkbox or enter key to continue";
            if (answer == null)//to noot run into error if user doesn't enter anything
            {
                answer = "  ";
            }
            if (answer.ToLower() == (Frm.MaoriWords[frm2.MeaningIndex]).ToLower() || answer.ToLower() == (Frm.CorrectionWords[frm2.MeaningIndex]).ToLower())//to check if the answer entered is right
            {
                frm2.Score++;
                engWord.ForeColor = Color.Green;
                engWord.Text = "Correct Answer!";//to let the user know if they got the answer correct
            }
            //if the option number chosen is the same as the option's meaning that was displayed then add one to the score
            else
            {
                engWord.ForeColor = Color.Red;
                engWord.Text = $"Incorrect answer! Correct answer was: {Frm.MaoriWords[frm2.MeaningIndex]}";
            }   // just to let the user know that they got it uncorrect and what the real answer is
            timer.Stop();//to stop the timer while the user reads if they got the answer right or not

        }

      
        public void Exit()
        {
            timer.Stop();
            if (frm2.Score == 10)//opens a box to show text
            {
                MessageBox.Show("👏Wow! 🎊 You got all correct!🎉", "Congratulations!");
            }
            else
            {
                MessageBox.Show($"You got {frm2.Score} out of 10", "Congratulations");
            }
            Application.Exit();//Exits the whole programme including the previous form
        }
        public void Run()
        {
            question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
            timer.Start();
            if (frm2.Counter >= 1 && !frm2.Flag)
            //so that score isn't checked the very first time the tickbox or enter is used and so that it doesn't check score when trying to skip the correct or incorrect message.
            {
                CheckScore();
                frm2.Flag = true;//if the tickbox is being pressed to check the answer
                return;//to not refresh the values until the user has read if they got the answer correct or not
            }
            if (frm2.Counter == 10)//when all the questions have been asked, it shows the score and exits application
            {
                Exit();
            }
            if (frm2.Counter < 10)//to refresh the value on screen and update the progress, except the very last time when all questions are done
            {
                RefreshScreen();
                progress.Text = $"Question: {frm2.Counter + 1} / 10";//shows the progress
                frm2.Flag = false;
            }
            input.Clear();//to clear the text in the inputbox
            frm2.Counter++;//updates the counter for the number of time the TickBox has been pressed
        }

        public Form2() => InitializeComponent();//initializing this form

        private void input_TextChanged(object sender, EventArgs e) => answer = input.Text;//to keep account of the text entered

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();//so that the previous hidden form 1 closes along aswell

        private void tickBox_Click(object sender, EventArgs e) => Run();

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//to run the same code as tickbox when enter key pressed
            {
                e.SuppressKeyPress = true;//to suppress the system sound of pressing enter in a single lined text box
                Run();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        { 

            timeLeft.Text = $"Time left: {frm2.SecsLeft} secs";

            if (frm2.SecsLeft<= 0)
            {
                Exit();//exits the programme when the timer runs out
            }
            frm2.SecsLeft--;
        }
    }
}
