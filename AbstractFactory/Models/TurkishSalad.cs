namespace AbstractFactory.Models
{
    public class TurkishSalad : ISalad
    {
        public void Prepare()
        {
            Console.WriteLine("Salata Hazırlanıyor");
        }
    }
}
