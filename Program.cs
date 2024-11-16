Console.WriteLine();
Console.Write("Enter your array of strings separated by a space: ");
string? inputstr = Console.ReadLine();
string [] arrays = inputstr.Split(' ');
int j = 0, counter = 0;
for (int i = 0; i < arrays.Length; i++)
{
    if (arrays[i].Length <= 3)
    {
        counter++;
    }
}
string [] str = new string[counter];
for (int i = 0; i < arrays.Length; i++)
{
    if (arrays[i].Length <= 3)
    {
    str[j] = arrays[i]; 
    j++;
    }
}
Console.WriteLine();
Console.Write("A new array whose elements contain no more than 3 characters: ");
for (int e = 0; e < str.Length; e++)
{
    Console.Write($"[{str[e]}] ");
}