using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Loan_applications.Domains;

namespace Loan_applications.Repository
{
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static readonly string path = "Storages/" + typeof(TIdentifier).Name + "s.xml";
        private List<TIdentifier> _storage = new();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (!File.Exists(path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(path, FileMode.Open);
            _storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveToXMLFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetFullPath(path));
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(path, FileMode.Create);
            xs.Serialize(fs, _storage);
        }

        public bool Create(TIdentifier obj) 
        {
            if (_storage.Where(t => t.ID == obj.ID).Count() != 0)
                return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int ID) 
        {
            return _storage.Where(t => t.ID == ID).FirstOrDefault();
        }

        public TIdentifier Update(TIdentifier obj) 
        {
            int index = _storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID) 
        { 
            return _storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}
