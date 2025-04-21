using System;
using System.Runtime.InteropServices;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {

           int name = (int)City.Nagpur;

            Console.WriteLine((int)name);

           
         
        }
        enum  City
        {
            Tokyo,
            LA,
            Mumbai,
            Sydney,
            Nagpur,
            Nanded,
            California


        }

    }
}

