namespace _2025_2_23
{
    internal class Program
    {  


        static void Main(string[] args)
        {  string word1, word2;
            Console.Write("Please input the first number:");
            word1=Console.ReadLine();
            Console.Write("Please input the second number:");
            word2 =Console.ReadLine();
            int number_1 = int.Parse(word1);
            int number_2 = int.Parse(word2);
            Console.Write("Please input the operator sign:");
            word1= Console.ReadLine();
            switch (word1)
            {
                case "+": Console.WriteLine("The result :{0}", number_1 + number_2);break;
                case "-": Console.WriteLine("The result :{0}", number_1 - number_2); break;
                case "*": Console.WriteLine("The result :{0}", number_1 * number_2); break;
                case "/": Console.WriteLine("The result :{0}", number_1 /number_2); break;
                case "%": Console.WriteLine("The result :{0}", number_1 %number_2); break;
               
            }

        }
    }
}