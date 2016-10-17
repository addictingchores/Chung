using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddictingChoresProject.Models
{
    public class Child
    {
        public int ChildId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BronzeBalance { get; set; }
        public int SilverBalance { get; set; }
        public int GoldBalance { get; set; }
    }
}