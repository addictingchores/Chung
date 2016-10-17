using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddictingChoresProject.Models
{
    public enum ValueType
    {
        Bronze, Silver, Gold
    }
    public class Chore
    {
        public int ChoreId { get; set; }
        public int Value{ get; set; }
        public ValueType? ValueType { get; set; }
        public string Description { get; set; }
        public string Assignment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string ChoreTitle{ get; set; }
        public string Completed { get; set; }
    }
}