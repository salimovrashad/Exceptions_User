namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            var field = user.GetType().GetField("Age", System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Instance);
            field.SetValue(user, 20);


            Console.WriteLine("New Age: " + field.GetValue(user));
        }
    }
}