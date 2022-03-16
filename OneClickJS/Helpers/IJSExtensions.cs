using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace OneClickJS.Helpers
{
    public static class IJSExtensions
    {
        public async static Task<bool> Confirm(this IJSRuntime js, string titulo, string mensaje, TipoMensajeSweetAlert tipoMnesaje)
        {
            return await js.InvokeAsync<bool>("CustomConfirm", titulo, mensaje, tipoMnesaje.ToString());
        }
        public async static Task<string> SaveData(this IJSRuntime js, string titulo, TipoMensajeSweetAlert icono)
        {
            return await js.InvokeAsync<string>("CustomSave", titulo, icono.ToString());
        }
        public async static Task<string> UploadedImage(this IJSRuntime js, string uploadedImage)
        {
            return await js.InvokeAsync<string>("UploadedImage", uploadedImage);
        }

        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content)
   => js.InvokeAsync<object>(
       "localStorage.setItem",
       key, content
       );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key)
            => js.InvokeAsync<object>(
                "localStorage.removeItem",
                key);


        public enum TipoMensajeSweetAlert
        {
            question, warning, error, success, info
        }
    }
}
