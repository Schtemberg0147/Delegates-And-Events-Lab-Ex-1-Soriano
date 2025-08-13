using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);
        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        //Just for convenience in inserting items in the combobox
        public static string[] AddPrograms = {"BSIT", "BSCS", "BSCPE", "BSIS", "BSBA", "BSA", "BSED"};

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
