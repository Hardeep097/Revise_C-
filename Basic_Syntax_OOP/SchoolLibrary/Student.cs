using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels {Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.21f;
        }

        public override string SendMesage(string message)
        {
            var originalMessage =  base.SendMesage(message);
            var sb = new StringBuilder(originalMessage);
            sb.AppendLine("This is private message");
            return sb.ToString();
        }
    }
}
