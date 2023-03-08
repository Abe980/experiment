int size = 5;
int[] arr = new int[size*size];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

int[,] arr2d = new int[size, size];

int temp = 0;
int index = 0;
while (temp < size/2)
{
    for (int i = temp; i < size - temp; i++)
    {
        arr2d[temp, i] = arr[index];
        index++;
    }
    for (int i = temp + 1; i< size - temp; i++)
    {
        arr2d[i, size - temp - 1] = arr[index];
        index++;
    }
    for (int i = size - temp - 2; i >=temp; i--)
    {
        arr2d[size - temp - 1, i] = arr[index];
        index++;
    }
    for (int i = size - temp - 2; i > temp; i--)
    {
        arr2d[i, temp] = arr[index];
        index++;
    }
    temp++;
    if (size % 2 != 0) arr2d[size / 2, size / 2] = arr[index];
}


PrintMatrix(arr2d);

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
