namespace Windows_Form
{
    partial class EditTask
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
            this.editTaskTitleLabel = new System.Windows.Forms.Label();
            this.editTaskDueDateLabel = new System.Windows.Forms.Label();
            this.editTaskDescriptionLabel = new System.Windows.Forms.Label();
            this.editTaskDueDate = new System.Windows.Forms.DateTimePicker();
            this.editTaskDescription = new System.Windows.Forms.TextBox();
            this.editTaskTitle = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editTaskId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editTaskTitleLabel
            // 
            this.editTaskTitleLabel.AutoSize = true;
            this.editTaskTitleLabel.Location = new System.Drawing.Point(24, 13);
            this.editTaskTitleLabel.Name = "editTaskTitleLabel";
            this.editTaskTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.editTaskTitleLabel.TabIndex = 0;
            this.editTaskTitleLabel.Text = "Title";
            // 
            // editTaskDueDateLabel
            // 
            this.editTaskDueDateLabel.AutoSize = true;
            this.editTaskDueDateLabel.Location = new System.Drawing.Point(24, 61);
            this.editTaskDueDateLabel.Name = "editTaskDueDateLabel";
            this.editTaskDueDateLabel.Size = new System.Drawing.Size(50, 13);
            this.editTaskDueDateLabel.TabIndex = 1;
            this.editTaskDueDateLabel.Text = "DueDate";
            // 
            // editTaskDescriptionLabel
            // 
            this.editTaskDescriptionLabel.AutoSize = true;
            this.editTaskDescriptionLabel.Location = new System.Drawing.Point(24, 111);
            this.editTaskDescriptionLabel.Name = "editTaskDescriptionLabel";
            this.editTaskDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.editTaskDescriptionLabel.TabIndex = 2;
            this.editTaskDescriptionLabel.Text = "Description";
            // 
            // editTaskDueDate
            // 
            this.editTaskDueDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.editTaskDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.editTaskDueDate.Location = new System.Drawing.Point(27, 77);
            this.editTaskDueDate.Name = "editTaskDueDate";
            this.editTaskDueDate.Size = new System.Drawing.Size(490, 20);
            this.editTaskDueDate.TabIndex = 5;
            // 
            // editTaskDescription
            // 
            this.editTaskDescription.Location = new System.Drawing.Point(26, 127);
            this.editTaskDescription.Multiline = true;
            this.editTaskDescription.Name = "editTaskDescription";
            this.editTaskDescription.Size = new System.Drawing.Size(491, 237);
            this.editTaskDescription.TabIndex = 4;
            this.editTaskDescription.Text = "Description";
            // 
            // editTaskTitle
            // 
            this.editTaskTitle.Location = new System.Drawing.Point(27, 29);
            this.editTaskTitle.Name = "editTaskTitle";
            this.editTaskTitle.Size = new System.Drawing.Size(490, 20);
            this.editTaskTitle.TabIndex = 3;
            this.editTaskTitle.Text = "Title";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(61, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 30);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(345, 370);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 30);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editTaskId
            // 
            this.editTaskId.AutoSize = true;
            this.editTaskId.Location = new System.Drawing.Point(93, 13);
            this.editTaskId.Name = "editTaskId";
            this.editTaskId.Size = new System.Drawing.Size(0, 13);
            this.editTaskId.TabIndex = 15;
            this.editTaskId.Visible = false;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 410);
            this.ControlBox = false;
            this.Controls.Add(this.editTaskId);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editTaskDueDate);
            this.Controls.Add(this.editTaskDescription);
            this.Controls.Add(this.editTaskTitle);
            this.Controls.Add(this.editTaskDescriptionLabel);
            this.Controls.Add(this.editTaskDueDateLabel);
            this.Controls.Add(this.editTaskTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTask";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editTaskTitleLabel;
        private System.Windows.Forms.Label editTaskDueDateLabel;
        private System.Windows.Forms.Label editTaskDescriptionLabel;
        private System.Windows.Forms.DateTimePicker editTaskDueDate;
        private System.Windows.Forms.TextBox editTaskDescription;
        private System.Windows.Forms.TextBox editTaskTitle;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label editTaskId;
    }
}