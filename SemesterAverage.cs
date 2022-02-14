/* Author: Stevenson Suhardy
 * Date Created: February 11, 2022
 * App name: Semester Average
 * App description: This app allows the user to calculate the average of their grade and displaying the letter grade
 * of the grade.
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

namespace SemesterAverage
{
    public partial class formSemesterAverage : Form
    {
        #region "Array Declarations"
        // Declaring 2 arrays, one for the input textbox and the other one for the output labels
        TextBox[] inputTextBoxArray;
        Label[] outputLabelArray;
        #endregion

        #region "Event Handlers"
        public formSemesterAverage()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When the form loads, 2 arrays for the textboxes and the output labels will be created and then the form
        /// will be reset to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSemesterAverage_Load(object sender, EventArgs e)
        {
            // Inputting all of the input textbox into the inputTextBoxArray array
            inputTextBoxArray = new TextBox[] {
                textBoxCourse1, textBoxCourse2, textBoxCourse3, textBoxCourse4, textBoxCourse5, textBoxCourse6,
                textBoxCourse7
            };
            // Inputting all of the output label into the outputLabelArray array
            outputLabelArray = new Label[]
            {
                labelCourse1Output, labelCourse2Output, labelCourse3Output, labelCourse4Output, labelCourse5Output,
                labelCourse6Output, labelCourse7Output, labelSemesterOutput, labelSemesterLetterGrade, labelOutput
            };
            // Reset the form when the form loads in
            ResetForm();
        }
        /// <summary>
        /// This event handler will occur when the user leaves a textbox. It will clear the error messages, and loop
        /// through the array, then for each textbox in the array, validate the textbox and then if it is valid,
        /// display the letter grade using the LetterGrade function in the output label on the same index as the
        /// input textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCourse_Leave(object sender, EventArgs e)
        {
            // Clearing the error messages
            labelOutput.Text = String.Empty;
            // Looping through the inputTextBoxArray
            for (int index = 0; index < inputTextBoxArray.Length; index++)
            {
                // Validating the text inside each textbox
                if (ValidateTextBox(inputTextBoxArray[index]))
                {
                    // Changing the output label of the current index into the letter grade of the grade using the
                    // LetterGrade function.
                    outputLabelArray[index].Text = LetterGrade(int.Parse(inputTextBoxArray[index].Text));
                    // Enable the calculate button once the input is fixed
                    buttonCalculate.Enabled = true;
                }
            }
        }
        /// <summary>
        /// This event handler will occur when the calculate button or the enter button is clicked. It will calculate
        /// the number of valid textboxes, blanktextboxes, the grade total of the user's input and the average of
        /// the grade totat and then displaying it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Declaring variables
            int validTextBoxes = 0;
            int blankTextBoxes = 0;
            double totalGrade = 0;
            double averageGrade = 0;

            // Looping through the array using foreach
            foreach (TextBox textBoxChecking in inputTextBoxArray)
            {
                // Validating text in each textbox
                if (ValidateTextBox(textBoxChecking))
                {
                    // Incrementing the validTextBoxes by 1 when a textbox is deemed to be valid
                    validTextBoxes++;
                    // Converting the text into a double then adding it to the totalGrade variable
                    totalGrade += double.Parse(textBoxChecking.Text);
                }
                // In case when the textbox is empty
                else if (String.IsNullOrEmpty(textBoxChecking.Text))
                {
                    // Increment the blankTextBoxes by 1 when a textbox is empty
                    blankTextBoxes++;
                }
            }
            // Checking to see if there are any invalid textboxes
            if (validTextBoxes + blankTextBoxes < inputTextBoxArray.Length)
            {
                // If there are, then disable the calculate button
                buttonCalculate.Enabled = false;
            }
            // Checking to see if every textbox is empty
            else if (blankTextBoxes == inputTextBoxArray.Length)
            {
                buttonCalculate.Enabled = false;
                labelOutput.Text = "Fill at minimum 1 textbox in order to calculate the average grade";
            }
            // When everything is valid
            else
            {
                // Enabling the calculate button
                buttonCalculate.Enabled = true;
                // Clearing the error messages
                labelOutput.Text = string.Empty;
                // Calculating the average grade and rounding the result to 0 decimals
                averageGrade = Math.Round(totalGrade / (inputTextBoxArray.Length - blankTextBoxes), 2);
                // Converting the average to a string and displaying it in the semester label
                labelSemesterOutput.Text = averageGrade.ToString();
                // Displaying the letter grade of the grade by using the LetterGrade function
                labelSemesterLetterGrade.Text = LetterGrade(averageGrade);
                // Disabling the Calculate button to prevent any further calculationsd
                buttonCalculate.Enabled = false;
                // Disabling all the textboxes until the reset button is clicked
                SetControlsEnabled(inputTextBoxArray, false);
            }
            
        }    
        /// <summary>
        /// Resetting the form to the default state when the reset button or escape button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        /// <summary>
        /// Closing the application when the user clicks the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Functions"
        /// <summary>
        /// The ValidateTextBox function is used to validate the text inside the textbox to check if it is numeric.
        /// It will also check if it is inside the valid range which is 0 and 100 inclusive and see if the textbox is
        /// blank. Except for when there is a blank textbox, display an error message on the output label when isValid
        /// is false.
        /// </summary>
        /// <param name="textBoxInput"></param>
        /// <returns></returns>
        private bool ValidateTextBox(TextBox textBoxInput)
        {
            // Variable Declaration
            const int MinimumGrade = 0;
            const int MaximumGrade = 100;
            int grade = 0;
            bool isValid = false;
            // Checking to see if the grade is numeric and if it is, convert it into an integer
            if (int.TryParse(textBoxInput.Text, out grade))
            {
                // Checking to see if the grade is between 0 and 100 inclusive.
                if (grade >= MinimumGrade && grade <= MaximumGrade)
                {
                    // Changing isValid to true when everything is valid.
                    isValid = true;
                }
                // When the grade is outside the range, set isValid to false and display the following error message
                // and change the focus to the textbox with the error.
                else
                {
                    isValid = false;
                    labelOutput.Text += String.Format("The input '{0}' is invalid. The input must be between 0 to 100\r\n", textBoxInput.Text);
                    textBoxInput.Focus();
                }
            }
            // When the textbox is empty, do not print any error message, but set the isValid to false
            else if (String.IsNullOrEmpty(textBoxInput.Text))
            {
                isValid = false;
            }
            // If the text is not numeric, set isValid to false display the following error message and change focus
            // to the textbox with the error
            else
            {
                isValid = false;
                labelOutput.Text += String.Format("The input '{0}' is invalid. The input must be numerical or decimal\r\n", textBoxInput.Text);
                textBoxInput.Focus();
            }
            return isValid;
        }
        /// <summary>
        /// Clearing all the text inside the control array, whether it is a textbox array or label array
        /// </summary>
        /// <param name="controlArray"></param>
        private void ClearControls(Control[] controlArray)
        {
            // Loop through the array
            foreach (Control controlToClear in controlArray)
            {
                // Clear all the text inside the control
                controlToClear.Text = String.Empty;
            }
        }
        /// <summary>
        /// Enables or disables controls inside the array (can be a textbox array)
        /// </summary>
        /// <param name="controlArray"></param>
        /// <param name="enabledStatus"></param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            // Loop through the array
            foreach (Control controlToSet in controlArray)
            {
                // Set the enabled to true or false based on the parameter that the user inputs
                controlToSet.Enabled = enabledStatus;
            }
        }
        /// <summary>
        /// Resets the form to it's original state
        /// </summary>
        private void ResetForm()
        {
            // Clears all of the textboxes
            ClearControls(inputTextBoxArray);
            // Clears all labels on the form
            ClearControls(outputLabelArray);
            // Enabling all of the textboxes
            SetControlsEnabled(inputTextBoxArray, true);
            // Enabling the Calculate Button
            buttonCalculate.Enabled = true;
            // Changing the Focus to the first textbox
            textBoxCourse1.Focus();
        }
        /// <summary>
        /// The LetterGrade function will return the letter grade of a grade that is inputted by the user.
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        private string LetterGrade(double grade)
        {
            // Declaring 2 arrays for the minimum grade of each letter grade and the letter grade itself
            int[] gradeArray = { 0, 50, 52, 58, 60, 62, 68, 70, 72, 78, 80, 82, 90 };
            string[] letterGradeArray = { "F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+",
                "A-", "A", "A+" };
            // Declaring a string variable to hold the letter grade
            string letterGrade = "";

            // Looping through the array
            for (int index = 0; index < gradeArray.Length; index++)
            {
                /* When the grade is larger than the minimum grade of a letter grade, store the value of the current
                index in the letterGradeArray and then proceed on looping through the array
                 */
                if (grade >= gradeArray[index])
                {
                    letterGrade = letterGradeArray[index];
                }
                // When the grade is lower than the grade of the current index in gradeArray, then return the
                // letter grade value stored in the letterGrade variable
                else
                {
                    return letterGrade;
                }
            }
            // Returning the letterGrade value when the loop is finished
            return letterGrade;
        }
        #endregion
    }
}
