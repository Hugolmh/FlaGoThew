namespace FlaGoThew
{
    partial class TaskForm
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
            this.ToDo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InProgress = new System.Windows.Forms.DataGridView();
            this.Done = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.DescTask = new System.Windows.Forms.TextBox();
            this.CreateTask = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataDescTask = new System.Windows.Forms.DataGridView();
            this.ModifyToDo = new System.Windows.Forms.Button();
            this.ToDoInProgess = new System.Windows.Forms.Button();
            this.InProgressDone = new System.Windows.Forms.Button();
            this.ModifyInProgress = new System.Windows.Forms.Button();
            this.DoneInProgress = new System.Windows.Forms.Button();
            this.ModifyDone = new System.Windows.Forms.Button();
            this.InProgressToDo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PrioTask = new System.Windows.Forms.TextBox();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.NomProjet = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateEcheance = new System.Windows.Forms.DateTimePicker();
            this.UserTask = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDescTask)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDo
            // 
            this.ToDo.AllowUserToAddRows = false;
            this.ToDo.AllowUserToDeleteRows = false;
            this.ToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDo.Location = new System.Drawing.Point(35, 217);
            this.ToDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.RowHeadersWidth = 51;
            this.ToDo.RowTemplate.Height = 24;
            this.ToDo.Size = new System.Drawing.Size(207, 422);
            this.ToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(44, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "To-Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(303, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "In Progress";
            // 
            // InProgress
            // 
            this.InProgress.AllowUserToAddRows = false;
            this.InProgress.AllowUserToDeleteRows = false;
            this.InProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InProgress.Location = new System.Drawing.Point(298, 217);
            this.InProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InProgress.Name = "InProgress";
            this.InProgress.ReadOnly = true;
            this.InProgress.RowHeadersWidth = 51;
            this.InProgress.RowTemplate.Height = 24;
            this.InProgress.Size = new System.Drawing.Size(207, 422);
            this.InProgress.TabIndex = 5;
            // 
            // Done
            // 
            this.Done.AllowUserToAddRows = false;
            this.Done.AllowUserToDeleteRows = false;
            this.Done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Done.Location = new System.Drawing.Point(546, 217);
            this.Done.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.RowHeadersWidth = 51;
            this.Done.RowTemplate.Height = 24;
            this.Done.Size = new System.Drawing.Size(207, 422);
            this.Done.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(542, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Done";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tâches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(809, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Création Tache";
            // 
            // NameTask
            // 
            this.NameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameTask.Location = new System.Drawing.Point(817, 105);
            this.NameTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(136, 30);
            this.NameTask.TabIndex = 10;
            // 
            // DescTask
            // 
            this.DescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DescTask.Location = new System.Drawing.Point(813, 181);
            this.DescTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescTask.Name = "DescTask";
            this.DescTask.Size = new System.Drawing.Size(136, 30);
            this.DescTask.TabIndex = 11;
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CreateTask.Location = new System.Drawing.Point(770, 474);
            this.CreateTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(87, 37);
            this.CreateTask.TabIndex = 12;
            this.CreateTask.Text = "Créer";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(831, 521);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // dataDescTask
            // 
            this.dataDescTask.AllowUserToAddRows = false;
            this.dataDescTask.AllowUserToDeleteRows = false;
            this.dataDescTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDescTask.Location = new System.Drawing.Point(813, 555);
            this.dataDescTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataDescTask.Name = "dataDescTask";
            this.dataDescTask.ReadOnly = true;
            this.dataDescTask.RowHeadersWidth = 51;
            this.dataDescTask.RowTemplate.Height = 24;
            this.dataDescTask.Size = new System.Drawing.Size(139, 128);
            this.dataDescTask.TabIndex = 14;
            // 
            // ModifyToDo
            // 
            this.ModifyToDo.Location = new System.Drawing.Point(126, 644);
            this.ModifyToDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyToDo.Name = "ModifyToDo";
            this.ModifyToDo.Size = new System.Drawing.Size(65, 44);
            this.ModifyToDo.TabIndex = 16;
            this.ModifyToDo.Text = "Modifier";
            this.ModifyToDo.UseVisualStyleBackColor = true;
            // 
            // ToDoInProgess
            // 
            this.ToDoInProgess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ToDoInProgess.Location = new System.Drawing.Point(196, 644);
            this.ToDoInProgess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDoInProgess.Name = "ToDoInProgess";
            this.ToDoInProgess.Size = new System.Drawing.Size(46, 44);
            this.ToDoInProgess.TabIndex = 17;
            this.ToDoInProgess.Text = ">";
            this.ToDoInProgess.UseVisualStyleBackColor = true;
            // 
            // InProgressDone
            // 
            this.InProgressDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InProgressDone.Location = new System.Drawing.Point(463, 644);
            this.InProgressDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InProgressDone.Name = "InProgressDone";
            this.InProgressDone.Size = new System.Drawing.Size(46, 44);
            this.InProgressDone.TabIndex = 20;
            this.InProgressDone.Text = ">";
            this.InProgressDone.UseVisualStyleBackColor = true;
            // 
            // ModifyInProgress
            // 
            this.ModifyInProgress.Location = new System.Drawing.Point(344, 644);
            this.ModifyInProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyInProgress.Name = "ModifyInProgress";
            this.ModifyInProgress.Size = new System.Drawing.Size(65, 44);
            this.ModifyInProgress.TabIndex = 19;
            this.ModifyInProgress.Text = "Modifier";
            this.ModifyInProgress.UseVisualStyleBackColor = true;
            // 
            // DoneInProgress
            // 
            this.DoneInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoneInProgress.Location = new System.Drawing.Point(710, 644);
            this.DoneInProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoneInProgress.Name = "DoneInProgress";
            this.DoneInProgress.Size = new System.Drawing.Size(46, 44);
            this.DoneInProgress.TabIndex = 23;
            this.DoneInProgress.Text = "<";
            this.DoneInProgress.UseVisualStyleBackColor = true;
            // 
            // ModifyDone
            // 
            this.ModifyDone.Location = new System.Drawing.Point(640, 644);
            this.ModifyDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyDone.Name = "ModifyDone";
            this.ModifyDone.Size = new System.Drawing.Size(65, 44);
            this.ModifyDone.TabIndex = 22;
            this.ModifyDone.Text = "Modifier";
            this.ModifyDone.UseVisualStyleBackColor = true;
            // 
            // InProgressToDo
            // 
            this.InProgressToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InProgressToDo.Location = new System.Drawing.Point(412, 643);
            this.InProgressToDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InProgressToDo.Name = "InProgressToDo";
            this.InProgressToDo.Size = new System.Drawing.Size(46, 44);
            this.InProgressToDo.TabIndex = 24;
            this.InProgressToDo.Text = "<";
            this.InProgressToDo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(813, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(813, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(813, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Priorité";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(813, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Utilisateur";
            // 
            // PrioTask
            // 
            this.PrioTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PrioTask.Location = new System.Drawing.Point(817, 375);
            this.PrioTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrioTask.Name = "PrioTask";
            this.PrioTask.Size = new System.Drawing.Size(136, 30);
            this.PrioTask.TabIndex = 30;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteTask.Location = new System.Drawing.Point(896, 474);
            this.DeleteTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(106, 37);
            this.DeleteTask.TabIndex = 31;
            this.DeleteTask.Text = "Supprimer";
            this.DeleteTask.UseVisualStyleBackColor = true;
            // 
            // NomProjet
            // 
            this.NomProjet.AutoSize = true;
            this.NomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProjet.Location = new System.Drawing.Point(44, 25);
            this.NomProjet.Name = "NomProjet";
            this.NomProjet.Size = new System.Drawing.Size(85, 25);
            this.NomProjet.TabIndex = 32;
            this.NomProjet.Text = "Projet x";
            this.NomProjet.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(818, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date écheance";
            // 
            // DateEcheance
            // 
            this.DateEcheance.Location = new System.Drawing.Point(822, 444);
            this.DateEcheance.Name = "DateEcheance";
            this.DateEcheance.Size = new System.Drawing.Size(200, 20);
            this.DateEcheance.TabIndex = 34;
            // 
            // UserTask
            // 
            this.UserTask.FormattingEnabled = true;
            this.UserTask.Location = new System.Drawing.Point(820, 246);
            this.UserTask.Name = "UserTask";
            this.UserTask.Size = new System.Drawing.Size(120, 95);
            this.UserTask.TabIndex = 35;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 692);
            this.Controls.Add(this.UserTask);
            this.Controls.Add(this.DateEcheance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NomProjet);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.PrioTask);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InProgressToDo);
            this.Controls.Add(this.DoneInProgress);
            this.Controls.Add(this.ModifyDone);
            this.Controls.Add(this.InProgressDone);
            this.Controls.Add(this.ModifyInProgress);
            this.Controls.Add(this.ToDoInProgess);
            this.Controls.Add(this.ModifyToDo);
            this.Controls.Add(this.dataDescTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateTask);
            this.Controls.Add(this.DescTask);
            this.Controls.Add(this.NameTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.InProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDescTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView InProgress;
        private System.Windows.Forms.DataGridView Done;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTask;
        private System.Windows.Forms.TextBox DescTask;
        private System.Windows.Forms.Button CreateTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataDescTask;
        private System.Windows.Forms.Button ModifyToDo;
        private System.Windows.Forms.Button ToDoInProgess;
        private System.Windows.Forms.Button InProgressDone;
        private System.Windows.Forms.Button ModifyInProgress;
        private System.Windows.Forms.Button DoneInProgress;
        private System.Windows.Forms.Button ModifyDone;
        private System.Windows.Forms.Button InProgressToDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PrioTask;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Label NomProjet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateEcheance;
        private System.Windows.Forms.ListBox UserTask;
    }
}