Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine());
if( a < 6){
    Console.WriteLine("Длинга массива должна быть больше 6");
}
else{
    int[] arr = GetArray(a);

    PrintArray(arr);

    SortArray(arr);

    PrintArray(arr);
}




int[] GetArray(int size){
    int[] mas = new int[size];
    for(int i=0;i<size;i++){
        mas[i] = new Random().Next(-5,10);
    }
    return mas;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

void SortArray(int[] array){
    for (int i = 0; i < array.Length-1; i++)
    {
        int MinPos = i;
        for (int j = i+1; j < array.Length; j++)        
        {
            if(array[j] < array[MinPos]){
                MinPos = j;
            }  
        }
        int temp = array[i];
        array[i] = array[MinPos];
        array[MinPos] = temp;
    }
}