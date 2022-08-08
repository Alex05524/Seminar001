int a = 22;
int b = 3;
int c = 9;
int max = 0;

if(a > b && a > c)
{
    max = a;
}
else if(b > c)
{
    max = b;
}
else
{
    max = c;
}

Console.WriteLine(max);

