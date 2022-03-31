using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    abstract class Vehicle
    {
        public int _drivetime { get; set; }
        public int _drivepath { get; set; }
        public abstract int AverageSpeed();
        public abstract void ShowInfo();
        
        
    }
}
