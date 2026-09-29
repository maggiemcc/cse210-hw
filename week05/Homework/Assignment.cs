public class Assignment
{
    private string _studentName;
    private string _topic;
    private string _title;

    public Assignment(string studentName, string topic, string title)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }


    public string GetSummary()
    {
        return "";
    }
}