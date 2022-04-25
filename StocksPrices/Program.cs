using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Timers;

namespace StocksPrices
{
    class Program
    {
        delegate double oprator( double x2);
       
        static void Main(string[] args)
        {

            Console.Title = "server";
            TcpListener list = new TcpListener(IPAddress.Parse("127.0.0.1"),808);
            list.Start();
            using (Socket socket = list.AcceptSocket())
            {
                byte[] bytes2send = { 1, 2, 3, 4 };
                socket.Send(bytes2send);
                byte[] bytesRecived = new byte[4];
                socket.Receive(bytesRecived);

                foreach (var item in bytesRecived)
                {
                    Console.WriteLine(item);
                }
            }
            list.Stop();
            Console.Read();

        }

       
        #region Stock test
        //static List<Stock> webList = new List<Stock>();
        //static List<Stock> csvList = new List<Stock>();
        //static List<Stock> jsonList = new List<Stock>();


        //static void Main(string[] args)
        //{

        //    System.Timers.Timer aTimer = new System.Timers.Timer();
        //    aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        //    aTimer.Interval = 20000;
        //    aTimer.Enabled = true;

        //    Console.WriteLine("Press \'q\' to quit the sample.");
        //    while (Console.Read() != 'q') ;

        //}
        //private static void OnTimedEvent(object source, ElapsedEventArgs e)
        //{
        //    webList = ReadFromWeb().Result;
        //    csvList = ReadFromCSV().Result;
        //    jsonList = ReadFromJson().Result;

        //    var lowerObj = GetLowestPrice("AAL");
        //    Console.WriteLine("name: "+ lowerObj.name+ " price: " + lowerObj.price + " source: " + lowerObj.source);   

        //    GetAllLowestPrices();
        //}
        //public static Stock GetLowestPrice(string stockName)
        //{
        //    decimal lowestPrice; 

        //    var jsonVal = jsonList.Where(x => x.name == stockName).FirstOrDefault().price;

        //    var webVal = webList.Where(x => x.name == stockName).FirstOrDefault().price;

        //    var csvVal = csvList.Where(x => x.name == stockName).FirstOrDefault().price;

        //    lowestPrice = Math.Min(jsonVal, Math.Min(webVal, csvVal));

        //   var source = (lowestPrice == jsonVal) ?Source.json : (lowestPrice == webVal? Source.web : Source.csv);

        //    Stock stock = new Stock { name = stockName, price = lowestPrice, source = source };

        //    return stock;

        //}
        //public static List<Stock> GetAllLowestPrices()
        //{

        //    var lstLowestPrice = new List<Stock>();
        //    foreach (var i in jsonList)
        //        lstLowestPrice.Add(GetLowestPrice(i.name));
        //    return lstLowestPrice;
        //}
        //private static async Task<List<Stock>> ReadFromJson()
        //{
        //    string json = await System.IO.File.ReadAllTextAsync("c:\\stocks.json");
        //    var stocks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Stock>>(json);
        //    List<Stock> model = new List<Stock>();
        //    foreach (var i in stocks)
        //    {
        //        model.Add(new Stock { name = i.name, price = i.price, source = Source.json });
        //    }
        //    return model;
        //}

        //private static async Task<List<Stock>> ReadFromCSV()
        //{
        //    List<Stock> model = new List<Stock>();
        //    using (var rd = new StreamReader("c:\\stocks.csv"))
        //    {
        //        String result; decimal _res;
        //        while (!rd.EndOfStream)
        //        {
        //            result = await rd.ReadLineAsync();
        //            var splits = result.Split(',');
        //            if (Decimal.TryParse((splits[2]), out _res))
        //                model.Add(new Stock { name = splits[0], price = _res, source = Source.csv });
        //        }
        //    }

        //    return model;
        //}

        //private static async Task<List<Stock>> ReadFromWeb()
        //{
        //    List<Stock> model = null;

        //    using (var w = new WebClient())
        //    {
        //        var json_data = string.Empty;
        //        // attempt to download JSON data as a string
        //        try
        //        {
        //            json_data = await w.DownloadStringTaskAsync("https://s3.amazonaws.com/test-data-samples/stocks.json");
        //        }
        //        catch (Exception) { }
        //        // if string with JSON data is not empty, deserialize it to class and return its instance 
        //        model = !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<List<Stock>>(json_data) : null;
        //        model.ForEach(c => c.source = Source.web);
        //    }

        //    return model;

        //}
        #endregion
    }
}
