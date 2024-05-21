using ToDoApp.Entity;

namespace ToDoApp.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<Notes> GetNotes();
        Notes GetNotesByID(int notesId);
        void InsertNotes(Notes notes);
        void DeleteNotes(int notesId);
        void UpdateNotes(Notes notes);
        void Save();
        bool NotesExists(int notesId);

    }
}
