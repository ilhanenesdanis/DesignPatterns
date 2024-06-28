namespace AbstractFactory.Models
{
    public class TurkishCuisine : IEatFactory
    {
        public IMainCourse PrepareMeal()
        {
            return new TurkishMainFood();
        }

        public ISalad PrepareSalad()
        {
            return new TurkishSalad();
        }
    }
}
