using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HomeWork.Lib
{
    /// <summary>
    /// A home work library.
    /// </summary>
    public class HomeWorkLib
    {
        /// <summary>
        /// Gets fizz buzz value version one.
        /// </summary>
        /// <param name="collection">[in,out] The collection.</param>
        /// <param name="endNumber">The end number.</param>
        /// <param name="combinations">The combinations.</param>
        public void GetFizzBuzzValueVersionOne(ref ObservableCollection<string> collection, int endNumber, List<Tuple<int, string>> combinations)
        {
            var counter = 1;

            do
            {
                var x = combinations.Where(x => counter % x.Item1 == 0);

                if (x.Count() == 0)
                    collection.Add(counter.ToString());
                else
                    collection.Add(string.Join(" ", x.Select(y => y.Item2)));

                counter++;
            } while (counter <= endNumber);
        }

        /// <summary>
        /// Gets the fizz buzz value version twoes in this collection.
        /// </summary>
        /// <param name="endNumber">The end number.</param>
        /// <param name="combinations">The combinations.</param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process the fizz buzz value version twoes in this collection.
        /// </returns>
        public IEnumerable<string> GetFizzBuzzValueVersionTwo(int endNumber, List<Tuple<int, string>> combinations)
        {
            var counter = 1;

            do
            {
                var x = combinations.Where(x => counter % x.Item1 == 0);

                if (x.Count() == 0)
                    yield return counter.ToString();
                else
                    yield return string.Join(" ", x.Select(y => y.Item2));

                counter++;
            } while (counter <= endNumber);
        }
    }
}