Console.Write("Сколько чисел хотите ввести: ");
int a = int.Parse(Console.ReadLine());

int[] arr = GetArray(a);
Console.WriteLine($"[{String.Join(", ", arr)}]");


Console.Write("Числа больше 0: ");
Console.WriteLine(BiggerZero(arr));


int[] GetArray(int size){
    int[] mas = new int[size];
    Console.WriteLine("Введите числа: ");
    for(int i=0;i<size;i++){
        mas[i] = int.Parse(Console.ReadLine());
    }
    return mas;
}

int BiggerZero(int[] arr){
    int count = 0;
    for(int i=0;i<arr.Length;i++){
        if(arr[i]>0){
            count+=1;
        }
    }
    return count;
}