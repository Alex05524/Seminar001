int a = 44;
int b = 5;
int c = 78;
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

