using System.Text;
using Microsoft.EntityFrameworkCore;
using ef_module1_scaffold.Data;

Console.OutputEncoding = Encoding.UTF8;

using var context = new UniversityContext();

Console.WriteLine("=== Студенти університету ===");
var students = context.Students
    .Include(s => s.Group)
    .ThenInclude(g => g.Faculty)
    .ToList();

foreach (var s in students)
{
    Console.WriteLine($"[{s.Id}] {s.FirstName} {s.LastName} | Група: {s.Group.Name} ({s.Group.Course} курс) | {s.Group.Faculty.Name}");
}

Console.WriteLine("\n=== Викладачі університету ===");
foreach (var t in context.Teachers.ToList())
{
    Console.WriteLine($"[{t.Id}] {t.FirstName} {t.LastName} — {t.Position}");
}