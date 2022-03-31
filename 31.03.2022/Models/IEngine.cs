namespace _31._03._2022.Models
{
    internal interface IEngine
    {
        public int _horsepower { get; set; }
        public int _tankSize { get; set; }
        public int _fuelType { get; set; }
        public int _currentOil { get; set; }
        void LeftFuelAmount();
    }
}