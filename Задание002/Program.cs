Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b) {
    if (a>c){
        Console.WriteLine("Максимальное число " + a);
    }
}
if (b>a){
    if (b>c){
        Console.WriteLine("Максимальное число " + b);
    }
}
if (c>a){
    if (c>b){
        Console.WriteLine("Максимальное число " + c);
    }
}
else {
        Console.WriteLine("Числа равны");
    }