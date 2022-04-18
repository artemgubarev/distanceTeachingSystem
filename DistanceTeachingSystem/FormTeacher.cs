using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace DistanceTeachingSystem
{
    public partial class FormTeacher : Form
    {
        DistanceTeaching distanceTeaching;
        Teacher teacher;

        YandexDisk yandexDisk;

        const string datFile = "data.dat";

        public FormTeacher(DistanceTeaching distanceTeaching, User user)
        {
            this.distanceTeaching = distanceTeaching;
            this.teacher = (Teacher)user;

            InitializeComponent();

            yandexDisk = new YandexDisk();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            listViewDisciplines.View = View.Details;
            listViewDisciplines.Columns.Add("Название дисциплины", 200);

            // показать ведомость
            listViewStatement.View = View.Details;
            listViewStatement.Columns.Add("Имя студента", 200);
            listViewStatement.Columns.Add("Количество баллов", 200);

            listViewStatement.Visible = false;

            // показать дисциплины
            foreach (Discipline discipline in this.distanceTeaching.Disciplines)
            {
                if (discipline.UsersId.Exists(id => id == this.teacher.Id))
                {
                    listViewDisciplines.Items.Add(discipline.Title);
                }
                else continue;
            }

            labelCreateDisciplineFailed.Visible = false; 
        }

        // --------------------сериализация данных----------
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
       
        // -----------------Кнопки-----------------

        // создать дисциплину
        private async void btnCreateDiscipline_Click(object sender, EventArgs e)
        {
            string disciplineTitle = txtBoxDisciplineTitle.Text;
            txtBoxDisciplineTitle.Clear();

            // если дисциплины с таким именем еще нет
            if (!this.distanceTeaching.Disciplines.Exists(d => d.Title == disciplineTitle))
            {
                try
                {
                    Discipline discipline = new Discipline(disciplineTitle);
                    //id преподавателя
                    discipline.UsersId.Add(this.teacher.Id);

                    listViewDisciplines.Items.Add(disciplineTitle);
                    this.distanceTeaching.Disciplines.Add(discipline);

                    labelCreateDisciplineFailed.Visible = false;

                    // создать директорию на диске
                    await Task.Run(() => yandexDisk.CreateDirectory(disciplineTitle));
                }
                catch(Exception)
                {
                    labelCreateDisciplineFailed.Visible = true;
                }

            }
            else MessageBox.Show("Дисциплина с таким названием уже существует!");
        }

        // удалить дисциплину
        private async void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in listViewDisciplines.SelectedItems)
            {
                listViewDisciplines.Items.Remove(listViewItem);

                Discipline discipline = this.distanceTeaching.Disciplines.Find(s => s.Title.Equals(listViewItem.SubItems[0].Text));

                this.distanceTeaching.Disciplines.Remove(discipline);

                await Task.Run(() => yandexDisk.DeleteDirectory(discipline.Title));
            }
        }

        // выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.distanceTeaching.Users.Add(this.teacher);

            int index = this.distanceTeaching.Users.IndexOf(this.distanceTeaching.Users.Where(n => n.Id == this.teacher.Id).FirstOrDefault());

            if (index >= 0)
                this.distanceTeaching.Users[index] = this.teacher;
            else this.distanceTeaching.Users.Add(this.teacher);

            // сериализация объекта
            // xmlSerialized(xmlFile);
            BinarySerializble(datFile);

            // закрыть приложение
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        // перейти к дисциплине
        private void btnSelectDiscipline_Click(object sender, EventArgs e)
        {
            // если выбрана хоть одна дисциплина
            if (listViewDisciplines.SelectedItems.Count == 1)
            {
                {
                    using (var form = new FormDiscipline(this.distanceTeaching,this.teacher, listViewDisciplines.SelectedItems[0].SubItems[0].Text))
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

        // показать ведомость
        private void btnShowStatement_Click(object sender, EventArgs e)
        {
            if (listViewDisciplines.SelectedItems.Count == 1)
            {
                listViewStatement.Visible = true;
                listViewStatement.Items.Clear();

                string disciplineTitle = listViewDisciplines.SelectedItems[0].SubItems[0].Text;

                Discipline discipline = this.distanceTeaching.Disciplines.Find(d => d.Title == disciplineTitle);

                foreach (Guid studentId in discipline.UsersId)
                {
                    User userData = this.distanceTeaching.Users.Find(u => u.Id == studentId);

                    if (userData.GetType() == typeof(Student))
                    {
                        Student student = (Student)userData;

                        double grade = student.GradeList.Where(g => g.Key == disciplineTitle).FirstOrDefault().Value;

                        ListViewItem listViewItem = new ListViewItem(new string[] { student.Name, grade.ToString() });

                        listViewStatement.Items.Add(listViewItem);
                    }
                }
            }
        }

    }
}
