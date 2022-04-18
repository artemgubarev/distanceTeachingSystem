namespace DistanceTeachingSystem
{
    partial class FormDisciplineForStudent
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
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxActions = new System.Windows.Forms.ComboBox();
            this.listViewMaterials = new System.Windows.Forms.ListView();
            this.btnDowloadMaterial = new System.Windows.Forms.Button();
            this.listViewExercises = new System.Windows.Forms.ListView();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxActions
            // 
            this.comboBoxActions.FormattingEnabled = true;
            this.comboBoxActions.Location = new System.Drawing.Point(22, 41);
            this.comboBoxActions.Name = "comboBoxActions";
            this.comboBoxActions.Size = new System.Drawing.Size(523, 21);
            this.comboBoxActions.TabIndex = 19;
            this.comboBoxActions.SelectedIndexChanged += new System.EventHandler(this.comboBoxActions_SelectedIndexChanged);
            // 
            // listViewMaterials
            // 
            this.listViewMaterials.HideSelection = false;
            this.listViewMaterials.Location = new System.Drawing.Point(22, 68);
            this.listViewMaterials.Name = "listViewMaterials";
            this.listViewMaterials.Size = new System.Drawing.Size(523, 328);
            this.listViewMaterials.TabIndex = 20;
            this.listViewMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // btnDowloadMaterial
            // 
            this.btnDowloadMaterial.Location = new System.Drawing.Point(22, 402);
            this.btnDowloadMaterial.Name = "btnDowloadMaterial";
            this.btnDowloadMaterial.Size = new System.Drawing.Size(136, 23);
            this.btnDowloadMaterial.TabIndex = 21;
            this.btnDowloadMaterial.Text = "Скачать";
            this.btnDowloadMaterial.UseVisualStyleBackColor = true;
            this.btnDowloadMaterial.Click += new System.EventHandler(this.btnDowloadMaterial_Click);
            // 
            // listViewExercises
            // 
            this.listViewExercises.HideSelection = false;
            this.listViewExercises.Location = new System.Drawing.Point(22, 68);
            this.listViewExercises.Name = "listViewExercises";
            this.listViewExercises.Size = new System.Drawing.Size(523, 328);
            this.listViewExercises.TabIndex = 22;
            this.listViewExercises.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(257, 402);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(136, 23);
            this.btnAddExercise.TabIndex = 23;
            this.btnAddExercise.Text = "Добавить работу";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.Location = new System.Drawing.Point(409, 402);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteExercise.TabIndex = 24;
            this.btnDeleteExercise.Text = "Удалить работу";
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // FormDisciplineForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(557, 460);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.listViewExercises);
            this.Controls.Add(this.btnDowloadMaterial);
            this.Controls.Add(this.listViewMaterials);
            this.Controls.Add(this.comboBoxActions);
            this.Controls.Add(this.btnExit);
            this.Name = "FormDisciplineForStudent";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.FormDisciplineForStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxActions;
        private System.Windows.Forms.ListView listViewMaterials;
        private System.Windows.Forms.Button btnDowloadMaterial;
        private System.Windows.Forms.ListView listViewExercises;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnDeleteExercise;
    }
}