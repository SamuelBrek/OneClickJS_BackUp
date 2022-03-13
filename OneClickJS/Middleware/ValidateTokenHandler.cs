using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OneClickJS.Middleware
{
    public class ValidateTokenHandler : DelegatingHandler
    {
        private ProtectedLocalStorage BrowserStorage { get; set; }
        public ValidateTokenHandler(ProtectedLocalStorage BrowserStorage) : base()
        {
            this.BrowserStorage = BrowserStorage;
        }
        protected override async Task <HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await BrowserStorage.GetAsync<string>("token");
            request.Headers.Add("Authorization", $"Bearer {token}");
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
