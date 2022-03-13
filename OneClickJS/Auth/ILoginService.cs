using System.Threading.Tasks;

namespace OneClickJS.Auth
{
    public interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
