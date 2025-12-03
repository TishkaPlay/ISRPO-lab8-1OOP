//global using Base;
/*using MyClass;
Person2 anton = new("Anton");*/

namespace OOP8
{
    //public delegate void NumberHandler(int number);

    internal class Program
    {
        /*public delegate void MessageHandler(string text);

        static void Double(int num) => Console.WriteLine($"Удвоено: {num * 2}");
        static void Square(int num) => Console.WriteLine($"Удвоено: {num * num}");*/

        static void Main(string[] args)
        {
            /*Person person = new Person();
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
            hero.Heal(50);*/

            /*Person garen = new Person();
            garen.name = "Гарен";
            garen.age = 25;
            garen.Print();*/

            /*Person timo = new Person();
            timo.Print();*/

            /*Person ahri = new();
            Person brand = new("Brand");
            Person darius = new("Darius", 25);
            ahri.Print();
            brand.Print();
            darius.Print();*/

            /*Person p1 = new Person();
            p1.name = "Denis";
            Person p2 = p1;
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
            class Person {
                public string? name;
            }*/

            /*void Example() {
                int x = 5;
                int[] arr = new int[1000];
            }*/

            /*Base.Person tom = new("Tom");
            tom.Print();*/

            /*Company microsoft = new("Microsoft");
            Pers0n tom = new("Tom", microsoft);
            tom.Print();*/

            /*var p1 = new Point2D(10, 20);
            var p2 = new Point2D(13, 24);

            Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");*/

            /*Calculate(5);*/

            /*State state1 = new State();
            Country country1 = new Country();*/

            //9 lab
            /*string name = null;
            Console.WriteLine(name.Length);*/

            /*string nonNullableName = "Ария";
            string? nullableName = null;

            Console.WriteLine(nullableName?.Length);*/

            /*string? text = null;
            Console.WriteLine(text?.Length);

            string? name = null;
            string result = name ?? "Default";
            Console.WriteLine(result);

            Console.WriteLine(name!.Length);

            string hero = null;*/

            /*int? val = null;
            IsNull(val);
            val = 22;
            IsNull(val);

            void IsNull(int? obj) 
            {
                if (obj == null) Console.WriteLine("null");
                else Console.WriteLine(obj);
            }*/

            /*MessageHandler handler = ShowMessage;
            handler("Привет, мир!");

            static void ShowMessage(string message)
            {
                Console.WriteLine($"Сообщение: {message}");
            }*/


            /*NumberHandler handler = Double;
            handler += Square;
            handler(5);*/

            /*Player player = new Player();
            player.OnDeath += () => Console.WriteLine("Враги празднуют победу!");
            player.OnDeath += ShowGameOver;
            player.TakeDamage(100);*/

            /*string? GetUserName(int id)
            {
                return id == 1 ? "Alice" : null;
            }

            var user = GetUserName(2);
            Console.WriteLine(user?.ToUpper());

            string? input = Console.ReadLine();
            if (input != null)
            {
                Console.WriteLine($"Вы ввели: {input}");
            }
            else
            {
                Console.WriteLine("Вы ничего не ввели!");
            }

            List<string> names = new() { "Anna", null, "Bob" };

            foreach (var name in names)
            {
                Console.WriteLine(name?.Length ?? 0);
            }*/

            /*int? number = null;
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));

            number = 15;
            Console.WriteLine(number.GetValueOrDefault());
            Console.WriteLine(number.GetValueOrDefault(10));
            int? number1 = 5;
            Nullable<int> number2 = 5;
            PrintNullable(5);
            PrintNullable(null);

            void PrintNullable(int? number)
            {
                if (number.HasValue)
                {
                    Console.WriteLine(number.Value);
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("параметр равен null");
                }
            }*/

            /*var tempSensor = new TemperatureSensor();
            var motionSensor = new MotionSensor();
            var smartLight = new SmartLight();

            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
            motionSensor.OnMotionDetected += smartLight.TurnOn;

            Console.WriteLine("=== Симуляция умного дома ===");

            motionSensor.DetectMotion(true);
            smartLight.TurnOn("Обнаружено движение");
            Thread.Sleep(3000);
            smartLight.TurnOff();*/

            /*tempSensor.CheckTemperature(15);
            tempSensor.CheckTemperature(35);
            motionSensor.DetectMotion(false);
            motionSensor.DetectMotion(true);*/

        }
        /*static void Calculate(int t)
        {
            object x = 6;
            int y = 7;
            int z = y + t;
        }*/

        //static void ShowGameOver() => Console.WriteLine("GAME OVER");
    }
}

/*namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;

        public void Print() => System.Console.WriteLine($"Имя: {name}");
    }
}*/
