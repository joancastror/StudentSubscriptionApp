class Program
{
    static void Main(string[] args)
    {
        // Crear instancias necesarias
        IStudentRepository studentRepository = new StudentRepository();
        INotificationService notificationService = new NotificationService();
        ISubscriptionService subscriptionService = new SubscriptionService(studentRepository, notificationService);

        // Crear un estudiante y un curso
        Student student = new Student
        {
            StudentId = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "joancastro.r@gmail.com"
        };

        Course course = new Course
        {
            CourseId = 101,
            Name = "C# Programming",
            Type = "online"
        };

        // Suscribir el estudiante al curso
        subscriptionService.Subscribe(student, course);
    }
}
