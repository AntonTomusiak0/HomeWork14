namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1603)) { play.DisplayInfo(); }
            using (Shop shop = new Shop("SuperMart", "123 Main St", "Grocery")) { shop.DisplayInfo(); }
            using (Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1603)) { play.DisplayInfo(); }
            using (Shop shop = new Shop("SuperMart", "123 Main St", "Grocery")) { shop.DisplayInfo(); }
        }
    }
}
public class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Genre: {Genre}, Year: {Year}");
    }
    ~Play()
    {
        Console.WriteLine($"Play '{Title}' by {Author} is being destroyed.");
    }
    public void Dispose()
    {
        Console.WriteLine($"Disposing Play '{Title}' by {Author}.");
        GC.SuppressFinalize(this);
    }
}
public class Shop : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Type { get; set; }
    public Shop(string name, string address, string type)
    {
        Name = name;
        Address = address;
        Type = type;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Address: {Address}, Type: {Type}");
    }
    ~Shop()
    {
        Console.WriteLine($"Shop '{Name}' at {Address} is being destroyed.");
    }
    public void Dispose()
    {
        Console.WriteLine($"Disposing Shop '{Name}' at {Address}.");
        GC.SuppressFinalize(this);
    }
}