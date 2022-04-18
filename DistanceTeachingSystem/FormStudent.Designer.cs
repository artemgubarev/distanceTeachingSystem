namespace DistanceTeachingSystem
{
    partial class FormStudent
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
            this.listViewDisciplines = new System.Windows.Forms.ListView();
            this.btnSelectDiscipline = new System.Windows.Forms.Button();
            this.listViewStatistic = new System.Windows.Forms.ListView();
            this.labelDisciplines = new System.Windows.Forms.Label();
            this.labelStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(672, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewDisciplines
            // 
            this.listViewDisciplines.HideSelection = false;
            this.listViewDisciplines.Location = new System.Drawing.Point(12, 56);
            this.listViewDisciplines.Name = "listViewDisciplines";
            this.listViewDisciplines.Size = new System.Drawing.Size(377, 370);
            this.listViewDisciplines.TabIndex = 2;
            this.listViewDisciplines.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelectDiscipline
            // 
            this.btnSelectDiscipline.Location = new System.Drawing.Point(12, 432);
            this.btnSelectDiscipline.Name = "btnSelectDiscipline";
            this.btnSelectDiscipline.Size = new System.Drawing.Size(152, 24);
            this.btnSelectDiscipline.TabIndex = 3;
            this.btnSelectDiscipline.Text = "Перейти к дисциплине";
            this.btnSelectDiscipline.UseVisualStyleBackColor = true;
            this.btnSelectDiscipline.Click += new System.EventHandler(this.btnSelectDiscipline_Click);
            // 
            // listViewStatistic
            // 
            this.listViewStatistic.HideSelection = false;
            this.listViewStatistic.Location = new System.Drawing.Point(419, 56);
            this.listViewStatistic.Name = "listViewStatistic";
            this.listViewStatistic.Size = new System.Drawing.Size(343, 370);
            this.listViewStatistic.TabIndex = 5;
            this.listViewStatistic.UseCompatibleStateImageBehavior = false;
            this.listViewStatistic.SelectedIndexChanged += new System.EventHandler(this.listViewStatistic_SelectedIndexChanged);
            // 
            // labelDisciplines
            // 
            this.labelDisciplines.AutoSize = true;
            this.labelDisciplines.Location = new System.Drawing.Point(12, 40);
            this.labelDisciplines.Name = "labelDisciplines";
            this.labelDisciplines.Size = new System.Drawing.Size(72, 13);
            this.labelDisciplines.TabIndex = 6;
            this.labelDisciplines.Text = "Дисциплины";
            // 
            // labelStatement
            // 
            this.labelStatement.AutoSize = true;
            this.labelStatement.Location = new System.Drawing.Point(416, 40);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Size = new System.Drawing.Size(163, 13);
            this.labelStatement.TabIndex = 7;
            this.labelStatement.Text = "Информация об успеваемости";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(774, 477);
            this.ControlBox = false;
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.labelDisciplines);
            this.Controls.Add(this.listViewStatistic);
            this.Controls.Add(this.btnSelectDiscipline);
            this.Controls.Add(this.listViewDisciplines);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormStudent";
            this.Text = "Дистанционное обучение";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewDisciplines;
        private System.Windows.Forms.Button btnSelectDiscipline;
        private System.Windows.Forms.ListView listViewStatistic;
        private System.Windows.Forms.Label labelDisciplines;
        private System.Windows.Forms.Label labelStatement;
    }
}