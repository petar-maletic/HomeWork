using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using HomeWork.Lib;

namespace HomeWork
{
    class Program
    {
        /// <summary>
        /// Main entry-point for this application.
        /// </summary>
        /// <param name="args">An array of command-line argument strings.</param>
        static void Main(string[] args)
        {
            //RunFizzBuzzVersionOne();
            RunFizzBuzzVersionTwo();
        }

        /// <summary>
        /// Executes the fizz buzz version one operation.
        /// </summary>
        private static void RunFizzBuzzVersionOne()
        {
            try
            {
                var homeWorkLib = new HomeWorkLib();
                var collection = new ObservableCollection<string>();

                collection.CollectionChanged += OnCollectionChanged;

                var combinations = new List<Tuple<int, string>>
                {
                    new Tuple<int, string>(3, "Colin"),
                    new Tuple<int, string>(5, "Pear"),
                    new Tuple<int, string>(10, "Test")
                };

                homeWorkLib.GetFizzBuzzValueVersionOne(ref collection, int.MaxValue, combinations);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Executes the fizz buzz version two operation.
        /// </summary>
        private static void RunFizzBuzzVersionTwo()
        {
            try
            {
                var homeWorkLib = new HomeWorkLib();
                var combinations = new List<Tuple<int, string>>
                {
                    new Tuple<int, string>(3, "Colin"),
                    new Tuple<int, string>(5, "Pear"),
                    new Tuple<int, string>(10, "Test"),
                    new Tuple<int, string>(100, "(PM)")
                };

                foreach (var item in homeWorkLib.GetFizzBuzzValueVersionTwo(int.MaxValue, combinations))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Raises the notify collection changed event.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="evt">Event information to send to registered event handlers.</param>
        private static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs evt)
        {
            foreach (var item in evt.NewItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}