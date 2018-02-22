using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
            /*
            List<Student> students = new List<Student>
            {
                new Student { Name= "James Knorr", StudentId= 1001, },
                new Student { Name= "Sarah G", StudentId= 1002 },
                new Student { Name= "Ethan K", StudentId= 1003 },
                new Student { Name= "Lambeau F", StudentId= 1004 }
            };*/

            var result = "";

            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId= 001, Name= "Playbooks", Students = new List<Student>()
                { new Student { Name= "James Knorr", StudentId= 1001 },
                  new Student { Name= "Sarah G", StudentId= 1002 } } },

                new Course() { CourseId= 002, Name= "Coaching", Students= new List<Student>()
                { new Student {Name= "Ethan K", StudentId= 1003 },
                  new Student {Name= "Lambeau F", StudentId= 1004 } } },

                new Course() { CourseId= 003, Name= "Drills", Students= new List<Student>()
                { new Student {Name= "Mary Beth", StudentId= 1005 },
                  new Student {Name= "Fred L", StudentId= 1006 } } }
            };

            foreach (Course course in courses)
            {
                result += string.Format("{0} - {1}<br />", course.CourseId, course.Name);
                foreach (Student student in course.Students)
                {
                    result += string.Format("&nbsp;&nbsp;Student name - {0}, ID {1}<br />", student.Name, student.StudentId);
                }
            }

            resultLabel.Text = result;

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1001, new Student() { Name= "Jay Knorr", StudentId= 1001, Courses= new List<Course>()
                { new Course { Name= "Coaching", CourseId= 101 },
                { new Course {Name= "Parenting", CourseId= 401 }}}}},

                { 1002, new Student() { Name= "Sarah Mac", StudentId= 1002, Courses= new List<Course>()
                { new Course {Name= "Play time", CourseId= 151 },
                { new Course {Name= "Tech of Relaxation", CourseId= 103 }}}}},

                { 1003, new Student() { Name= "Big E", StudentId= 1003, Courses= new List<Course>()
                { new Course {Name= "Napping", CourseId= 101 },
                    {new Course {Name= "Feeding", CourseId= 105 }}}}}
            };

            foreach (var student in students)
            {
                resultLabel.Text += string.Format("Student Name: {0}<br />Student ID: {1}<br />", student.Value.Name, student.Key);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += string.Format("&nbsp;&nbsp;Course: {0} - {1}<br />", course.Name, course.CourseId);
                }
            }

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */


            Student student1 = new Student()
            {
                Name = "Willy Jay", StudentId = 1, Enrollments = new List<Enrollment>(){
                new Enrollment() { Course = new Course() { Name = "Tennis", CourseId = 101 }, Grade= 99 },
                new Enrollment() { Course= new Course() { Name= "Swimming", CourseId= 103 }, Grade= 85 }}
            };

            Student student2 = new Student() {Name="James Ryan",StudentId=2, Enrollments = new List<Enrollment>(){
                new Enrollment() { Course = new Course() { Name = "Coaching", CourseId = 401 }, Grade= 100 },
                new Enrollment() { Course= new Course() { Name= "Motivation", CourseId= 503 }, Grade= 91 }}
            };

            List<Student> students = new List<Student>() { student1, student2 };
            
            /*Course course1 = new Course() { Name = "Tennis", CourseId = 101 };
            Course course2 = new Course() { Name = "Swimming", CourseId = 103 };
            Course course3 = new Course() { Name = "Coaching", CourseId = 404 };
            Course course4 = new Course() { Name = "Motivation", CourseId = 303 };
            */
            //List<Course> courses = new List<Course>() { course1, course2, course3, course4 };
            
            List<Enrollment> enrollments = new List<Enrollment>()
            {
                new Enrollment() { Student= student1},
                //new Enrollment() { Student= student1, Course= course2, Grade= 88 },
                new Enrollment() { Student= student2}
                //new Enrollment() { Student= student2, Course= course4, Grade= 92 }
            };

            foreach (var student in students)
            {
                resultLabel.Text += string.Format("Student: {0} ID - {1}<br />", 
                    student.Name,student.StudentId);
                foreach (var enrollment in student.Enrollments)
                {
                    resultLabel.Text += string.Format("&nbsp;&nbsp;Course: {0} {1} Grade: {2}<br />",
                        enrollment.Course.Name, enrollment.Course.CourseId,enrollment.Grade);
                }
            }
        }
    }
}