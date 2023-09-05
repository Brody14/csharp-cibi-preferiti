
string[] cibiPreferiti = { "Pistacchi in ogni loro forma", "Pizza", "Gazpacho", "Tiramisù", "Hummus" };

Console.WriteLine(cibiPreferiti.Length);

for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine($"{ i + 1} {cibiPreferiti[i]}");
}

Console.WriteLine($"Il cibo preferito è: {cibiPreferiti[0]}");
Console.WriteLine($"Il cibo meno preferito è: {cibiPreferiti[cibiPreferiti.Length - 1]}");

string median;

if (cibiPreferiti.Length % 2 == 0)
{
    int length = cibiPreferiti.Length / 2;
    median = ( cibiPreferiti[length - 1] + " " + cibiPreferiti[length] );
}else
{
    int length = cibiPreferiti.Length / 2;
    median = cibiPreferiti[length];

}

Console.WriteLine($"La mediana è: {median}");









