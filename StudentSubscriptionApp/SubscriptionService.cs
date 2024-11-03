public class SubscriptionService : ISubscriptionService
{
    private readonly IStudentRepository _studentRepository;
    private readonly INotificationService _notificationService;

    public SubscriptionService(IStudentRepository studentRepository, INotificationService notificationService)
    {
        _studentRepository = studentRepository;
        _notificationService = notificationService;
    }

    public void Subscribe(Student student, Course course)
    {
        Console.WriteLine("Starting Subscription");

        // Lógica de negocio para la suscripción
        if (course.Type == "online")
        {
            // Validaciones específicas para cursos en línea
        }
        else if (course.Type == "live")
        {
            // Validaciones específicas para cursos presenciales
        }

        // Procesamiento de pagos (se podría añadir un servicio de pagos)

        // Guardar la suscripción en la base de datos
        _studentRepository.Save(student);

        // Enviar notificación
        _notificationService.SendEmailConfirmation(student);

        Console.WriteLine("End Subscription");
    }
}
