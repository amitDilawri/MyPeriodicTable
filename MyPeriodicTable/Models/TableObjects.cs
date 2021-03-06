using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPeriodicTable.Models
{
    public static class TableObjects
    {
        public enum ElementTypes { AlkaliMetals, AlkalineEarthMetals, Lanthanoids, Actinoids, TransitionMetals, PostTransitionMetals, Metalloids, OtherNonMetals, NobleGases, Unknown };

        public static Dictionary<int, Elements> dictionaryOfElements = new Dictionary<int, Elements>()
        {
            { 1, new Elements{ AtomicNumber = 1, Symbol = "H", Name = "Hydrogen", Weight = "1.008", TypeOfElement = ElementTypes.OtherNonMetals.ToString() } },
            { 2, new Elements{ AtomicNumber = 2, Symbol = "He", Name = "Helium", Weight = "4.0026", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 3, new Elements{ AtomicNumber = 3, Symbol = "Li", Name = "Lithium", Weight = "6.94", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 4, new Elements{ AtomicNumber = 4, Symbol = "Be", Name = "Beryllium", Weight = "9.0122", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 5, new Elements{ AtomicNumber = 5, Symbol = "B", Name = "Boron", Weight = "10.81", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 6, new Elements{ AtomicNumber = 6, Symbol = "C", Name = "Carbon", Weight = "12.011", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 7, new Elements{ AtomicNumber = 7, Symbol = "N", Name = "Nitrogen", Weight = "14.007", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 8, new Elements{ AtomicNumber = 8, Symbol = "O", Name = "Oxygen", Weight = "15.999", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 9, new Elements{ AtomicNumber = 9, Symbol = "F", Name = "Fluorine", Weight = "18.998", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 10, new Elements{ AtomicNumber = 10, Symbol = "Ne", Name = "Neon", Weight = "20.180", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 11, new Elements{ AtomicNumber = 11, Symbol = "Na", Name = "Sodium", Weight = "22.99", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 12, new Elements{ AtomicNumber = 12, Symbol = "Mg", Name = "Magnesium", Weight = "24.305", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 13, new Elements{ AtomicNumber = 13, Symbol = "Al", Name = "Aluminium", Weight = "26.982", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 14, new Elements{ AtomicNumber = 14, Symbol = "Si", Name = "Silicon", Weight = "28.085", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 15, new Elements{ AtomicNumber = 15, Symbol = "P", Name = "Phosphorus", Weight = "30.974", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 16, new Elements{ AtomicNumber = 16, Symbol = "S", Name = "Sulfur", Weight = "32.06", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 17, new Elements{ AtomicNumber = 17, Symbol = "Cl", Name = "Chlorine", Weight = "35.45", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 18, new Elements{ AtomicNumber = 18, Symbol = "Ar", Name = "Argon", Weight = "39.948", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 19, new Elements{ AtomicNumber = 19, Symbol = "K", Name = "Potassium", Weight = "39.098", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 20, new Elements{ AtomicNumber = 20, Symbol = "Ca", Name = "Calcium", Weight = "40.078", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 21, new Elements{ AtomicNumber = 21, Symbol = "Sc", Name = "Scandium", Weight = "44.956", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 22, new Elements{ AtomicNumber = 22, Symbol = "Ti", Name = "Titanium", Weight = "47.867", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 23, new Elements{ AtomicNumber = 23, Symbol = "V", Name = "Vanadium", Weight = "50.942", TypeOfElement = ElementTypes.TransitionMetals.ToString() } },
            { 24, new Elements{ AtomicNumber = 24, Symbol = "Cr", Name = "Chromium", Weight = "51.996", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 25, new Elements{ AtomicNumber = 25, Symbol = "Mn", Name = "Manganese", Weight = "54.938", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 26, new Elements{ AtomicNumber = 26, Symbol = "Fe", Name = "Iron", Weight = "55.845", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 27, new Elements{ AtomicNumber = 27, Symbol = "Co", Name = "Cobalt", Weight = "58.933", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 28, new Elements{ AtomicNumber = 28, Symbol = "Ni", Name = "Nickel", Weight = "58.693", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 29, new Elements{ AtomicNumber = 29, Symbol = "Cu", Name = "Copper", Weight = "63.546", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 30, new Elements{ AtomicNumber = 30, Symbol = "Zn", Name = "Zinc", Weight = "65.38", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 31, new Elements{ AtomicNumber = 31, Symbol = "Ga", Name = "Gallium", Weight = "69.723", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 32, new Elements{ AtomicNumber = 32, Symbol = "Ge", Name = "Germanium", Weight = "72.630", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 33, new Elements{ AtomicNumber = 33, Symbol = "As", Name = "Arsenic", Weight = "74.922", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 34, new Elements{ AtomicNumber = 34, Symbol = "Se", Name = "Selenium", Weight = "78.971", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 35, new Elements{ AtomicNumber = 35, Symbol = "Br", Name = "Bromine", Weight = "79.904", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 36, new Elements{ AtomicNumber = 36, Symbol = "Kr", Name = "Krypton", Weight = "83.798", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 37, new Elements{ AtomicNumber = 37, Symbol = "Rb", Name = "Rubidium", Weight = "85.468", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 38, new Elements{ AtomicNumber = 38, Symbol = "Sr", Name = "Strontium", Weight = "87.62", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 39, new Elements{ AtomicNumber = 39, Symbol = "Y", Name = "Yttrium", Weight = "88.906", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 40, new Elements{ AtomicNumber = 40, Symbol = "Zr", Name = "Zirconium", Weight = "91.224", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 41, new Elements{ AtomicNumber = 41, Symbol = "Nb", Name = "Niobium", Weight = "92.906", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 42, new Elements{ AtomicNumber = 42, Symbol = "Mo", Name = "Molybdenur", Weight = "95.95", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 43, new Elements{ AtomicNumber = 43, Symbol = "Tc", Name = "Technetium", Weight = "(98)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 44, new Elements{ AtomicNumber = 44, Symbol = "Ru", Name = "Ruthenium", Weight = "101.07", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 45, new Elements{ AtomicNumber = 45, Symbol = "Rh", Name = "Rhodium", Weight = "102.91", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 46, new Elements{ AtomicNumber = 46, Symbol = "Pd", Name = "Palladium", Weight = "106.42", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 47, new Elements{ AtomicNumber = 47, Symbol = "Ag", Name = "Silver", Weight = "107.87", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 48, new Elements{ AtomicNumber = 48, Symbol = "Cd", Name = "Cadmium", Weight = "112.41", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 49, new Elements{ AtomicNumber = 49, Symbol = "In", Name = "Indium", Weight = "114.82", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 50, new Elements{ AtomicNumber = 50, Symbol = "Sn", Name = "Tin", Weight = "118.71", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 51, new Elements{ AtomicNumber = 51, Symbol = "Sb", Name = "Antimony", Weight = "121.76", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 52, new Elements{ AtomicNumber = 52, Symbol = "Te", Name = "Tellurium", Weight = "127.60", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 53, new Elements{ AtomicNumber = 53, Symbol = "I", Name = "Iodine", Weight = "126.90", TypeOfElement = ElementTypes.OtherNonMetals.ToString()} },
            { 54, new Elements{ AtomicNumber = 54, Symbol = "Xe", Name = "Xenon", Weight = "131.29", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 55, new Elements{ AtomicNumber = 55, Symbol = "Cs", Name = "Caesium", Weight = "132.91", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 56, new Elements{ AtomicNumber = 56, Symbol = "Ba", Name = "Barium", Weight = "137.33", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 57, new Elements{ AtomicNumber = 57, Symbol = "La", Name = "Lanthanum", Weight = "138.91", TypeOfElement = ElementTypes.Lanthanoids.ToString()}},
            { 58, new Elements{ AtomicNumber = 58, Symbol = "Ce", Name = "Cerium", Weight = "140.12", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 59, new Elements{ AtomicNumber = 59, Symbol = "Pr", Name = "Praseodymium", Weight = "140.91", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 60, new Elements{ AtomicNumber = 60, Symbol = "Nd", Name = "Neodymium", Weight = "144.24", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 61, new Elements{ AtomicNumber = 61, Symbol = "Pm", Name = "Promethium", Weight = "(145)", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 62, new Elements{ AtomicNumber = 62, Symbol = "Sm", Name = "Samarium", Weight = "150.36", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 63, new Elements{ AtomicNumber = 63, Symbol = "Eu", Name = "Europium", Weight = "151.96", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 64, new Elements{ AtomicNumber = 64, Symbol = "Gd", Name = "Gadolinium", Weight = "157.25", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 65, new Elements{ AtomicNumber = 65, Symbol = "Tb", Name = "Terbium", Weight = "158.93", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 66, new Elements{ AtomicNumber = 66, Symbol = "Dy", Name = "Dysprosium", Weight = "162.50", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 67, new Elements{ AtomicNumber = 67, Symbol = "Ho", Name = "Holmium", Weight = "164.93", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 68, new Elements{ AtomicNumber = 68, Symbol = "Er", Name = "Erbium", Weight = "167.26", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 69, new Elements{ AtomicNumber = 69, Symbol = "Tm", Name = "Thulium", Weight = "168.93", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 70, new Elements{ AtomicNumber = 70, Symbol = "Yb", Name = "Ytterbium", Weight = "173.05", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 71, new Elements{ AtomicNumber = 71, Symbol = "Lu", Name = "Lutetium", Weight = "174.97", TypeOfElement = ElementTypes.Lanthanoids.ToString()} },
            { 72, new Elements{ AtomicNumber = 72, Symbol = "Hf", Name = "Hafnium", Weight = "178.49", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 73, new Elements{ AtomicNumber = 73, Symbol = "Ta", Name = "Tantalum", Weight = "180.95", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 74, new Elements{ AtomicNumber = 74, Symbol = "W", Name = "Tungsten", Weight = "183.84", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 75, new Elements{ AtomicNumber = 75, Symbol = "Re", Name = "Rhenium", Weight = "186.21", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 76, new Elements{ AtomicNumber = 76, Symbol = "Os", Name = "Osmium", Weight = "190.23", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 77, new Elements{ AtomicNumber = 77, Symbol = "Ir", Name = "Iridium", Weight = "192.22", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 78, new Elements{ AtomicNumber = 78, Symbol = "Pt", Name = "Platinum", Weight = "195.08", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 79, new Elements{ AtomicNumber = 79, Symbol = "Au", Name = "Gold", Weight = "196.97", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 80, new Elements{ AtomicNumber = 80, Symbol = "Hg", Name = "Mercury", Weight = "200.59", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 81, new Elements{ AtomicNumber = 81, Symbol = "Tl", Name = "Thallium", Weight = "204.38", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 82, new Elements{ AtomicNumber = 82, Symbol = "Pb", Name = "Lead", Weight = "207.2", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 83, new Elements{ AtomicNumber = 83, Symbol = "Bi", Name = "Bismuth", Weight = "208.98", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 84, new Elements{ AtomicNumber = 84, Symbol = "Po", Name = "Polonium", Weight = "(209)", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 85, new Elements{ AtomicNumber = 85, Symbol = "At", Name = "Astatine", Weight = "(210)", TypeOfElement = ElementTypes.Metalloids.ToString()} },
            { 86, new Elements{ AtomicNumber = 86, Symbol = "Rn", Name = "Radon", Weight = "(222)", TypeOfElement = ElementTypes.NobleGases.ToString()} },
            { 87, new Elements{ AtomicNumber = 87, Symbol = "Fr", Name = "Francium", Weight = "(223)", TypeOfElement = ElementTypes.AlkaliMetals.ToString()} },
            { 88, new Elements{ AtomicNumber = 88, Symbol = "Ra", Name = "Radium", Weight = "(226)", TypeOfElement = ElementTypes.AlkalineEarthMetals.ToString()} },
            { 89, new Elements{ AtomicNumber = 89, Symbol = "Ac", Name = "Actinium", Weight = "(227)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 90, new Elements{ AtomicNumber = 90, Symbol = "Th", Name = "Thorium", Weight = "232.04", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 91, new Elements{ AtomicNumber = 91, Symbol = "Pa", Name = "Protactinium", Weight = "231.04", TypeOfElement = ElementTypes.Actinoids.ToString() } },
            { 92, new Elements{ AtomicNumber = 92, Symbol = "U", Name = "Uranium", Weight = "238.03", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 93, new Elements{ AtomicNumber = 93, Symbol = "Np", Name = "Neptunium", Weight = "(237)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 94, new Elements{ AtomicNumber = 94, Symbol = "Pu", Name = "Plutonium", Weight = "(244)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 95, new Elements{ AtomicNumber = 95, Symbol = "Am", Name = "Americium", Weight = "(243)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 96, new Elements{ AtomicNumber = 96, Symbol = "Cm", Name = "Curium", Weight = "(247)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 97, new Elements{ AtomicNumber = 97, Symbol = "Bk", Name = "Berkelium", Weight = "(247)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 98, new Elements{ AtomicNumber = 98, Symbol = "Cf", Name = "Californium", Weight = "(251)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 99, new Elements{ AtomicNumber = 99, Symbol = "Es", Name = "Einsteinium", Weight = "(252)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 100, new Elements{ AtomicNumber = 100, Symbol = "Fm", Name = "Fermium", Weight = "(257)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 101, new Elements{ AtomicNumber = 101, Symbol = "Md", Name = "Mendelevium", Weight = "(258)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 102, new Elements{ AtomicNumber = 102, Symbol = "No", Name = "Nobelium", Weight = "(259)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 103, new Elements{ AtomicNumber = 103, Symbol = "Lr", Name = "Lawrencium", Weight = "(266)", TypeOfElement = ElementTypes.Actinoids.ToString()} },
            { 104, new Elements{ AtomicNumber = 104, Symbol = "Rf", Name = "Rutherfordium", Weight = "(267)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 105, new Elements{ AtomicNumber = 105, Symbol = "Db", Name = "Dubnium", Weight = "(268)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 106, new Elements{ AtomicNumber = 106, Symbol = "Sg", Name = "Seaborgium", Weight = "(269)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 107, new Elements{ AtomicNumber = 107, Symbol = "Bh", Name = "Bohrium", Weight = "(270)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 108, new Elements{ AtomicNumber = 108, Symbol = "Hs", Name = "Hassium", Weight = "(270)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 109, new Elements{ AtomicNumber = 109, Symbol = "Mt", Name = "Meitnerium", Weight = "(278)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 110, new Elements{ AtomicNumber = 110, Symbol = "Ds", Name = "Darmstadtium", Weight = "(281)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 111, new Elements{ AtomicNumber = 111, Symbol = "Rg", Name = "Roentgenium", Weight = "(282)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 112, new Elements{ AtomicNumber = 112, Symbol = "Cn", Name = "Copernicium", Weight = "(285)", TypeOfElement = ElementTypes.TransitionMetals.ToString()} },
            { 113, new Elements{ AtomicNumber = 113, Symbol = "Nh", Name = "Nihonium", Weight = "(286)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 114, new Elements{ AtomicNumber = 114, Symbol = "Fl", Name = "Flerovium", Weight = "(289)", TypeOfElement = ElementTypes.PostTransitionMetals.ToString()} },
            { 115, new Elements{ AtomicNumber = 115, Symbol = "Mc", Name = "Moscovium", Weight = "(290)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 116, new Elements{ AtomicNumber = 116, Symbol = "Lv", Name = "Livermorium", Weight = "(293)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 117, new Elements{ AtomicNumber = 117, Symbol = "Ts", Name = "Tennessine", Weight = "(294)", TypeOfElement = ElementTypes.Unknown.ToString()} },
            { 118, new Elements{ AtomicNumber = 118, Symbol = "Og", Name = "Oganesson", Weight = "(294)", TypeOfElement = ElementTypes.Unknown.ToString()} }
        };
    }
}

