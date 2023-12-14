string folderPath = @"C:\\Users\\User\\Documents\\data(programm)\\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] heroes = {"Spider-Man", "Nathan Drake", "Rick Decard", "Althea Vestrit" };
//string[] villains = { "John Wick", "Doctor Octavius", "Frankenstein", "Gnasty Gnorc", "Harley Queen" };


string[] weapon = { "Gun", "Sword", "Shield", "Magic Staff", "Jewel of Chaos", "M16-1-A", "Blades of Chaos", "AWP", "plastic bottle" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day !");



string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take the world");



static string GetRandomValueFromArray(string[] someArray)
{
    Random random = new Random();
    int randomIndex = random.Next(0,someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}