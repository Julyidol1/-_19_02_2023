int a = 44;
int b = 5;
int c = 78;
int max = a;

if (a > b) max = a;
if (b > a) max = b;
if (c > b) max = c;

Console.WriteLine(max);
