namespace InterviewExercises;

public class Example1
{
    public async Task RunExample1Async()
    {
        Console.WriteLine("App started.");

        await RunTask1Async();
        await RunTask2Async();

        Console.WriteLine("App finished.");
    }

    private async Task RunTask1Async()
    {
        Console.WriteLine("Task #1 started.");

        await Task.Delay(2000);

        Console.WriteLine("Task #1 finished.");
    }

    private async Task RunTask2Async()
    {
        Console.WriteLine("Task #2 started.");

        await Task.Delay(1000);

        Console.WriteLine("Task #2 finished.");
    }
}
