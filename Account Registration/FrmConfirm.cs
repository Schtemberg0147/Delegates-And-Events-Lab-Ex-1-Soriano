using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegates;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            InitializeDelegates();
        }
        private void InitializeDelegates()
        {
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            InitilizeValues();
        }
        private void InitilizeValues()
        {
            programValue.Text = DelProgram(StudentInfoClass.Program);
            lastNameValue.Text = DelLastName(StudentInfoClass.LastName);
            firstNameValue.Text = DelFirstName(StudentInfoClass.FirstName);
            middleNameValue.Text = DelMiddleName(StudentInfoClass.MiddleName);
            addressValue.Text = DelAddress(StudentInfoClass.Address);
            ageValue.Text = DelNumAge(StudentInfoClass.Age).ToString();
            contactNoValue.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            studentNoValue.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        }   
    }
}
