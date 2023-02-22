int a = 5;
int b = 7;
int max = a;

if (a < b) max = b;
if (b < a) max = a;

Console.WriteLine(max);
