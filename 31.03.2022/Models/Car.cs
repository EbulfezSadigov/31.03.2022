using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03._2022.Models
{
    class Car:Vehicle,IEngine,ITransmission,IWheel
    {
        public int _doorcount { get; set; }
        public int _wincode { get; set; }
        public int _horsepower { get; set; }
        public int _fuelRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _currentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _wheelthickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _transmissionKind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _tankSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _fuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int AverageSpeed()
        {
            return _drivepath / _drivetime;
        }

        public void LeftFuelAmount()
        {
            Console.WriteLine(_fuelRate=_tankSize-_currentOil);
        }

        public override void ShowInfo()
        {
        }
    }
}
