using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_practicum
{
    class Edition
    {
        /// <summary>
        /// Поля и свойства для них
        /// </summary>
        private string title;
        private string authorSurname;
        private int? publicationYear;

        public string Title
        {
            get { return title; }
            set
            {
                if (value == "")
                {
                    title = "Неизвестный";
                }
                else
                {
                    title = value;
                }
            }
        }
        public string AuthorSurname
        {
            get { return authorSurname; }
            set
            {
                if (value == "")
                {
                    authorSurname = "Неизвестный";
                }
                else
                {
                    authorSurname = value;
                }
            }
        }
        public int? PublicationYear  
        {
            get { return publicationYear; }
            set
            {
                if (value == null || value < 1990 || value > 2024)  
                {
                    publicationYear = null;  
                }
                else
                {
                    publicationYear = value;  
                }
            }
        }
        /// <summary>
        /// Конструкторы
        /// </summary>
        public Edition() { } // пустой
        
        public Edition( string title, string authorSurname, int publicationYear )
        {
            this.title = title;
            this.authorSurname = authorSurname;
            this.publicationYear = publicationYear;
        }

        //public void ToChangePublicationYear()
        //{
        //    Console.WriteLine("введите измененный год издания");
        //    int changer = int.Parse(Console.ReadLine());
        //    publicationYear = changer;
        //    if (publicationYear == null || publicationYear < 1990 || publicationYear > 2024)
        //    {
        //        throw new Exception("введена пустая строка или год меньше 1990 либо больше 2024");
        //    }
        //}
        public int ToChangePublicationYear(int year)
        {
            if (year > 1990 && year < 2024)
            {
                return year;
            }
            else
            {
                year = 2000;
            }
            return year;
        }
        /// <summary>
        /// определить, попадает ли год издания в заданный интервал
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public string FallIntoYear(int year)
        {
            if (year > 1990 && year < 2024)
            {
                return "Попадает в интервал";
            }
            else
            {
                return "Не попадает в интервал";
            }
        }
        public override string ToString()
        {
            return $"Название: {title}, Фамилия автора: {authorSurname}, Год публикации: {publicationYear}";
        }
    }

    


}

