Console.WriteLine("Первая задача на поиск большего числа из двух");

bool valid = false;
int num1 = 0;
int num2 = 0;

while (valid == false) {
Console.WriteLine("Введите первое число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number1)) {
    num1 = number1;
    valid = true;
}
else Console.WriteLine("Некорректно введено первое число!");
}

valid = false;

while (valid == false) {
Console.WriteLine("Введите второе число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number2)) {
    num2 = number2;
    valid = true;
}
else Console.WriteLine("Некорректно введено второе число!");
}

if(num1 > num2) {
    Console.WriteLine("Большее число из введённых Вами: " + num1 + ", меньшее: " + num2);
}
else Console.WriteLine("Большее число из введённых Вами: " + num2 + ", меньшее: " + num1); 


