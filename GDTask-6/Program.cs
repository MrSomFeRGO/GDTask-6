Console.WriteLine(remove_glasnlde("Ты неудачник, лол)" ));

static string remove_glasnlde(string input)
{
    List<char> glasnlde = new List<char>() { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
    string output = "";
    foreach (var el in input)
    {
        if (!glasnlde.Contains(el))
        {
            output += el;
        }
    }

    return output;
}