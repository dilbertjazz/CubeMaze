using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeMaze.Models
{
    public class Maze
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public List<Cell> Cells { get; set; }
    }
}