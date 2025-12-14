using System;
namespace BookApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book()
        {
            Title = "Без названия";
            Author = "Неизвестен";
            Year = 2024;
        }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Year = 2024;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год издания: {Year}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.DisplayInfo();
            Console.WriteLine();
            Book book2 = new Book("1984", "Джордж Оруэлл", 1949);
            book2.DisplayInfo();
            Console.WriteLine();
            Book book3 = new Book("Новое поколение", "Алексей Смирнов");
            book3.DisplayInfo();
        }
    }
}
