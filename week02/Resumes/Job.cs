using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _starYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_starYear}-{_endYear}");
    }
}