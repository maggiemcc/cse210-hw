public abstract class Activity
{
    private string _date;
    private string _name;
    private double _time;

    public Activity(string date, string name, double time)
    {
        _date = date;
        _name = name;
        _time = time;
    }

    protected double GetMinutes()
    {
        return _time;
    }

    public double GetTime()
    {
        return _time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({GetTime()} mins): Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
