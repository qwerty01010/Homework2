Console.WriteLine ("Введите трехзначное число: ");
String? numbString = Console.ReadLine ();
var Numb = int.Parse (numbString!);
int resultFirst = 0;

if (Math.Abs (Numb) > 99 && Math.Abs (Numb) <1000 ) 
{
    resultFirst = (Numb/10) %10;
    
    if (resultFirst < 0) {resultFirst = resultFirst * -1;};
    
    Console.WriteLine (resultFirst);
}
else {Console.WriteLine ("Вы ввели не трехзначное число");}