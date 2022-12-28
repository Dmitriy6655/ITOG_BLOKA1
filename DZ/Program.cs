
string[] array = new string[] { "++", "Russia", "Great", "Country", "!", "++" };
string str = String.Empty;
int lengthStr = 3;

for (int i = 0; i < array.Length; i++)
{
    str = array[i];


    if (str.Length <= lengthStr)
    {
        Console.Write($" {array[i]} ");
    }


}
