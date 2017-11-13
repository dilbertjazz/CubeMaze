using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeMaze.Models
{
    public class Cell
    {
        public int id { get; set; }
        public int LocationId { get; set; }
        public int MachineId { get; set; }
        public List<User> Users { get; set; }
    }
}