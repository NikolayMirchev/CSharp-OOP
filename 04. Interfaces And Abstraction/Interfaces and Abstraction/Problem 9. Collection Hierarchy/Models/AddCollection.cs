﻿using Problem_9._Collection_Hierarchy.Interfaces;
using System.Collections.Generic;

namespace Problem_9._Collection_Hierarchy.Models
{
    public class AddCollection : IAddable
    {
        private List<string> data;
        private List<int> indexes;

        public AddCollection()
        {
            this.data = new List<string>();
            this.indexes = new List<int>();
        }

        public void Add(string element)
        {
            int index = this.data.Count;
            this.indexes.Add(index);
            this.data.Add(element);
        }

        public override string ToString()
        {
            return $"{string.Join(" ", this.indexes)}";
        }
    }
}
