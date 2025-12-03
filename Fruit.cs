/*using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Net;

namespace OOP8
{
    public class Fruit
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }

        static async Task Main1()
        {
            Fruit apple = new() { Name = "Яблоко", Quantity = 5 };

            string json = JsonConvert.SerializeObject(apple);
            Console.WriteLine("В JSON: " + json);

            var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
            Console.WriteLine($"Объект: {deserialized?.Name} - {deserialized.Quantity} шт");

            Console.Write("Введите URL сайта: ");
            string? url = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    HttpClient client = new HttpClient();
                    string html = await client.GetStringAsync(url);

                    HtmlDocument doc = new HtmlDocument();
                    doc.LoadHtml(html);

                    var titleNode = doc.DocumentNode.SelectSingleNode("//title");

                    if (titleNode != null)
                    {
                        Console.WriteLine($"Заголовок страницы: {titleNode.InnerText}");
                    }
                    else 
                    {
                        Console.WriteLine("Заголовок страницы не найден");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("URL не может быть пустым.");
            }

            
        }
    }
}*/