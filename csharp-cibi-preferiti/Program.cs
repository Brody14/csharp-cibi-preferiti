
string[] cibiPreferiti = { "Pistacchi in ogni loro forma", "Pizza", "Gazpacho", "Tiramisù", "Hummus" };

Console.WriteLine(cibiPreferiti.Length);

for(var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine($"{ i + 1} {cibiPreferiti[i]}");
}

Console.WriteLine($"Il cibo preferito è: {cibiPreferiti[0]}");
Console.WriteLine($"Il cibo meno preferito è: {cibiPreferiti[cibiPreferiti.Length - 1]}");



