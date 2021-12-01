using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace oopLaba2
{
        interface IStrategy
        {
            void Parse(string path);//public abstract
        }

        class LINQ : IStrategy
        {
            public void Parse(string path)
            {
                try
                {
                    XDocument file = XDocument.Load(path);
                    var workers = from worker in file.Descendants("worker")
                                     select new Worker
                                     {
                                         Name = worker.Element("name").Value,
                                         Department = worker.Element("department").Value,
                                         Cathedra = worker.Element("cathedra").Value,
                                         Date = worker.Element("date").Value,
                                         Degree = worker.Element("degree").Value,
                                         Gender = worker.Element("gender").Value,
                                     };
                    Global.FileData = workers.ToList();
                }
                catch
                {
                    MessageBox.Show("Invalid file!!!");
                    return;
                }
            }
        }

        class SAX : IStrategy
        {
            public void Parse(string path)
            {
                try
                {
                    List<Worker> workList = new List<Worker>();
                    string name = string.Empty;
                    string department = string.Empty;
                    string cathedra = string.Empty;
                    string date = string.Empty;
                    string degree = string.Empty;
                    string gender = string.Empty;

                    string element = string.Empty;

                    XmlReader file = XmlReader.Create(path);
                    while (file.Read())
                    {
                        if (file.NodeType == XmlNodeType.Element)
                        {
                            element = file.Name;
                        }
                        else if (file.NodeType == XmlNodeType.Text)
                        {
                            switch (element)
                            {
                                case "department":
                                    department = file.Value;
                                    break;
                                case "name":
                                    name = file.Value;
                                    break;
                                case "cathedra":
                                    cathedra = file.Value;
                                    break;
                                case "date":
                                    date = file.Value;
                                    break;
                                case "degree":
                                    degree = file.Value;
                                    break;
                                case "gender":
                                    gender = file.Value;
                                    break;
                            }
                        }
                        else if ((file.NodeType == XmlNodeType.EndElement)
                                && (file.Name == "worker"))
                        {
                        workList.Add(new Worker
                        {
                            Name = name,
                            Department = department,
                            Cathedra = cathedra,
                            Date = date,
                            Degree = degree,
                            Gender = gender
                            });
                        }
                    }
                    Global.FileData = workList;
                }
                catch
                {
                    MessageBox.Show("Invalid file!!!");
                    return;
                }
            }
        }
        class DOM : IStrategy
        {
            public void Parse(string path)
            {
                try
                {
                    List<Worker> personList = new List<Worker>();
                    XmlDocument file = new XmlDocument();
                    file.Load(path);
                    foreach (XmlNode professorNode in file.GetElementsByTagName("worker"))
                    {
                        personList.Add(new Worker
                        {
                            Name = professorNode["name"].ChildNodes[0].Value,
                            Department = professorNode["department"].ChildNodes[0].Value,
                            Cathedra = professorNode["cathedra"].ChildNodes[0].Value,
                            Date = professorNode["date"].ChildNodes[0].Value,
                            Degree = professorNode["degree"].ChildNodes[0].Value,
                            Gender = professorNode["gender"].ChildNodes[0].Value
                        });
                    }
                    Global.FileData = personList;
                }
                catch
                {
                    MessageBox.Show("Invalid file!!!");
                    return;
                }
            }
        }
    }