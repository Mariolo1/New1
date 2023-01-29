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

        public void AddGrade(float grade) //metoda void nic nie zwraca
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics() //Metoda zwraca Statistics
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
    }
}
