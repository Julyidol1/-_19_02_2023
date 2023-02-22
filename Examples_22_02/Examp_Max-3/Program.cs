int a = -3;
int b = -10;
int max = a;

if (a < b) max = b;
if (b < a) max = a;

Console.WriteLine(max);
