using System;
using System.Windows.Forms;
using Windows_Form.ToDoServiceReference;

namespace Windows_Form
{
    /// <summary>
    /// New Task Form
    /// </summary>
    public partial class NewTask : Form
    {
        /// <summary>
        /// Constructor for New Task Form
        /// </summary>
        public NewTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that runs when the Add button is clicked
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void addNewTask_Click(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();

            string title = newTaskTitle.Text.ToString();
            string description = newTaskDescription.Text.ToString();
            DateTime dueDate = newTaskDueDate.Value;

            ToDoList toDo = new ToDoList();

            Guid id = client.addToDo(title, description, dueDate);

            Program.toDoList.Refresh();
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void cancelNewTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
