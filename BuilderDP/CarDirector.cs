using BuilderDP.Builders;
using BuilderDP.Models;

namespace BuilderDP
{
    internal class CarDirector
    {
        public Car BuildSportCar()
        {
            return new CarBuilder()
                .SetColor("Red")
                .SetEnginePower(1600)
                .SetInterior("white")
                .Build();
        }
        public Car BuildFamilyCar()
        {
            return new CarBuilder()
                .SetColor("Green")
                .SetEnginePower(1800)
                .SetInterior("Red")
                .Build();
        }
    }
}
