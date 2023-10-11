Console.Clear();
// Console.SetCursorPosition();
// Console.WriteLine("+");

int xa = 1;
int ya = 1;
int xb = 32;
int yb = 1;
int xc = 16; 
int yc = 32;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = xb;
int count = 0;

while(count < 100000)
{
    int what = new Random().Next(0,3); //[0;3) 0 1 2
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}