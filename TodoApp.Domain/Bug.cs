namespace TodoApp.Domain;

public enum Severity
{
    Critical,
    Major,
    Minor,
    Irritating
}
public record Bug(string Title, string Description, Severity Severity, string AffectedVersion, int AffectedUsers, User CreatedBy, User? AssignedTo, IEnumerable<Byte[]> Images) : TodoTask(Title, DateTimeOffset.MinValue, CreatedBy);
