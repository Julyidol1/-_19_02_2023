Console.WriteLine("ЗАДАЧА, выводящая произведение от 1 до N");
int Multiply (int num){
    int multiply = 1;
    for( int i = 1; i <= num; i++){
        multiply*=i;
    }
    return multiply;
}
Console.Write("Введите число: ");
int number2 = int.Parse(Console.ReadLine()!);
int result2 = Multiply(number2);
Console.WriteLine($"Произведение от 1 до {number2} = {result2}");