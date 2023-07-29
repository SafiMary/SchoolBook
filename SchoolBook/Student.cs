using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchoolBook
{
    public class Student
    {
   
        [XmlAttribute]
        public string Name;
        [XmlAttribute]
        public string Surname;
        [XmlAttribute]
        public DateTime Birthday;
        public Student()
        {

        }
        public Student( string surname,string name, DateTime birthday)
        {
            
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
        }
        public override string ToString()
        {
            return $"Фамилия:{this.Surname} Имя:{this.Name}  Дата рождения:{this.Birthday.ToShortDateString()}";
        }
        static public void Serealize_it(List<Student> objectGrath, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream fStream = new FileStream(filename,
                FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fStream, objectGrath);
            }
        }

       
        static public void Deserealize_it(string filename, out List<Student> lst)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream fStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                lst = (List<Student>)xmlSerializer.Deserialize(fStream);
            }
        }
      

    }
}
