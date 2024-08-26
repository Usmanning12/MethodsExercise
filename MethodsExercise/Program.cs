namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();
            
            Console.WriteLine(Add(2,4)); 
            Console.WriteLine(Sub(13,5));
            Console.WriteLine(Mult(12,12));
            Console.WriteLine(Div(144,12));
        }

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello,{userName}! what is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine(
                $"One day, {userName} was walking through the woods while wearing a {favColor} t-shirt.{userName} saw a {favAnimal} listening to {favBand}");
        }

        public static int Add (int a,int b)
         {
             return a + b;
         }

        public static int Sub(int a, int b)
        {
            return a - b; 
        }

        public static int Mult(int a, int b)
        {
            return a * b; 
        }

        public static int Div(int a, int b)
        {
            return a / b; 
        }
        
}
    
    
    
    

    




}

