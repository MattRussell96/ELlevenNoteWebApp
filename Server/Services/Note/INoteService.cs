using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using ElevenNoteWebApp.Shared.Models;

namespace ElevenNoteWebApp.Server.Services.NoteEntity
{
    public interface INoteService
    {
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
        Task<bool> CreateNoteAsync(NoteCreate model);
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<bool> UpdateNoteAsync(NoteEdit model);
        Task<bool> DeleteNoteAsync(int noteId);
        void SetUserId(string userId);
    }
}
