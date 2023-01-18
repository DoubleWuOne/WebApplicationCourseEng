using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationCourseEng.DTOs;
using WebApplicationCourseEng.Entities;
using WebApplicationCourseEng.Helpers;

namespace WebApplicationCourseEng.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientUserName );
        Task<bool> SaveAllAsync();
    }
}
