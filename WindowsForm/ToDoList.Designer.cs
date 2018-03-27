namespace Windows_Form
{
    partial class ToDoList
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
            this.addTask = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addTask.Location = new System.Drawing.Point(21, 780);
            this.addTask.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(299, 35);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "Add A Task";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteAll.Location = new System.Drawing.Point(349, 780);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(142, 35);
            this.deleteAll.TabIndex = 2;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(507, 822);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.addTask);
            this.IsMdiContainer = true;
            this.Name = "ToDoList";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button deleteAll;
    }
}

