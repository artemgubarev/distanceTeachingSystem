using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DistanceTeachingSystem
{
    public partial class LoginForm : Form
    {
        DistanceTeaching distanceTeaching;
       
        const string datFile = "data.dat";

        // бинарная десериализация 
        private void BinaryDeserializble(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                this.distanceTeaching = (DistanceTeaching)formatter.Deserialize(fs);             
            }
        }

        public LoginForm()
        {
            InitializeComponent();

            if (File.Exists(datFile))
                BinaryDeserializble(datFile);
            else this.distanceTeaching = new DistanceTeaching();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            labelLoginFailed.Visible = false;
            labelNameFailed.Visible = false;
            labelPasswordFailed.Visible = false;
            labelRepeatPasswordFailed.Visible = false;
            labelRegistrationFailed.Visible = false;
        }

        // регистрация пользователя
        private void RegistrationUser(User user)
        {
            // попытка ввести имя
            try
            {
                user.Name = txtBoxRegistrationName.Text;
                labelNameFailed.Visible = false;
            }
            catch(Exception) { labelNameFailed.Visible = true; }

            // если пароль и повторный пароль совпадают
            if (txtBoxRegistrationPassword.Text == txtBoxRepeatPassword.Text)
            {
                labelRepeatPasswordFailed.Visible = false;

                try
                {
                    user.Password = txtBoxRegistrationPassword.Text;
                    
                    if(IsRegistered(user))
                    {
                        labelRegistrationFailed.Visible = true;
                    }
                    else
                    {
                        OpenFormForUser(user);
                        labelRegistrationFailed.Visible = false;
                    }

                    labelPasswordFailed.Visible = false;
                }
                catch (ArgumentException ex)
                {
                    labelPasswordFailed.Text = ex.Message;
                    labelPasswordFailed.Visible = true;
                }
            }
            else labelRepeatPasswordFailed.Visible = true;         
        }

        // зарегестрирован ли пользователь
        private bool IsRegistered(User user)
        {
            foreach(User userdata in this.distanceTeaching.Users)
            {
                if (userdata.Name == user.Name && userdata.Password == user.Password)
                    return true;
            }
            return false;
        }

        // открыть форму для пользователя
        private void OpenFormForUser(User user)
        {
            if (user.GetType() == typeof(Teacher))
            {
                FormTeacher formTeacher = new FormTeacher(this.distanceTeaching, user);
                formTeacher.Show();

                Hide();
            }
            else if (user.GetType() == typeof(Student))
            {
                FormStudent formStudent = new FormStudent(this.distanceTeaching, user);
                formStudent.Show();

                Hide();
            }
        }

        private void LoginUser()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User found = this.distanceTeaching.Users.Find(u => u.Name == txtBoxLoginName.Text &&
            u.Password == txtBoxLoginPassword.Text);

            if(found == null)
            {
                labelLoginFailed.Visible = true;          
            }
            else
            {    
                OpenFormForUser(found);
                labelLoginFailed.Visible = false;
            }
        }

        //User user;

        private void btnRegistrationAsTeaher_Click(object sender, EventArgs e)
        {
            User teacher = new Teacher();           

            RegistrationUser(teacher);
        }

        private void btnRegistrationAsStudent_Click(object sender, EventArgs e)
        {
            User student = new Student();
            RegistrationUser(student);
        }
    }
}
