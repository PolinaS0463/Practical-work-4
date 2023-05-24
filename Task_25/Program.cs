Console.WriteLine("Введите основание степени: ");
int base_of_degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени: ");
int exponent = Convert.ToInt32(Console.ReadLine());

int numberToThePower(int base_of_degree, int exponent){
    int num = 1;
    for(int i = 0; i < exponent; i += 1){
        num *= base_of_degree;
    }
    return num;
}

int result = numberToThePower(base_of_degree, exponent);
Console.WriteLine($"Число {base_of_degree} в {exponent}-й степени равно {result}");