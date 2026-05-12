using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._starYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._starYear = 2024;
        job2._endYear = 2026;

        Resume resume1 = new Resume();

        resume1._name = "Allison Rose";
        resume1._job.Add(job1);
        resume1._job.Add(job2);

        resume1.DisplayResumen();
    }
}