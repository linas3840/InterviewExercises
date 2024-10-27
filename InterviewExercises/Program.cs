using InterviewExercises;

public class Program
{
    public static async Task Main(string[] args)
    {
        var example1 = new Example1();
        var example2 = new Example2();

        await example1.RunExample1Async();
        //await example2.RunExample2Async();
    }
}