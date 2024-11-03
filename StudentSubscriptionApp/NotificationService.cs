public class NotificationService : INotificationService
{
    public void SendEmailConfirmation(Student student)
    {
        Console.WriteLine($"Sending email confirmation to {student.Email}");
    }
}
