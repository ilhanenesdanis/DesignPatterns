namespace AbstractFactory.Models
{
    public class TurkishMainFood : IMainCourse
    {
        public void Prepare()
        {
            Console.WriteLine("Yemek Hazırlanıyor");
        }
    }
}
