public class StudentRepository : IStudentRepository
{
    public void Save(Student student)
    {
        Console.WriteLine("Starting Save()");
        // Lógica de persistencia
        Console.WriteLine("End Save()");
    }

    public void Delete(Student student)
    {
        Console.WriteLine("Starting Delete()");
        // Verificar suscripciones activas antes de eliminar
        Console.WriteLine("End Delete()");
    }
}
