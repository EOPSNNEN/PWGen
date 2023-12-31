using System.Text;

namespace Base
{
    class Generator
    {
        static void Main()
        {
            Console.Title = "PWGen | 비밀번호 생성기 | Генератор паролей";

            Random rd = new Random();
            char[] pwChars = new char[32] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '@', '#', '$', '%', '^', '&' };

            StringBuilder password = new StringBuilder();

            Console.Write("Please enter the size of pw: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int pwSize))
            {
                for (var count = 0; count < pwSize; count++)
                {
                    password.Append(pwChars[rd.Next(0, pwChars.Length)]);
                }

                Console.WriteLine(password.ToString());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the size of pw.");
            }

            Console.ReadLine();
        }
    }
}