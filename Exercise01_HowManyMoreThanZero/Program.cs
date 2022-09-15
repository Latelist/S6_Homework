// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
//  пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
// а подсчет количества чисел производится после того, как пользователь не ввел информацию и 
// нажал Enter.

Console.Write("Please, enter numbers. Use space to split: ");

try
{
    string numbers = Console.ReadLine();
    var nums = numbers.Split(" ").Select(Int32.Parse).ToArray();

    int HowManyOverZero(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > 0)
            {
                sum += 1;
            }
        }
        return sum;
    }

    Console.WriteLine(HowManyOverZero(nums));
}
catch
{
    Console.WriteLine("Please, enter integers next time.");
}



