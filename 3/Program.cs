System.Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int k = 0; k < array.Length; k++)
array[k] = new Random().Next(1, 10);  
int min = 1;
int max = 1;
while(n <= array.Length)
{
    if(array[n] > max)
    {
        max = array[n];
    }
    n++;
}
while(n <= array.Length)
{
   if(array[n] < min)
    {
        min = array[n];
    }
    n++;
}
/*for (int i = 0; i <=array.Length;i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
for (int i = 0; i <=array.Length;i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}*/
Console.WriteLine("Минимальное число - " + min + ", максимальное число - " + max);
int iskomoe = max - min;
Console.WriteLine("Ответ: " + iskomoe);