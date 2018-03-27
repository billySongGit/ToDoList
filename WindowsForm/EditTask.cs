using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form.ToDoServiceReference;

namespace Windows_Form
{
    /// <summary>
    /// Edit Task form
    /// </summary>
    public partial class EditTask : Form
    {
        /// <summary>
        /// Constructor for EditTask Form
        /// </summary>
        /// <param name="id">Id of task</param>
        /// <param name="title">Title of task</param>
        /// <param name="description">Description of task</param>
        /// <param name="dueDate">Due Date of Task</param>
        public EditTask(Guid id, string title, string description, DateTime dueDate)
        {
            InitializeComponent();

            editTaskId.Text = id.ToString();
            editTaskTitle.Text = title;
            editTaskDescription.Text = description;
            editTaskDueDate.Value = dueDate;
        }

        /// <summary>
        /// Function that runs when the save button is clicked
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();
            client.saveTask(Guid.Parse(editTaskId.Text), editTaskTitle.Text, editTaskDescription.Text, Convert.ToDateTime(editTaskDueDate.Value));

            Program.toDoList.Refresh();

            this.Close();
        }

        /// <summary>
        /// Function to close window when the cancel button is clicked
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
