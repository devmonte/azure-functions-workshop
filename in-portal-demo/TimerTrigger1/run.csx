using System;

public class Message
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public static Message Run(TimerInfo myTimer, ILogger log)
{
    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
    return new Message { Name = "Test", Title = "TestTitle" };
}
