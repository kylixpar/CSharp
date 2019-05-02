using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class News : INews
    {
        public int id;
        public string title;
        public string publishDate;
        public string author;
        public string content;
        public float averageRate;

        public int[] RateList = new int[3];
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }
        public string PublishDate
        {
            get
            {
                return publishDate;
            }
            set
            {
                this.publishDate = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                this.content = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }
        public float AverageRate
        {
            get
            {
                return averageRate;
            }
            set
            {
                this.averageRate = value;
            }
        }
        public News()
        {
            Console.WriteLine("Enter id: ");
            id = Int32.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Enter title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter pubishDate: ");
            publishDate = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter Content: ");
            content = Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
                RateList[i] = Int16.Parse(Console.ReadLine());
            }
        }
        public News(int iD, string title, string publishDate, string author, string content, float averageRate)
        {
            ID = iD;
            Title = title;
            this.publishDate = publishDate;
            Author = author;
            Content = content;
            AverageRate = averageRate;
        }
        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + publishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("AverageRate: " + AverageRate);
        }
        
        public void Calculate()
        {
            int total = 0;
            foreach(int i in RateList)
            {
                total += i;

            }
            averageRate = (float)total / 3;
        }
        
    }
}
