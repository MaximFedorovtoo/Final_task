string [] ArrayAdd (string [] array)
{
    for (int i = 0; i + 1 > 0 ; i++)
    {
        Console.Write("ВВедите строку, или нажмите Enter для завершения: ");
        string str = Console.ReadLine();
        if (str != "")
        {
            Array.Resize(ref array, i+1);
            array[i] = str;
        }
        if(str == ""){break;}
    }
    return array;
}
string [] ArrayRemake (string [] array)
{
    string [] result = {};
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Array.Resize(ref result, i+1);
            result[count] = array[i];
            count++;
        }
    }
    return result;
}
void PrintArray (string [] array)
{
    Console.Write($"[{string.Join(",", array)}]");
}

string [] array = {};
array = ArrayAdd(array);
array = ArrayRemake(array);
PrintArray(array);



