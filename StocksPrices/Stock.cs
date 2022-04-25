namespace StocksPrices
{
    internal class Stock
    {
        public decimal price { get; set; }
        public string name { get; set; }

        public Source source { get; set; }
    }

    public enum Source { web, csv, json }
}