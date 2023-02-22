int a = 22;
int b = 3;
int c = 9;
int max = a;

if (a > b) max = a;
if (b > a) max = b;
if (c > b) max = c;
if (a > c) max = a;

Console.WriteLine(max);
