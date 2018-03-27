using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Windows_Form;

namespace Alogent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ToDoService : IToDoService
    {
        /// <summary>
        /// global variable for path
        /// </summary>
        private static string path = "ToDo.xml";

        /// <summary>
        /// Gets all records
        /// </summary>
        /// <returns>
        /// Returns a List of XElements (XDocument's element object)
        /// </returns>
        public List<XElement> getAllToDos()
        {
            XDocument xdoc = XDocument.Load(path);
            var tasks = xdoc.Root.Elements("Task");

            return tasks.ToList();
        }

        /// <summary>
        /// Gets record by Id
        /// </summary>
        /// <param name="id">Id of record to be retrieved</param>
        /// <returns>
        /// returns the XElement of the record whose Id is searched
        /// </returns>
        public XElement getById(Guid id)
        {
            XDocument xdoc = XDocument.Load(path);

            var task = xdoc.Root.Descendants("task")
                .Where(a => a.Attribute("id").Value.Equals(id.ToString()))
                .First();

            return task;
        }

        /// <summary>
        /// Method that saves the task during edit
        /// </summary>
        /// <param name="id">Id of task</param>
        /// <param name="title">new title of task</param>
        /// <param name="description">new description of task</param>
        /// <param name="dueDate">new duedate of Task</param>
        public void saveTask(Guid id, string title, string description, DateTime dueDate)
        {
            XDocument xdoc = XDocument.Load(path);

            var task = xdoc.Root.Elements("Task")
                        .Where(x => x.Attribute("Id").Value == id.ToString())
                        .Single();

            task.Element("Title").Value = title;
            task.Element("Description").Value = description;
            task.Element("DueDate").Value = dueDate.ToString();

            xdoc.Save(path);
        }

        /// <summary>
        /// Method to add a record to xml file
        /// </summary>
        /// <param name="title">Title of task</param>
        /// <param name="description">Description of task</param>
        /// <param name="dueDate">Due Date of Task</param>
        /// <returns></returns>
        public Guid addToDo(string title, string description, DateTime dueDate)
        {
            XDocument xdoc = XDocument.Load(path);

            ToDoListModel model = new ToDoListModel
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description,
                DueDate = dueDate
            };

            XElement task =
                new XElement("Task",
                    new XAttribute("Id", model.Id),
                    new XElement("Title", model.Title),
                    new XElement("Description", model.Description),
                    new XElement("DueDate", model.DueDate)
                );

            xdoc.Root.Add(task);
            xdoc.Save(path);

            return model.Id;

        }

        /// <summary>
        /// Method to Delete a record by Id
        /// </summary>
        /// <param name="id">Id of record to be deleted</param>
        public void deleteToDo(Guid id)
        {
            XDocument xdoc = XDocument.Load(path);

            string test = File.ReadAllText(path);

            xdoc.Root.Descendants("Task")
                .First(a => a.Attribute("Id").Value == id.ToString())
                .Remove();

            xdoc.Save(path);
        }

        /// <summary>
        /// Deletes all records from xml file
        /// </summary>
        public void deleteAll()
        {
            XDocument xdoc = XDocument.Load(path);

            xdoc.Root.RemoveAll();
            xdoc.Save(path);
        }
    }
}
