int a = 15;
int b = 10;
void Divide(ref int a, ref int b)
{
    int c = a / b;
    int d = a % b;
    a = c;
    b = d;
}
Divide(ref a, ref b);
System.Console.WriteLine(a);
System.Console.WriteLine(b);

void Minimum(int c, int d)
{
    if(c>d)
    {
        System.Console.WriteLine(d);
    }
    else if(c<d) 
    {
        System.Console.WriteLine(c);
    }
}
Minimum(1, 2)
