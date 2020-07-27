using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  ID
 *      Name Retrieval App, Kaleb Ehlert, 1/21/18
 *  Purpose
 *      The purpose of the program is to take the input of the user's name and output it into a label component.
 *  Form Controls
 *      Submission: Sumbit button, Name_Label: Label to identify name field, TextBox_Name: Textbox used to hold the input of the user, Label_Result: Used 
 *          to display the retrieved data submission.
 *  Code & Logic
 *      The name of the user is need for input.
 *      The processing is taking the name of the user and inserting that text into the message wanted for display after Submission is clicked.
 *      The output is the message, "Congratualtions, insert name, you retrieved the data".
 */

namespace EhlertProgram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Handles the event of the submission button being click processing the message intended to be displayed.
        private void Submission_Click(object sender, EventArgs e)
        {
            // Retrieve the text of textBox1 and combine with the congratulations message
            string text = "Congratulations, " + TextBox_Name.Text + ", you retrieved the data";

            // Set the Congratulations message in the bottom label
            Label_Result.Text = text;
        }

        // Handles the change of text in the textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
