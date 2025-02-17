﻿/*
This programme is a Multiple Choice Questions quiz
Define this form as an object calleed frm1 for the frm class()
When Form Loads()
    Hide options
Refresh Screen Method()
    Option 1 = frm.MaoriWords[Call Unique Random Number method from frm class(max value:49)]
    Option 2 = frm.MaoriWords[Call Unique Random Number method from frm class(max value:49)]
    Option 3 = frm.MaoriWords[Call Unique Random Number method from frm class(max value:49)]
    Meaning = Meaning of Option 1, Option 2 or Option 3
Check Score Method()
    If option Number chosen is equal to option used by meaning:
        Score + 1
        Display "Correct Answer"
    Else
        Display the right answer
if tickBox pressed:
    if first time being pressed
        Show all options
    Call refresh method()
    Call check score method()
    Uncheck all the boxes
    if pressed 10 times:
        Call Exit Method()
    Update Progress Label
Timer Event()
    If 50 seconds passed;
        Call Exit Method()
Exit Method()
    Show score 
    Open Form2
if close button pressed:
    Exit the whole programme
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
        Frm frm1 = new Frm(60, 0, 0, 0, 0, new int[30], new int[3]);//made frm1 an object within the frm clasa which contains all values that this form will use
        Random rnd = new Random();

        public Form1() => InitializeComponent();//initializing this form
        private void Form1_Load(object sender, EventArgs e)//hide all the options at the intro screen
        {
            option1.Hide();
            option2.Hide();
            option3.Hide();
        }

        private void option1_CheckedChanged(object sender, EventArgs e) => frm1.OptionNumber = 1;//when option 1 is pressed
        private void option2_CheckedChanged(object sender, EventArgs e) => frm1.OptionNumber = 2;//when option 2 is pressed
        private void option3_CheckedChanged(object sender, EventArgs e) => frm1.OptionNumber = 3;//when option 3 is pressed

        public void RefreshScreen()//method made to refresh all the values on screen
        {
            frm1.OptionIndex[0] = frm1.UniqueRnd(49);
            frm1.OptionIndex[1] = frm1.UniqueRnd(49);
            frm1.OptionIndex[2] = frm1.UniqueRnd(49);
            //stores a random index for each option in the optionIndex array
            frm1.MeaningIndex = rnd.Next(3);
            engWord.Text = Frm.Meaning[frm1.OptionIndex[frm1.MeaningIndex]];//chooses a random index from the any of the index the options are using
            option1.Text = Frm.MaoriWords[frm1.OptionIndex[0]];
            option2.Text = Frm.MaoriWords[frm1.OptionIndex[1]];
            option3.Text = Frm.MaoriWords[frm1.OptionIndex[2]];
            engWord.ForeColor = Color.White;
            question.Text = "Choose the word with the same meaning. Press the checkbox to continue.";
        }

        public void CheckScore()//method to check whether the user got the question correct or not
        {
            timer.Stop();//to stop the timer while the user reads if they got the answer right or not
            option1.Enabled = false;
            option2.Enabled = false;
            option3.Enabled = false;
            if (frm1.OptionNumber-1 == frm1.MeaningIndex && frm1.OptionNumber != 0)//just to confirm that a score isn't added if no options are selected
            { 
                frm1.Score++;
                engWord.ForeColor = Color.LightGreen;
                engWord.Text = "Correct Answer!";//to let the user know if they got the answer correct
            }
            //if the option number chosen is the same as the option's meaning that was displayed then add one to the score
            else
            {
                engWord.ForeColor = Color.LightSalmon;
                engWord.Text = $"Incorrect answer! Correct answer was: {Frm.MaoriWords[frm1.OptionIndex[frm1.MeaningIndex]]}";
            }   // just to let the user know that they got it uncorrect and what the real answer is
            question.Text = "Press checkbox to continue";

        }   


        private void tickBox_Click(object sender, EventArgs e)//Event for when tick box is clicked
        {    
            timer.Start();//to start the time when tick box is pressed
            if (frm1.Counter == 0)
            {
                option1.Show();
                option2.Show();
                option3.Show();
            }
           

            if (frm1.Counter >= 1 && !frm1.Flag)
            //so that score isn't checked the very first time the tickbox is clicked and so that it doesn't check score when trying to skip the correct or incorrect message.
            {
                CheckScore();
                frm1.Flag = true;//if the tickbox is being pressed to check the answer
                return;//to not refresh the values until the user has read if they got the answer correct or not
            }
            

            if (frm1.Counter < 10)//to refresh the values on screen, except the very last time when all questions are done
            {   
                RefreshScreen();
                progress.Text = $"Question: {frm1.Counter + 1} / 10";
                option1.Enabled = true;
                option2.Enabled = true;
                option3.Enabled = true;
                option1.Checked = false;
                option2.Checked = false;
                option3.Checked = false;
                //for all the options checked to reset each time
                frm1.OptionNumber = 0;
                frm1.Flag = false;
            }

            if (frm1.Counter == 10)//when all the questions have been asked, it Exits
            {
                Exit();
            }

            frm1.Counter++;//updates the counter for the number of time the TickBox has been pressed
        }

        private void timer_Tick(object sender, EventArgs e)//event that runs repeatedly at an interval of 1 second
        {   
            timeLeft.Text = $"Time left: {frm1.SecsLeft} seconds";
           
            if (frm1.SecsLeft <= 0)
            {
                Exit();//if they run out of time the programme exits automatically
            }

            frm1.SecsLeft--;
        }
        public void Exit()//A method to exit the programme
        {
            timer.Stop();
            if (frm1.Score == 10)
            {
                MessageBox.Show("👏Wow! 🎊 You got all correct!🎉,  Level 2 will now begin", "Congratulations!");//opens a box to show text
            }
            else
            {
                MessageBox.Show($"You got {frm1.Score} out of 10, Level 2 will now begin", "Congratulations");//opens a box to show text
            }
            this.Hide();//hides the current for when the new form opens
            Form2 form = new Form2();
            form.Show();//opens new form
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();//so that the previous hidden form 1 closes along aswell
    }
}
