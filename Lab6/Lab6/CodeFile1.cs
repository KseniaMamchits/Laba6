using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba5
{
    //Испытание, Тест, Экзамен, Выпускной экзамен, Вопрос;
    struct Teacher
    {
        public string Name;
        public string Subject;
        public Teacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
        public void Info()
        {
            Console.WriteLine($"Имя преподавателя {Name}, его дисциплина {Subject}");
        }
    }
    public partial class Author
    {
        public string Name { get; set; }

    }
    public partial class Author
    {
        public int Age { get; set; }

    }
   
    public class Session
    {
        

            public Session(string subject_for_exam, string subject_for_offset, int questions)
            {
            this.subject_for_exam = subject_for_exam;
            this.subject_for_offset = subject_for_offset;
            this.questions = questions;
            }
            public void Inf()
            {
                Console.WriteLine($"Информация для сессии студентов специальности {spec}");
            }
        
        public string subject_for_offset;
        public int questions;
        public string subject_for_exam;
       
            public string Offset
            {
                get
                {
                    return this.subject_for_offset;
                
                }
                set
                {
                    if (value != null)
                    {
                    this.subject_for_offset = value;
                    }
                    else
                    {
                        Console.WriteLine("Бред");
                    }
                }
           
            }
        public int Quest
        {
            get
            {
                return this.questions;
            }
            set
            {
                if (value != 0)
                {
                    this.questions = value;
                }
                else
                {
                    Console.WriteLine("Бред");
                }
            }
        }

        public string Exams
        {
            get
            {
                return this.subject_for_exam;

            }
            set
            {
                if (value != null)
                {
                    this.subject_for_exam = value;
                }
                else
                {
                    Console.WriteLine("Бред");
                }
            }

        }
        public string spec;
           
        public void Show()
        {
            Console.WriteLine("Экзамен: " + subject_for_exam);
            Console.WriteLine("Зачет:" + subject_for_offset);
            Console.WriteLine("Количество вопросов в тесте:" + questions);
        }

       public int Check(int questions, int q, int qq)
        {
            int count = 0;
            
                if (questions > 15)
                {
                    count++;
                }
            if (q > 15)
            {
                count++;
            }
            if (questions > 15)
            {
                count++;
            }
            return count;
        }
        public int Ch1(string s, string e, string h, string k, string l, string o)
        {
            int count = 0;

            if (s!=null)
            {
                count++;
            }
            if (e != null)
            {
                count++;
            }
            if (h != null)
            {
                count++;
            }
            if (k != null)
            {
                count++;
            }
            if (l != null)
            {
                count++;
            }
            if (o != null)
            {
                count++;
            }
            return count;
        }
    }
    
    
    interface ITest//испытание
    {
        void Move();
    }

    abstract class Exam
    {
        protected string Name;
        protected byte Mark;
       

        public Exam(string Name, byte Mark)
        {
            this.Name = Name;
            this.Mark = Mark;
        }

        public abstract void Move();
        
    }

    class FinalExam : Exam
    {
        string specialty;
        
        
        public FinalExam(string specialty, string Name, byte Mark) : base(Name, Mark)
        {
            this.specialty = specialty;
        }

        public override void Move()
        {
            Console.WriteLine("Выпускной экзамены для специальности " + specialty + ": " + Name + ". Проходной балл: " + Mark);
        }
        public enum Days
        {
            Monday = 1,
            Tuesday,
            Whensday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
    }

    public class Test : ITest
    {
        private string v;

        public Test(string v)
        {
            this.v = v;
        }

        public void Move()
        {
            Console.WriteLine("Тест по CorelDraw: ");
        }

        public override bool Equals(object obj)
        {
            if (obj == "-") // проверка
            {
                Console.WriteLine("Что-то не так");
                return false;
            }

            if (obj != "-")
            {
                Console.WriteLine("Тест сдан.");
                return true;
            }

            Console.WriteLine("Нет теста!");
            return false;
        }
        public override int GetHashCode()
        {
            return 444;
        }
    }

    sealed class Question : ITest
    {
        string answer;
        public Question(string answer)
        {
            this.answer = answer;
        }
        public void Move()
        {
            Console.WriteLine("Студент работает? " + answer);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var Author = new Author();
            Author.Name = "Ksenia";
            Author.Age = 18;
            Console.WriteLine("Автор и его возраст: " + Author.Name + ", " + Author.Age);
            Teacher tteacher = new Teacher("Ловенецкая", "математика");
            tteacher.Info();
            FinalExam spec1 = new FinalExam("ИСИТ", "Математика", 5);
            spec1.Move();
            Console.WriteLine("День экзамена: ");
            Console.WriteLine((FinalExam.Days)3);
            FinalExam spec2 = new FinalExam("ПОИТ", "Физическая культура", 10);
            spec2.Move();
            Console.WriteLine("День экзамена: ");
            Console.WriteLine((FinalExam.Days)1);
            Console.WriteLine("Иванов Иван");
            Question quest = new Question("Да, я работаю в ресторане быстрого питания");
            quest.Move();
            Console.WriteLine("Писали тест по CorelDraw?");
            Test test1 = new Test("+");
            test1.Move();
            test1.Equals("+");

            Session ses1 = new Session("Физика", "Английский",27);
            ses1.spec = "ИСИТ";
            ses1.Inf();
            ses1.Show();
            Session ses2 = new Session("Математика", "ООП", 10);
            ses2.Show();
            Session ses3 = new Session("Дизайн", "КСИС",16);
            ses3.Show();
            object[] ListOfSessios = new object[3];
            ListOfSessios[0] = ses1;
            ListOfSessios[1] = ses2;
            ListOfSessios[2] = ses3;
            Console.WriteLine(ses1.Check(ses1.questions, ses2.questions, ses3.questions));
        }
    }
}