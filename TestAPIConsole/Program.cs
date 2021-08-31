using Newtonsoft.Json;
using static System.Console;
using System.Net;
using System.ComponentModel;


namespace TestAPIConsole {
    class Program {

        static void Main() {
            WriteLine("Enter a location");

            callurl(ReadLine());

            Write("Press any key to end");
            ReadKey();
        }

        public static void callurl(string search_location) {
            var client = new WebClient();
            var content = client.DownloadString("http://api.weatherapi.com/v1/current.json?key="+ Key.API_KEY +"&q="+search_location+"&aqi=no");
            LocationRoot loc = JsonConvert.DeserializeObject<LocationRoot>(content);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(loc.Location)) {
                string name = descriptor.Name;
                object value = descriptor.GetValue(loc.Location);
                WriteLine($"{name}: {value}");
            }

            WriteLine();

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(loc.CurrentTemp)) {
                string name = descriptor.Name;
                object value = descriptor.GetValue(loc.CurrentTemp);
                WriteLine("{0}: {1}", name, value);
            }



        }
    }
    
}
