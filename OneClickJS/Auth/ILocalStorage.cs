using OneClickJS.Data;
using System.Threading.Tasks;

namespace OneClickJS.Auth
{
    public interface ILocalStorage
    {

        Task<T> GetValue<T>(ValuesKeys key);

        Task SetValue<T>(ValuesKeys key, T value);

        Task RemoveItem(ValuesKeys key);

        Task ClearAll();
    }
}
