using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class ConsultaPadrao
    {
        public delegate TResult Func<in T, out TResult>(T arg);

        public void Exemplo()
        {
            Func<int, bool> equalsFive = x => x == 5;
            bool result = equalsFive(5);
            Console.WriteLine(result);   // True

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 0); // conta a quantidade de numeros pares
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");

            var firstNumbersLessThanSix = numbers.TakeWhile(n => n < 6);
            Console.WriteLine(string.Join(" ", firstNumbersLessThanSix));//aqui ele imprime todos os numeros até serem maior que 6
            // Output:
            // 5 4 1 3

            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);// imprime até o valor da posição ser menor ou igual ao valor dentro dela
            Console.WriteLine(string.Join(" ", firstSmallNumbers));
            // Output:
            // 5 4
        }
    }
}
