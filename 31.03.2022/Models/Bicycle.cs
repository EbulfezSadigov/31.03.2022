using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Bicycle : Vehicle, IWheel
    {
        public int _wheelthickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
