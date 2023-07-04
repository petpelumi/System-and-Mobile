// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x, y;
x = 0;
y = 1;
int z = x + y;

for(int i = 0; i < 25; i++)
{
    
    x = y;
    y = z;
    z = x + y;
    Console.WriteLine(z);
}