using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopHundred.API.Entities;

namespace TopHundred.API.Services
{
    internal interface ITopIcosRepository
    {
        Task<IcoItem> GetIcoItem(Guid id);
        Task<List<IcoItem>> GetIcoItems();
        void AddIcoItem(IcoItem model);
        void UpdateIcoItem(IcoItem model, Guid id);
        Task<News> GetNews(Guid id);
        Task<List<News>> GetAllNews();
        Task<User> RegisterUser(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
