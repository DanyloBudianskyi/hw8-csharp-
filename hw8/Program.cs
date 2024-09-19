using Event_practice5;

namespace hw8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AnimalAdded += (sender, e) =>
            {
                Console.WriteLine($"Animal added. New count: {e.NewCount}");
            };

            zoo.AnimalRemoved += (sender, e) =>
            {
                Console.WriteLine($"Animal removed. New count: {e.NewCount}");
            };

            zoo.AddAnimal();
            zoo.AddAnimal();
            zoo.RemoveAnimal();
        }
    }
}
