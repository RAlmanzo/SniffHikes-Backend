using SniffHikes_Backend.Core.Entities;
using SniffHikes_Backend.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffHikes_Backend.Core.Services
{
    public class CommentService : ICommentService
    {
        public Task<bool> AddEventCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRouteCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddZoneCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEventCommentAsync(string commentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRouteCommentAsync(string commentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteZoneCommentAsync(string commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetAllEventCommentsAsync(string eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetAllRouteCommentsAsync(string routeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetAllZoneCommentsAsync(string zoneId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentByIdAsync(string commentId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateEventCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateRouteCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateZoneCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
