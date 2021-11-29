using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Loan_applications.Domains;

namespace Loan_applications.Storage
{
    public class WithID
    {
        public int ID { get; set; }
    }

    public class Storages
    {
        public static Storage<Agreement> AgreementStorage { get; } = new Storage<Agreement>();
        public static Storage<Application> ApplicationStorage { get; } = new Storage<Application>();
        public static Storage<Client> ClientStorage { get; } = new Storage<Client>();
        public static Storage<Dispatcher> DispatcherStorage { get; } = new Storage<Dispatcher>();
        public static Storage<Manager> ManagerStorage { get; } = new Storage<Manager>();
        public static Storage<Organization> OrganizationStorage { get; } = new Storage<Organization>();
        public static Storage<TypeOfLending> TypeStorage { get; } = new Storage<TypeOfLending>();
    }

    public class Storage<T> where T : WithID
    {
        private static string path = typeof(T).Name + ".xml";
        private List<T> storage = new List<T>();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (File.Exists(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    storage = (List<T>)xs.Deserialize(fs);
            }
        }

        public void SaveToXMLFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
                xs.Serialize(fs, storage);
        }

        public bool Create(T obj) 
        {
            if (storage.Where(t => t.ID == obj.ID).Count() != 0)
                return false;
            storage.Add(obj);
            return true;
        }

        public T Read(int ID) 
        {
            if (storage.Where(t => t.ID == ID).Count() != 0)
                return storage.Where(t => t.ID == ID).First();
            return null;
        }

        public T Update(T obj) 
        {
            int index = storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID) 
        { 
            return storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}
