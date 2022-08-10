Console.WriteLine ("Введите число трехзначное или более: ");
String? numbString = Console.ReadLine ();
var Numb = int.Parse (numbString!);


if (Math.Abs (Numb) > 99) 
{
    Console.WriteLine ("Третья цифра " + Numb.ToString ()[2]);
}
else {Console.WriteLine ("Третьей цифры нет");}