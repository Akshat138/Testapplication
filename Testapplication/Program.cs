// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine(i);
    }
    catch
    {
        throw;
    }
}
