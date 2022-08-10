Console.WriteLine ("Введите число от 1 до 7 для проверки дня недели: ");
String? numbString = Console.ReadLine ();
var Numb = int.Parse (numbString!);

if (Numb > 0 && Numb < 8 && Numb > 5 ) 
{
   if (Numb > 5 ) {Console.WriteLine ("Да");}
   else {Console.WriteLine("Нет");}
   
}
else 
{
    Console.WriteLine("Число не подходит для проверки дня недели");
}