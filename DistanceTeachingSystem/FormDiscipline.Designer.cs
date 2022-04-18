namespace DistanceTeachingSystem
{
    partial class FormDiscipline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.listViewExercises = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.listViewMaterials = new System.Windows.Forms.ListView();
            this.StudentsTabControl = new System.Windows.Forms.TabControl();
            this.CommonList = new System.Windows.Forms.TabPage();
            this.listViewCommonList = new System.Windows.Forms.ListView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.StudentsDiscipline = new System.Windows.Forms.TabPage();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.btnDownloadExercise = new System.Windows.Forms.Button();
            this.btnRateExercises = new System.Windows.Forms.Button();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.labelRateExerciseFailed = new System.Windows.Forms.Label();
            this.StudentsTabControl.SuspendLayout();
            this.CommonList.SuspendLayout();
            this.StudentsDiscipline.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxActions
            // 
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Location = new System.Drawing.Point(12, 35);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(523, 21);
            this.comboBoxActions.TabIndex = 6;
            this.comboBoxActions.SelectedIndexChanged += new System.EventHandler(this.comboBoxActions_SelectedIndexChanged);
            // 
            // listViewExercises
            // 
            this.listViewExercises.HideSelection = false;
            this.listViewExercises.Location = new System.Drawing.Point(12, 62);
            this.listViewExercises.Name = "listViewExercises";
            this.listViewExercises.Size = new System.Drawing.Size(523, 339);
            this.listViewExercises.TabIndex = 16;
            this.listViewExercises.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewMaterials
            // 
            this.listViewMaterials.HideSelection = false;
            this.listViewMaterials.Location = new System.Drawing.Point(13, 62);
            this.listViewMaterials.Name = "listViewMaterials";
            this.listViewMaterials.Size = new System.Drawing.Size(522, 343);
            this.listViewMaterials.TabIndex = 18;
            this.listViewMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // StudentsTabControl
            // 
            this.StudentsTabControl.Controls.Add(this.CommonList);
            this.StudentsTabControl.Controls.Add(this.StudentsDiscipline);
            this.StudentsTabControl.Location = new System.Drawing.Point(13, 62);
            this.StudentsTabControl.Name = "StudentsTabControl";
            this.StudentsTabControl.SelectedIndex = 0;
            this.StudentsTabControl.Size = new System.Drawing.Size(522, 343);
            this.StudentsTabControl.TabIndex = 19;
            // 
            // CommonList
            // 
            this.CommonList.Controls.Add(this.listViewCommonList);
            this.CommonList.Controls.Add(this.btnAddStudent);
            this.CommonList.Location = new System.Drawing.Point(4, 22);
            this.CommonList.Name = "CommonList";
            this.CommonList.Padding = new System.Windows.Forms.Padding(3);
            this.CommonList.Size = new System.Drawing.Size(514, 317);
            this.CommonList.TabIndex = 0;
            this.CommonList.Text = "                    Общий список                      ";
            this.CommonList.UseVisualStyleBackColor = true;
            // 
            // listViewCommonList
            // 
            this.listViewCommonList.HideSelection = false;
            this.listViewCommonList.Location = new System.Drawing.Point(0, 0);
            this.listViewCommonList.Name = "listViewCommonList";
            this.listViewCommonList.Size = new System.Drawing.Size(508, 279);
            this.listViewCommonList.TabIndex = 7;
            this.listViewCommonList.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 285);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(141, 26);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // StudentsDiscipline
            // 
            this.StudentsDiscipline.Controls.Add(this.listViewStudents);
            this.StudentsDiscipline.Controls.Add(this.btnDeleteStudent);
            this.StudentsDiscipline.Location = new System.Drawing.Point(4, 22);
            this.StudentsDiscipline.Name = "StudentsDiscipline";
            this.StudentsDiscipline.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsDiscipline.Size = new System.Drawing.Size(514, 317);
            this.StudentsDiscipline.TabIndex = 1;
            this.StudentsDiscipline.Text = "                 Изучающие дисциплину                  ";
            this.StudentsDiscipline.UseVisualStyleBackColor = true;
            // 
            // listViewStudents
            // 
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(0, 0);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(508, 274);
            this.listViewStudents.TabIndex = 8;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(6, 280);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(141, 26);
            this.btnDeleteStudent.TabIndex = 9;
            this.btnDeleteStudent.Text = "Удалить студента";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 411);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(141, 26);
            this.btnAddMaterial.TabIndex = 20;
            this.btnAddMaterial.Text = "Добавить материал";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(159, 411);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(141, 26);
            this.btnDeleteMaterial.TabIndex = 21;
            this.btnDeleteMaterial.Text = "Удалить материал";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // btnDownloadExercise
            // 
            this.btnDownloadExercise.Location = new System.Drawing.Point(12, 411);
            this.btnDownloadExercise.Name = "btnDownloadExercise";
            this.btnDownloadExercise.Size = new System.Drawing.Size(141, 26);
            this.btnDownloadExercise.TabIndex = 22;
            this.btnDownloadExercise.Text = "Скачать задание";
            this.btnDownloadExercise.UseVisualStyleBackColor = true;
            this.btnDownloadExercise.Click += new System.EventHandler(this.btnDownloadExercise_Click);
            // 
            // btnRateExercises
            // 
            this.btnRateExercises.Location = new System.Drawing.Point(159, 411);
            this.btnRateExercises.Name = "btnRateExercises";
            this.btnRateExercises.Size = new System.Drawing.Size(141, 26);
            this.btnRateExercises.TabIndex = 23;
            this.btnRateExercises.Text = "Засчитать работу";
            this.btnRateExercises.UseVisualStyleBackColor = true;
            this.btnRateExercises.Click += new System.EventHandler(this.btnRateExercises_Click);
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.Location = new System.Drawing.Point(306, 415);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(167, 20);
            this.txtBoxRate.TabIndex = 24;
            // 
            // labelRateExerciseFailed
            // 
            this.labelRateExerciseFailed.AutoSize = true;
            this.labelRateExerciseFailed.ForeColor = System.Drawing.Color.Red;
            this.labelRateExerciseFailed.Location = new System.Drawing.Point(303, 404);
            this.labelRateExerciseFailed.Name = "labelRateExerciseFailed";
            this.labelRateExerciseFailed.Size = new System.Drawing.Size(214, 13);
            this.labelRateExerciseFailed.TabIndex = 25;
            this.labelRateExerciseFailed.Text = "Оценка может быть в диапозоне [0; 100]";
            // 
            // FormDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(553, 443);
            this.ControlBox = false;
            this.Controls.Add(this.labelRateExerciseFailed);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.btnRateExercises);
            this.Controls.Add(this.btnDownloadExercise);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.StudentsTabControl);
            this.Controls.Add(this.listViewMaterials);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listViewExercises);
            this.Controls.Add(this.comboBoxActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.FormDiscipline_Load);
            this.StudentsTabControl.ResumeLayout(false);
            this.CommonList.ResumeLayout(false);
            this.StudentsDiscipline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActions;
        private System.Windows.Forms.ListView listViewExercises;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewMaterials;
        private System.Windows.Forms.TabControl StudentsTabControl;
        private System.Windows.Forms.TabPage CommonList;
        private System.Windows.Forms.ListView listViewCommonList;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TabPage StudentsDiscipline;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Button btnDownloadExercise;
        private System.Windows.Forms.Button btnRateExercises;
        private System.Windows.Forms.TextBox txtBoxRate;
        private System.Windows.Forms.Label labelRateExerciseFailed;
    }
}