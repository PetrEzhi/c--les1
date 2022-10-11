Console.Write("Enter username - ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.Write("osoboe prvetstvie!");
}
else
{
    Console.Write("obichno ");
    Console.WriteLine(username);
}