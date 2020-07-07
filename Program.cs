using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace iotest02
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifpath = @"test.json";
            var data = new List<Printers>();

            using (var ms = new FileStream(ifpath, FileMode.Open))
            {
                var serializer = new DataContractJsonSerializer(typeof(List<Printers>));
                data = (List<Printers>)serializer.ReadObject(ms);
                int len = data.Count;

                for (int i = 0; i < len; i++)
                {
                    Console.WriteLine("Id = {0}, Branch = {1}", data[i].Id, data[i].Branch);
                    for (int j = 0; j < data[i].Plist.Count; j++)
                    {
                        Console.WriteLine("Num = {0}, Name = {1}", data[i].Plist[j].Num, data[i].Plist[j].Name);
                    }
                }
            }
        }
    }
}
