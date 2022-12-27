using Quartz;

namespace Sample1;

public class HelloJob : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        await Console.Out.WriteLineAsync("Greetings from HelloJob!");
    }
}
