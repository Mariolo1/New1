using System;
using System.Linq.Expressions;

namespace New1
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee( string name, string surname, int age)// konstruktor
            :base(name,surname,age)
        {
            
            
        }
      
       
        public void AddGrade(string grade) // metoda przedstawiająca string na float
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else
            {
                throw new Exception("String is not float");
                
            }
        }

        public void AddGrade(float grade) //metoda1 void nic nie zwraca
        {
            if (grade >= 0 && grade <= 100) // walidacja
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(double grade) //metoda zwraca double na float
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }

        public void AddGrade(int grade) //metoda zwraca int na float
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }

        public void AddGrade(char grade) //metoda zwraca char na float
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
                   
            }
        }


        public Statistics GetStatistics() //Metoda z pętlą ForEach
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach( var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average  /= this.grades.Count;
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;

        }
         
              
    }
}
