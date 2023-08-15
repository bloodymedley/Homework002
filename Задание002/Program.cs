Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

 if (a == c && b == c){
        Console.WriteLine("Все числа равны");
}
else if (a>=b && b>=c) {
        Console.WriteLine("Максимальное число " + a);
    }

else if(b>=a && b>=c){
        Console.WriteLine("Максимальное число " + b);
}
else if(c>=a && a<=c){
        Console.WriteLine("Максимальное число " + c);
}
else if (a == c && b == c){
        Console.WriteLine("Все числа равны");
}