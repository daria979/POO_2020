using System;

namespace _01_25_feb
{
    class World
    {
        private int id;
        public void SayHello()
        {
            Console.WriteLine($"Hello from {id}");
        }


        /// <summary>
        /// Metoda constructor. 
        /// Are acelasi nume ca si clasa
        /// Nu are tip de return, nici macar void
        /// Initializeaza obiectul.
        /// Se apeleaza automat la crearea/instantierea unui obiect. 
        /// </summary>
        /// <param name="id"></param>
        public World(int id)
        {
            this.id = id;
        }
    }
}