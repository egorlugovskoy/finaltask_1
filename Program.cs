using static System.Console;
Clear();

string[] full = new string[4];
WriteLine("Введите строки");
string s = FillArray(full);
string[] cut = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
AddArray(full);
AddArray(cut);
WriteLine();
Write("[" + string.Join(", ", full) + "] -> ");
Write("[" + string.Join(", ", cut) + "]");

string FillArray(string[] data)
{
    string row = string.Empty;
    for (int i = 0; i < data.Length; i++)
    {
        Write($"Строка {i + 1}: ");
        data[i] = Console.ReadLine() + "";
        TestRow(data, i);
        if (data[i].Length <= 3)
        {
            row += " " + data[i];
        }
    }
    return row;
}
void AddArray(string[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = "\"" + data[i] + "\"";
    }
}
void TestRow(string[] data, int i)
{
    while (data[i] == "")
    {
        WriteLine($"Строка пустая, введите строку {i + 1} заново");
        Write($"Строка {i + 1}: ");
        data[i] = Console.ReadLine() + "";
    }
}