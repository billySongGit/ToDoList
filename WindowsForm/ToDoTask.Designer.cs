namespace Windows_Form
{
    partial class ToDoTask
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
            this.toDoTaskDescription = new System.Windows.Forms.TextBox();
            this.toDoTaskTitle = new System.Windows.Forms.TextBox();
            this.toDoTaskDueDate = new System.Windows.Forms.TextBox();
            this.toDoTaskId = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toDoTaskDescription
            // 
            this.toDoTaskDescription.Location = new System.Drawing.Point(16, 21);
            this.toDoTaskDescription.Multiline = true;
            this.toDoTaskDescription.Name = "toDoTaskDescription";
            this.toDoTaskDescription.ReadOnly = true;
            this.toDoTaskDescription.Size = new System.Drawing.Size(375, 80);
            this.toDoTaskDescription.TabIndex = 6;
            // 
            // toDoTaskTitle
            // 
            this.toDoTaskTitle.AccessibleName = "";
            this.toDoTaskTitle.Location = new System.Drawing.Point(16, 0);
            this.toDoTaskTitle.Name = "toDoTaskTitle";
            this.toDoTaskTitle.ReadOnly = true;
            this.toDoTaskTitle.Size = new System.Drawing.Size(232, 20);
            this.toDoTaskTitle.TabIndex = 7;
            this.toDoTaskTitle.Text = " ";
            // 
            // toDoTaskDueDate
            // 
            this.toDoTaskDueDate.Location = new System.Drawing.Point(257, 0);
            this.toDoTaskDueDate.Name = "toDoTaskDueDate";
            this.toDoTaskDueDate.ReadOnly = true;
            this.toDoTaskDueDate.Size = new System.Drawing.Size(134, 20);
            this.toDoTaskDueDate.TabIndex = 8;
            // 
            // toDoTaskId
            // 
            this.toDoTaskId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toDoTaskId.AutoSize = true;
            this.toDoTaskId.Location = new System.Drawing.Point(196, 104);
            this.toDoTaskId.Name = "toDoTaskId";
            this.toDoTaskId.Size = new System.Drawing.Size(0, 13);
            this.toDoTaskId.TabIndex = 9;
            this.toDoTaskId.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(16, 107);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(136, 30);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(255, 107);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 30);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ToDoTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(405, 137);
            this.ControlBox = false;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.toDoTaskId);
            this.Controls.Add(this.toDoTaskDueDate);
            this.Controls.Add(this.toDoTaskTitle);
            this.Controls.Add(this.toDoTaskDescription);
            this.Name = "ToDoTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox toDoTaskDescription;
        private System.Windows.Forms.TextBox toDoTaskTitle;
        private System.Windows.Forms.TextBox toDoTaskDueDate;
        private System.Windows.Forms.Label toDoTaskId;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}