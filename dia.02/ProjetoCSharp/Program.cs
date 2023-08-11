int size = 20;
int[] array = new int[size];

Random random = new();

Console.Clear();

for(int i = 0; i < size; i++){
    array[i] = random.Next(0, 501);
}

PrintArray();

// Array.Sort(array);
OrganizeArray();

PrintArray();

void PrintArray()
{
    foreach(int val in array){
        Console.Write(val + " ");
    }
    Console.WriteLine("\n");
}

void OrganizeArray()
{
    for(int j = 0; j < size; j++, size--){
        for(int i = 0; i < size - 1; i++){
            if(array[i] > array[i+1]){
                int val1 = array[i];
                array[i] = array[i+1];
                array[i+1] = val1;
            }
        }
    }
}