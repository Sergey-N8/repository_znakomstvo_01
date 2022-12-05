int[] arrey = {133,2,18,4,2554456,6444,78,18,849};

int n = arrey.Length;
int find = 18;

int index = 0;

while(index < n)
{
    if(arrey[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
