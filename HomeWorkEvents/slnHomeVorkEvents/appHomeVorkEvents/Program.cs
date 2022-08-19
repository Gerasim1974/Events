namespace appHomeVorkEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            microwave.OnWarmUpComplited += WarmUpCompletedHandler;

            microwave.WarmUp("Хот-Дог");
        }
        static void WarmUpCompletedHandler(string nameFood)
        {
            Console.WriteLine($"Ваша еда готова: {nameFood}");
        }
    }
}