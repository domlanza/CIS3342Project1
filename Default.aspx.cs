using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342_Solution
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Background information reference variables
            txtFirstName.Text = Request["firstname"].ToString();
            txtLastName.Text = Request["lastname"].ToString();
            txtTUID.Text = Request["studentId"].ToString();
            txtClassName.Text = Request["courses"].ToString();

            //Capture all course and professor scores in an array of type double
            
            double[] feedbackScore = { Convert.ToDouble(Request["question1"]), Convert.ToDouble(Request["question2"]),Convert.ToDouble(Request["question3"]), Convert.ToDouble(Request["question4"]),
            Convert.ToDouble(Request["question5"]), Convert.ToDouble(Request["question6"]), Convert.ToDouble(Request["question7"]), Convert.ToDouble(Request["question8"]), Convert.ToDouble(Request["question9"]),
            Convert.ToDouble(Request["question10"]),Convert.ToDouble(Request["question11"]), Convert.ToDouble(Request["question12"]), Convert.ToDouble(Request["question13"]), Convert.ToDouble(Request["question14"]),
            Convert.ToDouble(Request["question15"]), Convert.ToDouble(Request["question16"]), Convert.ToDouble(Request["question17"]), Convert.ToDouble(Request["question18"]),
            Convert.ToDouble(Request["question19"]),  Convert.ToDouble(Request["question20"]) };
            //pass feedbackscore to display and grader
            display(feedbackScore);
            grader(feedbackScore);
        }
        //grading class to take in data and gives a score
        public void grader(double[] feedbackScore)
        {
            //delcare reference variables to store current scores
            double courseScore = 0;
            double professorScore = 0;

            //loop through each 12 course questions and increment to courseScore
            for (int i = 0; i < 12; i++) {
                courseScore += feedbackScore[i];
            }//end loop

            //average scores
            double averageCourseScore = ((courseScore / 60) * 100);

            //Check is course score is above 0
            if (courseScore != 0)
                txtCourseScore.Text = averageCourseScore.ToString() + "%";
            else
                txtCourseScore.Text = ("your value is null");

            //loop through each 8 professor questions and incremenet to professor score
            for (int j = 12; j < 20; j++) {
                professorScore += feedbackScore[j];
            }

            //Average professor score
            double averageProfessorScore = ((professorScore / 40) * 100);

            //Check if professor score is above 0
            if (professorScore != 0)
                txtProfessorScore.Text = averageProfessorScore.ToString() + "%";
            else
                txtProfessorScore.Text = ("your value is null");

            //Course Letter grade if and else statements
            if (averageCourseScore <= 50) {
                txtCourseLetterGrade.Text = ("F"); }
            else if (averageCourseScore <= 69) {
                txtCourseLetterGrade.Text = ("D"); }
            else if (averageCourseScore <= 79) {
                txtCourseLetterGrade.Text = ("C"); }
            else if (averageCourseScore <= 89) {
                txtCourseLetterGrade.Text = ("B"); }
            else if (averageCourseScore <= 97) {
                txtCourseLetterGrade.Text = ("A"); }
            else {
                txtCourseLetterGrade.Text = ("A+");
            }

            //Professor Letter grade if and else statements
            if (averageProfessorScore <= 50) {
                txtProfessorLetterGrade.Text = ("F"); }
            else if (averageProfessorScore <= 69) {
                txtProfessorLetterGrade.Text = ("D"); }
            else if (averageProfessorScore <= 79) {
                txtProfessorLetterGrade.Text = ("C"); }
            else if (averageProfessorScore <= 89) {
                txtProfessorLetterGrade.Text = ("B"); }
            else if (averageProfessorScore <= 97) {
                txtProfessorLetterGrade.Text = ("A"); }
            else {
                txtProfessorLetterGrade.Text = ("A+"); }
            } //end grading function

        public void display(double[] surveyScores)
        {
            //begining of try
            try {
                //Question number: start at 1
                int questionNum = 1;
                //Loop through each question and add questions to ListBox
                for (int i = 0; i <= 19; i++) { 
                       if (surveyScores[i] == 1)
                        QuestionReview.Items.Add("Question Number " + questionNum + ": " + "Strongly Disagree");
                    else if (surveyScores[i] == 2)
                        QuestionReview.Items.Add("Question Number " + questionNum + ": " + "Disagree");
                    else if (surveyScores[i] == 3)
                        QuestionReview.Items.Add("Question Number " + questionNum + ": " + "Netural");
                    else if (surveyScores[i] == 4)
                        QuestionReview.Items.Add("Question Number " + questionNum + ": " + "Agree");
                    else
                        QuestionReview.Items.Add("Question Number " + questionNum + ": " + "Strongly Agree");
                    questionNum++;
                }

                //error handlings
                if (QuestionReview.Text == "")
                    throw new Exception();

            }//end of try
            catch (Exception err)
            {
                Console.Write(err.Message, "error");
            }//end of try-catch
        }//end display function
    }
    }
