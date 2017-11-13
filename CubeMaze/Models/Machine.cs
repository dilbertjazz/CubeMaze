using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CubeMaze.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public MachineType Type { get; set; }
    }

    public enum MachineType
    {
        None,
        Food,
        Water,
        Drug,
        Weapon,
        Armor
    }
}