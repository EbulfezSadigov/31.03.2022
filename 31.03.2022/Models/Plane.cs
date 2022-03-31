using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Plane : Vehicle
    {
        public int _wingLength { get; set; }

        public override int AverageSpeed()
        {
            return _drivepath / _drivetime;
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
