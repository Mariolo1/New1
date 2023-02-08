namespace New1
{
    public abstract class Person
    {
        public Person(string name, string surname, int age) // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }  //propercja
        public string Surname { get; private set; } //propercja
        public int Age { get; private set; } // propercja
    }
}
 