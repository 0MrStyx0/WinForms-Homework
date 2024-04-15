using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WorkerRegistration.Model;

namespace WorkerRegistration.Presenter
{
    public class WorkerPresenter
    {
       public List<Worker> workers { get; set; } = new List<Worker>();

        public string path { get; } = "WorkerData.xml";

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public void RemoveWorker(Worker worker)
        {
            workers.Remove(worker);
        }

        public void SaveData()
        {
            
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));
                serializer.Serialize(stream, workers);
            }
        }

        public void LoadData()
        {
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Worker>));
                workers = (List<Worker>)serializer.Deserialize(stream);
            }
        }
    }
}