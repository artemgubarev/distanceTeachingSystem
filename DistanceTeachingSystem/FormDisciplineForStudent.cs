using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTeachingSystem
{
    public partial class FormDisciplineForStudent : Form
    {
        YandexDisk yandexDisk;
        Student student;

        const string ExercisesPath = "Exercises";
        const string MaterialsPath = "Materials";

        public FormDisciplineForStudent(DistanceTeaching distanceTeaching, Student student, string disciplineTitle)
        {
            InitializeComponent();

            this.DistanceTeaching = distanceTeaching;
            this.disciplineTitle = disciplineTitle;
            this.student = student;

            yandexDisk = new YandexDisk();
        }

        public DistanceTeaching DistanceTeaching { get; set; }
        string disciplineTitle;

        private async void FormDisciplineForStudent_Load(object sender, EventArgs e)
        {
            // comboBox
            comboBoxActions.Items.Add("Материалы дисциплины");
            comboBoxActions.Items.Add("Отправка и оценка работ");

            comboBoxActions.SelectedItem = comboBoxActions.Items[0];

            // Listview Материалы
            listViewMaterials.View = View.Details;

            listViewMaterials.Columns.Add("Файл", 200);
            listViewMaterials.Columns.Add("Дата Добавления", 200);
            listViewMaterials.Columns.Add("Размер", 200);

            listViewMaterials.Name = "listViewMaterials";

            // Listview Задания
            listViewExercises.View = View.Details;

            listViewExercises.Columns.Add("Файл", 200);
            listViewExercises.Columns.Add("Дата добавления", 200);
            listViewExercises.Columns.Add("Имя студента", 200);
            listViewExercises.Columns.Add("Оценка", 200);

            listViewExercises.Name = "listViewExercises";

            ElementVisibilityForMaterials(true);
            ElementVisibilityForExercises(false);

            await Task.Run(() => yandexDisk.ShowFiles(disciplineTitle,ExercisesPath,listViewExercises, student, DistanceTeaching));
            await Task.Run(() => yandexDisk.ShowFiles(disciplineTitle,MaterialsPath, listViewMaterials, student, DistanceTeaching));
        }

        // --------- кнопки -----------------


        // закрыть форму
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // скачать материал
        private async void btnDowloadMaterial_Click(object sender, EventArgs e)
        {
            string path = getFolderPath();
            await Task.Run(() => yandexDisk.DownloadFiles(path,MaterialsPath, disciplineTitle, listViewMaterials));
        }

        // добавить работу
        private async void btnAddExercise_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dr = dialog.ShowDialog();

            // добавить задания студенту
            var files = dialog.FileNames;
            foreach(var file in files)
            {
                Exercise exercise = new Exercise(Path.GetFileName(file), 0.0);
                student.Exercises.Add(exercise);
            }
        

            if (dr == System.Windows.Forms.DialogResult.OK)
                await Task.Run(()=> yandexDisk.UploadFiles(dialog,disciplineTitle,ExercisesPath,listViewExercises));        
        }
    
        // удалить работу
        private async void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            await Task.Run(() => yandexDisk.DeleteFiles(disciplineTitle, ExercisesPath, listViewExercises));
        }

        // выбор действия над дисциплиной
        private void comboBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxActions.SelectedIndex)
            {
                // материалы дисциплины
                case 0:
                    // показать/скрыть элементы
                    ElementVisibilityForMaterials(true);
                    ElementVisibilityForExercises(false);


                    break;

                // задания
                case 1:
                    // показать/скрыть элементы
                    ElementVisibilityForMaterials(false);
                    ElementVisibilityForExercises(true);

                    break;
            }
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

        //--------- показать/скрыть элементы---------

        // для задания
        private void ElementVisibilityForExercises(bool visible)
        {
            listViewExercises.Visible = visible;
            btnDeleteExercise.Visible = visible;
            btnAddExercise.Visible = visible;
        }

        // для материалов
        private void ElementVisibilityForMaterials(bool visible)
        {
            listViewMaterials.Visible = visible;
            btnDowloadMaterial.Visible = visible;
        }
     
    }
}
