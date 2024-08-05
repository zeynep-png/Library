using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        //Proporties for the Book class
        public string BookName { get; set; }
        public string WriterFirstName { get; set; }
        public string WriterLastName { get; set; }
        public int PaperCount { get; set; }
        public string Publisher {  get; set; }
        public DateTime DateTime { get; set; }

        //Default Constructor
        public Book() { 
            DateTime = DateTime.Now;
        }

        //Constructor with parameters
        public Book(string bookName, string writerFirstName, string writerLastName, int paperCount, string publisher)
        {
            
            BookName = bookName;
            WriterFirstName = writerFirstName;
            WriterLastName = writerLastName;
            PaperCount = paperCount;
            Publisher = publisher;
            
            DateTime = DateTime.Now;

        }
        //Method to print the book details
       public void Show()
        {
            Console.WriteLine(WriterFirstName + " " + WriterLastName +" adlı yazarın " + PaperCount + " sayfalık " + Publisher + " tarafından çıkarılan " + BookName +" adlı kitabını oluşturdunuz.");
        }


    }
}
