using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Windows_Form
{
    [DataContract]
    public class ToDoListModel
    {
        [XmlAttribute, DataMember]
        public Guid Id;

        [XmlAttribute, DataMember]
        public string Title;

        [XmlAttribute, DataMember]
        public string Description;

        [XmlAttribute, DataMember]
        public DateTime DueDate;

        public ToDoListModel(Guid id, string title, string description, DateTime dueDate)
        {
            id = Id;
            title = Title;
            description = Description;
            dueDate = DueDate;
        }

        public ToDoListModel() { }
        

    }
}
