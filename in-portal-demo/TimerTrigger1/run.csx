using System;

public class User
{
    public string Name {get; set;}
    public string Email {get; set;}
}

public static void Run(TimerInfo myTimer, ICollector<User> outputQueueItem, ILogger log)
{
    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
    outputQueueItem.Add(new User{Name = "TimerUser", Email = "timer@timer.com"});
}
