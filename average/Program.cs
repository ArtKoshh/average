namespace confitionalIsAndLoops;

class Program
{
    static void Main(string[] args)
    {
        var x = Max(1, 2);
    }
    static int Max(int x,int y)
    {
        if(x > y)
        { return x;
        }
        else
            { return y;
        }
    }
    

}