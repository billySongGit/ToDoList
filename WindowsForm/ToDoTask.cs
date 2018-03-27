using System;
using System.Drawing;
using System.Windows.Forms;
using Windows_Form.ToDoServiceReference;

namespace Windows_Form
{
    /// <summary>
    /// Form to show the Task
    /// </summary>
    public partial class ToDoTask : Form
    {
        /// <summary>
        /// Constructor for ToDoTask Form
        /// </summary>
        /// <param name="id">Id of task</param>
        /// <param name="title">Title of task</param>
        /// <param name="description">Description of task</param>
        /// <param name="dueDate">Due Date of Task</param>
        public ToDoTask(Guid id, string title, string description, DateTime dueDate)
        {
            InitializeComponent();

            toDoTaskId.Text = id.ToString();
            toDoTaskTitle.Text = title;
            toDoTaskDescription.Text = description;
            toDoTaskDueDate.Text = dueDate.ToString();
        }

        /// <summary>
        /// Function to delete form from Parent form and data from XML
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();
            client.deleteToDo(Guid.Parse(this.toDoTaskId.Text));

            this.ParentForm.Hide();

            ToDoList toDo = new ToDoList();
            toDo.ShowDialog();

            this.ParentForm.Close();
        }

        /// <summary>
        /// Function to open up Edit Task Modal to edit task
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void editButton_Click(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();

            EditTask editTask = new EditTask(Guid.Parse(toDoTaskId.Text), toDoTaskTitle.Text, toDoTaskDescription.Text, Convert.ToDateTime(toDoTaskDueDate.Text));

            editTask.Location = new Point(50, 20);

            ToDoList todo = new ToDoList();

            editTask.ShowDialog();

            // this runs after the close of the editTask modal is closed.
            this.ParentForm.Hide();
            todo.ShowDialog();
            this.ParentForm.Close();
            // I couldn't get the Form.Refresh() method to work so I used this as a workaround.
        }

    }
}
