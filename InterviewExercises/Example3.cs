namespace InterviewExercises;

public class Example3
{
    public void RunExercise3()
    {
        Console.WriteLine("App started.");

        RunTask1();
        RunTask2();

        Console.WriteLine("App finished.");
    }

    private void RunTask1()
    {
        Console.WriteLine("Task #1 started.");

        Thread.Sleep(2000);

        Console.WriteLine("Task #1 finished.");
    }

    private void RunTask2()
    {
        Console.WriteLine("Task #2 started.");

        Thread.Sleep(1000);

        Console.WriteLine("Task #2 finished.");
    }
}
