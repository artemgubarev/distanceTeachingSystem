using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DistanceTeachingSystem
{
    public partial class FormStudent : Form
    {
        DistanceTeaching distanceTeaching;
        Student student;
        //User user;

        const string datFile = "data.dat";

        public FormStudent(DistanceTeaching distanceTeaching, User user)
        {
            this.distanceTeaching = distanceTeaching;
             this.student = (Student)user;
           // this.user = user;

            InitializeComponent();
        }

        // загрузка формы
        private void FormStudent_Load(object sender, EventArgs e)
        {
            // дисциплины
            listViewDisciplines.View = View.Details;
            listViewDisciplines.Columns.Add("Название дисциплины", 200);

            // ListView статистика
            listViewStatistic.View = View.Details;
            listViewStatistic.Columns.Add("Название дисциплины", 200);
            listViewStatistic.Columns.Add("Количество баллов", 200);

            listViewStatistic.Visible = false;


            // показать дисциплины
            foreach (Discipline discipline in this.distanceTeaching.Disciplines)
            {
                if (discipline.UsersId.Exists(id => id == this.student.Id))
                {
                    listViewDisciplines.Items.Add(discipline.Title);
                }
                else continue;
            }

            ShowStatistic();
        }

        //---------------- кнопки ----------------

        // выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            User found = this.distanceTeaching.Users.Find(u => u.Id == this.student.Id);

            if (found != null)
                found = this.student;
            else this.distanceTeaching.Users.Add(this.student);

            // сериализация
            BinarySerializble(datFile);

            // закрыть приложение
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        //перейти к дисциплине
        private void btnSelectDiscipline_Click(object sender, EventArgs e)
        {
            // если выбрана хоть одна дисциплина
            if (listViewDisciplines.SelectedItems.Count == 1)
            {
                {
                    using (var form = new FormDisciplineForStudent(this.distanceTeaching, this.student, listViewDisciplines.SelectedItems[0].SubItems[0].Text))
                    {
                        var result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            this.distanceTeaching = form.DistanceTeaching;
                        }
                    }
                }
            }
        }

        private void ShowStatistic()
        {
            listViewStatistic.Visible = true;

            // Student student = (Student)this.distanceTeaching.Users.Find(u => u.Id == this.student.Id);

           // Student student = (Student)this.user;

            foreach (KeyValuePair<string, double> gradeList in student.GradeList)
            {
                listViewStatistic.Items.Add(new ListViewItem(new string[] { gradeList.Key, gradeList.Value.ToString() }));
            }
        }

        

        //---------------- сериализация данных ----------------

        // бинарная сериализация
        private void BinarySerializble(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this.distanceTeaching);
            }
        }

        private void listViewStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
