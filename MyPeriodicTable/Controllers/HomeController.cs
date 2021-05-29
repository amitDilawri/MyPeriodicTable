using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPeriodicTable.Models;
using MyPeriodicTable.View_Model;
using System.Net;
using System.Text.RegularExpressions;

namespace MyPeriodicTable.Controllers
{
    [RoutePrefix("periodictable")]
    public class HomeController : Controller
    { 
        //[Route("")]
        public ActionResult DisplayElements()
        {                      
            return View(new ElementsOfPeriodicTable { elementDictionary = TableObjects.dictionaryOfElements});
        }
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //[Route("category")]
        public ActionResult CategoryOfElements(string ElementType)
        {
            List<Elements> myElements = TableObjects.dictionaryOfElements.Values.ToList().FindAll(x => x.TypeOfElement == ElementType);
            return View(new ElementsOfPeriodicTable { elements = myElements });
        }

        
        [HttpPost]
        public ActionResult SearchElement()
        {
            
            var myElements = new List<Elements>();
            string userInput = Request["searchElement"];
            ViewBag.search = userInput; //To retain the value in the search box
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            
            while (regex.IsMatch(userInput))
            {
                string searchInput = userInput.ToLower();
                int num;
                
                if (int.TryParse(searchInput, out num))
                {
                    myElements = TableObjects.dictionaryOfElements.Values.ToList().FindAll(x => x.AtomicNumber == num);
                }
                else if (searchInput.Length <= 2)
                {
                    myElements = TableObjects.dictionaryOfElements.Values.ToList().FindAll(x => x.Symbol.ToLower() == searchInput);

                }
                else
                {
                    myElements = TableObjects.dictionaryOfElements.Values.ToList().FindAll(x => x.Name.ToLower().Contains(searchInput));
 
                }
                break;
            }
            
            return View(new ElementsOfPeriodicTable { elements = myElements});
        }

        

    }
}