using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Entity;

namespace ToDoApp.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DBContext _context;

        public TodoRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Notes> GetNotes()
        {
            return _context.notes.ToList();
        }


        public Notes GetNotesByID(int id)
        {
            return _context.notes.Find(id);
        }

        public void InsertNotes(Notes notes)
        {
            _context.notes.Add(notes);
        }
        public void DeleteNotes(int notesID)
        {
            Notes notes = _context.notes.Find(notesID);
            _context.notes.Remove(notes);
        }

        public void UpdateNotes(Notes notes)
        {
            _context.Entry(notes).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool NotesExists(int notesId)
        {
            return _context.notes.Any(e => e.Id == notesId);
        }

    }
}
