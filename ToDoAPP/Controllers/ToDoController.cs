using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ToDoApp.Data;
using ToDoApp.Entity;
using ToDoApp.Repository;


namespace ToDoApp.Controllers
{
  
    public class ToDoController : Controller
    {

        private ITodoRepository _todoRepository;

        public ToDoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

      
        // GET: List
        public async Task<IActionResult> Index()
        {

            var result = _todoRepository.GetNotes();
            return View(result);
        }



        // GET: ToDo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] Notes note)
        {
            if (ModelState.IsValid)
            {
                _todoRepository.InsertNotes(note);
                _todoRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(note);
        }



        // GET: ToDo/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notes notes = _todoRepository.GetNotesByID(id);
           

            if (notes == null)
            {
                return NotFound();
            }
            return View(notes);
        }

        // POST: Todo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Notes notes)
        {
            if (id != notes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _todoRepository.UpdateNotes(notes);
                    _todoRepository.Save();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_todoRepository.NotesExists(notes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notes);
        }

        // GET: ToDo/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notes notes = _todoRepository.GetNotesByID(id);
            if (notes == null)
            {
                return NotFound();
            }

            return View(notes);
        }

        // POST: ToDo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Notes notes = _todoRepository.GetNotesByID(id);
            _todoRepository.DeleteNotes(id);
            _todoRepository.Save();
            return RedirectToAction(nameof(Index));
        }


    }
}
