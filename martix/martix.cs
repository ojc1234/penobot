using System.Numerics;
using System;
using System.Collections.Generic;

namespace penodiscordbot.martix
{
    internal class martix
    {
        public List<List<int>> marix = null;
        public martix(List<int> first, List<int> second)
        {
            List<List<int>> numbers = new List<List<int>>
            {
                 first,
                 second
            };
            this.marix = numbers;
        }
        public void Write()
        {
            marix.ForEach(i =>
            {
                i.ForEach(j =>
                {
                    Console.Write(j+" ");
                });
                Console.WriteLine();
            });
        }
        /// <summary>
        /// 스칼라 연산
        /// </summary>
        /// <param name="value"></param>
        public List<List<int>> Scalar(int value)
        {
            List<List<int>> numbers = new List<List<int>>();
            marix.ForEach(i =>
            {
                numbers.Add(i.ConvertAll((j)=>j*value));
            });
            this.marix = numbers;
            return numbers;
        }
    }
}
