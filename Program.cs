namespace TheThirteenthProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var number in (listOfNumbers.Top(30)))
            {
                Console.WriteLine(number);
            }
            var listOfPeople = new List<Person>
            {
            new Person ("Fill",66),
            new Person("Jack",90),
            new Person("Elen",43),
            new Person("Kate",12)
            };
            foreach (var human in (listOfPeople.Top(30, person => person.Age)))
            {
                Console.WriteLine(human.Name + " " + human.Age);
            }
        }
    }
}