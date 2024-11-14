Console.Write("Enter your array of strings separated by a space: ");
string? inputstr = Console.ReadLine();
string [] arrays = inputstr.Split(' ');
int j = 0;
string [] str = new string[arrays.Length];
for (int i = 0; i < arrays.Length; i++)
{
    if (arrays[i].Length <= 3)
    {
    str[j] = arrays[i]; 
    j++;
    }
}
for (int e = 0; e < str.Length; e++)
{
    Console.Write($"{str[e]} ");
}