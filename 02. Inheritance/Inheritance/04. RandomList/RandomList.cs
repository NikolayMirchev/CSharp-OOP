using System;
using System.Collections.Generic;

namespace _04._RandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public string RandomString()
        {
            return "";
        }
    }
}
