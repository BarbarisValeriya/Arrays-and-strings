// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine ("введите текст");
string text = Console.ReadLine();
text = text.ToLower();
Console.WriteLine("Полученная строка " + text);
Console.ReadKey();


