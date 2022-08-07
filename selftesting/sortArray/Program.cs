using static System.Console;
void swap(ref int a, ref int b)
{
int temp=a;
a=b;
b=temp;
}
void fillArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10,99);
    }
}
void sortArray(int[] arr)
{
for (int i = 0; i < arr.Length-1; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if(arr[j]<arr[i])swap(ref arr[j],ref arr[i]);
    }
}
}
void printArr(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($" {arr[i]}");
        if((i!=0)&&(!Convert.ToBoolean(i%10)))Write("\n");
    }Write("\n");
}
int[] arr ={12,32,35,9,10,999};
int [] arr2 = new int[40];
sortArray(arr);
printArr(arr);
fillArray(arr2);
printArr(arr2);
sortArray(arr2);
printArr(arr2);