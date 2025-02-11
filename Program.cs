namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            double weight;

            Console.Write("Enter Your First Name:");
            firstName = Console.ReadLine();

            Console.Write("Enter Your last Name:");
            lastName = Console.ReadLine();

            Console.Write("Enter Your Age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Weight:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Name is :" + firstName + " " + lastName);
            Console.WriteLine("Your Age is :" + age + " " + "Years old");
            Console.WriteLine("Your weight is :" + weight);



            Console.ReadLine();
        }
    }
}
