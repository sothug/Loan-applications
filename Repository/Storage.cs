using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Loan_applications.Repository
{
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static readonly string FilePath = "Storages/" + typeof(TIdentifier).Name + "s.xml";
        private List<TIdentifier> _storage = new();

        public Storage() { }

        public void ReadFromXmlFile()
        {
            if (!File.Exists(FilePath)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(FilePath, FileMode.Open);
            _storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveToXmlFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
                Directory.CreateDirectory(Path.GetFullPath(FilePath));
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(FilePath, FileMode.Create);
            xs.Serialize(fs, _storage);
            fs.Flush();
        }

        public bool Create(TIdentifier obj) 
        {
            // if (_storage.Where(t => t.ID == obj.ID).Count() != 0)
            if (_storage.Any(t => t.Id == obj.Id))
                return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id) 
        {
            return _storage.FirstOrDefault(t => t.Id == id);
        }

        public TIdentifier Update(TIdentifier obj) 
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objId) 
        { 
            return _storage.RemoveAll(t => t.Id == objId) != 0;
        }
    }
}
