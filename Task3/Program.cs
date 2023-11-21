// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine ("введите текст");
string text = Console.ReadLine();
text = text.Replace(" ", "");

string Palindrom(string text)
{
    char[] OBRtext = text.ToCharArray();
    Array.Reverse(OBRtext);
    string finaltext = new string(OBRtext);
    if (text == finaltext)
    {
     Console.WriteLine("Данная запись является палиндромом");
    }
    else
    {
     Console.WriteLine("Данная запись не является палиндромом");
    }
    return text;
}

Console.WriteLine(Palindrom(text));





