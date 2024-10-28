using System.Text;

Console.WriteLine("Enter a World");
string str = Console.ReadLine();
if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("Input cannot be null or empty.");
    return;
}

bool[] seen = new bool[256];
StringBuilder sb = new StringBuilder();
for (int i = 0; i < str.Length; i++)
{
    if (!seen[str[i]])
    {
        seen[str[i]] = true;
        sb.Append(str[i]);
    }
}

Console.WriteLine(sb.ToString());

