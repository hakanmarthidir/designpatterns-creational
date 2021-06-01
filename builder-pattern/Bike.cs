using System;
using System.Collections.Generic;

namespace builder_pattern
{
    public class Bike
    {
        private List<string> _bikeParts = new List<string>();

        public Bike()
        {
            this._bikeParts.Clear();
        }

        public void AddPart(string partname)
        {
            this._bikeParts.Add(partname);
        }

        public void ShowBikeParts()
        {
            foreach (var item in _bikeParts)
            {
                Console.WriteLine(item);
            }
        }

        public List<string> GetBikeParts()
        {
            return this._bikeParts;
        }
    }
}
