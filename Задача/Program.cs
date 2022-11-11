string[] OutputArray(string[] InputArray)
{
    int count = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i].Length <=3)
            {
                count++;
            }
          
    }
    string[] arr = new string[count];
    int index = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i].Length <= 3)
            {
                arr[index] = InputArray[i];
                index++;
            }
    }
    return arr;
}

string[] array = {"Moscow","House","45","dog","I"};
string[] UserArray = OutputArray(array);
Console.WriteLine('['+string.Join(',',UserArray)+']');
