using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.DTO
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Family { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
    }
}
