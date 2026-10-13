public class Running : Activity
{
    private double _distance;

    public Running(string date, string name, double time, double distance) : base(date, name, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

}