string[] CreateArray(int size)
{
    string[] array = new string [size];
    for(int i = 0; i < size; i++)
        array[i] = Console.ReadLine();
    return array;    
}
void ShowArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < (array.Length - 1); i++)
        Console.Write(array[i] + ", ");
    Console.Write(array[array.Length - 1] + "]\n ");
}