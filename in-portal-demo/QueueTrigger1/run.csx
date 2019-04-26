using System;

public class User
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public static void Run(User myQueueItem, ICollector<User> outputTable, ILogger log)
{
    log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

    if(myQueueItem.Name.Equals("Azure"))
    {
        log.LogInformation("Adding new user to table!");
        myQueueItem.PartitionKey = "Demo";
        myQueueItem.RowKey = Guid.NewGuid().ToString();
          outputTable.Add(myQueueItem);
        return;
    }
    log.LogInformation("Wrong user!");
}
