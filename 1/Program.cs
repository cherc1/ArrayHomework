int[] array = new int [11];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100);  
Console.WriteLine(string.Join(", ", array));
int n = 0; int kol = 0;
while(n <= array.Length)
{
    if(array[n] > 20 && array[n] < 90)
    {
        kol++;
    }
    n++;
}
Console.WriteLine("Количество искомых = " + kol);