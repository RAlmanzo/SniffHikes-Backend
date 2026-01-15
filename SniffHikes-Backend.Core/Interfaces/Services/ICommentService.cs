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
        Task<IEnumerable<Comment>> GetAllEventCommentsAsync(string eventId);
        Task<bool> AddEventCommentAsync(Comment comment);
        Task<bool> DeleteEventCommentAsync(string commentId);
        Task<Comment> UpdateEventCommentAsync(Comment comment);
        Task<IEnumerable<Comment>> GetAllRouteCommentsAsync(string routeId);
        Task<bool> AddRouteCommentAsync(Comment comment);
        Task<bool> DeleteRouteCommentAsync(string commentId);
        Task<Comment> UpdateRouteCommentAsync(Comment comment);
        Task<IEnumerable<Comment>> GetAllZoneCommentsAsync(string zoneId);
        Task<bool> AddZoneCommentAsync(Comment comment);
        Task<bool> DeleteZoneCommentAsync(string commentId);
        Task<Comment> UpdateZoneCommentAsync(Comment comment);
    }
}
