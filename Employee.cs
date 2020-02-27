using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcRestPoc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int[] TestArray { get; set; }
        public TestObj[] TestObjs { get; set; }
    }
}