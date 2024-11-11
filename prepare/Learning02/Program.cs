using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1.company = "Apple";
        job1.jobTitle = "Software Engineer";
        job1.startYear = 2019;
        job1.endYear = 2023;

        Job job2 = new Job();

        job2.company = "NVidia";
        job2.jobTitle = "Manager";
        job2.startYear = 2010;
        job2.endYear = 2019;

        Job job3 = new Job();

        job3.company = "McDonalds";
        job3.jobTitle = "CEO";
        job3.startYear = 2010;
        job3.endYear = 2010;

        Resume myResume = new Resume();

        myResume.name = "Ronald M.";
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);
        myResume.jobs.Add(job3);

        myResume.Display();
    }
}