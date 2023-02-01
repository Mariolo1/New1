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


        public void AddGrade(float grade) //metoda1 void nic nie zwraca
        {
            if (grade >= 0 && grade <= 100) // walidacja
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid data");
            }
        }
        public void AddGrade(string grade) //metoda2 zwraca string na float
        {
            if(float.TryParse(grade , out float result))
            {
                this.AddGrade(result);
            }
            else 
            {
                Console.WriteLine("String is not float ");
            }
        }
       
        public Statistics GetStatisticsWitchForEach() //Metoda z pętlą ForEach
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

            return statistics;

        }
        public Statistics GetStatisticsWitchWhile() //Metoda z pętlą While
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

           while(index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            }

            statistics.Average /= this.grades.Count;

            return statistics;

        }

        public Statistics GetStatisticsWitchFor() //Metoda z pętlą For
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            

            for (var index = 0; index < this.grades.Count; index ++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
               
            }

            statistics.Average /= this.grades.Count;

            return statistics;

        }

        public Statistics GetStatisticsWitchDoWhile() //Metoda z pętlą DoWhile
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;

            }while(index < this.grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;

        }
    }
}
