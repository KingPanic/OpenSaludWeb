using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.SessionStorage;

namespace OpenSalud.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorage;
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var emailAddress = await _sessionStorage.GetItemAsync<string>("emailAddress");

            ClaimsIdentity identity = new ClaimsIdentity();

            if (emailAddress != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, emailAddress),
                }, "apiauth_type");
            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        // This function will tell application that the user is authenticated.
        // For test purposes we are disregarding if it is an actually valid email address.
        public void MarkUserAsAuthenticated(string emailAddress)
        {
            var identity = new ClaimsIdentity(new[]
{
                new Claim(ClaimTypes.Name, emailAddress),
            }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorage.RemoveItemAsync("emailAddress");
            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
