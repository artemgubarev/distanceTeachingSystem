namespace DistanceTeachingSystem
{
    partial class FormTeacher
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
            this.btnCreateDiscipline = new System.Windows.Forms.Button();
            this.txtBoxDisciplineTitle = new System.Windows.Forms.TextBox();
            this.btnDeleteDiscipline = new System.Windows.Forms.Button();
            this.btnSelectDiscipline = new System.Windows.Forms.Button();
            this.labelCreateDisciplineFailed = new System.Windows.Forms.Label();
            this.listViewStatement = new System.Windows.Forms.ListView();
            this.btnShowStatement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(743, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 22);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewDisciplines
            // 
            this.listViewDisciplines.HideSelection = false;
            this.listViewDisciplines.Location = new System.Drawing.Point(12, 28);
            this.listViewDisciplines.Name = "listViewDisciplines";
            this.listViewDisciplines.Size = new System.Drawing.Size(472, 328);
            this.listViewDisciplines.TabIndex = 1;
            this.listViewDisciplines.UseCompatibleStateImageBehavior = false;
            // 
            // btnCreateDiscipline
            // 
            this.btnCreateDiscipline.Location = new System.Drawing.Point(12, 378);
            this.btnCreateDiscipline.Name = "btnCreateDiscipline";
            this.btnCreateDiscipline.Size = new System.Drawing.Size(105, 22);
            this.btnCreateDiscipline.TabIndex = 2;
            this.btnCreateDiscipline.Text = "Создать";
            this.btnCreateDiscipline.UseVisualStyleBackColor = true;
            this.btnCreateDiscipline.Click += new System.EventHandler(this.btnCreateDiscipline_Click);
            // 
            // txtBoxDisciplineTitle
            // 
            this.txtBoxDisciplineTitle.Location = new System.Drawing.Point(123, 378);
            this.txtBoxDisciplineTitle.Name = "txtBoxDisciplineTitle";
            this.txtBoxDisciplineTitle.Size = new System.Drawing.Size(167, 20);
            this.txtBoxDisciplineTitle.TabIndex = 3;
            // 
            // btnDeleteDiscipline
            // 
            this.btnDeleteDiscipline.Location = new System.Drawing.Point(12, 415);
            this.btnDeleteDiscipline.Name = "btnDeleteDiscipline";
            this.btnDeleteDiscipline.Size = new System.Drawing.Size(105, 22);
            this.btnDeleteDiscipline.TabIndex = 4;
            this.btnDeleteDiscipline.Text = "Удалить";
            this.btnDeleteDiscipline.UseVisualStyleBackColor = true;
            this.btnDeleteDiscipline.Click += new System.EventHandler(this.btnDeleteDiscipline_Click);
            // 
            // btnSelectDiscipline
            // 
            this.btnSelectDiscipline.Location = new System.Drawing.Point(343, 376);
            this.btnSelectDiscipline.Name = "btnSelectDiscipline";
            this.btnSelectDiscipline.Size = new System.Drawing.Size(141, 22);
            this.btnSelectDiscipline.TabIndex = 5;
            this.btnSelectDiscipline.Text = "Перейти к дисциплине";
            this.btnSelectDiscipline.UseVisualStyleBackColor = true;
            this.btnSelectDiscipline.Click += new System.EventHandler(this.btnSelectDiscipline_Click);
            // 
            // labelCreateDisciplineFailed
            // 
            this.labelCreateDisciplineFailed.AutoSize = true;
            this.labelCreateDisciplineFailed.ForeColor = System.Drawing.Color.Red;
            this.labelCreateDisciplineFailed.Location = new System.Drawing.Point(120, 359);
            this.labelCreateDisciplineFailed.Name = "labelCreateDisciplineFailed";
            this.labelCreateDisciplineFailed.Size = new System.Drawing.Size(214, 13);
            this.labelCreateDisciplineFailed.TabIndex = 6;
            this.labelCreateDisciplineFailed.Text = "Имя дисциплины не может быть пустым";
            // 
            // listViewStatement
            // 
            this.listViewStatement.HideSelection = false;
            this.listViewStatement.Location = new System.Drawing.Point(513, 28);
            this.listViewStatement.Name = "listViewStatement";
            this.listViewStatement.Size = new System.Drawing.Size(335, 330);
            this.listViewStatement.TabIndex = 7;
            this.listViewStatement.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowStatement
            // 
            this.btnShowStatement.Location = new System.Drawing.Point(343, 415);
            this.btnShowStatement.Name = "btnShowStatement";
            this.btnShowStatement.Size = new System.Drawing.Size(141, 22);
            this.btnShowStatement.TabIndex = 8;
            this.btnShowStatement.Text = "Показать ведомость";
            this.btnShowStatement.UseVisualStyleBackColor = true;
            this.btnShowStatement.Click += new System.EventHandler(this.btnShowStatement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название дисциплины";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowStatement);
            this.Controls.Add(this.listViewStatement);
            this.Controls.Add(this.labelCreateDisciplineFailed);
            this.Controls.Add(this.btnSelectDiscipline);
            this.Controls.Add(this.btnDeleteDiscipline);
            this.Controls.Add(this.txtBoxDisciplineTitle);
            this.Controls.Add(this.btnCreateDiscipline);
            this.Controls.Add(this.listViewDisciplines);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormTeacher";
            this.Text = "Дистанционное обучение";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewDisciplines;
        private System.Windows.Forms.Button btnCreateDiscipline;
        private System.Windows.Forms.TextBox txtBoxDisciplineTitle;
        private System.Windows.Forms.Button btnDeleteDiscipline;
        private System.Windows.Forms.Button btnSelectDiscipline;
        private System.Windows.Forms.Label labelCreateDisciplineFailed;
        private System.Windows.Forms.ListView listViewStatement;
        private System.Windows.Forms.Button btnShowStatement;
        private System.Windows.Forms.Label label1;
    }
}