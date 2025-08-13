using Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            InitializePixelFont();
            InitializeDelegates();
            confirmationLabel.Font = new Font(confirmationLabel.Font.FontFamily, 18, FontStyle.Bold);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitializePixelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontFilePath = Path.Combine(Application.StartupPath, "CustomFonts", "static", "PixelifySans-Regular.ttf");
            pfc.AddFontFile(fontFilePath);
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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
            studentNoValue.Text = $"0{DelStudNo(StudentInfoClass.StudentNo).ToString()}";

            InitializePixelFont(); //Reapply custom font
        }   
    }
}
