Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfAllDigits(int num){
    int result = 0;
    while (number > 0){
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.WriteLine($"Сумма чисел в числе {number} равна {sumOfAllDigits(number)}");