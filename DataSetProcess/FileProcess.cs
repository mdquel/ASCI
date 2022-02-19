using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataSetProcess
{
    public class FileProcess
    {
        public string Destino;
        public class Project
        {
            public string Id { get; set; }
            public string Comentario { get; set; }
            public string Sentimiento { get; set; }
        }
        public bool Process(string fichero)
        {
            try
            {
                List<Project> data = new List<Project>();
                var grabarCSV = new csvWriter(Destino);
                grabarCSV.Open();
                grabarCSV.WriteHeader();
                XmlDocument doc = new XmlDocument();
                doc.Load(fichero);
                var _sentimiento = "positive";
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    String id = node.ChildNodes[0].InnerText;
                    if (node.HasChildNodes)
                    {
                        switch (node.ChildNodes[5].ChildNodes[0].ChildNodes[0].InnerText)
                        {
                            case "NONE":
                                _sentimiento = "none";
                                break;
                            case "P":
                                _sentimiento = "positive";
                                break;
                            case "P+":
                                _sentimiento = "positive";
                                break;
                            case "NEU":
                                _sentimiento = "none";
                                break;
                            case "N+":
                                _sentimiento = "negative";
                                break;
                            case "N":
                                _sentimiento = "negative";
                                break;
                        }
                        grabarCSV.Write(new string[] { node.ChildNodes[2].InnerText.Replace(";", "").Replace(",", "").Replace(@"\", "").Replace("'", "").Replace("\"", ""), _sentimiento });
                    }
                }
                grabarCSV.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
