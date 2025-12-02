/*namespace OOP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            person.Age = 37;
            person.Print();

            var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };

            Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
            Console.WriteLine($"{banana.Name} x {banana.Quantity} = {banana.TotalPrice} Руб.");

            Hero hero = new Hero("Ривен", 120);
            Console.WriteLine($"Имя героя: {hero.Name}\nУровень героя: {hero.Level}\nМана: {hero.Mana}\nСтатус: {hero.Status}");
            hero.TakeDamage(50);
            hero.Heal(30);
            hero.TakeDamage(200);
            hero.Heal(50);
        }
    }
}
*/