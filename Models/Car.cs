using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEg.Models
{
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string CarName { get; set; }
        public float Price { get; set;}
        public DateTime DOM { get; set; }
    }
}
