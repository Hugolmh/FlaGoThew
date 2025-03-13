namespace FlaGoThew
{
    partial class ProjectForm
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
            this.ListProject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameProject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeProject = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DescProject = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModifyTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListProject)).BeginInit();
            this.SuspendLayout();
            // 
            // ListProject
            // 
            this.ListProject.AllowUserToAddRows = false;
            this.ListProject.AllowUserToDeleteRows = false;
            this.ListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProject.Location = new System.Drawing.Point(93, 95);
            this.ListProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListProject.Name = "ListProject";
            this.ListProject.ReadOnly = true;
            this.ListProject.RowHeadersWidth = 51;
            this.ListProject.RowTemplate.Height = 24;
            this.ListProject.Size = new System.Drawing.Size(941, 544);
            this.ListProject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(93, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projets";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteButton.Location = new System.Drawing.Point(1092, 549);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 56);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameProject
            // 
            this.NameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameProject.Location = new System.Drawing.Point(1092, 131);
            this.NameProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameProject.Name = "NameProject";
            this.NameProject.Size = new System.Drawing.Size(180, 36);
            this.NameProject.TabIndex = 13;
            this.NameProject.TextChanged += new System.EventHandler(this.NameProject_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(1107, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Création projet";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CreateButton.Location = new System.Drawing.Point(1094, 466);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(180, 54);
            this.CreateButton.TabIndex = 15;
            this.CreateButton.Text = "Créer";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(1087, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(1089, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date échéance";
            // 
            // dateTimeProject
            // 
            this.dateTimeProject.Location = new System.Drawing.Point(1092, 320);
            this.dateTimeProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeProject.Name = "dateTimeProject";
            this.dateTimeProject.Size = new System.Drawing.Size(213, 22);
            this.dateTimeProject.TabIndex = 18;
            this.dateTimeProject.ValueChanged += new System.EventHandler(this.dateTimeProject_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(1089, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Description";
            // 
            // DescProject
            // 
            this.DescProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DescProject.Location = new System.Drawing.Point(1092, 217);
            this.DescProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescProject.Name = "DescProject";
            this.DescProject.Size = new System.Drawing.Size(180, 36);
            this.DescProject.TabIndex = 19;
            this.DescProject.TextChanged += new System.EventHandler(this.DescProject_TextChanged);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Status.Location = new System.Drawing.Point(1092, 397);
            this.Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(180, 36);
            this.Status.TabIndex = 21;
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(1087, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Statut";
            // 
            // ModifyTask
            // 
            this.ModifyTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ModifyTask.Location = new System.Drawing.Point(1092, 623);
            this.ModifyTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyTask.Name = "ModifyTask";
            this.ModifyTask.Size = new System.Drawing.Size(180, 56);
            this.ModifyTask.TabIndex = 23;
            this.ModifyTask.Text = "Modifier";
            this.ModifyTask.UseVisualStyleBackColor = true;
            this.ModifyTask.Click += new System.EventHandler(this.ModifyTask_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 690);
            this.Controls.Add(this.ModifyTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescProject);
            this.Controls.Add(this.dateTimeProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.NameProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListProject);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectForm";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.ListProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox NameProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescProject;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ModifyTask;
    }
}