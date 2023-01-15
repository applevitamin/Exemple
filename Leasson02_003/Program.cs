int[] array = {1, 2, 3, 18, 54, 65, 18, 9 };

int n = array.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //если значение индекса совпадает выведет первый и остановится.
    }
index++;
}