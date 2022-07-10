int[] array = {11, 21, 31, 14, 51, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
       Console.WriteLine(index); 
       break;    //брейк добавили чтобы остановиться на найденном значении, а не бегать по всему массиву, иначе он показал бы все индексы совпадающие с файнд
    }
    //index = index + 1;
index++;
}