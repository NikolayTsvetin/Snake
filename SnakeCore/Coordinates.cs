public class Coordinates
{
    private int _x;
    private int _y;
    
    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X
    {
        get => _x;
        set
        {
            if (value < 0 || value > Constants.Width)
            {
                return;
            }

            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0 || value > Constants.Height)
            {
                return;
            }

            _y = value;
        }
    }

}