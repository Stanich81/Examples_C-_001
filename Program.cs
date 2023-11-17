Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a*(-1);
int min;
int max;

Console.WriteLine($"a = {a}, b = {b}");

if (a>b){
    max = a; min = b;
    Console.WriteLine($"max = {max}, min = {min}");
}
else {
    max = b; min = a;
    Console.WriteLine($"max = {max}, min = {min}");
}

while(min < max){
    Console.Write($"{min}, ");
    min = min + 1; 
}
Console.Write($"{min}");