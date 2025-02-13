namespace FlaGoThew
{
    partial class Home
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
            this.UserTask = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PrioTask = new System.Windows.Forms.TextBox();
            this.DeleteTask = new System.Windows.Forms.Button();
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
            this.ToDo.Location = new System.Drawing.Point(47, 267);
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.RowHeadersWidth = 51;
            this.ToDo.RowTemplate.Height = 24;
            this.ToDo.Size = new System.Drawing.Size(276, 519);
            this.ToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(59, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "To-Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(404, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "In Progress";
            // 
            // InProgress
            // 
            this.InProgress.AllowUserToAddRows = false;
            this.InProgress.AllowUserToDeleteRows = false;
            this.InProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InProgress.Location = new System.Drawing.Point(397, 267);
            this.InProgress.Name = "InProgress";
            this.InProgress.ReadOnly = true;
            this.InProgress.RowHeadersWidth = 51;
            this.InProgress.RowTemplate.Height = 24;
            this.InProgress.Size = new System.Drawing.Size(276, 519);
            this.InProgress.TabIndex = 5;
            // 
            // Done
            // 
            this.Done.AllowUserToAddRows = false;
            this.Done.AllowUserToDeleteRows = false;
            this.Done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Done.Location = new System.Drawing.Point(728, 267);
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.RowHeadersWidth = 51;
            this.Done.RowTemplate.Height = 24;
            this.Done.Size = new System.Drawing.Size(276, 519);
            this.Done.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(723, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Done";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tâches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(1079, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Création Tache";
            // 
            // NameTask
            // 
            this.NameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameTask.Location = new System.Drawing.Point(1089, 235);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(180, 36);
            this.NameTask.TabIndex = 10;
            // 
            // DescTask
            // 
            this.DescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DescTask.Location = new System.Drawing.Point(1084, 325);
            this.DescTask.Name = "DescTask";
            this.DescTask.Size = new System.Drawing.Size(180, 36);
            this.DescTask.TabIndex = 11;
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CreateTask.Location = new System.Drawing.Point(1027, 584);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(116, 45);
            this.CreateTask.TabIndex = 12;
            this.CreateTask.Text = "Créer";
            this.CreateTask.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(1108, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // dataDescTask
            // 
            this.dataDescTask.AllowUserToAddRows = false;
            this.dataDescTask.AllowUserToDeleteRows = false;
            this.dataDescTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDescTask.Location = new System.Drawing.Point(1084, 683);
            this.dataDescTask.Name = "dataDescTask";
            this.dataDescTask.ReadOnly = true;
            this.dataDescTask.RowHeadersWidth = 51;
            this.dataDescTask.RowTemplate.Height = 24;
            this.dataDescTask.Size = new System.Drawing.Size(185, 157);
            this.dataDescTask.TabIndex = 14;
            // 
            // ModifyToDo
            // 
            this.ModifyToDo.Location = new System.Drawing.Point(168, 792);
            this.ModifyToDo.Name = "ModifyToDo";
            this.ModifyToDo.Size = new System.Drawing.Size(87, 54);
            this.ModifyToDo.TabIndex = 16;
            this.ModifyToDo.Text = "Modifier";
            this.ModifyToDo.UseVisualStyleBackColor = true;
            // 
            // ToDoInProgess
            // 
            this.ToDoInProgess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ToDoInProgess.Location = new System.Drawing.Point(261, 792);
            this.ToDoInProgess.Name = "ToDoInProgess";
            this.ToDoInProgess.Size = new System.Drawing.Size(61, 54);
            this.ToDoInProgess.TabIndex = 17;
            this.ToDoInProgess.Text = ">";
            this.ToDoInProgess.UseVisualStyleBackColor = true;
            // 
            // InProgressDone
            // 
            this.InProgressDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InProgressDone.Location = new System.Drawing.Point(617, 793);
            this.InProgressDone.Name = "InProgressDone";
            this.InProgressDone.Size = new System.Drawing.Size(61, 54);
            this.InProgressDone.TabIndex = 20;
            this.InProgressDone.Text = ">";
            this.InProgressDone.UseVisualStyleBackColor = true;
            // 
            // ModifyInProgress
            // 
            this.ModifyInProgress.Location = new System.Drawing.Point(458, 792);
            this.ModifyInProgress.Name = "ModifyInProgress";
            this.ModifyInProgress.Size = new System.Drawing.Size(87, 54);
            this.ModifyInProgress.TabIndex = 19;
            this.ModifyInProgress.Text = "Modifier";
            this.ModifyInProgress.UseVisualStyleBackColor = true;
            // 
            // DoneInProgress
            // 
            this.DoneInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoneInProgress.Location = new System.Drawing.Point(947, 792);
            this.DoneInProgress.Name = "DoneInProgress";
            this.DoneInProgress.Size = new System.Drawing.Size(61, 54);
            this.DoneInProgress.TabIndex = 23;
            this.DoneInProgress.Text = "<";
            this.DoneInProgress.UseVisualStyleBackColor = true;
            // 
            // ModifyDone
            // 
            this.ModifyDone.Location = new System.Drawing.Point(854, 792);
            this.ModifyDone.Name = "ModifyDone";
            this.ModifyDone.Size = new System.Drawing.Size(87, 54);
            this.ModifyDone.TabIndex = 22;
            this.ModifyDone.Text = "Modifier";
            this.ModifyDone.UseVisualStyleBackColor = true;
            // 
            // InProgressToDo
            // 
            this.InProgressToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InProgressToDo.Location = new System.Drawing.Point(550, 791);
            this.InProgressToDo.Name = "InProgressToDo";
            this.InProgressToDo.Size = new System.Drawing.Size(61, 54);
            this.InProgressToDo.TabIndex = 24;
            this.InProgressToDo.Text = "<";
            this.InProgressToDo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(1084, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(1084, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(1084, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 26);
            this.label9.TabIndex = 27;
            this.label9.Text = "Priorité";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // UserTask
            // 
            this.UserTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UserTask.Location = new System.Drawing.Point(1089, 413);
            this.UserTask.Name = "UserTask";
            this.UserTask.Size = new System.Drawing.Size(180, 36);
            this.UserTask.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(1084, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Utilisateur";
            // 
            // PrioTask
            // 
            this.PrioTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PrioTask.Location = new System.Drawing.Point(1089, 506);
            this.PrioTask.Name = "PrioTask";
            this.PrioTask.Size = new System.Drawing.Size(180, 36);
            this.PrioTask.TabIndex = 30;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteTask.Location = new System.Drawing.Point(1194, 584);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(141, 45);
            this.DeleteTask.TabIndex = 31;
            this.DeleteTask.Text = "Supprimer";
            this.DeleteTask.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 852);
            this.Controls.Add(this.DeleteTask);
            this.Controls.Add(this.PrioTask);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UserTask);
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
            this.Name = "Home";
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
        private System.Windows.Forms.TextBox UserTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PrioTask;
        private System.Windows.Forms.Button DeleteTask;
    }
}