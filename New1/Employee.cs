using System;

namespace New1
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee( string name, string surname)// konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }  //propercja

        public string Surname { get; private set; }//propercja

        public void AddGrade(string grade) // metoda przedstawiająca string na float
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else
            {
                Console.WriteLine("; String nie jest zmiennoprzecinkowy ");
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
                Console.WriteLine("invalid data >100");
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
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
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
