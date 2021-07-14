using HW07_01.models;
using System;

namespace HW07_01
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person1 = new();
            person1.SayHello();

            Student student1 = new();
            student1.Age = student1.SetAge(21);
            student1.SayHello();
            student1.ShowAge();

            Teacher teacher1 = new();
            teacher1.Age = teacher1.SetAge(30);
            teacher1.SayHello();
            teacher1.Explain();
        }
    }
}
