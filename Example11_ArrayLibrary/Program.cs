void FillArray(int[] collection) //void метод которые не возваращает значение, поэтому return не нужен
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1, 10);
    index++;
    //index = index + 1
}
} void FillArray(int[] collection);

void PrintArray(int[] col);
{
int count = col.Lengh;                       //         НИХРЕНА НЕ РАБОТАЕТ
int position = 0;
while (position < count)
{
    Console.WriteLine(col[position]);
    position++;
}

int[] array = new int[10]; //new int[10] - создай новый массив, в кот 10 элементов, по умолчанию нули, чтобы заполнить команда

int IndexOf(int[] collection, int find)
{
int count = collection.Lengh;
int index = 0;
int position = 0;
while (index < count)
if (collection[index] == find)
{
  position = index;
  break;  
}
index++;
}
return position;
}
int[] array = new int[10];

FillArray(array);

array[4] = 4;
array[4] = 6;


PrintArray(array);
Console.WriteLine();

int pos  = IndexOf(array, 4);
Console.WriteLine(pos);


