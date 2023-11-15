public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    public void MoveLeft()
    {
        if (_mazeMap[(_currX, _currY)][0] == true)
        {
            _currX--;
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveRight()
    {
        if (_mazeMap[(_currX, _currY)][1] == true)
        {
            _currX++;
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveUp()
    {
        if (_mazeMap[(_currX, _currY)][2] == true)
        {
            _currY--;
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveDown()
    {
        if (_mazeMap[(_currX, _currY)][3] == true)
        {
            _currY++;
        }
        else
        {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}