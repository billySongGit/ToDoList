namespace Windows_Form
{
    partial class NewTask
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
            this.newTaskTitle = new System.Windows.Forms.TextBox();
            this.newTaskDescription = new System.Windows.Forms.TextBox();
            this.newTaskDueDate = new System.Windows.Forms.DateTimePicker();
            this.addNewTask = new System.Windows.Forms.Button();
            this.cancelNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTaskTitle
            // 
            this.newTaskTitle.Location = new System.Drawing.Point(12, 12);
            this.newTaskTitle.Name = "newTaskTitle";
            this.newTaskTitle.Size = new System.Drawing.Size(361, 20);
            this.newTaskTitle.TabIndex = 0;
            this.newTaskTitle.Text = "Title";
            // 
            // newTaskDescription
            // 
            this.newTaskDescription.Location = new System.Drawing.Point(12, 38);
            this.newTaskDescription.Multiline = true;
            this.newTaskDescription.Name = "newTaskDescription";
            this.newTaskDescription.Size = new System.Drawing.Size(361, 94);
            this.newTaskDescription.TabIndex = 1;
            this.newTaskDescription.Text = "Description";
            // 
            // newTaskDueDate
            // 
            this.newTaskDueDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.newTaskDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newTaskDueDate.Location = new System.Drawing.Point(13, 138);
            this.newTaskDueDate.Name = "newTaskDueDate";
            this.newTaskDueDate.Size = new System.Drawing.Size(360, 20);
            this.newTaskDueDate.TabIndex = 2;
            // 
            // addNewTask
            // 
            this.addNewTask.Location = new System.Drawing.Point(13, 164);
            this.addNewTask.Name = "addNewTask";
            this.addNewTask.Size = new System.Drawing.Size(172, 64);
            this.addNewTask.TabIndex = 3;
            this.addNewTask.Text = "Add";
            this.addNewTask.UseVisualStyleBackColor = true;
            this.addNewTask.Click += new System.EventHandler(this.addNewTask_Click);
            // 
            // cancelNewTask
            // 
            this.cancelNewTask.Location = new System.Drawing.Point(204, 164);
            this.cancelNewTask.Name = "cancelNewTask";
            this.cancelNewTask.Size = new System.Drawing.Size(169, 64);
            this.cancelNewTask.TabIndex = 4;
            this.cancelNewTask.Text = "Cancel";
            this.cancelNewTask.UseVisualStyleBackColor = true;
            this.cancelNewTask.Click += new System.EventHandler(this.cancelNewTask_Click);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 241);
            this.ControlBox = false;
            this.Controls.Add(this.cancelNewTask);
            this.Controls.Add(this.addNewTask);
            this.Controls.Add(this.newTaskDueDate);
            this.Controls.Add(this.newTaskDescription);
            this.Controls.Add(this.newTaskTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newTaskTitle;
        private System.Windows.Forms.TextBox newTaskDescription;
        private System.Windows.Forms.DateTimePicker newTaskDueDate;
        private System.Windows.Forms.Button addNewTask;
        private System.Windows.Forms.Button cancelNewTask;
    }
}