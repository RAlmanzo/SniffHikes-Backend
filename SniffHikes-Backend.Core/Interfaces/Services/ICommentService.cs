using SniffHikes_Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Interfaces.Services
{
    public interface ICommentService
    {
        Task<bool> AddEventCommentAsync(Comment comment);
        Task<bool> DeleteEventCommentAsync(string commentId);
        Task<Comment> UpdateEventCommentAsync(Comment comment);
    }
}
