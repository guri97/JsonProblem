﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{
    internal class JSONDataOperation
    {
        public static void jsonSerialize()
        {
            string jsonPath = @"C:\Users\GURPREET SINGH\source\repos\JsonProblem\Files\JsonData.json";

            //Collection intializer
            List<Person> person = new List<Person>();
            person.Add(new Person() { PersonId = 12, Name = "Ganesh", Address = "Portblair" });
            person.Add(new Person() { PersonId = 13, Name = "Kalpak", Address = "Nagpur" });
            person.Add(new Person() { PersonId = 14, Name = "Abhishek", Address = "Maharashtra" });
            string result = JsonConvert.SerializeObject(person);//objcet to string
            using (StreamWriter sw = new StreamWriter(jsonPath))
            {
                sw.Write(result);
            }

        }

        public static void JsonDeserialization()//string to object
        {
            string jsonPath = @"C:\Users\GURPREET SINGH\source\repos\JsonProblem\Files\JsonData.json";
            if (FileExist(jsonPath))
            {
                string JsonData = File.ReadAllText(jsonPath);
                var result = JsonConvert.DeserializeObject<List<Person>>(JsonData);
                foreach (Person person in result)
                {

                    Console.WriteLine(person.ToString());
                }

            }
            else
            {
                Console.WriteLine("File not exist");
            }



        }
        public static bool FileExist(string path)
        {
            string InputFile = @"C:\Users\GURPREET SINGH\source\repos\JsonProblem\Files\JsonData.json";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
                return true;
            }
            else
            {
                Console.WriteLine("not Exist");
                return false;
            }
        }
    }
}