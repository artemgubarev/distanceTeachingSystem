using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTeachingSystem
{
    public partial class FormDiscipline : Form
    {
        YandexDisk yandexDisk;
        Teacher teacher;

        const string ExercisesPath = "Exercises";
        const string MaterialsPath = "Materials";

        public FormDiscipline(DistanceTeaching DistanceTeaching,Teacher teacher, string disciplineTitle)
        {
            InitializeComponent();

            this.DistanceTeaching = DistanceTeaching;
            this.disciplineTitle = disciplineTitle;
            this.teacher = teacher;

            yandexDisk = new YandexDisk();

            labelRateExerciseFailed.Visible = false;
        }

        public DistanceTeaching DistanceTeaching { get; set; }
        string disciplineTitle;

        private async void FormDiscipline_Load(object sender, EventArgs e)
        {
            // comboBox
            comboBoxActions.Items.Add("Материалы дисциплины");
            comboBoxActions.Items.Add("Проверка и оценка работ");
            comboBoxActions.Items.Add("Студенты");
           // comboBoxActions.SelectedText = "Действия";
            comboBoxActions.SelectedItem = comboBoxActions.Items[0];
            //comboBoxActions.Visible = false;

            // Listview Материалы
            listViewMaterials.View = View.Details;

            listViewMaterials.Columns.Add("Файл", 200);
            listViewMaterials.Columns.Add("Дата Добавления", 200);
            listViewMaterials.Columns.Add("Размер", 200);

            listViewMaterials.Name = "listViewMaterials";

            // Listview студенты
            listViewCommonList.View = View.Details;

            listViewCommonList.Columns.Add("Имя", 200);
            listViewCommonList.Columns.Add("Id", 200);

            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Имя", 200);
            listViewStudents.Columns.Add("Id", 200);

            // Listview Задания
            listViewExercises.View = View.Details;

            listViewExercises.Columns.Add("Файл", 200);
            listViewExercises.Columns.Add("Дата добавления", 200);
            listViewExercises.Columns.Add("Имя студента", 200);
            listViewExercises.Columns.Add("Оценка", 200);

            listViewExercises.Name = "listViewExercises";

            ElementVisibilityForStudents(false);
            ElementVisibilityForMaterials(true);
            ElementVisibilityForExercises(false);

            await Task.Run(() => yandexDisk.ShowFiles(disciplineTitle, ExercisesPath, listViewExercises, teacher, DistanceTeaching));
            await Task.Run(() => yandexDisk.ShowFiles(disciplineTitle, MaterialsPath, listViewMaterials, teacher, DistanceTeaching));
        }

        // ----------Кнопки-------------

        // добавить студента в дисциплину
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Discipline found = this.DistanceTeaching.Disciplines.Find(d => d.Title == disciplineTitle);

            foreach (ListViewItem item in listViewCommonList.SelectedItems)
            {
                Guid studId = Guid.Parse(item.SubItems[1].Text);

                // если студента нет в списке добавляем его
                if (!found.UsersId.Exists(id => id == studId))
                {
                    found.UsersId.Add(studId);
                    listViewStudents.Items.Add(new ListViewItem(new string[] { item.SubItems[0].Text, item.SubItems[1].Text }));

                    Student student = (Student)this.DistanceTeaching.Users.Find(u => u.Id == studId);

                    student.GradeList.Add(disciplineTitle,0.0);
                }
                else continue;
            }
        }

        // удалить студента из дисциплины
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Discipline found = this.DistanceTeaching.Disciplines.Find(d => d.Title == disciplineTitle);

            foreach (ListViewItem item in listViewStudents.SelectedItems)
            {
                found.UsersId.Remove(Guid.Parse(item.SubItems[1].Text));
                listViewStudents.Items.Remove(item);
            }
        }

        // выбор действия над дисциплиной
        private void comboBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Discipline found = this.DistanceTeaching.Disciplines.Find(d => d.Title == disciplineTitle);

            switch (comboBoxActions.SelectedIndex)
            {
                // материалы дисциплины
                case 0:
                    // Показать/скрыть элементы
                    ElementVisibilityForMaterials(true);
                    ElementVisibilityForStudents(false);
                    ElementVisibilityForExercises(false);
                    break;

                case 1:
                    // Показать/скрыть элементы
                    ElementVisibilityForMaterials(false);
                    ElementVisibilityForStudents(false);
                    ElementVisibilityForExercises(true);
                    break;

                // Добаление удаление студентов
                case 2:
                    // Показать/скрыть элементы
                    ElementVisibilityForMaterials(false);
                    ElementVisibilityForStudents(true);
                    ElementVisibilityForExercises(false);

                    // заполнить общий список студентов
                    foreach (User user in this.DistanceTeaching.Users)
                    {
                        if (user.GetType() == typeof(Student))
                            listViewCommonList.Items.Add(new ListViewItem(new string[] { user.Name, user.Id.ToString() }));
                    }

                    // заполнить список студентов изучающих дисциплину
                    foreach (Guid id in found.UsersId)
                    {
                        User user = this.DistanceTeaching.Users.Find(u => u.Id == id);

                        if (user != null && user.GetType() == typeof(Student))
                            listViewStudents.Items.Add(new ListViewItem(new string[] { user.Name, user.Id.ToString() }));
                    }
                    break;
            }
        }

        // закрыть форму
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // скачать работу
        private async void btnDownloadExercise_Click(object sender, EventArgs e)
        {
            string path = getFolderPath();
            await Task.Run(() => yandexDisk.DownloadFiles(path, ExercisesPath, disciplineTitle, listViewExercises));
        }

        // добавить материал
        private async void btnAddMaterial_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dr = dialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
                await Task.Run(() => yandexDisk.UploadFiles(dialog, disciplineTitle, MaterialsPath, listViewMaterials));
        }

        // засчитать работу
        private void btnRateExercises_Click(object sender, EventArgs e)
        {
            if (listViewExercises.SelectedItems.Count == 1)
            {
                try
                {
                    string studentName = listViewExercises.SelectedItems[0].SubItems[2].Text;
                    string exerciseTitle = listViewExercises.SelectedItems[0].SubItems[0].Text;

                    double grade = Convert.ToDouble(txtBoxRate.Text);

                    Student student = (Student)this.DistanceTeaching.Users.Find(u => u.Name == studentName);

                    Exercise exercise = student.Exercises.Find(ex => ex.Title == exerciseTitle);

                    exercise.Grade = grade;

                    listViewExercises.SelectedItems[0].SubItems[3].Text = txtBoxRate.Text;

                    student.GradeList[disciplineTitle] += grade;

                    labelRateExerciseFailed.Visible = false;
                }
                catch(Exception)
                {
                    labelRateExerciseFailed.Visible = true;
                }
            }
        }

        // удалить материал
        private async void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            await Task.Run(() => yandexDisk.DeleteFiles(disciplineTitle, MaterialsPath, listViewMaterials));
        }

        // получить имя директории из диалоговго окна
        private string getFolderPath()
        {
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            return null;
        }

        // ------------ Показать/скрыть элементы

        // для материалов
        private void ElementVisibilityForMaterials(bool visible)
        {
            listViewMaterials.Visible = visible;
            btnAddMaterial.Visible = visible;
            btnDeleteMaterial.Visible = visible;
        }

        // для студентов
        private void ElementVisibilityForStudents(bool visible)
        {
            listViewCommonList.Items.Clear();
            listViewStudents.Items.Clear();

            StudentsTabControl.Visible = visible;
        }

        // для задания
        private void ElementVisibilityForExercises(bool visible)
        {
            listViewExercises.Visible = visible;
            btnDownloadExercise.Visible = visible;
            btnRateExercises.Visible = visible;
            txtBoxRate.Visible = visible;
        }  
    }
}