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
            this.NomProjet = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateEcheance = new System.Windows.Forms.DateTimePicker();
            this.IdUser = new System.Windows.Forms.TextBox();
            this.DeleteDone = new System.Windows.Forms.Button();
            this.DeleteInProgress = new System.Windows.Forms.Button();
            this.DeleteTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Done)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDo
            // 
            this.ToDo.AllowUserToAddRows = false;
            this.ToDo.AllowUserToDeleteRows = false;
            this.ToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDo.Location = new System.Drawing.Point(34, 62);
            this.ToDo.Margin = new System.Windows.Forms.Padding(2);
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.RowHeadersWidth = 51;
            this.ToDo.RowTemplate.Height = 24;
            this.ToDo.Size = new System.Drawing.Size(715, 185);
            this.ToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "To-Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(28, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "In Progress";
            // 
            // InProgress
            // 
            this.InProgress.AllowUserToAddRows = false;
            this.InProgress.AllowUserToDeleteRows = false;
            this.InProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InProgress.Location = new System.Drawing.Point(33, 275);
            this.InProgress.Margin = new System.Windows.Forms.Padding(2);
            this.InProgress.Name = "InProgress";
            this.InProgress.ReadOnly = true;
            this.InProgress.RowHeadersWidth = 51;
            this.InProgress.RowTemplate.Height = 24;
            this.InProgress.Size = new System.Drawing.Size(715, 185);
            this.InProgress.TabIndex = 5;
            // 
            // Done
            // 
            this.Done.AllowUserToAddRows = false;
            this.Done.AllowUserToDeleteRows = false;
            this.Done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Done.Location = new System.Drawing.Point(32, 499);
            this.Done.Margin = new System.Windows.Forms.Padding(2);
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.RowHeadersWidth = 51;
            this.Done.RowTemplate.Height = 24;
            this.Done.Size = new System.Drawing.Size(715, 185);
            this.Done.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(29, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Done";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tâches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(971, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Création Tache";
            // 
            // NameTask
            // 
            this.NameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameTask.Location = new System.Drawing.Point(975, 199);
            this.NameTask.Margin = new System.Windows.Forms.Padding(2);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(161, 30);
            this.NameTask.TabIndex = 10;
            // 
            // DescTask
            // 
            this.DescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DescTask.Location = new System.Drawing.Point(975, 275);
            this.DescTask.Margin = new System.Windows.Forms.Padding(2);
            this.DescTask.Name = "DescTask";
            this.DescTask.Size = new System.Drawing.Size(165, 30);
            this.DescTask.TabIndex = 11;
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateTask.Location = new System.Drawing.Point(1026, 533);
            this.CreateTask.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(87, 37);
            this.CreateTask.TabIndex = 12;
            this.CreateTask.Text = "Créer";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // ModifyToDo
            // 
            this.ModifyToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifyToDo.Location = new System.Drawing.Point(756, 106);
            this.ModifyToDo.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyToDo.Name = "ModifyToDo";
            this.ModifyToDo.Size = new System.Drawing.Size(65, 40);
            this.ModifyToDo.TabIndex = 16;
            this.ModifyToDo.Text = "✏️";
            this.ModifyToDo.UseVisualStyleBackColor = true;
            this.ModifyToDo.Click += new System.EventHandler(this.ModifyToDo_Click);
            // 
            // ToDoInProgess
            // 
            this.ToDoInProgess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ToDoInProgess.Location = new System.Drawing.Point(756, 150);
            this.ToDoInProgess.Margin = new System.Windows.Forms.Padding(2);
            this.ToDoInProgess.Name = "ToDoInProgess";
            this.ToDoInProgess.Size = new System.Drawing.Size(65, 40);
            this.ToDoInProgess.TabIndex = 17;
            this.ToDoInProgess.Text = "↓";
            this.ToDoInProgess.UseVisualStyleBackColor = true;
            this.ToDoInProgess.Click += new System.EventHandler(this.ToDoInProgess_Click);
            // 
            // InProgressDone
            // 
            this.InProgressDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InProgressDone.Location = new System.Drawing.Point(755, 420);
            this.InProgressDone.Margin = new System.Windows.Forms.Padding(2);
            this.InProgressDone.Name = "InProgressDone";
            this.InProgressDone.Size = new System.Drawing.Size(65, 40);
            this.InProgressDone.TabIndex = 20;
            this.InProgressDone.Text = "↓";
            this.InProgressDone.UseVisualStyleBackColor = true;
            this.InProgressDone.Click += new System.EventHandler(this.InProgressDone_Click);
            // 
            // ModifyInProgress
            // 
            this.ModifyInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifyInProgress.Location = new System.Drawing.Point(755, 370);
            this.ModifyInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyInProgress.Name = "ModifyInProgress";
            this.ModifyInProgress.Size = new System.Drawing.Size(65, 40);
            this.ModifyInProgress.TabIndex = 19;
            this.ModifyInProgress.Text = "✏️";
            this.ModifyInProgress.UseVisualStyleBackColor = true;
            this.ModifyInProgress.Click += new System.EventHandler(this.ModifyInProgress_Click);
            // 
            // DoneInProgress
            // 
            this.DoneInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DoneInProgress.Location = new System.Drawing.Point(756, 499);
            this.DoneInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.DoneInProgress.Name = "DoneInProgress";
            this.DoneInProgress.Size = new System.Drawing.Size(65, 40);
            this.DoneInProgress.TabIndex = 23;
            this.DoneInProgress.Text = "↑";
            this.DoneInProgress.UseVisualStyleBackColor = true;
            this.DoneInProgress.Click += new System.EventHandler(this.DoneInProgress_Click);
            // 
            // ModifyDone
            // 
            this.ModifyDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModifyDone.Location = new System.Drawing.Point(756, 587);
            this.ModifyDone.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyDone.Name = "ModifyDone";
            this.ModifyDone.Size = new System.Drawing.Size(65, 40);
            this.ModifyDone.TabIndex = 22;
            this.ModifyDone.Text = "✏️";
            this.ModifyDone.UseVisualStyleBackColor = true;
            this.ModifyDone.Click += new System.EventHandler(this.ModifyDone_Click);
            // 
            // InProgressToDo
            // 
            this.InProgressToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InProgressToDo.Location = new System.Drawing.Point(755, 275);
            this.InProgressToDo.Margin = new System.Windows.Forms.Padding(2);
            this.InProgressToDo.Name = "InProgressToDo";
            this.InProgressToDo.Size = new System.Drawing.Size(65, 40);
            this.InProgressToDo.TabIndex = 24;
            this.InProgressToDo.Text = "↑";
            this.InProgressToDo.UseVisualStyleBackColor = true;
            this.InProgressToDo.Click += new System.EventHandler(this.InProgressToDo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(975, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nom";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(975, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(975, 392);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Priorité";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(975, 320);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "Utilisateur";
            // 
            // PrioTask
            // 
            this.PrioTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PrioTask.Location = new System.Drawing.Point(979, 416);
            this.PrioTask.Margin = new System.Windows.Forms.Padding(2);
            this.PrioTask.Name = "PrioTask";
            this.PrioTask.Size = new System.Drawing.Size(165, 30);
            this.PrioTask.TabIndex = 30;
            // 
            // NomProjet
            // 
            this.NomProjet.AutoSize = true;
            this.NomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomProjet.Location = new System.Drawing.Point(1004, 38);
            this.NomProjet.Name = "NomProjet";
            this.NomProjet.Size = new System.Drawing.Size(85, 25);
            this.NomProjet.TabIndex = 32;
            this.NomProjet.Text = "Projet x";
            this.NomProjet.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(975, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Date écheance";
            // 
            // DateEcheance
            // 
            this.DateEcheance.Location = new System.Drawing.Point(979, 485);
            this.DateEcheance.Name = "DateEcheance";
            this.DateEcheance.Size = new System.Drawing.Size(164, 20);
            this.DateEcheance.TabIndex = 34;
            // 
            // IdUser
            // 
            this.IdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IdUser.Location = new System.Drawing.Point(979, 344);
            this.IdUser.Margin = new System.Windows.Forms.Padding(2);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(164, 30);
            this.IdUser.TabIndex = 35;
            // 
            // DeleteDone
            // 
            this.DeleteDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDone.Location = new System.Drawing.Point(755, 543);
            this.DeleteDone.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDone.Name = "DeleteDone";
            this.DeleteDone.Size = new System.Drawing.Size(65, 40);
            this.DeleteDone.TabIndex = 36;
            this.DeleteDone.Text = "🗑️";
            this.DeleteDone.UseVisualStyleBackColor = true;
            this.DeleteDone.Click += new System.EventHandler(this.DeleteDone_Click);
            // 
            // DeleteInProgress
            // 
            this.DeleteInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInProgress.Location = new System.Drawing.Point(755, 322);
            this.DeleteInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteInProgress.Name = "DeleteInProgress";
            this.DeleteInProgress.Size = new System.Drawing.Size(65, 40);
            this.DeleteInProgress.TabIndex = 37;
            this.DeleteInProgress.Text = "🗑️";
            this.DeleteInProgress.UseVisualStyleBackColor = true;
            this.DeleteInProgress.Click += new System.EventHandler(this.DeleteInProgress_Click);
            // 
            // DeleteTodo
            // 
            this.DeleteTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteTodo.Location = new System.Drawing.Point(756, 62);
            this.DeleteTodo.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteTodo.Name = "DeleteTodo";
            this.DeleteTodo.Size = new System.Drawing.Size(65, 40);
            this.DeleteTodo.TabIndex = 38;
            this.DeleteTodo.Text = "🗑️";
            this.DeleteTodo.UseVisualStyleBackColor = true;
            this.DeleteTodo.Click += new System.EventHandler(this.DeleteTodo_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 692);
            this.Controls.Add(this.DeleteTodo);
            this.Controls.Add(this.DeleteInProgress);
            this.Controls.Add(this.DeleteDone);
            this.Controls.Add(this.IdUser);
            this.Controls.Add(this.DateEcheance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NomProjet);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Done)).EndInit();
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
        private System.Windows.Forms.Label NomProjet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateEcheance;
        private System.Windows.Forms.TextBox IdUser;
        private System.Windows.Forms.Button DeleteDone;
        private System.Windows.Forms.Button DeleteInProgress;
        private System.Windows.Forms.Button DeleteTodo;
    }
}