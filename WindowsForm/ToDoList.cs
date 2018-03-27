using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows_Form.ToDoServiceReference;

namespace Windows_Form
{
    /// <summary>
    /// ToDoList Form
    /// </summary>
    public partial class ToDoList : Form
    {
        /// <summary>
        /// Constructor for ToDoList form
        /// </summary>
        public ToDoList()
        {
            InitializeComponent();
            this.Shown += ToDoListShown;
        }

        /// <summary>
        /// Global instantiation of a count
        /// </summary>
        /// <remarks>
        /// Decided to use a Global variable here so that it wouldn't be reset after the ToDoListShown method ends
        /// </remarks>
        private int count = 0;

        /// <summary>
        /// Function to call function that places ToDoTask forms onto the ToDoList form
        /// </summary>
        /// <param name="sender">sender object passed through from constructor</param>
        /// <param name="e">the event</param>
        private void ToDoListShown(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();
            List<XElement> tasks = client.getAllToDos();

            foreach (XElement elem in tasks)
            {
                ToDoListModel model = new ToDoListModel()
                {
                    Id = Guid.Parse(elem.Attribute("Id").Value),
                    Title = elem.Element("Title").Value,
                    Description = elem.Element("Description").Value,
                    DueDate = Convert.ToDateTime(elem.Element("DueDate").Value),
                };

                ToDoTask toDoTask = new ToDoTask(model.Id, model.Title, model.Description, model.DueDate)
                {
                    MdiParent = this,

                };

                toDoTask.Show();
                toDoTask.Location = new Point(40, 20 + 153 * count++); //Location property has to be outside of instantiation or it won't show correctly.
            }

        }

        /// <summary>
        /// Function opens up NewTask form as a modal to add a new Task to XML
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void addTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();

            newTask.ShowDialog();
            newTask.Location = new Point(50, 20);
            this.Hide();
            ToDoList todo = new ToDoList();
            todo.Show();
        }

        /// <summary>
        /// Function to delete all XML nodes
        /// </summary>
        /// <param name="sender">sender object passed through click</param>
        /// <param name="e">the click event</param>
        private void deleteAll_Click(object sender, EventArgs e)
        {
            ToDoServiceClient client = new ToDoServiceClient();
            client.deleteAll();

            this.Hide();

            ToDoList toDo = new ToDoList();
            toDo.ShowDialog();

            this.Close();
        }
    }
}
