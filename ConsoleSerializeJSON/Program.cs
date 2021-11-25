using System;
using System.Text.Json;
using System.IO;

namespace ConsoleSerializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1. Person
            Person tom = new Person();

            tom.Name = "Tom";
            tom.LastName = "Smith";
            tom.Age = 35;

            // 2. Serialize
            Console.WriteLine("\nSerialize\n");
            string json = JsonSerializer.Serialize<Person>(tom);
                        
            Console.WriteLine(json);



            string writePath = @"D:\work\Person.json";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(json);
                }

                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // ==============================================================================

            string json_from_file = "";

            try
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    json_from_file = sr.ReadToEnd();
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // 3. Deserialize
            Person restoredPerson = JsonSerializer.Deserialize<Person>(json_from_file);

            Console.WriteLine("\nDeserialize\n");
            Console.WriteLine(restoredPerson.Name);
            Console.WriteLine(restoredPerson.LastName);
            Console.WriteLine(restoredPerson.Age);
            
        }
    }
}
