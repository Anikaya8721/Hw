Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
string n_text = Convert.ToString(n);

if (n_text.Length > 2)
{
  Console.WriteLine("третья цифра: " + n_text[2]);
}
else
{
  Console.WriteLine("третьей цифры нет");
}
