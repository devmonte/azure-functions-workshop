using System;

public class Message
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}

public static void Run(Message myQueueItem, ICollector<Message> messages, ILogger log)
{
    log.LogInformation($"C# Queue trigger function processed: name = {myQueueItem.Name}, title {myQueueItem.Title}");
    if(myQueueItem.Name.Equals("Azure"))
    {
        log.LogInformation("Adding new message to table!");
        myQueueItem.PartitionKey = "Demo";
        myQueueItem.RowKey = Guid.NewGuid().ToString();
          messages.Add(myQueueItem);
    }

}
