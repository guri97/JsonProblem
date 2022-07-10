using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class CSVOperation
    {
        public static void CSVSerilaization()
        {
            try
            {
                string csvpath = @"C:\Users\GURPREET SINGH\source\repos\JsonProblem\Files\CsvData.csv";
                List<Person> person = new List<Person>();
                person.Add(new Person() { PersonId = 12, Name = "Ganesh", Address = "PortBlair" });
                person.Add(new Person() { PersonId = 13, Name = "Kalpak", Address = "Nagpur" });
                person.Add(new Person() { PersonId = 14, Name = "Abhishek", Address = "Maharashtra" });


                using (StreamWriter sw = new StreamWriter(csvpath))
                {

                    CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    //this has to be written to write the records inside the file
                    csvWriter.WriteRecords(person);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static List<Person> CSVDeserialize()
        {
            try
            {
                string csvpath = @"C:\Users\GURPREET SINGH\source\repos\JsonProblem\Files\CsvData.csv";
                StreamReader sr = new StreamReader(csvpath);
                CsvReader cr = new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Person> res = cr.GetRecords<Person>().ToList();
                foreach (Person person in res)
                {
                    Console.WriteLine(person);
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }


}

//o/p after csv deserialization
//Enter the choice you want 1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
//6
//Id:  12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery