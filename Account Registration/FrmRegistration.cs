using Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    
    public partial class FrmRegistration : Form
    {
        
        DelegateText getFirstName, getLastName, getMiddleName, getAddress, getProgram;
        DelegateNumber getAge, getContactNo, getStudentNo;
        public FrmRegistration()
        {
            InitializeComponent();
            InitializeDelegates();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            InitializePixelFont();
            InitializeLabelBackColor();
        }

        private void InitializeLabelBackColor()
        {
            MakeLabelTransparentOverPictureBox(pictureBox, studentNumberLabel, programLabel, firstNameLabel, middleNameLabel, lastNameLabel, ageLabel, contactNumberLabel, addressLabel);
        }

        private void MakeLabelTransparentOverPictureBox(PictureBox pictureBox, params System.Windows.Forms.Label[] labels)
        {
            foreach(var label in labels){
                Point oldPos = label.PointToScreen(Point.Empty);
                label.Parent.Controls.Remove(label);
                pictureBox.Controls.Add(label);
                label.Location = pictureBox.PointToClient(oldPos);
                label.BackColor = Color.Transparent;
                label.BringToFront();
            } 
        }

        
        private void InitializeDelegates()
        {
            getLastName = new DelegateText(StudentInfoClass.GetLastName);
            getMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            getAddress = new DelegateText(StudentInfoClass.GetAddress);
            getProgram = new DelegateText(StudentInfoClass.GetProgram);
            getAge = new DelegateNumber(StudentInfoClass.GetAge);
            getContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            getStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void InitializePixelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontFilePath = Path.Combine(Application.StartupPath, "CustomFonts", "static", "PixelifySans-Regular.ttf");
            pfc.AddFontFile(fontFilePath);
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = getFirstName(firstNameTextBox.Text);
            StudentInfoClass.LastName = getLastName(lastNameTextBox.Text);
            StudentInfoClass.MiddleName = getMiddleName(middleNameTextBox.Text);
            StudentInfoClass.Address = getAddress(addressRichTextBox.Text);
            StudentInfoClass.Program = getProgram(programComboBox.Text);
            StudentInfoClass.Age = getAge(Convert.ToInt32(ageTextBox.Text));
            StudentInfoClass.ContactNo = getContactNo(Convert.ToInt64(contactNoTextBox.Text));
            StudentInfoClass.StudentNo = getStudentNo(Convert.ToInt64(studentNoTextBox.Text));

            FrmConfirm formConfirmation = new FrmConfirm(); //Initialize instance of FrmConfirm
            formConfirmation.Show();  //show FrmConfirm
        }
    }
}
