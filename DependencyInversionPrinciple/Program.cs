public class Program
{
    static void Main()
    {
        INotification emailNotification = new EmailNotification();
        INotification smsNotification = new SmsNotification();

        NotificationService emailNotificationService = new NotificationService(emailNotification);
        emailNotification.SendNotification("email sent");

        NotificationService smsNotificationService = new NotificationService(smsNotification);
        smsNotification.SendNotification("sms sent");
    }
   
}


// high level module
public class NotificationService
{
    private INotification notification;
    public NotificationService(INotification _notification) 
    { 
        notification = _notification;
    }

    public void Send(string message)
    {
        notification.SendNotification(message);
    }
}

// abstraction
public interface INotification
{
    public void SendNotification(string message);
}


// low level module
public class EmailNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}

public class SmsNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}
