using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {

            // 6-2 문제
            Console.WriteLine("20을 초과하는 숫자를 입력하세요");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput % 3 == 0)
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
                Console.WriteLine(userInput % 3);
            }
            else if (userInput % 3 != 0)
            {
                Console.WriteLine("20보다 크지만 3의 배수가 아닙니다.");
            }
            else if (userInput < 20)
            {
                Console.WriteLine("20보다 작은 숫자는 출력하지 않습니다.");
            }
        }
    }
}


