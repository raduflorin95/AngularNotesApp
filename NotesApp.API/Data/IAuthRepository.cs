using System.Threading.Tasks;
using NotesApp.API.Models;

namespace NotesApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string passwowrd);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}