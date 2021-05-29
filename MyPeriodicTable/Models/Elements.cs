using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPeriodicTable.Models
{
    public class Elements
    {
        public int AtomicNumber { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string TypeOfElement { get; set; }

        public Elements()
        {
            //
        }

        public Elements(int atomic, string sym, string name, string weight)
        {
            this.AtomicNumber = atomic;
            this.Symbol = sym;
            this.Name = name;
            this.Weight = weight;
        }
        public Elements(int atomic, string sym, string name, string weight, string elementType)
        {
            this.AtomicNumber = atomic;
            this.Symbol = sym;
            this.Name = name;
            this.Weight = weight;
            this.TypeOfElement = elementType;
        }

        
    }   
}