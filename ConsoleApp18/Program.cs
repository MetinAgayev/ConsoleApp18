using System;

namespace ConsoleApp18
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(31);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();


        }
    }
}