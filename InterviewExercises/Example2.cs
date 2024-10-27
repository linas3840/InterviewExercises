namespace InterviewExercises;

public class Example2
{
    public async Task RunExample2Async()
    {
        Console.WriteLine("App started.");

        var task1 = RunTask1Async();
        var task2 = RunTask2Async();

        await Task.WhenAll(task1, task2);

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
