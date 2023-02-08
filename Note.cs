using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejednevnik
{
    internal class Note
    {
        public string Name;
        public string Description;
        public DateTime Date;
        public void GetInfo()
        {
            Console.WriteLine("Название: " + Name + "\n" + Description);
            Console.ReadLine();
        }
        public Note(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            Date = date;
        }
    }
}
