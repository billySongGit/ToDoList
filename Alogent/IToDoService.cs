using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Linq;
using Windows_Form;

namespace Alogent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract, XmlSerializerFormat]
    public interface IToDoService
    {
        [OperationContract]
        List<XElement> getAllToDos();

        [OperationContract]
        XElement getById(Guid id);

        [OperationContract]
        void saveTask(Guid id, string title, string description, DateTime dueDate);

        [OperationContract]
        Guid addToDo(string title, string description, DateTime duedate);

        [OperationContract]
        void deleteToDo(Guid id);

        [OperationContract]
        void deleteAll();

    }
}
