Console.WriteLine("*****************************\n Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = n;
while(n>=1)
{
   if (n % 2 == 0)
Console.WriteLine(Convert.ToString(n)+" ");
n--; 
}