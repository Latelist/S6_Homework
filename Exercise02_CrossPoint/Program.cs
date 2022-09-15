// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetCoefficients()
{
    double[] coefficients = new double[4];
    Console.Write("Please, enter value k1: ");
    coefficients[0] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please, enter value b1: ");
    coefficients[1] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please, enter value k2: ");
    coefficients[2] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please, enter value b2: ");
    coefficients[3] = Convert.ToDouble(Console.ReadLine());

    return coefficients;

}



double[] FindCrosspoint(double[] coeffs)
{
    double[] crosspoint = new double[2];
    
    crosspoint[0] = (coeffs[3] - coeffs[1]) / (coeffs[0] - coeffs[2]);

    crosspoint[1] = coeffs[0] * crosspoint[0] + coeffs[1];

    return crosspoint;
}

void PrintArray(double[] array)
{
    Console.Write("Crosspoint coordinates are: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

PrintArray(FindCrosspoint(GetCoefficients()));

