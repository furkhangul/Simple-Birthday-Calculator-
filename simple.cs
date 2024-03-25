using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime birthDay = new DateTime(2004,04,11);
            DateTime now = DateTime.Now;
            Console.WriteLine("Your Birthday Date: {0}", birthDay);
            Console.WriteLine("Now Date: {0}", now.Date);
            int ageYear = 0;
            int ageMonth = 0;
            int ageDay = 0;
            ageYear = now.Year - birthDay.Year;

            //günler ile zamanı ayarlama 
            if(now.Month > birthDay.Month)
            {
                if (now.Day > birthDay.Day)
                {
                    ageDay = now.Day - birthDay.Day;
                    ageMonth = now.Month - birthDay.Month;
                }
                else
                {
                    ageDay = birthDay.Day - now.Day;
                    ageMonth = now.Month - birthDay.Month;
                    ageMonth--;

                }
            }
            else if (now.Month < birthDay.Month)
            {
                if(now.Day > birthDay.Day)
                {
                    ageDay = now.Day - birthDay.Day;
                    ageMonth = birthDay.Month - now.Month;
                    ageYear--;
                }
                else
                {
                    ageDay = birthDay.Day - now.Day;
                    ageMonth--;
                    ageMonth = birthDay.Month - now.Month;
                    ageYear--;
                }
            }
            else
            {
                if(now.Day> birthDay.Day)
                {
                    ageDay = now.Day - birthDay.Day;
                    ageMonth = now.Month - birthDay.Month;
                }
                else
                {
                    ageDay = birthDay.Day - now.Day;
                    ageMonth--;
                    ageMonth = now.Month - birthDay.Month;
                    ageYear --;
                }
            }
            Console.WriteLine("Your Age: {0} year.{1} mounth.{2}day ", ageYear,ageMonth,ageDay); 
            Console.ReadLine();
        }
    }
}
