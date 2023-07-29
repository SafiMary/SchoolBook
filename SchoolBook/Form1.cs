using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolBook
{
    public partial class Form1 : Form
    {
        List<Student> journal = new List<Student>();
    
        public Form1()
        {
            InitializeComponent();
            ShowToolTip();
        }
        public void ShowToolTip()
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.ShowAlways = true; 
            myToolTip.SetToolTip(maskTextBoxbirthd, "ВВОД даты в формате ДД.ММ.ГГГГ");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void saveToXml(string path = "student.xml")//сохранили в файл Xml
        {
            Student.Serealize_it(journal, path);
           
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {//обработали дату и записали всю информацию в журнал
         var date = maskTextBoxbirthd.Text.Split(',');
        int year = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int day = int.Parse(date[2]);
        DateTime dt = new DateTime(day, month,year);
        Text = dt.ToString("dd - MM - yyyy");
    
            var student = new Student( textBoxSurname.Text, textBoxName.Text, dt); ;
            journal.Add(student);
            listBoxStud.Items.Add(student.ToString());//чтобы информация о новом студенте отображалась в лист бокс
            
        }
        private void buttonSave_Click(object sender, EventArgs e)//сохранили в файл Xml и показали содержимое журнала
        {
            saveToXml();
            showMagazine();
        }
        
     
        private void showMagazine()//показали содержимое журнала
        {
            StringBuilder sb = new StringBuilder();
            var counter = 1;
            foreach (var item in journal)
            {
                sb.Append($"{counter++})  Фамилия: {item.Surname}   Имя: {item.Name}  Дата рождения: {item.Birthday.ToShortDateString()}\n");
            }
            MessageBox.Show(sb.ToString());

        }

        private void listBoxStud_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxNum.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            maskTextBoxbirthd.Clear();
        }

        private void buttonSort_Click(object sender, EventArgs e)//сортировать список учеников по алфавиту
        {
            journal = journal.OrderBy(x => x.Surname).ToList();
            showMagazine();

        }

       
    }
}
