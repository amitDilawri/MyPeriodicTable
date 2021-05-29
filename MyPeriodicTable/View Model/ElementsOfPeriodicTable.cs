using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPeriodicTable.Models;

namespace MyPeriodicTable.View_Model
{
    public class ElementsOfPeriodicTable
    {
        public Dictionary<int, Elements> elementDictionary { get; set; }
        
        public List<Elements> elements { get; set; }

        
        
    }
}