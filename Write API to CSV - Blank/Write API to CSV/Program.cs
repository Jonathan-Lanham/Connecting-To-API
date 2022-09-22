using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Write_API_to_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadHealthInformation();
            Console.ReadKey();
        }

        public static List<string> NCTID = new List<string>();

        public static List<HealthModel> allContents;

        public static async void LoadHealthInformation()
        {

        }

        public static void Process()
        {

        }

        public static void ToCSV()
        {

        }
    }
}

