
namespace Notes.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(NotesDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
