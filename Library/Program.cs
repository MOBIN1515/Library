using System;
using System.Collections.Generic;
namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Book> library = new List<Book>();
            {
                new Book { Title = "قلعه حیوانات", Author = "جورج اورول", Year = 1945 };
                new Book { Title = "شازده کوچولو", Author = "آنتوان دو سنت اگزوپری", Year = 1943 };
                new Book { Title = "ملت عشق", Author = "الیف شافاک", Year = 2010 };
            };
            Console.WriteLine(" لیست کتاب‌ها:");
            foreach (var Book in library)
            {
                Book.DisplayInfo();
            }
         
            Console.WriteLine("جست و جوی عنوان کتاب");
            Console.WriteLine("عنوان کتاب را وارد کنید");
            string SearchTitle = Console.ReadLine();

            bool found = false;

            foreach (var Book in library)
            {
                if (Book.Title.Contains(SearchTitle))
                {
                    Console.WriteLine("موجود است");

                    Book.DisplayInfo();
                    found = true;
                }
                if (!found)
                {
                    Console.WriteLine(" کتاب مورد نظر پیدا نشد");
                }
            }
            Console.WriteLine(" افزودن کتاب جدید");

            Console.Write("عنوان: ");
            string newTitle = Console.ReadLine();

            Console.Write(" نویسنده: ");
            string newAuthor = Console.ReadLine();

            Console.Write("سال انتشار: ");
            int newYear = int.Parse(Console.ReadLine());

           
            Book newBook = new Book
            {
                Title = newTitle,
                Author = newAuthor,
                Year = newYear
            };
            
            library.Add(newBook);

            Console.WriteLine(" کتاب با موفقیت اضافه شد");







        }

    }
}
