namespace AbstractFactory.Models
{
    public interface IEatFactory
    {
        IMainCourse PrepareMeal();
        ISalad PrepareSalad();
    }
}
